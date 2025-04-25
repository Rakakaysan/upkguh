namespace upkguh
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tentang = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.informasi = new System.Windows.Forms.Button();
            this.materi = new System.Windows.Forms.Button();
            this.manage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tentang_apk1 = new upkguh.Tentang_apk();
            this.materi_Pembelajaran1 = new upkguh.Materi_Pembelajaran();
            this.manajemen_pengguna1 = new upkguh.Manajemen_pengguna();
            this.dashboard_Admin1 = new upkguh.Dashboard_Admin();
            this.tugasAdmin1 = new upkguh.TugasAdmin();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tentang);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.informasi);
            this.panel1.Controls.Add(this.materi);
            this.panel1.Controls.Add(this.manage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 696);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 330);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tugas Pembelajaran";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tentang
            // 
            this.tentang.FlatAppearance.BorderSize = 0;
            this.tentang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tentang.Location = new System.Drawing.Point(0, 415);
            this.tentang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tentang.Name = "tentang";
            this.tentang.Size = new System.Drawing.Size(200, 56);
            this.tentang.TabIndex = 4;
            this.tentang.Text = "Tentang Aplikasi";
            this.tentang.UseVisualStyleBackColor = true;
            this.tentang.Click += new System.EventHandler(this.tentang_Click);
            // 
            // logout
            // 
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Location = new System.Drawing.Point(3, 524);
            this.logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(197, 56);
            this.logout.TabIndex = 3;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // informasi
            // 
            this.informasi.FlatAppearance.BorderSize = 0;
            this.informasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informasi.Location = new System.Drawing.Point(0, 302);
            this.informasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.informasi.Name = "informasi";
            this.informasi.Size = new System.Drawing.Size(135, 61);
            this.informasi.TabIndex = 2;
            this.informasi.UseVisualStyleBackColor = true;
            this.informasi.Click += new System.EventHandler(this.informasi_Click);
            // 
            // materi
            // 
            this.materi.FlatAppearance.BorderSize = 0;
            this.materi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materi.Location = new System.Drawing.Point(3, 242);
            this.materi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materi.Name = "materi";
            this.materi.Size = new System.Drawing.Size(197, 56);
            this.materi.TabIndex = 1;
            this.materi.Text = "Materi Pembelajaran";
            this.materi.UseVisualStyleBackColor = true;
            this.materi.Click += new System.EventHandler(this.materi_Click);
            // 
            // manage
            // 
            this.manage.FlatAppearance.BorderSize = 0;
            this.manage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manage.Location = new System.Drawing.Point(3, 169);
            this.manage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manage.Name = "manage";
            this.manage.Size = new System.Drawing.Size(197, 56);
            this.manage.TabIndex = 0;
            this.manage.Text = "Manajemen Pengguna";
            this.manage.UseVisualStyleBackColor = true;
            this.manage.Click += new System.EventHandler(this.manage_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1045, 100);
            this.panel2.TabIndex = 1;
            // 
            // tentang_apk1
            // 
            this.tentang_apk1.BackColor = System.Drawing.Color.PapayaWhip;
            this.tentang_apk1.Location = new System.Drawing.Point(200, 91);
            this.tentang_apk1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tentang_apk1.Name = "tentang_apk1";
            this.tentang_apk1.Size = new System.Drawing.Size(1025, 602);
            this.tentang_apk1.TabIndex = 7;
            this.tentang_apk1.Load += new System.EventHandler(this.tentang_apk1_Load);
            // 
            // materi_Pembelajaran1
            // 
            this.materi_Pembelajaran1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.materi_Pembelajaran1.Location = new System.Drawing.Point(202, 94);
            this.materi_Pembelajaran1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materi_Pembelajaran1.Name = "materi_Pembelajaran1";
            this.materi_Pembelajaran1.Size = new System.Drawing.Size(1040, 602);
            this.materi_Pembelajaran1.TabIndex = 4;
            // 
            // manajemen_pengguna1
            // 
            this.manajemen_pengguna1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.manajemen_pengguna1.Location = new System.Drawing.Point(202, 95);
            this.manajemen_pengguna1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manajemen_pengguna1.Name = "manajemen_pengguna1";
            this.manajemen_pengguna1.Size = new System.Drawing.Size(1040, 602);
            this.manajemen_pengguna1.TabIndex = 3;
            // 
            // dashboard_Admin1
            // 
            this.dashboard_Admin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dashboard_Admin1.Location = new System.Drawing.Point(200, 95);
            this.dashboard_Admin1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboard_Admin1.Name = "dashboard_Admin1";
            this.dashboard_Admin1.Size = new System.Drawing.Size(1048, 614);
            this.dashboard_Admin1.TabIndex = 2;
            // 
            // tugasAdmin1
            // 
            this.tugasAdmin1.BackColor = System.Drawing.Color.PapayaWhip;
            this.tugasAdmin1.Location = new System.Drawing.Point(200, 79);
            this.tugasAdmin1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tugasAdmin1.Name = "tugasAdmin1";
            this.tugasAdmin1.Size = new System.Drawing.Size(1025, 602);
            this.tugasAdmin1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 696);
            this.Controls.Add(this.tentang_apk1);
            this.Controls.Add(this.materi_Pembelajaran1);
            this.Controls.Add(this.manajemen_pengguna1);
            this.Controls.Add(this.dashboard_Admin1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tugasAdmin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Simba App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button informasi;
        private System.Windows.Forms.Button materi;
        private System.Windows.Forms.Button manage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button tentang;
        private Dashboard_Admin dashboard_Admin1;
        private Manajemen_pengguna manajemen_pengguna1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Materi_Pembelajaran materi_Pembelajaran1;
        //private Pengaturan_sistem pengaturan_sistem1;
        private Tentang_apk tentang_apk1;
        private System.Windows.Forms.Button button1;
        private TugasAdmin tugasAdmin1;
    }
}