using Inventory_Managment_System.Controller;
using Inventory_Managment_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System.View
{
    public partial class AddProductForm : Form
    {
        private readonly DataGridView productsDataGridView;
        public AddProductForm()
        {
            InitializeComponent();

            productsDataGridView = TabControlUC.tabControlUC_Instance.TableDataGridView["productsDataGridView"];
        }

        private void productUC_Load(object sender, EventArgs e)
        {
            UITextBoxValidator.modifyAllEmptyOrNullTextbox(productUC);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!UITextBoxValidator.checkTextBoxesForEmptyString(productUC) && productUC.productUCValidator.checkTextBoxesForNumericInput(false))
            {
                try
                {
                    if (!productUC.DisplayedAssociatedParts.Count.Equals(0))
                    {
                        Controller.Controller.addProductToInventory(in productUC, productUC.DisplayedAssociatedParts);

                        var newProductRowIndex = UIDataGridViewValidator.getTableRowCount(productsDataGridView);
                        UIDataGridViewValidator.recreateTableData(productsDataGridView, Inventory.Products, newProductRowIndex);

                        this.Close();
                        Program.ShowInitialAppForm();
                    }
                    else
                    {
                        UIMsgBox.displayNoAssociatedPartWarning();
                    }
                }
                catch (ArgumentOutOfRangeException argOutOfRangeExcp)
                {
                    if(argOutOfRangeExcp.ParamName !=null && argOutOfRangeExcp.ParamName.Equals("Max [ArgumentOutOfRangeException]"))
                    {
                        UIMsgBox.displayMinExceedsMaxWarning(int.Parse(productUC.Controls["productMinTxtBox"].Text),
                                                    int.Parse(productUC.Controls["productMaxTxtBox"].Text));
                    } else
                    {
                        throw argOutOfRangeExcp;
                    }
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.ShowInitialAppForm();
        }
    }
}
