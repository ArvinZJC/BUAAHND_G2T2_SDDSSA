#region Using Directives
using System;
using System.Windows.Forms;
#endregion Using Directives

namespace Paint
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMainInterface());
        } // end main
    } // end static class Program
} // end namespace Paint