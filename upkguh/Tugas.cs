using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace upkguh
{
    public partial class Tugas : UserControl
    {
        private string connectionString = Konesksi.conn;
        private int? _selectedTugasId = null; // To store the ID of the selected row for update/delete

        public Tugas()
        {
            InitializeComponent();
            ConfigureDataGridView();
            ShowData();
            UpdateDateLabel();
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false; // Optional: Hide row header column

            // Attach the event handler for cell clicks
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a valid row is clicked (not the header)
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                try
                {
                    // Get the ID from the hidden column
                    _selectedTugasId = Convert.ToInt32(row.Cells["id_tugas"].Value);

                    // Populate the input fields (handle potential DBNull values)
                    NamaTugas.Text = row.Cells["nama_tugas"].Value?.ToString() ?? "";
                    DeskripsiTugas.Text = row.Cells["deskripsi_tugas"].Value?.ToString() ?? ""; // RichTextBox handles nulls okay
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error konversi ID tugas: " + ex.Message, "Error Tipe Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error memuat data dari baris: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ShowData()
        {
            try
            {
                // Using statement ensures proper disposal of resources
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("SELECT id_tugas, nama_tugas, deskripsi_tugas, tanggal_dibuat, tanggal_diubah FROM tugas ORDER BY tanggal_dibuat DESC", connection)) // Order by newest first
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable tabel = new DataTable();
                    adapter.Fill(tabel);

                    dataGridView1.DataSource = null; // Unbind previous data
                    dataGridView1.DataSource = tabel;
                    dataGridView1.ClearSelection();

                    // Configure Columns (AFTER setting DataSource)
                    if (dataGridView1.Columns.Count > 0)
                    {
                        dataGridView1.Columns["id_tugas"].Visible = false; // Hide internal ID
                        dataGridView1.Columns["deskripsi_tugas"].Visible = false; // Description shown in RichTextBox
                        dataGridView1.Columns["nama_tugas"].HeaderText = "Nama Tugas";
                        dataGridView1.Columns["tanggal_dibuat"].HeaderText = "Tgl Dibuat";
                        dataGridView1.Columns["tanggal_diubah"].HeaderText = "Tgl Diubah";

                        // Optional: Adjust column widths or fill weights
                        dataGridView1.Columns["nama_tugas"].FillWeight = 60;
                        dataGridView1.Columns["tanggal_dibuat"].FillWeight = 20;
                        dataGridView1.Columns["tanggal_diubah"].FillWeight = 20;

                        // Optional: Format date columns
                        dataGridView1.Columns["tanggal_dibuat"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                        dataGridView1.Columns["tanggal_diubah"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error saat menampilkan data tugas: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menampilkan data tugas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void NamaTugas_Click(object sender, EventArgs e)
        {

        }
    }
}
