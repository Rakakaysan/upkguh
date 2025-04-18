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
    public partial class Materi : UserControl
    {
        public Materi()
        {
            InitializeComponent();
        }

        private void pengertian_Click(object sender, EventArgs e)
        {
            pengertian.BringToFront();
        }

        private void contoh_Click(object sender, EventArgs e)
        {
            contoh.BringToFront();
        }
    }
}
