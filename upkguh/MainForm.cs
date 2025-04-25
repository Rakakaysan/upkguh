using System;
using System.Windows.Forms;

namespace upkguh
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manage_Click(object sender, EventArgs e)
        {
            manajemen_pengguna1.BringToFront();
        }

        private void materi_Click(object sender, EventArgs e)
        {
            materi_Pembelajaran1.BringToFront();
        }

        private void tentang_Click(object sender, EventArgs e)
        {
            tentang_apk1.BringToFront();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tugasAdmin1.BringToFront();
        }

        private void informasi_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tentang_apk1_Load(object sender, EventArgs e)
        {

        }
    }
}
