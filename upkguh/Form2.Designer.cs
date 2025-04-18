namespace upkguh
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tentang = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.setting = new System.Windows.Forms.Button();
            this.informasi = new System.Windows.Forms.Button();
            this.materi = new System.Windows.Forms.Button();
            this.manage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.manajemen_pengguna1 = new upkguh.Manajemen_pengguna();
            this.dashboard_Admin1 = new upkguh.Dashboard_Admin();
            this.materi_Pembelajaran1 = new upkguh.Materi_Pembelajaran();
            this.informasi_Pengguna1 = new upkguh.Informasi_Pengguna();
            this.pengaturan_sistem1 = new upkguh.Pengaturan_sistem();
            this.tentang_apk1 = new upkguh.Tentang_apk();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tentang);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.setting);
            this.panel1.Controls.Add(this.informasi);
            this.panel1.Controls.Add(this.materi);
            this.panel1.Controls.Add(this.manage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 696);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
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
            this.tentang.Location = new System.Drawing.Point(-3, 451);
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
            this.logout.Location = new System.Drawing.Point(0, 579);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(197, 56);
            this.logout.TabIndex = 3;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // setting
            // 
            this.setting.FlatAppearance.BorderSize = 0;
            this.setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting.Location = new System.Drawing.Point(0, 377);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(197, 56);
            this.setting.TabIndex = 2;
            this.setting.Text = "Pengaturan sistem";
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // informasi
            // 
            this.informasi.FlatAppearance.BorderSize = 0;
            this.informasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informasi.Location = new System.Drawing.Point(0, 302);
            this.informasi.Name = "informasi";
            this.informasi.Size = new System.Drawing.Size(197, 56);
            this.informasi.TabIndex = 2;
            this.informasi.Text = "Informasi pengguna";
            this.informasi.UseVisualStyleBackColor = true;
            this.informasi.Click += new System.EventHandler(this.informasi_Click);
            // 
            // materi
            // 
            this.materi.FlatAppearance.BorderSize = 0;
            this.materi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materi.Location = new System.Drawing.Point(0, 226);
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
            this.manage.Location = new System.Drawing.Point(0, 148);
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1045, 100);
            this.panel2.TabIndex = 1;
            // 
            // manajemen_pengguna1
            // 
            this.manajemen_pengguna1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.manajemen_pengguna1.Location = new System.Drawing.Point(203, 95);
            this.manajemen_pengguna1.Name = "manajemen_pengguna1";
            this.manajemen_pengguna1.Size = new System.Drawing.Size(1039, 602);
            this.manajemen_pengguna1.TabIndex = 3;
            // 
            // dashboard_Admin1
            // 
            this.dashboard_Admin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dashboard_Admin1.Location = new System.Drawing.Point(200, 95);
            this.dashboard_Admin1.Name = "dashboard_Admin1";
            this.dashboard_Admin1.Size = new System.Drawing.Size(1049, 614);
            this.dashboard_Admin1.TabIndex = 2;
            // 
            // materi_Pembelajaran1
            // 
            this.materi_Pembelajaran1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.materi_Pembelajaran1.Location = new System.Drawing.Point(203, 94);
            this.materi_Pembelajaran1.Name = "materi_Pembelajaran1";
            this.materi_Pembelajaran1.Size = new System.Drawing.Size(1039, 602);
            this.materi_Pembelajaran1.TabIndex = 4;
            // 
            // informasi_Pengguna1
            // 
            this.informasi_Pengguna1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.informasi_Pengguna1.Location = new System.Drawing.Point(206, 94);
            this.informasi_Pengguna1.Name = "informasi_Pengguna1";
            this.informasi_Pengguna1.Size = new System.Drawing.Size(1036, 602);
            this.informasi_Pengguna1.TabIndex = 5;
            // 
            // pengaturan_sistem1
            // 
            this.pengaturan_sistem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pengaturan_sistem1.Location = new System.Drawing.Point(200, 95);
            this.pengaturan_sistem1.Name = "pengaturan_sistem1";
            this.pengaturan_sistem1.Size = new System.Drawing.Size(1042, 602);
            this.pengaturan_sistem1.TabIndex = 6;
            // 
            // tentang_apk1
            // 
            this.tentang_apk1.BackColor = System.Drawing.Color.PapayaWhip;
            this.tentang_apk1.Location = new System.Drawing.Point(200, 91);
            this.tentang_apk1.Name = "tentang_apk1";
            this.tentang_apk1.Size = new System.Drawing.Size(1025, 602);
            this.tentang_apk1.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 696);
            this.Controls.Add(this.tentang_apk1);
            this.Controls.Add(this.pengaturan_sistem1);
            this.Controls.Add(this.informasi_Pengguna1);
            this.Controls.Add(this.materi_Pembelajaran1);
            this.Controls.Add(this.manajemen_pengguna1);
            this.Controls.Add(this.dashboard_Admin1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button setting;
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
        private Informasi_Pengguna informasi_Pengguna1;
        private Pengaturan_sistem pengaturan_sistem1;
        private Tentang_apk tentang_apk1;
    }
}