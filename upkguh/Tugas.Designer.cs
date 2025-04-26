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
            this.StatusTugasLabel = new System.Windows.Forms.Label();
            this.NamaTugas = new System.Windows.Forms.Label();
            this.listTugasDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.KumpulkanButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.JawabanTugasInput = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.KontenTugas = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listTugasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Daftar Tugas \r\nSiswa";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(137, 66);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(180, 21);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "<Tanggal Sekarang>";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.StatusTugasLabel);
            this.panel1.Controls.Add(this.NamaTugas);
            this.panel1.Location = new System.Drawing.Point(499, 303);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 106);
            this.panel1.TabIndex = 2;
            // 
            // StatusTugasLabel
            // 
            this.StatusTugasLabel.AutoSize = true;
            this.StatusTugasLabel.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTugasLabel.Location = new System.Drawing.Point(4, 40);
            this.StatusTugasLabel.Name = "StatusTugasLabel";
            this.StatusTugasLabel.Size = new System.Drawing.Size(96, 19);
            this.StatusTugasLabel.TabIndex = 6;
            this.StatusTugasLabel.Text = "Status Tugas:";
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
            // 
            // listTugasDataGridView
            // 
            this.listTugasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTugasDataGridView.Location = new System.Drawing.Point(499, 66);
            this.listTugasDataGridView.Name = "listTugasDataGridView";
            this.listTugasDataGridView.RowHeadersWidth = 51;
            this.listTugasDataGridView.RowTemplate.Height = 24;
            this.listTugasDataGridView.Size = new System.Drawing.Size(388, 207);
            this.listTugasDataGridView.TabIndex = 19;
            this.listTugasDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Search";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(499, 41);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(168, 22);
            this.search.TabIndex = 20;
            this.search.Click += new System.EventHandler(this.search_TextChanged);
            // 
            // KumpulkanButton
            // 
            this.KumpulkanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.KumpulkanButton.Location = new System.Drawing.Point(37, 417);
            this.KumpulkanButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KumpulkanButton.Name = "KumpulkanButton";
            this.KumpulkanButton.Size = new System.Drawing.Size(127, 24);
            this.KumpulkanButton.TabIndex = 25;
            this.KumpulkanButton.Text = "Kumpulkan";
            this.KumpulkanButton.UseVisualStyleBackColor = false;
            this.KumpulkanButton.Click += new System.EventHandler(this.KumpulkanButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Jawaban Tugas";
            // 
            // JawabanTugasInput
            // 
            this.JawabanTugasInput.Location = new System.Drawing.Point(37, 282);
            this.JawabanTugasInput.Name = "JawabanTugasInput";
            this.JawabanTugasInput.Size = new System.Drawing.Size(432, 122);
            this.JawabanTugasInput.TabIndex = 26;
            this.JawabanTugasInput.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Konten Tugas";
            // 
            // KontenTugas
            // 
            this.KontenTugas.Location = new System.Drawing.Point(37, 132);
            this.KontenTugas.Name = "KontenTugas";
            this.KontenTugas.ReadOnly = true;
            this.KontenTugas.Size = new System.Drawing.Size(432, 111);
            this.KontenTugas.TabIndex = 22;
            this.KontenTugas.Text = "";
            // 
            // Tugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.JawabanTugasInput);
            this.Controls.Add(this.KumpulkanButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KontenTugas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.listTugasDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tugas";
            this.Size = new System.Drawing.Size(911, 482);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listTugasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.DataGridView listTugasDataGridView;
        private System.Windows.Forms.Label NamaTugas;
        private System.Windows.Forms.Button KumpulkanButton;
        private System.Windows.Forms.Label StatusTugasLabel;
        private System.Windows.Forms.RichTextBox JawabanTugasInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox KontenTugas;
    }
}
