using Microsoft.Data.SqlClient; // Added
using System;
using System.Data;
using System.Globalization;

//using System.Data.SqlClient; // Can remove if using Microsoft.Data.SqlClient
using System.Windows.Forms;

namespace upkguh
{
    public partial class Tugas : UserControl
    {
        private string connectionString = Konesksi.conn;
        private int? _selectedTugasId = null;
        // **** IMPORTANT: Assume you have a way to get the current student's ID ****
        // **** Replace this with your actual implementation ****
        //private int _currentUserId = CurrentUser.UserId; // Example: Get ID from a static class
        private int _currentUserId = Model.id; // Example: Get ID from a static class

        public Tugas()
        {
            InitializeComponent();
            ConfigureDataGridView();

            // Add this line: Attach event handler for the search TextBox
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // End Add line

            ShowData(); // Initial load
            UpdateDateLabel(); // This label doesn't exist in the provided designer code
            ClearDetails(); // Clear details initially
        }

        private void ConfigureDataGridView()
        {
            listTugasDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listTugasDataGridView.MultiSelect = false;
            listTugasDataGridView.AllowUserToAddRows = false;
            listTugasDataGridView.AllowUserToDeleteRows = false;
            listTugasDataGridView.ReadOnly = true;
            listTugasDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listTugasDataGridView.RowHeadersVisible = false;

            listTugasDataGridView.CellClick -= dataGridView1_CellClick; // Remove if added previously
            listTugasDataGridView.CellClick += dataGridView1_CellClick; // Add event handler
        }

        private void ClearDetails()
        {
            _selectedTugasId = null;
            NamaTugas.Text = "-";
            KontenTugas.Text = "-";
            JawabanTugasInput.Text = "";
            StatusTugasLabel.Text = "Pilih tugas dari daftar";
            JawabanTugasInput.ReadOnly = true;
            KumpulkanButton.Enabled = false;
            listTugasDataGridView.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < listTugasDataGridView.Rows.Count)
            {
                DataGridViewRow row = listTugasDataGridView.Rows[e.RowIndex];
                try
                {
                    _selectedTugasId = Convert.ToInt32(row.Cells["id_tugas"].Value);
                    NamaTugas.Text = row.Cells["nama_tugas"].Value?.ToString() ?? "";
                    // KontenTugas is a Label, use Text property
                    KontenTugas.Text = row.Cells["deskripsi_tugas"].Value?.ToString() ?? "Tidak ada deskripsi.";

                    // Now check submission status for this task and user
                    CheckSubmissionStatus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error memuat detail tugas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearDetails();
                }
            }
        }

