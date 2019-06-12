namespace GradeSummary
{
    partial class FrmSummaryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSummaryPage));
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblAverage = new System.Windows.Forms.Label();
            this.LblSum = new System.Windows.Forms.Label();
            this.LblCounterForGrades = new System.Windows.Forms.Label();
            this.LblAllGrades = new System.Windows.Forms.Label();
            this.LblAttention = new System.Windows.Forms.Label();
            this.LblLowestGrade = new System.Windows.Forms.Label();
            this.LblHighestGrade = new System.Windows.Forms.Label();
            this.BtnMainPage = new System.Windows.Forms.Button();
            this.TxtCountForGrades = new System.Windows.Forms.TextBox();
            this.TxtLowestGrade = new System.Windows.Forms.TextBox();
            this.TxtSum = new System.Windows.Forms.TextBox();
            this.TxtAverage = new System.Windows.Forms.TextBox();
            this.TxtHighestGrade = new System.Windows.Forms.TextBox();
            this.TxtAllGrades = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(126, 29);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(173, 46);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Summary";
            // 
            // LblAverage
            // 
            this.LblAverage.AutoSize = true;
            this.LblAverage.BackColor = System.Drawing.Color.Transparent;
            this.LblAverage.Location = new System.Drawing.Point(120, 471);
            this.LblAverage.Name = "LblAverage";
            this.LblAverage.Size = new System.Drawing.Size(82, 22);
            this.LblAverage.TabIndex = 0;
            this.LblAverage.Text = "Average:";
            // 
            // LblSum
            // 
            this.LblSum.AutoSize = true;
            this.LblSum.BackColor = System.Drawing.Color.Transparent;
            this.LblSum.Location = new System.Drawing.Point(152, 420);
            this.LblSum.Name = "LblSum";
            this.LblSum.Size = new System.Drawing.Size(50, 22);
            this.LblSum.TabIndex = 0;
            this.LblSum.Text = "Sum:";
            // 
            // LblCounterForGrades
            // 
            this.LblCounterForGrades.AutoSize = true;
            this.LblCounterForGrades.BackColor = System.Drawing.Color.Transparent;
            this.LblCounterForGrades.Location = new System.Drawing.Point(45, 369);
            this.LblCounterForGrades.Name = "LblCounterForGrades";
            this.LblCounterForGrades.Size = new System.Drawing.Size(157, 22);
            this.LblCounterForGrades.TabIndex = 0;
            this.LblCounterForGrades.Text = "Number of grades:";
            // 
            // LblAllGrades
            // 
            this.LblAllGrades.AutoSize = true;
            this.LblAllGrades.BackColor = System.Drawing.Color.Transparent;
            this.LblAllGrades.Location = new System.Drawing.Point(53, 247);
            this.LblAllGrades.Name = "LblAllGrades";
            this.LblAllGrades.Size = new System.Drawing.Size(149, 22);
            this.LblAllGrades.TabIndex = 0;
            this.LblAllGrades.Text = "Grades recorded:";
            // 
            // LblAttention
            // 
            this.LblAttention.AutoSize = true;
            this.LblAttention.BackColor = System.Drawing.Color.Transparent;
            this.LblAttention.ForeColor = System.Drawing.Color.Red;
            this.LblAttention.Location = new System.Drawing.Point(12, 88);
            this.LblAttention.Name = "LblAttention";
            this.LblAttention.Size = new System.Drawing.Size(406, 132);
            this.LblAttention.TabIndex = 0;
            this.LblAttention.Text = resources.GetString("LblAttention.Text");
            // 
            // LblLowestGrade
            // 
            this.LblLowestGrade.AutoSize = true;
            this.LblLowestGrade.BackColor = System.Drawing.Color.Transparent;
            this.LblLowestGrade.Location = new System.Drawing.Point(49, 575);
            this.LblLowestGrade.Name = "LblLowestGrade";
            this.LblLowestGrade.Size = new System.Drawing.Size(153, 22);
            this.LblLowestGrade.TabIndex = 0;
            this.LblLowestGrade.Text = "The lowest grade:";
            // 
            // LblHighestGrade
            // 
            this.LblHighestGrade.AutoSize = true;
            this.LblHighestGrade.BackColor = System.Drawing.Color.Transparent;
            this.LblHighestGrade.Location = new System.Drawing.Point(47, 523);
            this.LblHighestGrade.Name = "LblHighestGrade";
            this.LblHighestGrade.Size = new System.Drawing.Size(155, 22);
            this.LblHighestGrade.TabIndex = 0;
            this.LblHighestGrade.Text = "The highest grade:";
            // 
            // BtnMainPage
            // 
            this.BtnMainPage.Location = new System.Drawing.Point(156, 640);
            this.BtnMainPage.Name = "BtnMainPage";
            this.BtnMainPage.Size = new System.Drawing.Size(130, 35);
            this.BtnMainPage.TabIndex = 0;
            this.BtnMainPage.TabStop = false;
            this.BtnMainPage.Text = "Main Page";
            this.BtnMainPage.UseVisualStyleBackColor = true;
            this.BtnMainPage.Click += new System.EventHandler(this.BtnMainPage_Click);
            // 
            // TxtCountForGrades
            // 
            this.TxtCountForGrades.Location = new System.Drawing.Point(208, 366);
            this.TxtCountForGrades.Name = "TxtCountForGrades";
            this.TxtCountForGrades.ReadOnly = true;
            this.TxtCountForGrades.Size = new System.Drawing.Size(140, 30);
            this.TxtCountForGrades.TabIndex = 0;
            this.TxtCountForGrades.TabStop = false;
            // 
            // TxtLowestGrade
            // 
            this.TxtLowestGrade.Location = new System.Drawing.Point(208, 572);
            this.TxtLowestGrade.Name = "TxtLowestGrade";
            this.TxtLowestGrade.ReadOnly = true;
            this.TxtLowestGrade.Size = new System.Drawing.Size(140, 30);
            this.TxtLowestGrade.TabIndex = 0;
            this.TxtLowestGrade.TabStop = false;
            // 
            // TxtSum
            // 
            this.TxtSum.Location = new System.Drawing.Point(208, 417);
            this.TxtSum.Name = "TxtSum";
            this.TxtSum.ReadOnly = true;
            this.TxtSum.Size = new System.Drawing.Size(140, 30);
            this.TxtSum.TabIndex = 0;
            this.TxtSum.TabStop = false;
            // 
            // TxtAverage
            // 
            this.TxtAverage.Location = new System.Drawing.Point(208, 468);
            this.TxtAverage.Name = "TxtAverage";
            this.TxtAverage.ReadOnly = true;
            this.TxtAverage.Size = new System.Drawing.Size(140, 30);
            this.TxtAverage.TabIndex = 0;
            this.TxtAverage.TabStop = false;
            // 
            // TxtHighestGrade
            // 
            this.TxtHighestGrade.Location = new System.Drawing.Point(208, 520);
            this.TxtHighestGrade.Name = "TxtHighestGrade";
            this.TxtHighestGrade.ReadOnly = true;
            this.TxtHighestGrade.Size = new System.Drawing.Size(140, 30);
            this.TxtHighestGrade.TabIndex = 0;
            this.TxtHighestGrade.TabStop = false;
            // 
            // TxtAllGrades
            // 
            this.TxtAllGrades.Location = new System.Drawing.Point(208, 244);
            this.TxtAllGrades.Multiline = true;
            this.TxtAllGrades.Name = "TxtAllGrades";
            this.TxtAllGrades.ReadOnly = true;
            this.TxtAllGrades.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtAllGrades.Size = new System.Drawing.Size(165, 100);
            this.TxtAllGrades.TabIndex = 0;
            this.TxtAllGrades.TabStop = false;
            // 
            // FrmSummaryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::GradeSummary.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(430, 716);
            this.Controls.Add(this.TxtAllGrades);
            this.Controls.Add(this.TxtHighestGrade);
            this.Controls.Add(this.TxtAverage);
            this.Controls.Add(this.TxtSum);
            this.Controls.Add(this.TxtLowestGrade);
            this.Controls.Add(this.TxtCountForGrades);
            this.Controls.Add(this.BtnMainPage);
            this.Controls.Add(this.LblHighestGrade);
            this.Controls.Add(this.LblLowestGrade);
            this.Controls.Add(this.LblAttention);
            this.Controls.Add(this.LblAllGrades);
            this.Controls.Add(this.LblCounterForGrades);
            this.Controls.Add(this.LblSum);
            this.Controls.Add(this.LblAverage);
            this.Controls.Add(this.LblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSummaryPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Grade Summary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSummaryPage_FormClosed);
            this.Load += new System.EventHandler(this.FrmSummaryPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        } // end method InitializeComponent
        #endregion Windows Form Designer generated code

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblAverage;
        private System.Windows.Forms.Label LblSum;
        private System.Windows.Forms.Label LblCounterForGrades;
        private System.Windows.Forms.Label LblAllGrades;
        private System.Windows.Forms.Label LblAttention;
        private System.Windows.Forms.Label LblLowestGrade;
        private System.Windows.Forms.Label LblHighestGrade;
        private System.Windows.Forms.Button BtnMainPage;
        private System.Windows.Forms.TextBox TxtCountForGrades;
        private System.Windows.Forms.TextBox TxtLowestGrade;
        private System.Windows.Forms.TextBox TxtSum;
        private System.Windows.Forms.TextBox TxtAverage;
        private System.Windows.Forms.TextBox TxtHighestGrade;
        private System.Windows.Forms.TextBox TxtAllGrades;
    } // end partial class FrmSummaryPage
} // end namespace GradeSummary