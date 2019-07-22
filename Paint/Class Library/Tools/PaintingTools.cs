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
            string pattern = @"^(([1-9][0-9]?)|100)$"; // allow entering an integer between 1 and 100

            /* check if the input is legal;
             * the input can start with spaces and can also end up with spaces
             */
            if (Regex.IsMatch(inputForSize.Trim(), pattern))
                return true;
            else
                return false;
        } // end method CheckInputForSize
        #endregion Public Methods
    } // end class PaintingTools
} // end namespace Tools
                        
                        