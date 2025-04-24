namespace upkguh
{
    partial class TugasAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DeskripsiTugas = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bcancel = new System.Windows.Forms.Button();
            this.Bdelete = new System.Windows.Forms.Button();
            this.Bsave = new System.Windows.Forms.Button();
            this.NamaTugas = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.DeskripsiTugas);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.Bcancel);
            this.panel2.Controls.Add(this.Bdelete);
            this.panel2.Controls.Add(this.Bsave);
            this.panel2.Controls.Add(this.NamaTugas);
            this.panel2.Location = new System.Drawing.Point(28, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 389);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Deskripsi Tugas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nama Tugas";
            // 
            // DeskripsiTugas
            // 
            this.DeskripsiTugas.Location = new System.Drawing.Point(34, 115);
            this.DeskripsiTugas.Name = "DeskripsiTugas";
            this.DeskripsiTugas.Size = new System.Drawing.Size(282, 96);
            this.DeskripsiTugas.TabIndex = 19;
            this.DeskripsiTugas.Text = "";
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
            this.Bcancel.Location = new System.Drawing.Point(227, 240);
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
            this.Bdelete.Location = new System.Drawing.Point(133, 240);
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
            this.Bsave.Location = new System.Drawing.Point(31, 240);
            this.Bsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bsave.Name = "Bsave";
            this.Bsave.Size = new System.Drawing.Size(84, 24);
            this.Bsave.TabIndex = 15;
            this.Bsave.Text = "Save";
            this.Bsave.UseVisualStyleBackColor = false;
            this.Bsave.Click += new System.EventHandler(this.Bsave_Click);
            // 
            // NamaTugas
            // 
            this.NamaTugas.Location = new System.Drawing.Point(37, 55);
            this.NamaTugas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NamaTugas.Name = "NamaTugas";
            this.NamaTugas.Size = new System.Drawing.Size(279, 22);
            this.NamaTugas.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(33, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(263, 31);
            this.label14.TabIndex = 8;
            this.label14.Text = "Tugas Pembelajaran";
            // 
            // TugasAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label14);
            this.Name = "TugasAdmin";
            this.Size = new System.Drawing.Size(911, 482);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox DeskripsiTugas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bcancel;
        private System.Windows.Forms.Button Bdelete;
        private System.Windows.Forms.Button Bsave;
        private System.Windows.Forms.TextBox NamaTugas;
        private System.Windows.Forms.Label label14;
    }
}
