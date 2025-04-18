using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace upkguh
{
    public partial class Manajemen_pengguna : UserControl
    {
        private SqlConnection connection = new SqlConnection(Konesksi.conn);
        private SqlCommand command;
        private SqlDataAdapter adapter;
        public SqlDataReader reader;
        private DataTable tabel;
        public int NIP;
        public Manajemen_pengguna()
        {
            InitializeComponent();
            ShowData();
        }
        public void ShowData()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

                connection.Open();

                string sql = "SELECT * FROM [manajemen]";
                command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                tabel = new DataTable();
                adapter.Fill(tabel);

                if (tabel.Rows.Count == 0)
                {
                    MessageBox.Show("Data tidak ditemukan di tabel manajemen.");
                }

                dataGridView1.DataSource = tabel;
                dataGridView1.Refresh();

                // Validasi jumlah kolom sebelum mengakses
                if (dataGridView1.Columns.Count >= 6)
                {
                    dataGridView1.Columns[0].HeaderText = "NIP";
                    dataGridView1.Columns[1].HeaderText = "Nama";
                    dataGridView1.Columns[2].HeaderText = "Email";
                    dataGridView1.Columns[3].HeaderText = "Jabatan";
                    dataGridView1.Columns[4].HeaderText = "Status";
                    dataGridView1.Columns[5].HeaderText = "Password";
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menampilkan data: " + ex.Message);
            }
        }

        public void insertData()
        {
            try
            {
                connection.Close();
                connection.Open();

                string sql = "INSERT INTO [user] (nama, role, email, no_telp, username, password) " +
                    "VALUES (@nama, @role, @email, @no_telp, @username, @password)";

                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@nama", nama.Text);
                command.Parameters.AddWithValue("@role", "siswa"); // Role akan selalu menjadi siswa
                command.Parameters.AddWithValue("@email", jabatan.Text);
                command.Parameters.AddWithValue("@no_telp", status.Text);
                command.Parameters.AddWithValue("@username", username.Text);
                command.Parameters.AddWithValue("@password", password.Text);
                command.ExecuteNonQuery();

                sql = "SELECT id_user FROM [user] WHERE username = '" + username.Text + "' " +
                    "AND password = '" + password.Text + "'";

                command = new SqlCommand(sql, connection);

                reader = command.ExecuteReader();
                reader.Read();
                int id = reader.GetInt32(0); // dapatkan id dari SQL Query diatas

                connection.Close();
                connection.Open();

                sql = "INSERT INTO [siswa] (id_user, nis, kelas, alamat) " +
                    "VALUES (@id, @nis, @kelas, @alamat)";

                command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nis", nis.Text);
                command.Parameters.AddWithValue("@kelas", kelas.SelectedItem);
                command.Parameters.AddWithValue("@alamat", alamat.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Data berhasil dimasukan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                clearinput();
                ShowData();
            }
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Bsave_Click(object sender, EventArgs e)
        {

        }
    }
}
