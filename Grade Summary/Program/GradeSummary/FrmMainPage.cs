// class that contains control events of the main page of the main program

#region Using Directives
using System;
using System.Drawing;
using System.Windows.Forms;

using SummaryGenerator;
#endregion Using Directives

namespace GradeSummary
{
    /// <summary>
    /// Extending from class <see cref="Form"/>, the partial class <see cref="FrmMainPage"/> contains relevant methods and control events of the main page.
    /// </summary>
    public partial class FrmMainPage : Form
    {
        public FrmMainPage()
        {
            InitializeComponent();
        } //end constructor FrmMainPage

        #region Members
        private int count = 0;
        private readonly GradeSummaryGenerator gradeSummary = new GradeSummaryGenerator(); // create a GradeSummaryGenerator object and assign it to "gradeSummary";
        #endregion Members

        #region Private Methods
        // initialise the status of the specified controls
        private void InitialiseControlStatus()
        {
            LblCheck.Text = "";
            LblStorageStatus.Text = "";
            BtnOK.Enabled = false;
        } // end method InitialiseControlStatus 

        // select all in the specified text box
        private void SelectText()
        {
            TxtInput.Select();
            TxtInput.SelectAll();
        } // end method SelectText
        #endregion Private Methods

        #region Control Events
        // have an initial operation on the status of the specified controls as well as the date and time
        private void FrmMainPage_Load(object sender, EventArgs e)
        {
            InitialiseControlStatus(); // call the specified method to initialise the status of the specified controls
            TxtInput.Select();
            LblDateAndTime.Text = DateTime.Now.ToString(); // display the start date and time, which is accurate to a second
        } // end method FrmMainPage_Load

        // synchronously display the current date and time, which is accurate to a second
        private void TimerDateAndTime_Tick(object sender, EventArgs e)
        {
            LblDateAndTime.Text = DateTime.Now.ToString();
        } // end method TimerDateAndTime_Tick

        // synchronously check the input
        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            InitialiseControlStatus(); // call the specified method to initialise the status of specified controls 
            LblCheck.Text = gradeSummary.CheckInput(TxtInput.Text); // call the specified method in class GenerateSummary to check the input

            if (LblCheck.Text == "" && TxtInput.Text.Trim() != "")
                BtnOK.Enabled = true;
        } // end method TxtInput_TextChanged

        // check the storage status, and confirm to record grades if there is space in the storage
        private void BtnOK_Click(object sender, EventArgs e)
        {
            /* execute if there is space in the storage;
             * call the specified method in class GenerateSummary to check the storage status
             */
            if (gradeSummary.CheckStorageStatus(count))
            {
                gradeSummary.grade[count++] = Convert.ToDouble(TxtInput.Text);
                SelectText(); // call the specified method to select all in the specified text box

                LblStorageStatus.Text = "Successfully recorded.";
                LblStorageStatus.ForeColor = Color.Green;
                BtnSummaryPage.Enabled = true;
                BtnClear.Enabled = true;
            }
            else
            {
                LblStorageStatus.Text = "Error! No space to record the grade.";
                LblStorageStatus.ForeColor = Color.Red;
            } // end if...else
        } // end method BtnOK_Click

        // hide the main page and display the summary page
        private void BtnSummaryPage_Click(object sender, EventArgs e)
        {
            FrmSummaryPage summaryPage = new FrmSummaryPage(count, gradeSummary); // create a FrmSummaryPage object with the specified parameters and assign it to "summaryPage"

            Hide(); // hide the main page
            summaryPage.ShowDialog(this); // display the summary page and set the main page as the owner of the summary page
        } // end method BtnSummaryPage_Click

        // have an operation on the storage and the status of the specified controls
        private void BtnClear_Click(object sender, EventArgs e)
        {
            count = gradeSummary.ClearStorage(count); // call the specified method in class GenerateSummary to clear grades recorded in the storage and reset the grade count to 0
            SelectText(); // call the specified method to select all in the specified text box

            LblStorageStatus.Text = "Grades recorded have been cleared.";
            LblStorageStatus.ForeColor = Color.Green;
            BtnSummaryPage.Enabled = false;
            BtnClear.Enabled = false;
        } // end method BtnClear_Click
        #endregion Control Events
    } // end partial class FrmMainPage
} // end namespace GradeSummary