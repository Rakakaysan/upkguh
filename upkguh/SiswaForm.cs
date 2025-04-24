using System;
using System.Windows.Forms;

namespace upkguh
{
    public partial class siswa : Form
    {
        public siswa()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Kompetensi_Click(object sender, EventArgs e)
        {
            kompetisi1.BringToFront();
        }

        private void materi_Click(object sender, EventArgs e)
        {
            materi1.BringToFront();
        }

        private void tugas_Click(object sender, EventArgs e)
        {
            tugas1.BringToFront();
        }

        private void tentang_Click(object sender, EventArgs e)
        {
            tentang_apk1.BringToFront();
        }

        private void pengertian_Click(object sender, EventArgs e)
        {
            pengertian1.BringToFront();
        }

        private void ciri_Click(object sender, EventArgs e)
        {
            ciriCiri1.BringToFront();
        }

        private void jeniscndi_Click(object sender, EventArgs e)
        {
            jenis_jenis1.BringToFront();
        }

        private void fungsi_Click(object sender, EventArgs e)
        {
            fungsi1.BringToFront();
        }

        private void contoh_Click(object sender, EventArgs e)
        {
            contoh1.BringToFront();
        }

        private void vidcndi_Click(object sender, EventArgs e)
        {
            vidcndi.BringToFront();
        }

        private void siswa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void siswa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
