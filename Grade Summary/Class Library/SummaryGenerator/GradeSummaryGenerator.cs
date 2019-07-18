// class that contains certain methods called by the main program of Grade Summary

#region Using Directives
using System;
using System.Text.RegularExpressions;
#endregion Using Directives

namespace SummaryGenerator
{
    /// <summary>
    /// The class <see cref="GradeSummaryGenerator"/> contains certain methods called by the main program of Grade Summary.
    /// </summary>
    public class GradeSummaryGenerator
    {
        #region Members
        private double sum; // the variable "sum" is used to store the sum of grades recorded
        private string gradeList;
        /// <summary>
        /// An array storing up to 100 grades.
        /// </summary>
        public double[] grade = new double[100];
        #endregion Members

        #region Private Methods
        // check if all the grades are the same
        private bool HasDifferentGrades(int count)
        {
            int countForSameGrade = 0;

            for (int i = 1; i < count; i++)
            {
                if (grade[i] == grade[i - 1])
                    countForSameGrade++;
                else
                    break;
            } // end for

            if (countForSameGrade < count - 1)
                return true;
            else
                return false;
        } // end method HasDifferentGrades

        // sort from the highest to the lowest
        private void DescendingSort()
        {
            Array.Sort(grade);
            Array.Reverse(grade);
        } // end method DescendingSort
        #endregion Private Methods

        #region Public Methods
        /// <summary>
        /// Check the input.
        /// </summary>
        /// <param name="input">the input</param>
        /// <returns>return the checking result</returns>
        public string CheckInput(string input)
        {
            string pattern = @"^(100.0|100|(\d{1,2}(\.\d)?))?$"; // allow entering an integer or a number with 1 decimal place between 0 and 100

            /* check if the input is legal;
             * allow entering only spaces;
             * the input can start with spaces and can also end up with spaces
             */
            if (Regex.IsMatch(input.Trim(), pattern))
                return "";
            else
                return "×";
        } // end method CheckInput

        /// <summary>
        /// Check the storage status.
        /// </summary>
        /// <param name="count">the number of grades</param>
        /// <returns>return true if there is space; otherwise, return false</returns>
        public bool CheckStorageStatus(int count)
        {
            // the storage can store at most 100 numbers (count 0 - 99)
            if (count < 100)
                return true;
            else 
                return false;
        } // end method CheckStorageStatus

        /// <summary>
        /// Clear grades recorded in the storage and reset the grade count to 0.
        /// </summary>
        /// <param name="count">the number of grades</param>
        /// <returns>return the initial number of grades</returns>
        public int ClearStorage(int count)
        {
            Array.Clear(grade, 0, count); //clear grades recorded in the storage

            sum = 0;
            gradeList = "";

            return 0; // reset the number of grades to 0
        } // end method ClearStorage

        /// <summary>
        /// Get the grade list.
        /// </summary>
        /// <param name="count">the number of grades</param>
        /// <returns>return the grade list</returns>
        public string GetGradeList(int count)
        {
            gradeList = "";
            
            // loop to create a grade list containing grades recorded (1 grade a line)
            for (int i = 0; i < count; i++)
                gradeList += grade[i].ToString() + Environment.NewLine; // the line feed is "\r\n" in Windows

            return gradeList.Substring(0, gradeList.Length - Environment.NewLine.Length); // return the grade list without any extra line feed
        } // end method GetGradeList 

        /// <summary>
        /// Get the sum of grades recorded.
        /// </summary>
        /// <param name="count">the number of grades</param>
        /// <returns>return the sum of grades recorded</returns>
        public string GetSum(int count)
        {
            sum = 0;

            // loop to calculate the sum of grades
            for (int i = 0; i < count; i++)
                sum += grade[i];

            return sum.ToString();
        } // end method GetSum

        /// <summary>
        /// Get the average of grades recorded.
        /// </summary>
        /// <param name="count">the number of grades</param>
        /// <returns>return the average of grades recorded</returns>
        public string GetAverage(int count)
        {
            return Math.Round(sum / count, 1).ToString(); // 1 decimal place is kept in the average grade
        } // end method GetAverage

        /// <summary>
        /// Get the highest grade.
        /// </summary>
        /// <param name="count">the number of grades</param>
        /// <returns>return the highest grade</returns>
        public string GetHighestGrade(int count)
        {
            /* execute if the value of the grade count is not 1 and there are different grades;
             * call the specified method to check if all the grades are the same
             */
            if (count != 1 && HasDifferentGrades(count))
            {
                DescendingSort(); // call the specified method to sort from the highest to the lowest
                return grade[0].ToString();
            }
            else
                return "-";
        } // end method GetHighestGrade

        /// <summary>
        /// Get the lowest grade.
        /// </summary>
        /// <param name="count">the number of grades</param>
        /// <returns>return the lowest grade</returns>
        public string GetLowestGrade(int count)
        {
            /* execute if the value of the grade count is not 1 and there are different grades;
             * call the specified method to check if all the grades are the same
             */
            if (count != 1 && HasDifferentGrades(count))
            {
                DescendingSort(); // call the specified method to sort from the highest to the lowest
                return grade[count - 1].ToString();
            }
            else
                return "-";
        } // end method GetLowestGrade
        #endregion Public Methods
    } // end class GradeSummaryGenerator
} // end namespace SummaryGenerator