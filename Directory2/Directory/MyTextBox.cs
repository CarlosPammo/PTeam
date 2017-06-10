using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Directory
{
    public class MyTextBox : TextBox
    {
        /// <summary>
        /// Verification
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            int number;
            bool isValid = int.TryParse(Text, out number);
            return isValid;
        }

    }
}
