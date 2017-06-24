using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace econtact
{
    public class Tbox: TextBox
    {
        public bool IsValid()
        {
            int number;
            bool isValid = int.TryParse(Text, out number);
            return isValid;
        }
    }
}
