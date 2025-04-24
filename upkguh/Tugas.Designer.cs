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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Daftar Tugas \r\nSiswa";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(33, 127);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 21);
            this.dateLabel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.DeskripsiTugas);
            this.panel1.Controls.Add(this.NamaTugas);
            this.panel1.Location = new System.Drawing.Point(37, 349);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 106);
            this.panel1.TabIndex = 2;
            // 
            // DeskripsiTugas
            // 
            this.DeskripsiTugas.AutoSize = true;
            this.DeskripsiTugas.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskripsiTugas.Location = new System.Drawing.Point(5, 30);
            this.DeskripsiTugas.Name = "DeskripsiTugas";
            this.DeskripsiTugas.Size = new System.Drawing.Size(277, 19);
            this.DeskripsiTugas.TabIndex = 5;
            this.DeskripsiTugas.Text = "Pilih tugas untuk melihat informasi disini";
            // 
            // NamaTugas
            // 
            this.NamaTugas.AutoSize = true;
            this.NamaTugas.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaTugas.Location = new System.Drawing.Point(5, 9);
            this.NamaTugas.Name = "NamaTugas";
            this.NamaTugas.Size = new System.Drawing.Size(78, 17);
            this.NamaTugas.TabIndex = 4;
            this.NamaTugas.Text = "Pilih Tugas";
            this.NamaTugas.Click += new System.EventHandler(this.NamaTugas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(388, 148);
            this.dataGridView1.TabIndex = 19;
            // 
            // Tugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tugas";
            this.Size = new System.Drawing.Size(911, 482);
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
    }
}
