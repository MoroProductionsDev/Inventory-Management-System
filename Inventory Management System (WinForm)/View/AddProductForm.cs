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
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void productUC_Load(object sender, EventArgs e)
        {
            UITextBoxValidator.modifyAllEmptyOrNullTextbox(productUC);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {


            if (!UITextBoxValidator.checkTextBoxesForEmptyString(productUC) && productUC.productUCValidator.checkTextBoxesForNumericInput(false))
            {
                var productsDataGridView = TabControlUC.tabControlUC_Instance.TableDataGridView["productsDataGridView"];

                if (!productUC.DisplayedAssociatedParts.Count.Equals(0))
                {
                    Controller.Controller.addProductToInventory(in productUC, productUC.DisplayedAssociatedParts);

                    var newProductRowIndex = UIDataGridViewValidator.getTableRowCount(productsDataGridView);
                    UIDataGridViewValidator.recreateTableData(productsDataGridView, Inventory.Products, newProductRowIndex);

                    this.Close();
                    Program.ShowInitialAppForm();
                } else
                {
                    // MsgBox Warning
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
