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
    public partial class ModifyProductForm : Form
    {
        private readonly int selectedRowIndex;
        private readonly DataGridView productsDataGridView;
        private readonly int selectedProductRowIndex;
        public ModifyProductForm(in int rowIndex)
        {
            InitializeComponent();
            selectedRowIndex = rowIndex;

            productsDataGridView = TabControlUC.tabControlUC_Instance.TableDataGridView["productsDataGridView"];
            selectedProductRowIndex = UIDataGridViewValidator.getTableSelectedRowIndex(productsDataGridView);
        }

        private void productUC_Load(object sender, EventArgs e)
        {
            var selectedModifiableProduct = Controller.Controller.lookUpProductFromTheInventory(selectedRowIndex);
            productUC.Controls["productIDTxtBox"].Text = selectedModifiableProduct.ProductID.ToString();
            productUC.Controls["productNameTxtBox"].Text = selectedModifiableProduct.Name;
            productUC.Controls["productInventoryTxtBox"].Text = selectedModifiableProduct.InStock.ToString();
            productUC.Controls["productPriceTxtBox"].Text = selectedModifiableProduct.Price.ToString();
            productUC.Controls["productMinTxtBox"].Text = selectedModifiableProduct.Min.ToString();
            productUC.Controls["productMaxTxtBox"].Text = selectedModifiableProduct.Max.ToString();

            productUC.initializeAssociatedPartsInTable(selectedModifiableProduct.AssociatedParts);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!UITextBoxValidator.checkTextBoxesForEmptyString(productUC) && productUC.productUCValidator.checkTextBoxesForNumericInput(false))
            {
                try
                {
                    if (!productUC.DisplayedAssociatedParts.Count.Equals(0))
                    {
                        Controller.Controller.updateProductInInventory(in productUC, productUC.DisplayedAssociatedParts, selectedProductRowIndex);

                        UIDataGridViewValidator.recreateTableData(productsDataGridView, Inventory.Products);

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
