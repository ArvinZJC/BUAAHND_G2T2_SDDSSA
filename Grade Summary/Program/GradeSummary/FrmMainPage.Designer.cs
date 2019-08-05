namespace GradeSummary
{
    public partial class FrmMainPage
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

        #region Windows Form Designer Generated Code
        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainPage));
            this.LblAttention = new System.Windows.Forms.Label();
            this.LblEnterGrade = new System.Windows.Forms.Label();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnSummaryPage = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LblDateAndTime = new System.Windows.Forms.Label();
            this.LblCheck = new System.Windows.Forms.Label();
            this.LblStorageStatus = new System.Windows.Forms.Label();
            this.TimerDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblAttention
            // 
            this.LblAttention.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAttention.AutoSize = true;
            this.LblAttention.BackColor = System.Drawing.Color.Transparent;
            this.LblAttention.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAttention.ForeColor = System.Drawing.Color.Red;
            this.LblAttention.Location = new System.Drawing.Point(12, 9);
            this.LblAttention.Name = "LblAttention";
            this.LblAttention.Size = new System.Drawing.Size(523, 88);
            this.LblAttention.TabIndex = 0;
            this.LblAttention.Text = "ATTENTION:\r\n1. Please enter 1 grade at a time and then click \"OK\" to record it.\r\n" +
    "2. The grade entered should be a 1-digit positive number or 0.\r\n3. At most 100 g" +
    "rades can be recorded.";
            // 
            // LblEnterGrade
            // 
            this.LblEnterGrade.AutoSize = true;
            this.LblEnterGrade.BackColor = System.Drawing.Color.Transparent;
            this.LblEnterGrade.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnterGrade.Location = new System.Drawing.Point(32, 127);
            this.LblEnterGrade.Name = "LblEnterGrade";
            this.LblEnterGrade.Size = new System.Drawing.Size(121, 22);
            this.LblEnterGrade.TabIndex = 0;
            this.LblEnterGrade.Text = "Enter a grade:";
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(159, 124);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtInput.Size = new System.Drawing.Size(173, 30);
            this.TxtInput.TabIndex = 0;
            this.TxtInput.TabStop = false;
            this.TxtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtInput.TextChanged += new System.EventHandler(this.TxtInput_TextChanged);
            // 
            // BtnOK
            // 
            this.BtnOK.Enabled = false;
            this.BtnOK.Location = new System.Drawing.Point(410, 121);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(100, 35);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.TabStop = false;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnSummaryPage
            // 
            this.BtnSummaryPage.Enabled = false;
            this.BtnSummaryPage.Location = new System.Drawing.Point(36, 227);
            this.BtnSummaryPage.Name = "BtnSummaryPage";
            this.BtnSummaryPage.Size = new System.Drawing.Size(170, 35);
            this.BtnSummaryPage.TabIndex = 0;
            this.BtnSummaryPage.TabStop = false;
            this.BtnSummaryPage.Text = "Display Summary";
            this.BtnSummaryPage.UseVisualStyleBackColor = true;
            this.BtnSummaryPage.Click += new System.EventHandler(this.BtnSummaryPage_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Enabled = false;
            this.BtnClear.Location = new System.Drawing.Point(410, 227);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(100, 35);
            this.BtnClear.TabIndex = 0;
            this.BtnClear.TabStop = false;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LblDateAndTime
            // 
            this.LblDateAndTime.AutoSize = true;
            this.LblDateAndTime.BackColor = System.Drawing.Color.Transparent;
            this.LblDateAndTime.Location = new System.Drawing.Point(12, 285);
            this.LblDateAndTime.Name = "LblDateAndTime";
            this.LblDateAndTime.Size = new System.Drawing.Size(133, 22);
            this.LblDateAndTime.TabIndex = 0;
            this.LblDateAndTime.Text = "(Date and time)";
            // 
            // LblCheck
            // 
            this.LblCheck.AutoSize = true;
            this.LblCheck.BackColor = System.Drawing.Color.Transparent;
            this.LblCheck.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCheck.ForeColor = System.Drawing.Color.Red;
            this.LblCheck.Location = new System.Drawing.Point(338, 127);
            this.LblCheck.Name = "LblCheck";
            this.LblCheck.Size = new System.Drawing.Size(45, 23);
            this.LblCheck.TabIndex = 0;
            this.LblCheck.Text = "(×?)";
            // 
            // LblStorageStatus
            // 
            this.LblStorageStatus.AutoSize = true;
            this.LblStorageStatus.BackColor = System.Drawing.Color.Transparent;
            this.LblStorageStatus.Location = new System.Drawing.Point(155, 178);
            this.LblStorageStatus.Name = "LblStorageStatus";
            this.LblStorageStatus.Size = new System.Drawing.Size(133, 22);
            this.LblStorageStatus.TabIndex = 0;
            this.LblStorageStatus.Text = "(Storage status)";
            // 
            // TimerDateAndTime
            // 
            this.TimerDateAndTime.Enabled = true;
            this.TimerDateAndTime.Interval = 1000;
            this.TimerDateAndTime.Tick += new System.EventHandler(this.TimerDateAndTime_Tick);
            // 
            // FrmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::GradeSummary.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(547, 316);
            this.Controls.Add(this.LblStorageStatus);
            this.Controls.Add(this.LblCheck);
            this.Controls.Add(this.LblDateAndTime);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSummaryPage);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.LblEnterGrade);
            this.Controls.Add(this.LblAttention);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade Summary";
            this.Load += new System.EventHandler(this.FrmMainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        } // end method InitializeComponent
        #endregion Windows Form Designer Generated Code

        private System.Windows.Forms.Label LblAttention;
        private System.Windows.Forms.Label LblEnterGrade;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnSummaryPage;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label LblDateAndTime;
        private System.Windows.Forms.Label LblCheck;
        private System.Windows.Forms.Label LblStorageStatus;
        private System.Windows.Forms.Timer TimerDateAndTime;
    } // end partial class FrmMainPage
} // end namespace GradeSummary