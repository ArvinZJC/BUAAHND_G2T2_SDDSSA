namespace Paint
{
    public partial class CanvasRectTracker
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

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // RectTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RectTracker";
            this.Size = new System.Drawing.Size(10, 10);
            this.ResumeLayout(false);

        } // end method InitializeComponent
        #endregion Component Designer generated code
    } // end partial class CanvasRectTracker
} // end namespace Paint