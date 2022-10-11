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
    public partial class PartUC : UserControl
    {
        private RadioButton InHouseRadioButton { get => inHouseRdBtn; }
        public RadioButton OutSourcedRadioButton { get => outSourcedRdBtn; }
        public TextBox IDTxtBox { get => partIDTxtBox; }
        public TextBox NameTxtBox { get => partNameTxtBox; }

        public TextBox InventoryTxtBox { get => partInventoryTxtBox; }
        public TextBox Price { get => partPriceTxtBox; }

        public TextBox MinTxtBox { get => partMinTxtBox; }
        public TextBox MaxTxtBox { get => partMaxTxtBox; }

        public Button SaveButton { get => saveBtn; }
        public Button CancelButton { get => cancelBtn; }

        public PartUC()
        {
            InitializeComponent();
        }

        private void inHouseRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.machineID.Visible = true;
            this.partCompanyNameLbl.Visible = false;
        }

        private void outSourcedRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.machineID.Visible = false;
            this.partCompanyNameLbl.Visible = true;
        }
    }
}
