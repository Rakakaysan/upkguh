using Microsoft.Data.SqlClient; // Make sure you have this package installed
using System;
using System.Data;
using System.Windows.Forms;

namespace upkguh
{
    public partial class Materi_Pembelajaran : UserControl
    {
        // Assume Konesksi.conn provides the connection string
        private string connectionString = Konesksi.conn;
        private int? _selectedMateriId = null; // To store the ID of the selected row for update/delete

        public Materi_Pembelajaran()
        {
            InitializeComponent();
            ConfigureDataGridView(); // Optional: Improve DGV appearance
            ShowData();
            ClearInputs(); // Start with a clean form
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Consider setting specific column widths if Fill doesn't look right
        }

        // --- READ ---
        public void ShowData()
        {
            try
            {
                // Using statement ensures connection is closed even if errors occur
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("SELECT id_materi, nama_materi, konten_materi, url_youtube, tanggal_dibuat, tanggal_diubah FROM materi_pembelajaran ORDER BY nama_materi", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable tabel = new DataTable();
                    adapter.Fill(tabel);

                    dataGridView1.DataSource = null; // Clear previous data
                    dataGridView1.DataSource = tabel;
                    dataGridView1.ClearSelection(); // Deselect any rows

                    // Set Header Text & Hide ID Column (Do this *after* setting DataSource)
                    if (dataGridView1.Columns.Count > 0)
                    {
                        dataGridView1.Columns["id_materi"].Visible = false; // Hide internal ID
                        dataGridView1.Columns["nama_materi"].HeaderText = "Nama Materi";
                        dataGridView1.Columns["konten_materi"].HeaderText = "Konten";
                        dataGridView1.Columns["url_youtube"].HeaderText = "URL YouTube";
                        dataGridView1.Columns["tanggal_dibuat"].HeaderText = "Tgl Dibuat";
                        dataGridView1.Columns["tanggal_diubah"].HeaderText = "Tgl Diubah";

                        // Optional: Format date columns if needed
                        dataGridView1.Columns["tanggal_dibuat"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                        dataGridView1.Columns["tanggal_diubah"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    }


                    if (tabel.Rows.Count == 0)
                    {
                        // Optional: Inform user if table is empty
                        // MessageBox.Show("Belum ada data materi pembelajaran.");
                    }
                } // using automatically closes connection
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error saat menampilkan data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menampilkan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Helper: Clear Inputs ---
        private void ClearInputs()
        {
            NamaMateri.Clear();
            KontenMateri.Clear();
            URLYouTubeMateri.Clear();

            _selectedMateriId = null; // Reset selection
            Bsave.Text = "Save";      // Reset button text
            dataGridView1.ClearSelection(); // Deselect grid row
        }

        // --- Helper: Validate Inputs ---
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(NamaMateri.Text))
            {
                MessageBox.Show("Nama Materi tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NamaMateri.Focus();
                return false;
            }
            // Basic URL validation (optional, can be more sophisticated)
            if (!string.IsNullOrWhiteSpace(URLYouTubeMateri.Text))
            {
                if (!Uri.TryCreate(URLYouTubeMateri.Text, UriKind.Absolute, out _))
                {
                    // Allow simple non-URL text too, or enforce stricter validation:
                    // MessageBox.Show("Format URL YouTube tidak valid.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // URLYouTubeMateri.Focus();
                    // return false;
                }
            }

            return true; // All good
        }


        // --- CREATE / UPDATE ---
        private void Bsave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return; // Stop if validation fails
            }

            bool isUpdate = (_selectedMateriId != null);
            string sql;

            if (isUpdate)
            {
                // --- UPDATE ---
                sql = @"UPDATE materi_pembelajaran
                        SET nama_materi = @Nama,
                            konten_materi = @Konten,
                            url_youtube = @Url,
                            tanggal_diubah = GETDATE()
                        WHERE id_materi = @Id";
            }
            else
            {
                // --- CREATE (INSERT) ---
                // tanggal_dibuat has a default, tanggal_diubah is NULL initially
                sql = @"INSERT INTO materi_pembelajaran (nama_materi, konten_materi, url_youtube)
                        VALUES (@Nama, @Konten, @Url)";
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Add parameters to prevent SQL Injection
                    command.Parameters.AddWithValue("@Nama", NamaMateri.Text.Trim());

                    // Handle potential nulls for nullable columns
                    command.Parameters.AddWithValue("@Konten", string.IsNullOrWhiteSpace(KontenMateri.Text) ? (object)DBNull.Value : KontenMateri.Text.Trim());
                    command.Parameters.AddWithValue("@Url", string.IsNullOrWhiteSpace(URLYouTubeMateri.Text) ? (object)DBNull.Value : URLYouTubeMateri.Text.Trim());

                    if (isUpdate)
                    {
                        command.Parameters.AddWithValue("@Id", _selectedMateriId.Value);
                    }

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Data materi berhasil {(isUpdate ? "diperbarui" : "disimpan")}!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData();    // Refresh the grid
                        ClearInputs(); // Clear the form
                    }
                    else
                    {
                        MessageBox.Show($"Data materi {(isUpdate ? "tidak ditemukan atau " : "")}gagal {(isUpdate ? "diperbarui" : "disimpan")}.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } // using automatically closes connection
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Event Handler for Grid Click (to load data for editing) ---
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a valid row is clicked (not the header)
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                try
                {
                    // Get the ID from the hidden column
                    _selectedMateriId = Convert.ToInt32(row.Cells["id_materi"].Value);

                    // Populate the input fields (handle potential DBNull values)
                    NamaMateri.Text = row.Cells["nama_materi"].Value?.ToString() ?? "";
                    KontenMateri.Text = row.Cells["konten_materi"].Value?.ToString() ?? "";
                    URLYouTubeMateri.Text = row.Cells["url_youtube"].Value?.ToString() ?? "";

                    // Change button text to indicate update mode
                    Bsave.Text = "Update";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error memuat data dari baris: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearInputs(); // Clear form if loading fails
                }
            }
        }


        // --- DELETE ---
        private void Bdelete_Click(object sender, EventArgs e)
        {
            if (_selectedMateriId == null)
            {
                MessageBox.Show("Pilih data materi yang akan dihapus dari tabel terlebih dahulu.", "Hapus Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmation dialog
            DialogResult confirmation = MessageBox.Show($"Apakah Anda yakin ingin menghapus materi '{NamaMateri.Text}' (ID: {_selectedMateriId.Value})?",
                                                       "Konfirmasi Hapus",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                string sql = "DELETE FROM materi_pembelajaran WHERE id_materi = @Id";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", _selectedMateriId.Value);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data materi berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ShowData();    // Refresh grid
                            ClearInputs(); // Clear form
                        }
                        else
                        {
                            MessageBox.Show("Data materi tidak ditemukan atau gagal dihapus.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    } // using automatically closes connection
                }
                catch (SqlException ex)
                {
                    // Handle potential foreign key constraint errors if this table is referenced elsewhere
                    MessageBox.Show("Database Error saat menghapus: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("General Error saat menghapus: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- CANCEL ---
        private void Bcancel_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
    }
}