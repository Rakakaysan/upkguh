namespace upkguh
{
    partial class Materi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MateriKontenText = new System.Windows.Forms.RichTextBox();
            this.YouTubeVideoPlayer = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "MATERI PEMBELAJARAN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(472, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(410, 386);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MateriKontenText
            // 
            this.MateriKontenText.Location = new System.Drawing.Point(23, 267);
            this.MateriKontenText.Name = "MateriKontenText";
            this.MateriKontenText.Size = new System.Drawing.Size(398, 193);
            this.MateriKontenText.TabIndex = 2;
            this.MateriKontenText.Text = "";
            // 
            // YouTubeVideoPlayer
            // 
            this.YouTubeVideoPlayer.Location = new System.Drawing.Point(23, 65);
            this.YouTubeVideoPlayer.MinimumSize = new System.Drawing.Size(20, 20);
            this.YouTubeVideoPlayer.Name = "YouTubeVideoPlayer";
            this.YouTubeVideoPlayer.Size = new System.Drawing.Size(398, 187);
            this.YouTubeVideoPlayer.TabIndex = 3;
            // 
            // Materi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.YouTubeVideoPlayer);
            this.Controls.Add(this.MateriKontenText);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Materi";
            this.Size = new System.Drawing.Size(911, 482);
            this.Load += new System.EventHandler(this.Materi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox MateriKontenText;
        private System.Windows.Forms.WebBrowser YouTubeVideoPlayer;
    }
}
