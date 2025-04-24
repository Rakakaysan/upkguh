namespace upkguh
{
    partial class Manajemen_pengguna
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.Bcancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bdelete = new System.Windows.Forms.Button();
            this.Bsave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.jabatan = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.TextBox();
            this.nip_input = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.Bcancel);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.Bdelete);
            this.panel2.Controls.Add(this.Bsave);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.jabatan);
            this.panel2.Controls.Add(this.username);
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.status);
            this.panel2.Controls.Add(this.nip_input);
            this.panel2.Controls.Add(this.nama);
            this.panel2.Location = new System.Drawing.Point(18, 61);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 408);
            this.panel2.TabIndex = 0;
            // 
            // Bcancel
            // 
            this.Bcancel.Location = new System.Drawing.Point(267, 273);
            this.Bcancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bcancel.Name = "Bcancel";
            this.Bcancel.Size = new System.Drawing.Size(75, 24);
            this.Bcancel.TabIndex = 14;
            this.Bcancel.Text = "Cancel";
            this.Bcancel.UseVisualStyleBackColor = true;
            this.Bcancel.Click += new System.EventHandler(this.Bcancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(405, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(455, 346);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Bdelete
            // 
            this.Bdelete.Location = new System.Drawing.Point(173, 273);
            this.Bdelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bdelete.Name = "Bdelete";
            this.Bdelete.Size = new System.Drawing.Size(75, 24);
            this.Bdelete.TabIndex = 11;
            this.Bdelete.Text = "Delete";
            this.Bdelete.UseVisualStyleBackColor = true;
            this.Bdelete.Click += new System.EventHandler(this.Bdelete_Click);
            // 
            // Bsave
            // 
            this.Bsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bsave.Location = new System.Drawing.Point(71, 273);
            this.Bsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bsave.Name = "Bsave";
            this.Bsave.Size = new System.Drawing.Size(84, 24);
            this.Bsave.TabIndex = 10;
            this.Bsave.Text = "Save";
            this.Bsave.UseVisualStyleBackColor = false;
            this.Bsave.Click += new System.EventHandler(this.Bsave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(219, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Jabatan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "NIP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nama Lengkap";
            // 
            // jabatan
            // 
            this.jabatan.Location = new System.Drawing.Point(212, 154);
            this.jabatan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jabatan.Name = "jabatan";
            this.jabatan.Size = new System.Drawing.Size(168, 22);
            this.jabatan.TabIndex = 5;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(24, 154);
            this.username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(168, 22);
            this.username.TabIndex = 4;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(24, 216);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(168, 22);
            this.password.TabIndex = 3;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(212, 216);
            this.status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(168, 22);
            this.status.TabIndex = 2;
            // 
            // nip_input
            // 
            this.nip_input.Location = new System.Drawing.Point(212, 86);
            this.nip_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nip_input.Name = "nip_input";
            this.nip_input.Size = new System.Drawing.Size(168, 22);
            this.nip_input.TabIndex = 1;
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(24, 86);
            this.nama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(168, 22);
            this.nama.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(284, 31);
            this.label14.TabIndex = 2;
            this.label14.Text = "Manajemen Pengguna";
            // 
            // Manajemen_pengguna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Manajemen_pengguna";
            this.Size = new System.Drawing.Size(911, 482);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox jabatan;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.TextBox nip_input;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Bdelete;
        private System.Windows.Forms.Button Bsave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bcancel;
    }
}
