namespace upkguh
{
    partial class PengumpulanTugas
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NilaiTugas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.JawabanTugasReadOnly = new System.Windows.Forms.RichTextBox();
            this.NamaTugasSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KontenMateriReadOnly = new System.Windows.Forms.RichTextBox();
            this.listPengumpulanDataGrid = new System.Windows.Forms.DataGridView();
            this.Bcancel = new System.Windows.Forms.Button();
            this.Bdelete = new System.Windows.Forms.Button();
            this.Bsave = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NilaiTugas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPengumpulanDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(48, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nama Tugas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.NilaiTugas);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.JawabanTugasReadOnly);
            this.panel2.Controls.Add(this.NamaTugasSelect);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.KontenMateriReadOnly);
            this.panel2.Controls.Add(this.listPengumpulanDataGrid);
            this.panel2.Controls.Add(this.Bcancel);
            this.panel2.Controls.Add(this.Bdelete);
            this.panel2.Controls.Add(this.Bsave);
            this.panel2.Location = new System.Drawing.Point(28, 53);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 416);
            this.panel2.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Penilaian Tugas";
            // 
            // NilaiTugas
            // 
            this.NilaiTugas.Location = new System.Drawing.Point(37, 317);
            this.NilaiTugas.Name = "NilaiTugas";
            this.NilaiTugas.Size = new System.Drawing.Size(120, 22);
            this.NilaiTugas.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Jawaban Tugas";
            // 
            // JawabanTugasReadOnly
            // 
            this.JawabanTugasReadOnly.Location = new System.Drawing.Point(37, 182);
            this.JawabanTugasReadOnly.Name = "JawabanTugasReadOnly";
            this.JawabanTugasReadOnly.ReadOnly = true;
            this.JawabanTugasReadOnly.Size = new System.Drawing.Size(282, 104);
            this.JawabanTugasReadOnly.TabIndex = 26;
            this.JawabanTugasReadOnly.Text = "";
            // 
            // NamaTugasSelect
            // 
            this.NamaTugasSelect.FormattingEnabled = true;
            this.NamaTugasSelect.Location = new System.Drawing.Point(37, 34);
            this.NamaTugasSelect.Name = "NamaTugasSelect";
            this.NamaTugasSelect.Size = new System.Drawing.Size(279, 24);
            this.NamaTugasSelect.TabIndex = 25;
            this.NamaTugasSelect.SelectedIndexChanged += new System.EventHandler(this.NamaTugasSelect_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Search";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(381, 33);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(168, 22);
            this.search.TabIndex = 23;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Konten Tugas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nama Tugas";
            // 
            // KontenMateriReadOnly
            // 
            this.KontenMateriReadOnly.Location = new System.Drawing.Point(34, 90);
            this.KontenMateriReadOnly.Name = "KontenMateriReadOnly";
            this.KontenMateriReadOnly.ReadOnly = true;
            this.KontenMateriReadOnly.Size = new System.Drawing.Size(282, 64);
            this.KontenMateriReadOnly.TabIndex = 19;
            this.KontenMateriReadOnly.Text = "";
            // 
            // listPengumpulanDataGrid
            // 
            this.listPengumpulanDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPengumpulanDataGrid.Location = new System.Drawing.Point(381, 58);
            this.listPengumpulanDataGrid.Name = "listPengumpulanDataGrid";
            this.listPengumpulanDataGrid.RowHeadersWidth = 51;
            this.listPengumpulanDataGrid.RowTemplate.Height = 24;
            this.listPengumpulanDataGrid.Size = new System.Drawing.Size(460, 317);
            this.listPengumpulanDataGrid.TabIndex = 18;
            this.listPengumpulanDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listPengumpulanDataGrid_CellClick);
            // 
            // Bcancel
            // 
            this.Bcancel.Location = new System.Drawing.Point(230, 351);
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
            this.Bdelete.Location = new System.Drawing.Point(136, 351);
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
            this.Bsave.Location = new System.Drawing.Point(34, 351);
            this.Bsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bsave.Name = "Bsave";
            this.Bsave.Size = new System.Drawing.Size(84, 24);
            this.Bsave.TabIndex = 15;
            this.Bsave.Text = "Save";
            this.Bsave.UseVisualStyleBackColor = false;
            this.Bsave.Click += new System.EventHandler(this.Bsave_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(263, 31);
            this.label14.TabIndex = 25;
            this.label14.Text = "Pengumpulan Tugas";
            // 
            // PengumpulanTugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Name = "PengumpulanTugas";
            this.Size = new System.Drawing.Size(911, 482);
            this.Load += new System.EventHandler(this.PengumpulanTugas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NilaiTugas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPengumpulanDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NamaTugasSelect;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.RichTextBox KontenMateriReadOnly;
        private System.Windows.Forms.DataGridView listPengumpulanDataGrid;
        private System.Windows.Forms.Button Bcancel;
        private System.Windows.Forms.Button Bdelete;
        private System.Windows.Forms.Button Bsave;
        private System.Windows.Forms.RichTextBox JawabanTugasReadOnly;
        private System.Windows.Forms.NumericUpDown NilaiTugas;
    }
}
