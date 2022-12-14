using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Managment_System.Controller;
using Inventory_Managment_System.Model;

namespace Inventory_Managment_System.View
{
    public partial class ProductUC : UserControl
    {
        public readonly UITextBoxValidator productUCValidator;
        public readonly string[] tableNames;
        public BindingList<Part> DisplayedAssociatedParts { get; private set; }

        public ProductUC()
        {
            InitializeComponent();
            productUCValidator = new UITextBoxValidator(this);
            DisplayedAssociatedParts = new BindingList<Part>();
            tableNames = new string[] {this.searchControlUC.tableNames[0], 
                            this.searchControlUC.tableNames[1]};
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
                removeAssociatedPartFromTable(selectedPartsRowIndex);
            }
            else
            {
                UIMsgBox.displayUnselectedRowWarning(obj, action);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchString = this.searchControlUC.Controls["searchTxtbox"].Text.Trim();
            int matchingIndex = -1;

            if (!string.IsNullOrEmpty(searchString))
            {
                matchingIndex = Controller.Controller.searchForPartNameInTheInventory(this.partsDataGridView, searchString);
            }

            if (matchingIndex != -1)
            {
                UIDataGridViewValidator.setTableSelectedRowIndex(this.partsDataGridView, matchingIndex);
            }
            else
            {
                UIDataGridViewValidator.unselectRowInTable(this.partsDataGridView);
            }
        }

        public void initializeAssociatedPartsInTable(BindingList<Part> associatedParts)
        {
            for (var idx = 0; idx < associatedParts.Count; ++idx)
            {
                DisplayedAssociatedParts.Add(Controller.Controller.lookUpPartFromTheInventory(idx));
            }
            UIDataGridViewValidator.recreateTableData(associatedPartsDataGridView, DisplayedAssociatedParts);
        }

        private void addAssociatedPartToTable(in int index)
        {
            DisplayedAssociatedParts.Add(Controller.Controller.lookUpPartFromTheInventory(index));
            UIDataGridViewValidator.recreateTableData(associatedPartsDataGridView, DisplayedAssociatedParts);
        }

        private void removeAssociatedPartFromTable(in int index)
        {
            DisplayedAssociatedParts.RemoveAt(index);
            UIDataGridViewValidator.recreateTableData(associatedPartsDataGridView, DisplayedAssociatedParts);
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
