using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Managment_System.Controller;
using Inventory_Managment_System.Model;
using static Inventory_Managment_System.View.TabControlUC;

namespace Inventory_Managment_System.View
{
    public partial class ProductUC : UserControl
    {
        public readonly UITextBoxValidator productUCValidator;
        private readonly BindingList<Part> associatedParts;
        public ProductUC()
        {
            InitializeComponent();
            productUCValidator = new UITextBoxValidator(this);
            associatedParts = new BindingList<Part>();
        }

        private void ProductUC_Load(object sender, EventArgs e)
        {
            loadAllParts();
        }

        private void loadAllParts()
        {
            UIDataGridViewValidator.insertDataInTable(partsDataGridView, Inventory.AllParts);
            UIDataGridViewValidator.unselectRowInTable(partsDataGridView);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var obj = "part";
            var action = "add";
            var selectedPartsRowIndex = UIDataGridViewValidator.getTableSelectedRowIndex(partsDataGridView);

            if (selectedPartsRowIndex != (int)UIDataGridViewValidator.IndexVal.Invalid)
            {
                // Do something
                addAssociatedPartToTable(selectedPartsRowIndex);
            }
            else
            {
                UIMsgBox.displayUnselectedRowWarning(obj, action);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var obj = "associated part";
            var action = "deleted";
            var selectedPartsRowIndex = UIDataGridViewValidator.getTableSelectedRowIndex(associatedPartsDataGridView);

            if (selectedPartsRowIndex != (int)UIDataGridViewValidator.IndexVal.Invalid)
            {
                // Do something
                removeAssociatedPartFromTable(selectedPartsRowIndex);
            }
            else
            {
                UIMsgBox.displayUnselectedRowWarning(obj, action);
            }
        }

        private void addAssociatedPartToTable(in int index)
        {
            associatedParts.Add(Controller.Controller.lookUpPartFromTheInventory(index));
            UIDataGridViewValidator.recreateTableData(associatedPartsDataGridView, associatedParts);
        }

        private void removeAssociatedPartFromTable(in int index)
        {
            associatedParts.RemoveAt(index);
            UIDataGridViewValidator.recreateTableData(associatedPartsDataGridView, associatedParts);
        }

        private void productNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            productUCValidator.modifyTextbox(sender, e, UITextBoxValidator.ValType.NullAndEmptyString);
        }

        private void productInventoryTxtBox_TextChanged(object sender, EventArgs e)
        {
            productUCValidator.modifyTextbox(sender, e, UITextBoxValidator.ValType.Integer);
        }

        private void productPriceTxtBox_TextChanged(object sender, EventArgs e)
        {
            productUCValidator.modifyTextbox(sender, e, UITextBoxValidator.ValType.Decimal);
        }

        private void productMinTxtBox_TextChanged(object sender, EventArgs e)
        {
            productUCValidator.modifyTextbox(sender, e, UITextBoxValidator.ValType.Integer);
        }

        private void productMaxTxtBox_TextChanged(object sender, EventArgs e)
        {
            productUCValidator.modifyTextbox(sender, e, UITextBoxValidator.ValType.Integer);
        }
    }
}
