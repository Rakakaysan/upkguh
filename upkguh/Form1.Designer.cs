namespace upkguh
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.bcancel = new System.Windows.Forms.Button();
            this.blogin = new System.Windows.Forms.Button();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.bcancel);
            this.panel3.Controls.Add(this.blogin);
            this.panel3.Controls.Add(this.tPassword);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tUsername);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(444, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(526, 273);
            this.panel3.TabIndex = 2;
            // 
            // bcancel
            // 
            this.bcancel.Location = new System.Drawing.Point(363, 204);
            this.bcancel.Name = "bcancel";
            this.bcancel.Size = new System.Drawing.Size(121, 50);
            this.bcancel.TabIndex = 5;
            this.bcancel.Text = "Cancel";
            this.bcancel.UseVisualStyleBackColor = true;
            this.bcancel.Click += new System.EventHandler(this.Bcancel_Click);
            // 
            // blogin
            // 
            this.blogin.Location = new System.Drawing.Point(66, 204);
            this.blogin.Name = "blogin";
            this.blogin.Size = new System.Drawing.Size(121, 50);
            this.blogin.TabIndex = 4;
            this.blogin.Text = "Login";
            this.blogin.UseVisualStyleBackColor = true;
            this.blogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(250, 143);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(234, 26);
            this.tPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(250, 60);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(234, 26);
            this.tUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 682);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bcancel;
        private System.Windows.Forms.Button blogin;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

