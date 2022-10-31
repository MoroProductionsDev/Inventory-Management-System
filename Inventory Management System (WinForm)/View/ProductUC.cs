using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Managment_System.Model;
using static Inventory_Managment_System.View.TabControlUC;

namespace Inventory_Managment_System.View
{
    public partial class ProductUC : UserControl
    {
        public readonly UITextBoxValidator productUCValidator;
        public ProductUC()
        {
            InitializeComponent();
            productUCValidator = new UITextBoxValidator(this);
        }

        private void ProductUC_Load(object sender, EventArgs e)
        {
            loadAllParts();
        }

        private void loadAllParts()
        {
            var partList = Inventory.AllParts;

            UIDataGridViewValidator.insertDataInTable(partsDataGridView, partList);
            //foreach (var part in partList)
            //{
            //    this.partsDataGridView.Rows.Add(new object[] { part.PartID, part.Name, part.InStock,
            //            part.Price, part.Min, part.Max
            //    });
            //}
        }
        private void unselectRowInTable(DataGridView dataGridView)
        {
            dataGridView.ClearSelection();
        }
        //private int getProductsSelectedRowIndex()
        //{
        //    var selectedRow = productsDataGridView.SelectedRows;
        //    int selectedRowIndex;
        //    try
        //    {
        //        selectedRowIndex = selectedRow[0].Index;
        //    }
        //    catch (ArgumentOutOfRangeException)
        //    {
        //        selectedRowIndex = (int)IndexVal.Invalid;
        //    }

        //    return selectedRowIndex;
        //}
        public int getPartsRowCount()
        {
            return partsDataGridView.Rows.Count;
        }
        private void setPartsSelectedRowIndex(in int index)
        {
            partsDataGridView.Rows[index].Selected = true;
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
