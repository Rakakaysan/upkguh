using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace upkguh
{
    public partial class Manajemen_pengguna : UserControl
    {
        // Use the connection string from your Konesksi class
        private string connectionString = Konesksi.conn;
        private int? _selectedNip = null; // Use nullable int to track selected NIP for editing/deleting

        public Manajemen_pengguna()
        {
            InitializeComponent();
            ConfigureDataGridView(); // Optional: Configure DGV appearance/behavior
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            ShowData();
            ClearInputs(); // Start with clean inputs
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Select full rows
            dataGridView1.MultiSelect = false; // Only allow selecting one row
            dataGridView1.AllowUserToAddRows = false; // Prevent users adding rows directly
            dataGridView1.AllowUserToDeleteRows = false; // Prevent users deleting rows directly
            dataGridView1.ReadOnly = true; // Make grid read-only, editing happens in textboxes
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Adjust columns
        }

        // --- READ ---
        // Update Signature: Add optional searchTerm parameter
        public void ShowData(string searchTerm = null)
        // End Update Signature
        {
            // Add this line: Base SQL query without WHERE clause
            string sql = "SELECT NIP, [nama lengkap], jabatan, status, username, password FROM [manajemen]";

            try
            {
                // Add this block: Modify SQL and add parameter if searchTerm is provided
                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    // Search across multiple relevant fields (NIP, Nama, Username)
                    // Use LIKE for partial matches. CAST NIP to VARCHAR for LIKE comparison.
                    sql += @" WHERE CAST(NIP AS VARCHAR(20)) LIKE @SearchTerm
                      OR [nama lengkap] LIKE @SearchTerm
                      OR username LIKE @SearchTerm
                      OR jabatan LIKE @SearchTerm
                      OR status LIKE @SearchTerm";
                }
                // End Add block

                using (SqlConnection connection = new SqlConnection(connectionString))
                // Update this line: Use the dynamically built 'sql' variable
                using (SqlCommand command = new SqlCommand(sql, connection))
                // End Update line
                {
                    // Add this block: Add the search parameter IF searchTerm was provided
                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        // Add '%' wildcards for partial matching
                        command.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");
                    }
                    // End Add block

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable tabel = new DataTable();
                        adapter.Fill(tabel);

                        // --- Keep the rest of the ShowData method as is from here ---
                        dataGridView1.DataSource = null; // Clear previous data source
                        dataGridView1.DataSource = tabel; // Bind new data
                        dataGridView1.ClearSelection(); // Deselect any rows initially

                        // Set Header Text (Important: Do this *after* setting DataSource)
                        if (dataGridView1.Columns.Count >= 6)
                        {
                            dataGridView1.Columns["NIP"].HeaderText = "NIP";
                            dataGridView1.Columns["nama lengkap"].HeaderText = "Nama Lengkap";
                            dataGridView1.Columns["jabatan"].HeaderText = "Jabatan";
                            dataGridView1.Columns["status"].HeaderText = "Status";
                            dataGridView1.Columns["username"].HeaderText = "Username";
                            dataGridView1.Columns["password"].HeaderText = "Password";
                            // dataGridView1.Columns["password"].Visible = false;
                        }
                        else if (dataGridView1.Columns.Count > 0)
                        {
                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                dataGridView1.Columns[i].HeaderText = tabel.Columns[i].ColumnName;
                            }
                        }

                        if (tabel.Rows.Count == 0 && !string.IsNullOrWhiteSpace(searchTerm))
                        {
                            // Optional: Indicate if search yielded no results
                            // MessageBox.Show($"Data dengan kata kunci '{searchTerm}' tidak ditemukan.");
                        }
                        else if (tabel.Rows.Count == 0)
                        {
                            // Optional: Indicate table is empty (no search term)
                            // MessageBox.Show("Tidak ada data pengguna di tabel manajemen.");
                        }
                    }
                } // using statements automatically close the connection
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error saat menampilkan/mencari data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menampilkan/mencari data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            // Call ShowData, passing the current text from the search box
            ShowData(search.Text);
        }

        // --- Helper: Clear Inputs ---
        private void ClearInputs()
        {
            nip_input.Clear();
            nama.Clear();
            jabatan.Clear();
            status.Clear();
            username.Clear();
            password.Clear();

            _selectedNip = null; // Reset selected NIP
            nip_input.ReadOnly = false; // Allow editing NIP for new entries
            Bsave.Text = "Save"; // Reset button text
            dataGridView1.ClearSelection();
        }

        // --- Helper: Validate Inputs ---
        private bool ValidateInputs(bool isUpdate = false)
        {
            // NIP validation (only for new entries)
            if (!isUpdate)
            {
                if (string.IsNullOrWhiteSpace(nip_input.Text))
                {
                    MessageBox.Show("NIP tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nip_input.Focus();
                    return false;
                }
                if (!int.TryParse(nip_input.Text, out _)) // Check if NIP is a valid integer
                {
                    MessageBox.Show("NIP harus berupa angka.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nip_input.Focus();
                    return false;
                }
            }

            // Other fields validation
            if (string.IsNullOrWhiteSpace(nama.Text))
            {
                MessageBox.Show("Nama Lengkap tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nama.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(jabatan.Text))
            {
                MessageBox.Show("Jabatan tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                jabatan.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(status.Text))
            {
                MessageBox.Show("Status tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                status.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(username.Text))
            {
                MessageBox.Show("Username tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                username.Focus();
                return false;
            }
            // Password can often be optional or handled differently, adding basic check
            if (string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Password tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password.Focus();
                return false;
            }

            return true; // All validations passed
        }


        // --- CREATE / UPDATE ---
        private void Bsave_Click(object sender, EventArgs e)
        {
            bool isUpdate = (_selectedNip != null); // Check if we are updating

            if (!ValidateInputs(isUpdate)) // Pass whether it's an update for validation logic
            {
                return; // Stop if validation fails
            }

            string sql;
            if (isUpdate)
            {
                // --- UPDATE ---
                sql = "UPDATE [manajemen] SET [nama lengkap] = @Nama, jabatan = @Jabatan, status = @Status, username = @Username, password = @Password WHERE NIP = @NIP";
            }
            else
            {
                // --- CREATE (INSERT) ---
                // Optional: Check if NIP already exists before inserting
                if (NipExists(int.Parse(nip_input.Text)))
                {
                    MessageBox.Show($"NIP {nip_input.Text} sudah ada. Gunakan NIP lain.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nip_input.Focus();
                    return;
                }
                sql = "INSERT INTO [manajemen] (NIP, [nama lengkap], jabatan, status, username, password) VALUES (@NIP, @Nama, @Jabatan, @Status, @Username, @Password)";
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Add parameters (prevents SQL Injection)
                    // Use AddWithValue for simplicity, but Add is slightly preferred for explicit type specification
                    command.Parameters.AddWithValue("@Nama", nama.Text.Trim());
                    command.Parameters.AddWithValue("@Jabatan", jabatan.Text.Trim());
                    command.Parameters.AddWithValue("@Status", status.Text.Trim());
                    command.Parameters.AddWithValue("@Username", username.Text.Trim());
                    command.Parameters.AddWithValue("@Password", password.Text); // Don't trim password

                    // Add NIP parameter differently for INSERT vs UPDATE
                    if (isUpdate)
                    {
                        command.Parameters.AddWithValue("@NIP", _selectedNip.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@NIP", int.Parse(nip_input.Text.Trim()));
                    }

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery(); // Execute the command

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Data berhasil {(isUpdate ? "diperbarui" : "disimpan")}!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData(); // Refresh the grid
                        ClearInputs(); // Clear the form
                    }
                    else
                    {
                        MessageBox.Show($"Data gagal {(isUpdate ? "diperbarui" : "disimpan")}.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } // using automatically closes connection
            }
            catch (SqlException ex)
            {
                // Check for specific SQL errors like Primary Key violation if needed
                if (!isUpdate && ex.Number == 2627) // Primary key violation error number
                {
                    MessageBox.Show($"NIP {nip_input.Text} sudah ada. Gunakan NIP lain.", "Error Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nip_input.Focus();
                }
                else
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error Konversi NIP: Pastikan NIP adalah angka yang valid. " + ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nip_input.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Event Handler for Grid Click (to load data for editing) ---
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row (not header) is clicked
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Safely get data from cells, handle potential nulls or DBNull
                try
                {
                    // Store the selected NIP
                    _selectedNip = Convert.ToInt32(row.Cells["NIP"].Value);

                    // Populate text boxes
                    nip_input.Text = row.Cells["NIP"].Value?.ToString() ?? "";
                    nama.Text = row.Cells["nama lengkap"].Value?.ToString() ?? "";
                    jabatan.Text = row.Cells["jabatan"].Value?.ToString() ?? "";
                    status.Text = row.Cells["status"].Value?.ToString() ?? "";
                    username.Text = row.Cells["username"].Value?.ToString() ?? "";
                    password.Text = row.Cells["password"].Value?.ToString() ?? ""; // Be careful displaying passwords

                    // Update UI state for editing
                    nip_input.ReadOnly = true; // Prevent editing the primary key
                    Bsave.Text = "Update"; // Change button text
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error memuat data dari baris: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearInputs(); // Clear form if loading fails
                }
            }
        }

        // --- CANCEL ---
        private void Bcancel_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        // --- DELETE ---
        // **IMPORTANT**: Add a Button named `Bdelete` in your form's designer first!
        // Then, double-click it in the designer to create this event handler.
        private void Bdelete_Click(object sender, EventArgs e)
        {
            if (_selectedNip == null)
            {
                MessageBox.Show("Pilih data yang akan dihapus dari tabel terlebih dahulu.", "Hapus Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmation dialog
            DialogResult confirmation = MessageBox.Show($"Apakah Anda yakin ingin menghapus pengguna dengan NIP: {_selectedNip.Value}?",
                                                       "Konfirmasi Hapus",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                string sql = "DELETE FROM [manajemen] WHERE NIP = @NIP";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@NIP", _selectedNip.Value);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ShowData();    // Refresh grid
                            ClearInputs(); // Clear form
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan atau gagal dihapus.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    } // using automatically closes connection
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error saat menghapus: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("General Error saat menghapus: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- Optional: Check if NIP exists before Insert ---
        private bool NipExists(int nip)
        {
            string sql = "SELECT COUNT(*) FROM [manajemen] WHERE NIP = @NIP";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@NIP", nip);
                    connection.Open();
                    int count = (int)command.ExecuteScalar(); // Gets the result of the COUNT(*)
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat memeriksa NIP: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; // Assume it exists to prevent accidental overwrite on error
            }
        }

        // Remove or comment out the old insertData if it's no longer needed
        // public void insertData() { ... }

        // Keep this empty if you don't need specific cell content click logic
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Usually handled by CellClick or SelectionChanged for loading data
        }

        // You might not need the Bedit button click if CellClick loads data.
        // If you keep Bedit, decide its function (e.g., maybe enable editing fields?)
        private void Bedit_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Manajemen_pengguna_Load(object sender, EventArgs e)
        {

        }
    }
}