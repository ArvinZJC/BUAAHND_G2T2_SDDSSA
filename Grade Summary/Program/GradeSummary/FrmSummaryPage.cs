// class that contains control events of the summary page of the main program

#region Using Directives
using System;
using System.Drawing;
using System.Windows.Forms;

using SummaryGenerator;
#endregion Using Directives

namespace GradeSummary
{
    /// <summary>
    /// Extending from class <see cref="Form"/>, the partial class <see cref="FrmSummaryPage"/> contains relevant methods and control events of the summary page.
    /// </summary>
    public partial class FrmSummaryPage : Form
    {
        public FrmSummaryPage(int number, GradeSummaryGenerator summaryData)
        {
            InitializeComponent();

            count = number;
            gradeSummary = summaryData;
        } // end constructor FrmSummaryPage

        #region Members
        private readonly int count;
        private readonly GradeSummaryGenerator gradeSummary;
        #endregion Members

        #region Control Events
        // have an operation on the status of the specified controls to display the summary
        private void FrmSummaryPage_Load(object sender, EventArgs e)
        {
            TxtAllGrades.BackColor = Color.White;
            TxtCountForGrades.BackColor = Color.White;
            TxtSum.BackColor = Color.White;
            TxtAverage.BackColor = Color.White;
            TxtHighestGrade.BackColor = Color.White;
            TxtLowestGrade.BackColor = Color.White;

            TxtHighestGrade.Text = gradeSummary.GetHighestGrade(count); // call the specified method in class GenerateSummary to get the highest grade
            TxtLowestGrade.Text = gradeSummary.GetLowestGrade(count); // call the specified method in class GenerateSummary to get the lowest grade
            TxtAllGrades.Text = gradeSummary.GetGradeList(count);
            /* call the specified method in class GenerateSummary to get the grade list;
             * the 3 methods above called in this order enable that the grade list can be displayed in a descending order
             */
            TxtCountForGrades.Text = count.ToString(); // get the number of grades recorded
            TxtSum.Text = gradeSummary.GetSum(count); // call the specified method in class GenerateSummary to get the sum of grades recorded
            TxtAverage.Text = gradeSummary.GetAverage(count); // call the specified method in class GenerateSummary to get the average of grades recorded
            BtnMainPage.Select();
        } // end method FrmSummaryPage_Load

        // have an operation on the main page and the summary page when the form containing the summary page is closed by the user
        private void FrmSummaryPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            // execute if the form containing the summary page is closed by the user
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Owner.Show(); // return to the main page 
                Dispose(); // dispose of the summary page 
            } // end if
        } // end method FrmSummaryPage_FormClosed
        
        // have an operation on the main page and the summary page when the specified button is clicked
        private void BtnMainPage_Click(object sender, EventArgs e)
        {
            Owner.Show(); // return to the main page 
            Dispose(); // dispose of the summary page
        } // end method BtnMainPage_Click
        #endregion Control Events
    } // end partial class FrmSummaryPage
} // end namespace GradeSummary