        // Method to check submission status
        private void CheckSubmissionStatus()
        {
            if (_selectedTugasId == null) return; // No task selected

            StatusTugasLabel.Text = "Memeriksa status...";
            JawabanTugasInput.Text = "";
            JawabanTugasInput.ReadOnly = true;
            KumpulkanButton.Enabled = false;

            string sql = @"SELECT jawaban_tugas, nilai
                           FROM pengumpulan_tugas
                           WHERE id_tugas = @id_tugas AND id_user = @id_user";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id_tugas", _selectedTugasId.Value);
                    command.Parameters.AddWithValue("@id_user", _currentUserId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Submission found
                        {
                            JawabanTugasInput.Text = reader["jawaban_tugas"]?.ToString() ?? "";
                            object nilaiObj = reader["nilai"];

                            if (nilaiObj != null && nilaiObj != DBNull.Value)
                            {
                                StatusTugasLabel.Text = $"Sudah Dinilai: {nilaiObj}";
                                JawabanTugasInput.ReadOnly = true; // Cannot edit after grading
                                KumpulkanButton.Enabled = false;
                            }
                            else
                            {
                                StatusTugasLabel.Text = "Sudah Dikumpulkan (Belum Dinilai)";
                                // Decide if student can edit before grading
                                JawabanTugasInput.ReadOnly = true; // Let's make it read-only once submitted
                                KumpulkanButton.Enabled = false; // Cannot resubmit easily
                            }
                        }
                        else // No submission found
                        {
                            StatusTugasLabel.Text = "Belum Dikumpulkan";
                            JawabanTugasInput.ReadOnly = false; // Allow input
                            KumpulkanButton.Enabled = true; // Allow submission
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                StatusTugasLabel.Text = "Error memeriksa status.";
                MessageBox.Show("Error memeriksa status pengumpulan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ShowData with Search functionality
        public void ShowData(string searchTerm = null)
        {
            string sql = "SELECT id_tugas, nama_tugas, deskripsi_tugas, tanggal_dibuat, tanggal_diubah FROM tugas";
            try
            {
                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    sql += " WHERE nama_tugas LIKE @SearchTerm OR deskripsi_tugas LIKE @SearchTerm";
                }
                sql += " ORDER BY tanggal_dibuat DESC";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable tabel = new DataTable();
                        adapter.Fill(tabel);

                        listTugasDataGridView.DataSource = null;
                        listTugasDataGridView.DataSource = tabel;
                        // Keep column configuration from original ShowData
                        if (listTugasDataGridView.Columns.Count > 0)
                        {
                            listTugasDataGridView.Columns["id_tugas"].Visible = false;
                            listTugasDataGridView.Columns["deskripsi_tugas"].Visible = false;
                            listTugasDataGridView.Columns["nama_tugas"].HeaderText = "Nama Tugas";
                            listTugasDataGridView.Columns["tanggal_dibuat"].HeaderText = "Tgl Dibuat";
                            listTugasDataGridView.Columns["tanggal_diubah"].HeaderText = "Tgl Diubah";
                            listTugasDataGridView.Columns["nama_tugas"].FillWeight = 60;
                            listTugasDataGridView.Columns["tanggal_dibuat"].FillWeight = 20;
                            listTugasDataGridView.Columns["tanggal_diubah"].FillWeight = 20;
                            listTugasDataGridView.Columns["tanggal_dibuat"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                            listTugasDataGridView.Columns["tanggal_diubah"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error menampilkan/mencari data tugas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Don't clear details here, only when selecting a different row or explicitly cancelling
            // ClearDetails(); // Remove this if it was added unintentionally
        }


        // Event handler for search text changes
        private void search_TextChanged(object sender, EventArgs e)
        {
            ShowData(search.Text);
            // When search changes, selection might become invalid, so clear details
            ClearDetails();
        }

        // Event handler for the submit button
        private void KumpulkanButton_Click(object sender, EventArgs e)
        {
            if (_selectedTugasId == null)
            {
                MessageBox.Show("Pilih tugas yang ingin dikumpulkan terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(JawabanTugasInput.Text))
            {
                MessageBox.Show("Jawaban tidak boleh kosong.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                JawabanTugasInput.Focus();
                return;
            }

            // Optional: Double-check status again before submitting
            // CheckSubmissionStatus();
            // if (!KumpulkanButton.Enabled) { // Check if enabled after status check
            //     MessageBox.Show("Status tugas tidak memungkinkan untuk pengumpulan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //     return;
            // }

            string sql = @"INSERT INTO pengumpulan_tugas (id_tugas, id_user, jawaban_tugas, tanggal_pengumpulan)
                           VALUES (@id_tugas, @id_user, @jawaban, GETDATE())";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id_tugas", _selectedTugasId.Value);
                    command.Parameters.AddWithValue("@id_user", _currentUserId);
                    command.Parameters.AddWithValue("@jawaban", JawabanTugasInput.Text);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Tugas berhasil dikumpulkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Refresh status after submission
                        CheckSubmissionStatus();
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengumpulkan tugas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                // Check for unique constraint violation if student tries to submit twice (though UI should prevent)
                if (ex.Number == 2627 || ex.Number == 2601) // Unique constraint violation codes
                {
                    MessageBox.Show("Anda sudah pernah mengumpulkan tugas ini.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CheckSubmissionStatus(); // Refresh status to show existing submission
                }
                else
                {
                    MessageBox.Show("Database error saat mengumpulkan tugas: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat mengumpulkan tugas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateDateLabel()
        {
            try
            {
                // Get the current date and time
                DateTime currentDate = DateTime.Now;

                // Specify the Indonesian culture information ("id-ID")
                // This ensures day and month names are in Indonesian
                CultureInfo culture = new CultureInfo("id-ID");

                // Define the desired format string:
                // dddd = Full day name (Senin, Selasa, ...)
                // dd   = Day of the month (01-31)
                // MMMM = Full month name (Januari, Februari, ...)
                // yyyy = Four-digit year
                string format = "dddd, dd MMMM yyyy";

                // Format the date using the specified format and culture
                dateLabel.Text = currentDate.ToString(format, culture);
            }
            catch (CultureNotFoundException ex)
            {
                // Handle case where the culture might not be supported (very unlikely for id-ID)
                dateLabel.Text = "Error: Culture not found.";
                MessageBox.Show($"Error setting date format: {ex.Message}", "Culture Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle any other potential errors
                dateLabel.Text = "Error loading date.";
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Remove or comment out unused/placeholder methods
        // private void UpdateDateLabel() { ... } // Only needed if dateLabel exists
        // private void NamaTugas_Click(object sender, EventArgs e) { }
        // private void Bsave_Click(object sender, EventArgs e) { } // Not used in student view
    }

    // **** Example Static Class for Current User ID ****
    // **** Implement this based on your login system ****
    public static class CurrentUser
    {
        public static int UserId { get; set; } = 1; // Placeholder - Set this after login!
    }
}