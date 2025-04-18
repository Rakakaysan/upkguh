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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 window = new Form1();
            this.Hide();
            window.Show();
        }

        private void manage_Click(object sender, EventArgs e)
        {
            manajemen_pengguna1.BringToFront();
        }

        private void materi_Click(object sender, EventArgs e)
        {
            materi_Pembelajaran1.BringToFront();
        }

        private void informasi_Click(object sender, EventArgs e)
        {
            informasi_Pengguna1.BringToFront();
        }

        private void setting_Click(object sender, EventArgs e)
        {
            pengaturan_sistem1.BringToFront();
        }

        private void tentang_Click(object sender, EventArgs e)
        {
            tentang_apk1.BringToFront();
        }
    }
}
