namespace upkguh
{
    partial class Materi_Pembelajaran
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
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.KontenMateri = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bcancel = new System.Windows.Forms.Button();
            this.Bdelete = new System.Windows.Forms.Button();
            this.Bsave = new System.Windows.Forms.Button();
            this.URLYouTubeMateri = new System.Windows.Forms.TextBox();
            this.NamaMateri = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(36, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(262, 31);
            this.label14.TabIndex = 6;
            this.label14.Text = "Materi Pembelajaran";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.KontenMateri);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.Bcancel);
            this.panel2.Controls.Add(this.Bdelete);
            this.panel2.Controls.Add(this.Bsave);
            this.panel2.Controls.Add(this.URLYouTubeMateri);
            this.panel2.Controls.Add(this.NamaMateri);
            this.panel2.Location = new System.Drawing.Point(31, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 389);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "URL YouTube Materi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Konten Materi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nama Materi";
            // 
            // KontenMateri
            // 
            this.KontenMateri.Location = new System.Drawing.Point(34, 115);
            this.KontenMateri.Name = "KontenMateri";
            this.KontenMateri.Size = new System.Drawing.Size(282, 96);
            this.KontenMateri.TabIndex = 19;
            this.KontenMateri.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(370, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(460, 317);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Bcancel
            // 
            this.Bcancel.Location = new System.Drawing.Point(227, 304);
            this.Bcancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bcancel.Name = "Bcancel";
            this.Bcancel.Size = new System.Drawing.Size(75, 24);
            this.Bcancel.TabIndex = 17;
            this.Bcancel.Text = "Cancel";
            this.Bcancel.UseVisualStyleBackColor = true;
            this.Bcancel.Click += new System.EventHandler(this.Bcancel_Click);
            // 
            // Bdelete
            // 
            this.Bdelete.Location = new System.Drawing.Point(133, 304);
            this.Bdelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bdelete.Name = "Bdelete";
            this.Bdelete.Size = new System.Drawing.Size(75, 24);
            this.Bdelete.TabIndex = 16;
            this.Bdelete.Text = "Delete";
            this.Bdelete.UseVisualStyleBackColor = true;
            this.Bdelete.Click += new System.EventHandler(this.Bdelete_Click);
            // 
            // Bsave
            // 
            this.Bsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bsave.Location = new System.Drawing.Point(31, 304);
            this.Bsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bsave.Name = "Bsave";
            this.Bsave.Size = new System.Drawing.Size(84, 24);
            this.Bsave.TabIndex = 15;
            this.Bsave.Text = "Save";
            this.Bsave.UseVisualStyleBackColor = false;
            this.Bsave.Click += new System.EventHandler(this.Bsave_Click);
            // 
            // URLYouTubeMateri
            // 
            this.URLYouTubeMateri.Location = new System.Drawing.Point(37, 254);
            this.URLYouTubeMateri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.URLYouTubeMateri.Name = "URLYouTubeMateri";
            this.URLYouTubeMateri.Size = new System.Drawing.Size(279, 22);
            this.URLYouTubeMateri.TabIndex = 10;
            // 
            // NamaMateri
            // 
            this.NamaMateri.Location = new System.Drawing.Point(37, 55);
            this.NamaMateri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NamaMateri.Name = "NamaMateri";
            this.NamaMateri.Size = new System.Drawing.Size(279, 22);
            this.NamaMateri.TabIndex = 7;
            // 
            // Materi_Pembelajaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label14);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Materi_Pembelajaran";
            this.Size = new System.Drawing.Size(911, 482);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox URLYouTubeMateri;
        private System.Windows.Forms.TextBox NamaMateri;
        private System.Windows.Forms.Button Bcancel;
        private System.Windows.Forms.Button Bdelete;
        private System.Windows.Forms.Button Bsave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox KontenMateri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}
