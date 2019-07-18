// class that contains

#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
#endregion Using Directives

namespace Tools
{
    /// <summary>
    /// The clas <see cref="PaintingTools"/> contains
    /// </summary>
    public class PaintingTools
    {
        #region Members

        #endregion Members

        #region Private Methods

        #endregion Private Methods

        #region Public Methods
        public bool CheckInputForSize(string inputForSize)
        {
            /* allow entering only spaces;
               allow entering an integer or a number with 1 decimal place between 0 and 100;
               the input can start with spaces and can also end up with spaces */
            string pattern = @"^\s*(100.0|100|(\d{1,2}(\.\d)?))?\s*$";

            // check if the input is legal
            if (Regex.IsMatch(inputForSize, pattern))
                return true;
            else
                return false;
        } // end method CheckInputForSize
        #endregion Public Methods
    } // end class PaintingTools
} // end namespace Tools