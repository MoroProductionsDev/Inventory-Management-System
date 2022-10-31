using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.View
{
    public static class UIMsgBox
    {
        public static bool displayDeletionWarning()
        {
            string warningMsg = "Are you sure you want to delete this part?";
            MessageBoxButtons msgBoxButtons = MessageBoxButtons.YesNo;

            var result = MessageBox.Show(warningMsg, "Warning", msgBoxButtons, MessageBoxIcon.Warning);

            return result == DialogResult.Yes;
        }

        public static void displayUnselectedRowWarning(string obj, string action)
        {
            string informationMsg = $"Please select {obj} to {action}.";
            MessageBoxButtons msgBoxButtons = MessageBoxButtons.OK;

            MessageBox.Show(informationMsg, "Information", msgBoxButtons, MessageBoxIcon.Information);
        }
    }
}
