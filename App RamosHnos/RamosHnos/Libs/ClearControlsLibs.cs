using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RamosHnos.Libs
{
    class ClearControlsLibs
    {
        public static void ClearAll(Control ctrl, GroupBox gb)
        {
            foreach (var txt in ctrl.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = 0;
                }
            }

            foreach (var txt2 in gb.Controls)
            {
                if (txt2 is TextBox)
                {
                    ((TextBox)txt2).Clear();
                }
                else if (txt2 is ComboBox)
                {
                    ((ComboBox)txt2).SelectedIndex = 0;
                }
            }                 
        }
    }
}
