using Microsoft.Data.SqlClient; // Added
using System;
using System.Data;
using System.Windows.Forms;

namespace upkguh
{
    public partial class PengumpulanTugas : UserControl
    {
        private string connectionString = Konesksi.conn;
        private int? _selectedPengumpulanId = null; // To store the ID of the selected SUBMISSION
        private int? _selectedTugasId = null; // To store the ID of the selected TASK from ComboBox

        public PengumpulanTugas()
        {
            InitializeComponent();
            ConfigureDataGridView();
            this.Load += PengumpulanTugas_Load; // Use Load event for initial setup

            // Add this line: Attach event handler for the search TextBox
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // End Add line
        }

        private void PengumpulanTugas_Load(object sender, EventArgs e)
        {
            LoadTugasComboBox();
            ClearDetails(); // Clear details initially
            // LoadSubmissionsGrid(); // Load initially for the first task? Or wait for selection. Let's wait.
        }


        private void ConfigureDataGridView()
        {
            listPengumpulanDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listPengumpulanDataGrid.MultiSelect = false;
            listPengumpulanDataGrid.AllowUserToAddRows = false;
            listPengumpulanDataGrid.AllowUserToDeleteRows = false;
            listPengumpulanDataGrid.ReadOnly = true;
            listPengumpulanDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listPengumpulanDataGrid.RowHeadersVisible = false;

            listPengumpulanDataGrid.CellClick -= listPengumpulanDataGrid_CellClick; // Ensure not added multiple times
            listPengumpulanDataGrid.CellClick += listPengumpulanDataGrid_CellClick;
        }

        public void ClearDetails()
        {
            _selectedPengumpulanId = null;
            KontenMateriReadOnly.Text = ""; // Should show Assignment Description
            JawabanTugasReadOnly.Text = "";
            NilaiTugas.Value = 0; // Reset grade input
            NilaiTugas.Enabled = false;
            Bsave.Enabled = false;
            Bdelete.Enabled = false;
            listPengumpulanDataGrid.ClearSelection();
        }

        // Load assignments into the ComboBox
        public void LoadTugasComboBox()
        {
            string sql = "SELECT id_tugas, nama_tugas FROM tugas ORDER BY nama_tugas";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Add a placeholder item
                    DataRow placeholder = dt.NewRow();
                    placeholder["id_tugas"] = DBNull.Value; // Use DBNull for value
                    placeholder["nama_tugas"] = "-- Pilih Tugas --";
                    dt.Rows.InsertAt(placeholder, 0);


                    NamaTugasSelect.DataSource = dt;
                    NamaTugasSelect.DisplayMember = "nama_tugas";
                    NamaTugasSelect.ValueMember = "id_tugas"; // This will be int or DBNull
                    NamaTugasSelect.SelectedIndex = 0; // Select placeholder initially
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error memuat daftar tugas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for ComboBox selection change
        private void NamaTugasSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NamaTugasSelect.SelectedIndex > 0 && NamaTugasSelect.SelectedValue != null && NamaTugasSelect.SelectedValue != DBNull.Value)
            {
                _selectedTugasId = Convert.ToInt32(NamaTugasSelect.SelectedValue);
                LoadSubmissionsGrid(); // Load submissions for the selected task
                LoadAssignmentDescription(); // Load description for selected task
            }
            else
            {
                _selectedTugasId = null;
                listPengumpulanDataGrid.DataSource = null; // Clear grid if placeholder selected
                ClearDetails();
                KontenMateriReadOnly.Text = ""; // Clear assignment description
            }
        }

