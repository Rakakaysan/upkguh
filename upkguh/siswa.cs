using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Form1 window = new Form1();
            this.Hide();
            window.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Kompetensi_Click(object sender, EventArgs e)
        {
            kompetisi1.BringToFront();
        }

        private void materi_Click(object sender, EventArgs e)
        {
            materi.BringToFront();
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
    }
}
