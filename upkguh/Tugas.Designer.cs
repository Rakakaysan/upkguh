namespace upkguh
{
    partial class Tugas
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeskripsiTugas = new System.Windows.Forms.Label();
            this.NamaTugas = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NamaMateri = new System.Windows.Forms.TextBox();
            this.KontenMateri = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bsave = new System.Windows.Forms.Button();
            this.Bdelete = new System.Windows.Forms.Button();
            this.Bcancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Daftar Tugas \r\nSiswa";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(573, 17);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 23);
            this.dateLabel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.DeskripsiTugas);
            this.panel1.Controls.Add(this.NamaTugas);
            this.panel1.Location = new System.Drawing.Point(577, 373);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 132);
            this.panel1.TabIndex = 2;
            // 
            // DeskripsiTugas
            // 
            this.DeskripsiTugas.AutoSize = true;
            this.DeskripsiTugas.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskripsiTugas.Location = new System.Drawing.Point(6, 38);
            this.DeskripsiTugas.Name = "DeskripsiTugas";
            this.DeskripsiTugas.Size = new System.Drawing.Size(311, 21);
            this.DeskripsiTugas.TabIndex = 5;
            this.DeskripsiTugas.Text = "Pilih tugas untuk melihat informasi disini";
            // 
            // NamaTugas
            // 
            this.NamaTugas.AutoSize = true;
            this.NamaTugas.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaTugas.Location = new System.Drawing.Point(6, 11);
            this.NamaTugas.Name = "NamaTugas";
            this.NamaTugas.Size = new System.Drawing.Size(89, 19);
            this.NamaTugas.TabIndex = 4;
            this.NamaTugas.Text = "Pilih Tugas";
            this.NamaTugas.Click += new System.EventHandler(this.NamaTugas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(577, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(436, 259);
            this.dataGridView1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(577, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 26);
            this.textBox1.TabIndex = 20;
            // 
            // NamaMateri
            // 
            this.NamaMateri.Location = new System.Drawing.Point(42, 178);
            this.NamaMateri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NamaMateri.Name = "NamaMateri";
            this.NamaMateri.Size = new System.Drawing.Size(313, 26);
            this.NamaMateri.TabIndex = 8;
            // 
            // KontenMateri
            // 
            this.KontenMateri.Location = new System.Drawing.Point(42, 254);
            this.KontenMateri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KontenMateri.Name = "KontenMateri";
            this.KontenMateri.Size = new System.Drawing.Size(317, 119);
            this.KontenMateri.TabIndex = 22;
            this.KontenMateri.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nama Tugas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Deskripsi Tugas";
            // 
            // Bsave
            // 
            this.Bsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bsave.Location = new System.Drawing.Point(42, 407);
            this.Bsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bsave.Name = "Bsave";
            this.Bsave.Size = new System.Drawing.Size(94, 30);
            this.Bsave.TabIndex = 25;
            this.Bsave.Text = "Save";
            this.Bsave.UseVisualStyleBackColor = false;
            this.Bsave.Click += new System.EventHandler(this.Bsave_Click);
            // 
            // Bdelete
            // 
            this.Bdelete.Location = new System.Drawing.Point(142, 407);
            this.Bdelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bdelete.Name = "Bdelete";
            this.Bdelete.Size = new System.Drawing.Size(84, 30);
            this.Bdelete.TabIndex = 26;
            this.Bdelete.Text = "Delete";
            this.Bdelete.UseVisualStyleBackColor = true;
            // 
            // Bcancel
            // 
            this.Bcancel.Location = new System.Drawing.Point(232, 407);
            this.Bcancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bcancel.Name = "Bcancel";
            this.Bcancel.Size = new System.Drawing.Size(84, 30);
            this.Bcancel.TabIndex = 27;
            this.Bcancel.Text = "Cancel";
            this.Bcancel.UseVisualStyleBackColor = true;
            // 
            // Tugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.Bcancel);
            this.Controls.Add(this.Bdelete);
            this.Controls.Add(this.Bsave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.KontenMateri);
            this.Controls.Add(this.NamaMateri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tugas";
            this.Size = new System.Drawing.Size(1025, 602);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DeskripsiTugas;
        private System.Windows.Forms.Label NamaTugas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox NamaMateri;
        private System.Windows.Forms.RichTextBox KontenMateri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bsave;
        private System.Windows.Forms.Button Bdelete;
        private System.Windows.Forms.Button Bcancel;
    }
}
