using Inventory_Managment_System.Controller;
using Inventory_Managment_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System.View
{
    public partial class PartUC : UserControl
    {
        public readonly UITextBoxValidator partUCValidator;
        public PartUC()
        {
            InitializeComponent();
            partUCValidator = new UITextBoxValidator(this);
        }

        private void inHouseRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.partMachineIDLbl.Visible = true;
            this.partCompanyNameLbl.Visible = false;
            partUCValidator.toolTip.RemoveAll();

            // Validate the MachineID/CompanyName textbox when the [inHouse] radio button is checked 
            partUCValidator.modifyTextbox(partMachineIDorCompanyNameTxtBox, e, UITextBoxValidator.ValType.Integer);
        }

        private void outSourcedRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.partMachineIDLbl.Visible = false;
            this.partCompanyNameLbl.Visible = true;
            partUCValidator.toolTip.RemoveAll();

            // Validate the MachineID/CompanyName textbox when the [outSourced] radio button is checked 
            partUCValidator.modifyTextbox(partMachineIDorCompanyNameTxtBox, e, UITextBoxValidator.ValType.NullAndEmptyString);
        }

        private void partNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            partUCValidator.modifyTextbox(sender, e, UITextBoxValidator.ValType.NullAndEmptyString);
        }

        private void partInventoryTxtBox_TextChanged(object sender, EventArgs e)
        {
            partUCValidator.modifyTextbox(sender, e, UITextBoxValidator.ValType.Integer);
        }

        private void partPriceTxtBox_TextChanged(object sender, EventArgs e)
        {
            partUCValidator.modifyTextbox(sender, e, UITextBoxValidator.ValType.Decimal);
        }

        private void partMinTxtBox_TextChanged(object sender, EventArgs e)
        {
            partUCValidator.modifyTextbox(sender, e, UITextBoxValidator.ValType.Integer);
        }

        private void partMaxTxtBox_TextChanged(object sender, EventArgs e)
        {
            partUCValidator.modifyTextbox(sender, e, UITextBoxValidator.ValType.Integer);
        }

        private void machineIDorCompanyNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (inHouseRdBtn.Checked)
            {
                partUCValidator.modifyTextbox(sender, e, UITextBoxValidator.ValType.Integer);
            }
            else
            {
                partUCValidator.modifyTextbox(sender, e, UITextBoxValidator.ValType.NullAndEmptyString);
            }
        }
    }
}
