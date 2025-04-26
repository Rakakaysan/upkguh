using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace upkguh
{
    public partial class LoginForm : Form
    {
        public SqlConnection connection = new SqlConnection(Konesksi.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            string username = tUsername.Text;
            string password = tPassword.Text;

            string sql = "SELECT * FROM [user] WHERE username = @username AND password = @password";

            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            adapter = new SqlDataAdapter(command);
            tabel = new DataTable();
            adapter.Fill(tabel);

            if (tabel.Rows.Count > 0)
            {
                DataRow row = tabel.Rows[0]; // Ambil baris pertama saja
                if (row["role"].ToString() == "admin")
                {
                    reader = command.ExecuteReader();
                    reader.Read();
                    Model.name = reader.GetString(1);

                    this.Hide();
                    MainForm window = new MainForm();
                    window.Show();
                }
                else if (row["role"].ToString() == "siswa")
                {
                    this.Hide();
                    siswa windows = new siswa();
                    windows.Show();
                }
                else
                {
                    MessageBox.Show("Role tidak dikenali", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                connection.Close();
                connection.Open();

                username = tUsername.Text;
                password = tPassword.Text;

                sql = "SELECT * FROM [manajemen] WHERE username = @username AND password = @password";

                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                adapter = new SqlDataAdapter(command);
                tabel = new DataTable();
                adapter.Fill(tabel);

                if (tabel.Rows.Count > 0)
                {
                    reader = command.ExecuteReader();
                    reader.Read();
                    Model.id = reader.GetInt32(0);
                    this.Hide();
                    siswa windows = new siswa();
                    windows.Show();
                }

                else
                {
                    MessageBox.Show("Username atau password salah", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
            }

            connection.Close();
        }

        private void Bcancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