        // Load assignment description into the read-only RichTextBox
        private void LoadAssignmentDescription()
        {
            if (_selectedTugasId == null)
            {
                KontenMateriReadOnly.Text = "";
                return;
            }

            string sql = "SELECT deskripsi_tugas FROM tugas WHERE id_tugas = @id_tugas";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id_tugas", _selectedTugasId.Value);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    KontenMateriReadOnly.Text = result?.ToString() ?? "Tidak ada deskripsi.";
                }
            }
            catch (Exception ex)
            {
                KontenMateriReadOnly.Text = "Error memuat deskripsi.";
                MessageBox.Show("Error memuat deskripsi tugas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Load submissions into the DataGridView for the selected task
        private void LoadSubmissionsGrid(string searchTerm = null)
        {
            if (_selectedTugasId == null)
            {
                listPengumpulanDataGrid.DataSource = null;
                return; // No task selected
            }

            // --- Updated SQL Query ---
            // Select relevant columns: submission ID, student name (from manajemen), submission date, grade
            string sql = @"SELECT
                       p.id_pengumpulan,
                       m.[nama lengkap] AS NamaSiswa, -- Get name from manajemen table
                       p.tanggal_pengumpulan,
                       p.nilai
                   FROM
                       pengumpulan_tugas p
                   JOIN
                       dbo.manajemen m ON p.id_user = m.NIP -- JOIN with manajemen using NIP
                   WHERE
                       p.id_tugas = @id_tugas"; // Filter by selected assignment ID

            try
            {
                // Add search condition based on the name from the manajemen table
                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    // Add the AND keyword before the search condition
                    sql += " AND m.[nama lengkap] LIKE @SearchTerm";
                }

                // Add ORDER BY clause for the name from the manajemen table
                sql += " ORDER BY m.[nama lengkap]"; // Order by student name

                // --- End of Updated SQL Query ---


                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Add the required parameter for the selected assignment
                    command.Parameters.AddWithValue("@id_tugas", _selectedTugasId.Value);

                    // Add the search parameter only if a search term was provided
                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        listPengumpulanDataGrid.DataSource = null;
                        listPengumpulanDataGrid.DataSource = dt;

                        // Configure grid columns (after setting datasource)
                        // This part remains the same as it uses the alias 'NamaSiswa'
                        if (listPengumpulanDataGrid.Columns.Count > 0)
                        {
                            // Check if columns exist before accessing them (safer)
                            if (listPengumpulanDataGrid.Columns.Contains("id_pengumpulan"))
                                listPengumpulanDataGrid.Columns["id_pengumpulan"].Visible = false; // Hide ID

                            if (listPengumpulanDataGrid.Columns.Contains("NamaSiswa"))
                                listPengumpulanDataGrid.Columns["NamaSiswa"].HeaderText = "Nama Pengguna"; // Changed Header Text slightly

                            if (listPengumpulanDataGrid.Columns.Contains("tanggal_pengumpulan"))
                            {
                                listPengumpulanDataGrid.Columns["tanggal_pengumpulan"].HeaderText = "Tgl Pengumpulan";
                                listPengumpulanDataGrid.Columns["tanggal_pengumpulan"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                            }

                            if (listPengumpulanDataGrid.Columns.Contains("nilai"))
                                listPengumpulanDataGrid.Columns["nilai"].HeaderText = "Nilai";


                            // Adjust FillWeights if columns exist
                            if (listPengumpulanDataGrid.Columns.Contains("NamaSiswa") &&
                                listPengumpulanDataGrid.Columns.Contains("tanggal_pengumpulan") &&
                                listPengumpulanDataGrid.Columns.Contains("nilai"))
                            {
                                listPengumpulanDataGrid.Columns["NamaSiswa"].FillWeight = 50;
                                listPengumpulanDataGrid.Columns["tanggal_pengumpulan"].FillWeight = 30;
                                listPengumpulanDataGrid.Columns["nilai"].FillWeight = 20;
                            }
                        }
                    }
                }
                ClearDetails(); // Clear details when grid reloads
            }
            catch (SqlException ex) // Catch specific SQL errors first
            {
                MessageBox.Show("Database Error saat memuat data pengumpulan: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listPengumpulanDataGrid.DataSource = null;
            }
            catch (Exception ex) // Catch general errors
            {
                MessageBox.Show("Error memuat data pengumpulan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listPengumpulanDataGrid.DataSource = null;
            }
        }

        // Event handler for search text changes
        private void search_TextChanged(object sender, EventArgs e)
        {
            // Reload the grid for the currently selected task, applying the search term
            LoadSubmissionsGrid(search.Text);
        }


        // Event handler for clicking a row in the submissions grid
        private void listPengumpulanDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < listPengumpulanDataGrid.Rows.Count)
            {
                DataGridViewRow row = listPengumpulanDataGrid.Rows[e.RowIndex];
                try
                {
                    _selectedPengumpulanId = Convert.ToInt32(row.Cells["id_pengumpulan"].Value);

                    // Load the student's answer for this specific submission
                    LoadSubmissionDetails();

                    // Enable controls for grading/deleting
                    NilaiTugas.Enabled = true;
                    Bsave.Enabled = true;
                    Bdelete.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error memuat detail pengumpulan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearDetails();
                }
            }
        }

        // Load details for the selected submission
        private void LoadSubmissionDetails()
        {
            if (_selectedPengumpulanId == null) return;

            string sql = "SELECT jawaban_tugas, nilai FROM pengumpulan_tugas WHERE id_pengumpulan = @id_pengumpulan";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id_pengumpulan", _selectedPengumpulanId.Value);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            JawabanTugasReadOnly.Text = reader["jawaban_tugas"]?.ToString() ?? "";
                            object nilaiObj = reader["nilai"];
                            if (nilaiObj != null && nilaiObj != DBNull.Value)
                            {
                                // Use decimal for NumericUpDown, safely convert
                                if (decimal.TryParse(nilaiObj.ToString(), out decimal currentNilai))
                                {
                                    // Clamp value within NumericUpDown limits if necessary
                                    NilaiTugas.Value = Math.Max(NilaiTugas.Minimum, Math.Min(NilaiTugas.Maximum, currentNilai));
                                }
                                else
                                {
                                    NilaiTugas.Value = NilaiTugas.Minimum; // Default if conversion fails
                                }

                            }
                            else
                            {
                                NilaiTugas.Value = NilaiTugas.Minimum; // Or 0 if Minimum is 0
                            }
                        }
                        else
                        {
                            // Submission not found? Should not happen if ID came from grid
                            ClearDetails();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error memuat jawaban/nilai: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearDetails();
            }
        }


        // Save Button (Grade Submission)
        private void Bsave_Click(object sender, EventArgs e)
        {
            if (_selectedPengumpulanId == null)
            {
                MessageBox.Show("Pilih data pengumpulan yang akan dinilai.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = @"UPDATE pengumpulan_tugas
                           SET nilai = @nilai, tanggal_penilaian = GETDATE()
                           WHERE id_pengumpulan = @id_pengumpulan";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Get value from NumericUpDown
                    command.Parameters.AddWithValue("@nilai", Convert.ToInt32(NilaiTugas.Value)); // Assuming nilai is INT
                    command.Parameters.AddWithValue("@id_pengumpulan", _selectedPengumpulanId.Value);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Nilai berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSubmissionsGrid(search.Text); // Refresh grid with current search
                        // ClearDetails(); // Keep selection or clear? Let's clear.
                        ClearDetails();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menyimpan nilai. Data mungkin tidak ditemukan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menyimpan nilai: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete Button
        private void Bdelete_Click(object sender, EventArgs e)
        {
            if (_selectedPengumpulanId == null)
            {
                MessageBox.Show("Pilih data pengumpulan yang akan dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmation
            DialogResult confirmation = MessageBox.Show("Apakah Anda yakin ingin menghapus data pengumpulan ini?",
                                                      "Konfirmasi Hapus",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                string sql = "DELETE FROM pengumpulan_tugas WHERE id_pengumpulan = @id_pengumpulan";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id_pengumpulan", _selectedPengumpulanId.Value);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data pengumpulan berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadSubmissionsGrid(search.Text); // Refresh grid
                            ClearDetails();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus. Data mungkin tidak ditemukan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat menghapus data pengumpulan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Cancel Button
        private void Bcancel_Click(object sender, EventArgs e)
        {
            ClearDetails();
            // Optionally reset ComboBox selection?
            // NamaTugasSelect.SelectedIndex = 0;
            listPengumpulanDataGrid.ClearSelection();
        }
    }
}