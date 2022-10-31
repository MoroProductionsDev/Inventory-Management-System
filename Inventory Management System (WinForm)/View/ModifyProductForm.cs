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
        public ModifyProductForm(in int rowIndex)
        {
            InitializeComponent();
            selectedRowIndex = rowIndex;
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

        //private void saveBtn_Click(object sender, EventArgs e)
        //{
        //    if (!UITextBoxValidator.checkTextBoxesForEmptyString(partUC) && partUC.partUCValidator.checkTextBoxesForNumericInput(isInhouseRdBtnChecked))
        //    {
        //        var partsDataGridView = TabControlUC.tabControlUC_Instance.TableDataGridView["partsDataGridView"];
        //        var selectedPartsRowIndex = UIDataGridViewValidator.getTableSelectedRowIndex(partsDataGridView);

        //        if (isInhouseRdBtnChecked)
        //        {
        //            Controller.Controller.updateInhousePartToInventory(in selectedPartsRowIndex, in partUC);
        //        }
        //        else if (isOutsourcedRdBtnChecked)
        //        {
        //            Controller.Controller.updateOutsourcedPartToInventory(in selectedPartsRowIndex, in partUC);
        //        }

        //        UIDataGridViewValidator.recreateTableData(partsDataGridView, Inventory.AllParts, selectedPartsRowIndex);

        //        this.Close();
        //        Program.ShowInitialAppForm();
        //    }
        //}
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.ShowInitialAppForm();
        }
    }
}
