namespace Paint
{
    partial class FrmAboutPaint
    {
        private System.ComponentModel.IContainer components = null; // required designer variable

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        } // end method Dispose

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAboutPaint));
            this.BtnClose = new System.Windows.Forms.Button();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.LblProduct = new System.Windows.Forms.Label();
            this.LblVersion = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(407, -2);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(60, 44);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.TabStop = false;
            this.BtnClose.Text = "×";
            this.BtnClose.UseVisualStyleBackColor = false;
            // 
            // PicLogo
            // 
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicLogo.BackgroundImage")));
            this.PicLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicLogo.Location = new System.Drawing.Point(49, 55);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(150, 150);
            this.PicLogo.TabIndex = 1;
            this.PicLogo.TabStop = false;
            // 
            // LblProduct
            // 
            this.LblProduct.AutoSize = true;
            this.LblProduct.BackColor = System.Drawing.Color.Transparent;
            this.LblProduct.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProduct.Location = new System.Drawing.Point(205, 81);
            this.LblProduct.Name = "LblProduct";
            this.LblProduct.Size = new System.Drawing.Size(219, 90);
            this.LblProduct.TabIndex = 0;
            this.LblProduct.Text = "Paint";
            // 
            // LblVersion
            // 
            this.LblVersion.AutoSize = true;
            this.LblVersion.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVersion.Location = new System.Drawing.Point(214, 171);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(197, 34);
            this.LblVersion.TabIndex = 0;
            this.LblVersion.Text = "Version 1.0.0.0";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(65, 235);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(333, 44);
            this.LblEmail.TabIndex = 0;
            this.LblEmail.Text = "If you encounter any problems,\r\nplease send an email to: tomzjc@qq.com";
            this.LblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCopyright
            // 
            this.LblCopyright.AutoSize = true;
            this.LblCopyright.Location = new System.Drawing.Point(145, 310);
            this.LblCopyright.Name = "LblCopyright";
            this.LblCopyright.Size = new System.Drawing.Size(169, 22);
            this.LblCopyright.TabIndex = 0;
            this.LblCopyright.Text = "© 2018  Arvin Zhao";
            // 
            // FrmAboutPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(467, 393);
            this.Controls.Add(this.LblCopyright);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblVersion);
            this.Controls.Add(this.LblProduct);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.BtnClose);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAboutPaint";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion Windows Form Designer generated code

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Label LblProduct;
        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblCopyright;
    } // end partial class FrmAboutPaint
} // end namespace Paint