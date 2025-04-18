using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upkguh
{
    public partial class Form1 : Form
    {
        public SqlConnection connection = new SqlConnection(Konesksi.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;
        public Form1()
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
                    Form2 window = new Form2();
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
                MessageBox.Show("Username atau password salah", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
