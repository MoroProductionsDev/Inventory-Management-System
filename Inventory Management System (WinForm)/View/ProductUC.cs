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

namespace Inventory_Managment_System.View
{
    public partial class ProductUC : UserControl
    {
        public readonly UIValidator productUCValidator;
        public ProductUC()
        {
            InitializeComponent();
            productUCValidator = new UIValidator(this);
        }

        private void ProductUC_Load(object sender, EventArgs e)
        {
            loadAllParts();
        }

        private void loadAllParts()
        {
            var partList = Inventory.AllParts;

            foreach (var part in partList)
            {
                this.partsDataGridView.Rows.Add(new object[] { part.PartID, part.Name, part.InStock,
                        part.Price, part.Min, part.Max
                });
            }
        }

        private void productNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            productUCValidator.modifyTextbox(sender, e, UIValidator.ValType.NullAndEmptyString);
        }

        private void productInventoryTxtBox_TextChanged(object sender, EventArgs e)
        {
            productUCValidator.modifyTextbox(sender, e, UIValidator.ValType.Integer);
        }

        private void productPriceTxtBox_TextChanged(object sender, EventArgs e)
        {
            productUCValidator.modifyTextbox(sender, e, UIValidator.ValType.Decimal);
        }

        private void productMinTxtBox_TextChanged(object sender, EventArgs e)
        {
            productUCValidator.modifyTextbox(sender, e, UIValidator.ValType.Integer);
        }

        private void productMaxTxtBox_TextChanged(object sender, EventArgs e)
        {
            productUCValidator.modifyTextbox(sender, e, UIValidator.ValType.Integer);
        }
    }
}
