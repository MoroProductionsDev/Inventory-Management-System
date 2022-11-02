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

            MessageBox.Show(informationMsg, "Information", msgBoxButtons, MessageBoxIcon.Exclamation);
        }

        public static void displayDeletingProductWithAssociatedParts(int associatedPartsCount)
        {
            string s = associatedPartsCount == 0 ? "" : "s";
            string informationMsg = $"This product has {associatedPartsCount} associated part{s} attached to it.\n" +
                                    $"Modify the product and remove the all associated part{s} from the product.";
            MessageBoxButtons msgBoxButtons = MessageBoxButtons.OK;

            MessageBox.Show(informationMsg, "Information", msgBoxButtons, MessageBoxIcon.Stop);
        }

        public static void displayMinExceedsMaxWarning(int min, int max)
        {
            string informationMsg = min == max ? $"Your minimum of {min} should not equal your maximum of {max}." :
                                                $"Your minimum of {min} should not exceed your maximum of {max}.";
            MessageBoxButtons msgBoxButtons = MessageBoxButtons.OK;

            MessageBox.Show(informationMsg, "Information", msgBoxButtons, MessageBoxIcon.Error);
        }

        public static void displayInStockOutOfRangeWarning(int min, int max, int inStock)
        {
            
            string informationMsg = inStock < min ? 
                                    $"Instock of {inStock} should be less than the minimum of {min}." : 
                                    $"Instock of {inStock} should be greater than the maximum of {max}.";
            MessageBoxButtons msgBoxButtons = MessageBoxButtons.OK;

            MessageBox.Show(informationMsg, "Information", msgBoxButtons, MessageBoxIcon.Error);
        }
    }
}
