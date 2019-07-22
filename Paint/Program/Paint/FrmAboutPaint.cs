// class that 

#region Using Directives
using System;
using System.Windows.Forms;
#endregion Using Directives

namespace Paint
{
    /// <summary>
    /// Extending from the class <see cref="Form"/>, the class <see cref="FrmAboutPaint"/> contains 
    /// </summary>
    public partial class FrmAboutPaint : Form
    {
        public FrmAboutPaint()
        {
            InitializeComponent();
        } // end constructor FrmAboutPaint

        #region Members
        private readonly ApplicationInfo applicationInfo = new ApplicationInfo();
        #endregion Members

        #region Control Events
        private void FrmAboutPaint_Load(object sender, EventArgs e)
        {
            LblProduct.Text = applicationInfo.Name;
            LblVersion.Text = "Version " + applicationInfo.Version;
            LblCopyright.Text = applicationInfo.Copyright;
        } // end method FrmAboutPaint_Load

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Dispose(); // dispose of the form About Paint
        } // end method BtnClose_Click
        #endregion Control Events
    } // end partial class FrmAboutPaint
} // end namespace Paint