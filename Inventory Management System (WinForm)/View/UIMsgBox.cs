using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.View
{
    public static class UIMsgBox
    {
        public static bool displayDeletionWarning(string obj)
        {
            string warningMsg = $"Are you sure you want to delete this {obj}?";
            MessageBoxButtons msgBoxButtons = MessageBoxButtons.YesNo;

            var result = MessageBox.Show(warningMsg, "Warning", msgBoxButtons, MessageBoxIcon.Warning);

            return result == DialogResult.Yes;
        }

        public static void displayUnselectedRowWarning(string obj, string action)
        {
            // a or an base associated part or something else
            string informationMsg = (obj.ToUpper()[0]) == 'A' ? $"Please select an {obj} to {action}." :
                                                                $"Please select a {obj} to {action}.";
            MessageBoxButtons msgBoxButtons = MessageBoxButtons.OK;

            MessageBox.Show(informationMsg, "Information", msgBoxButtons, MessageBoxIcon.Information);
        }

        public static void displayNoAssociatedPartWarning()
        {
            string informationMsg = $"Must have at least one associated part.";
            MessageBoxButtons msgBoxButtons = MessageBoxButtons.OK;

            MessageBox.Show(informationMsg, "Information", msgBoxButtons, MessageBoxIcon.Information);
        }

        public static void displayMinExceedsMaxWarning(int min, int max)
        {
            string informationMsg = $"Your minimum {min} exceeds your maximum {max}.";
            MessageBoxButtons msgBoxButtons = MessageBoxButtons.OK;

            MessageBox.Show(informationMsg, "Information", msgBoxButtons, MessageBoxIcon.Information);
        }
    }
}
