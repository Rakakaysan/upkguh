namespace upkguh
{
    partial class siswa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(siswa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Button();
            this.tentang = new System.Windows.Forms.Button();
            this.tugas = new System.Windows.Forms.Button();
            this.materi = new System.Windows.Forms.Button();
            this.Kompetensi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.materi1 = new upkguh.Materi();
            this.dashboardsiswa1 = new upkguh.DashboardSiswa();
            this.jenis_jenis2 = new upkguh.Jenis_jenis();
            this.tentang_apk1 = new upkguh.Tentang_apk();
            this.tugas1 = new upkguh.Tugas();
            this.kompetisi1 = new upkguh.kompetisi();
            this.ciriCiri1 = new upkguh.CiriCiri();
            this.pengertian1 = new upkguh.pengertian();
            this.fungsi1 = new upkguh.Fungsi();
            this.contoh1 = new upkguh.Contoh();
            this.jenis_jenis1 = new upkguh.Jenis_jenis();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.tentang);
            this.panel1.Controls.Add(this.tugas);
            this.panel1.Controls.Add(this.materi);
            this.panel1.Controls.Add(this.Kompetensi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 597);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(11, 10);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(162, 105);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // logout
            // 
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Location = new System.Drawing.Point(0, 463);
            this.logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(178, 45);
            this.logout.TabIndex = 3;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // tentang
            // 
            this.tentang.FlatAppearance.BorderSize = 0;
            this.tentang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tentang.Location = new System.Drawing.Point(0, 322);
            this.tentang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tentang.Name = "tentang";
            this.tentang.Size = new System.Drawing.Size(178, 45);
            this.tentang.TabIndex = 2;
            this.tentang.Text = " Tentang Aplikasi Dan Pengembang";
            this.tentang.UseVisualStyleBackColor = true;
            this.tentang.Click += new System.EventHandler(this.tentang_Click);
            // 
            // tugas
            // 
            this.tugas.FlatAppearance.BorderSize = 0;
            this.tugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tugas.Location = new System.Drawing.Point(0, 257);
            this.tugas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tugas.Name = "tugas";
            this.tugas.Size = new System.Drawing.Size(178, 45);
            this.tugas.TabIndex = 2;
            this.tugas.Text = "Tugas";
            this.tugas.UseVisualStyleBackColor = true;
            this.tugas.Click += new System.EventHandler(this.tugas_Click);
            // 
            // materi
            // 
            this.materi.FlatAppearance.BorderSize = 0;
            this.materi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materi.Location = new System.Drawing.Point(0, 192);
            this.materi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materi.Name = "materi";
            this.materi.Size = new System.Drawing.Size(178, 45);
            this.materi.TabIndex = 1;
            this.materi.Text = "Materi";
            this.materi.UseVisualStyleBackColor = true;
            this.materi.Click += new System.EventHandler(this.materi_Click);
            // 
            // Kompetensi
            // 
            this.Kompetensi.FlatAppearance.BorderSize = 0;
            this.Kompetensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kompetensi.Location = new System.Drawing.Point(0, 129);
            this.Kompetensi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kompetensi.Name = "Kompetensi";
            this.Kompetensi.Size = new System.Drawing.Size(178, 45);
            this.Kompetensi.TabIndex = 0;
            this.Kompetensi.Text = "Kompetensi Dan Tujuan";
            this.Kompetensi.UseVisualStyleBackColor = false;
            this.Kompetensi.Click += new System.EventHandler(this.Kompetensi_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.refreshBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(178, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 80);
            this.panel2.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // materi1
            // 
            this.materi1.BackColor = System.Drawing.Color.PapayaWhip;
            this.materi1.Location = new System.Drawing.Point(179, 79);
            this.materi1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materi1.Name = "materi1";
            this.materi1.Size = new System.Drawing.Size(963, 518);
            this.materi1.TabIndex = 14;
            // 
            // dashboardsiswa1
            // 
            this.dashboardsiswa1.Location = new System.Drawing.Point(178, 79);
            this.dashboardsiswa1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardsiswa1.Name = "dashboardsiswa1";
            this.dashboardsiswa1.Size = new System.Drawing.Size(955, 545);
            this.dashboardsiswa1.TabIndex = 13;
            // 
            // jenis_jenis2
            // 
            this.jenis_jenis2.Location = new System.Drawing.Point(178, 79);
            this.jenis_jenis2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jenis_jenis2.Name = "jenis_jenis2";
            this.jenis_jenis2.Size = new System.Drawing.Size(964, 518);
            this.jenis_jenis2.TabIndex = 12;
            // 
            // tentang_apk1
            // 
            this.tentang_apk1.BackColor = System.Drawing.Color.PapayaWhip;
            this.tentang_apk1.Location = new System.Drawing.Point(178, 79);
            this.tentang_apk1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tentang_apk1.Name = "tentang_apk1";
            this.tentang_apk1.Size = new System.Drawing.Size(911, 482);
            this.tentang_apk1.TabIndex = 11;
            // 
            // tugas1
            // 
            this.tugas1.BackColor = System.Drawing.Color.PapayaWhip;
            this.tugas1.Location = new System.Drawing.Point(178, 79);
            this.tugas1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tugas1.Name = "tugas1";
            this.tugas1.Size = new System.Drawing.Size(911, 482);
            this.tugas1.TabIndex = 10;
            // 
            // kompetisi1
            // 
            this.kompetisi1.BackColor = System.Drawing.Color.PapayaWhip;
            this.kompetisi1.Location = new System.Drawing.Point(178, 79);
            this.kompetisi1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kompetisi1.Name = "kompetisi1";
            this.kompetisi1.Size = new System.Drawing.Size(1024, 518);
            this.kompetisi1.TabIndex = 8;
            // 
            // ciriCiri1
            // 
            this.ciriCiri1.Location = new System.Drawing.Point(180, 85);
            this.ciriCiri1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ciriCiri1.Name = "ciriCiri1";
            this.ciriCiri1.Size = new System.Drawing.Size(1021, 512);
            this.ciriCiri1.TabIndex = 7;
            // 
            // pengertian1
            // 
            this.pengertian1.BackColor = System.Drawing.Color.PapayaWhip;
            this.pengertian1.Location = new System.Drawing.Point(180, 85);
            this.pengertian1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pengertian1.Name = "pengertian1";
            this.pengertian1.Size = new System.Drawing.Size(1024, 512);
            this.pengertian1.TabIndex = 6;
            // 
            // fungsi1
            // 
            this.fungsi1.Location = new System.Drawing.Point(180, 85);
            this.fungsi1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fungsi1.Name = "fungsi1";
            this.fungsi1.Size = new System.Drawing.Size(911, 482);
            this.fungsi1.TabIndex = 5;
            // 
            // contoh1
            // 
            this.contoh1.Location = new System.Drawing.Point(178, 85);
            this.contoh1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contoh1.Name = "contoh1";
            this.contoh1.Size = new System.Drawing.Size(964, 533);
            this.contoh1.TabIndex = 4;
            // 
            // jenis_jenis1
            // 
            this.jenis_jenis1.Location = new System.Drawing.Point(178, 85);
            this.jenis_jenis1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jenis_jenis1.Name = "jenis_jenis1";
            this.jenis_jenis1.Size = new System.Drawing.Size(911, 482);
            this.jenis_jenis1.TabIndex = 3;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(35, 22);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(192, 34);
            this.refreshBtn.TabIndex = 15;
            this.refreshBtn.Text = "Refresh Data";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // siswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 597);
            this.Controls.Add(this.materi1);
            this.Controls.Add(this.dashboardsiswa1);
            this.Controls.Add(this.jenis_jenis2);
            this.Controls.Add(this.tentang_apk1);
            this.Controls.Add(this.tugas1);
            this.Controls.Add(this.kompetisi1);
            this.Controls.Add(this.ciriCiri1);
            this.Controls.Add(this.pengertian1);
            this.Controls.Add(this.fungsi1);
            this.Controls.Add(this.contoh1);
            this.Controls.Add(this.jenis_jenis1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "siswa";
            this.Text = "Simba App Siswa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.siswa_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.siswa_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button tentang;
        private System.Windows.Forms.Button tugas;
        private System.Windows.Forms.Button materi;
        private System.Windows.Forms.Button Kompetensi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Jenis_jenis jenis_jenis1;
        private Contoh contoh1;
        private Fungsi fungsi1;
        private pengertian pengertian1;
        private CiriCiri ciriCiri1;
        private kompetisi kompetisi1;
        private Tugas tugas1;
        private Tentang_apk tentang_apk1;
        private Jenis_jenis jenis_jenis2;
        private DashboardSiswa dashboardsiswa1;
        private Materi materi1;
        private System.Windows.Forms.Button refreshBtn;
    }
}