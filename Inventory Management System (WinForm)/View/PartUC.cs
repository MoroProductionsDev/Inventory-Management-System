using Inventory_Managment_System.Controller;
using Inventory_Managment_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private RadioButton InHouseRadioButton { get => inHouseRdBtn; }
        public RadioButton OutSourcedRadioButton { get => outSourcedRdBtn; }
        public TextBox IDTxtBox { get => partIDTxtBox; }
        public TextBox NameTxtBox { get => partNameTxtBox; }

        public TextBox InventoryTxtBox { get => partInventoryTxtBox; }
        public TextBox PriceTxtBox { get => partPriceTxtBox; }

        public TextBox MinTxtBox { get => partMinTxtBox; }
        public TextBox MaxTxtBox { get => partMaxTxtBox; }

        public Button SaveButton { get => saveBtn; }
        public Button CancelButton { get => cancelBtn; }

        private List<TextBox> textBoxList;

        private String[] textBoxName;

        private ToolTip toolTip; //to display the textbox tool messages

        public PartUC()
        {
            InitializeComponent();
            toolTip = new ToolTip();
            textBoxList = new List<TextBox>() { NameTxtBox, InventoryTxtBox,
                partPriceTxtBox, partMinTxtBox, partMaxTxtBox };
            textBoxName = new String[] {InventoryTxtBox.Name, partPriceTxtBox.Name,
                        partMinTxtBox.Text, partMaxTxtBox.Text };
        }

        private void inHouseRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.partMachineIDLbl.Visible = true;
            this.partCompanyNameLbl.Visible = false;
            toolTip.RemoveAll();
            machineIDorCompanyNameTxtBox.BackColor = Color.White;
            machineIDorCompanyNameTxtBox.Clear();
        }

        private void outSourcedRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.partMachineIDLbl.Visible = false;
            this.partCompanyNameLbl.Visible = true;
            toolTip.RemoveAll();
            machineIDorCompanyNameTxtBox.BackColor = Color.White;
            machineIDorCompanyNameTxtBox.Clear();
        }

        private void partNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            modifyTextbox(sender, e, false);
        }

        private void partInventoryTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (inHouseRdBtn.Checked)
            {
                hasNumericInput(sender, e);
            }
            modifyTextbox(sender, e, true);
        }

        private void partPriceTxtBox_TextChanged(object sender, EventArgs e)
        {
            modifyTextbox(sender, e, true);
        }

        private void partMinTxtBox_TextChanged(object sender, EventArgs e)
        {
            modifyTextbox(sender, e, true);
            
        }

        private void partMaxTxtBox_TextChanged(object sender, EventArgs e)
        {
            modifyTextbox(sender, e, true);

        }

        private void machineIDorCompanyNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (inHouseRdBtn.Checked)
            {
                modifyTextbox(sender, e, true);
            } else
            {
                modifyTextbox(sender, e, false);
            }

            
        }
        private void modifyTextbox(object sender, EventArgs e, bool checkNumericTxtBox)
        {
            if (checkNumericTxtBox)
            {
                if (!hasEmptyOrNullString(sender, e) && hasNumericInput(sender, e))
                {
                    ((TextBox)sender).BackColor = Color.White;
                }
                else
                {
                    ((TextBox)sender).BackColor = Color.OrangeRed;
                    displayTheIndicatedToolTip(sender, e, checkNumericTxtBox);
                }
            } else
            {
                if (!hasEmptyOrNullString(sender, e))
                {
                    ((TextBox)sender).BackColor = Color.White;
                }
                else
                {
                    ((TextBox)sender).BackColor = Color.OrangeRed;
                    displayTheIndicatedToolTip(sender, e, checkNumericTxtBox);
                }
            }
        }

        private bool hasEmptyOrNullString(object sender, EventArgs e)
        {
            bool isItEmptyOrNull = true;
            if (sender.GetType().Equals(typeof(TextBox)))
            {
                try
                {
                    Controller.Validate.ValidateNullorEmptyString(((TextBox)sender).Text);
                    isItEmptyOrNull =  false;
                    
                }
                catch (NullReferenceException)
                {
                    isItEmptyOrNull = true;
                }
            }
            return isItEmptyOrNull;
        }

        private bool hasNumericInput(object sender, EventArgs e)
        {
            bool isItNumeric = false;
            if (sender.GetType().Equals(typeof(TextBox)))
            {

                if (Controller.Validate.ValidateNumericInput(((TextBox)sender).Text))
                {
                    isItNumeric = true;
                }
                else
                {
                    isItNumeric = false;
                    
                }
            }
            return isItNumeric;
        }

        private void displayTheIndicatedToolTip(object sender, EventArgs e, bool checkNumericTxtBox)
        {
            if(((TextBox)sender).Equals(NameTxtBox)) {
                    toolTip.SetToolTip((TextBox)sender, $"{partNameLbl.Text} is required");
            }
            else if (((TextBox)sender).Equals(InventoryTxtBox))
            {
                if (checkNumericTxtBox && !hasEmptyOrNullString(sender, e))
                {
                    toolTip.SetToolTip((TextBox)sender, $"{partInventoryLbl.Text} requires a number");
                }
                else
                {
                    toolTip.SetToolTip((TextBox)sender, $"{partInventoryLbl.Text} is required");
                }
            }
            else if (((TextBox)sender).Equals(PriceTxtBox))
            {
                if (checkNumericTxtBox && !hasEmptyOrNullString(sender, e))
                {
                    toolTip.SetToolTip((TextBox)sender, $"{partInventoryLbl.Text} requires a number");
                }
                else
                {
                    toolTip.SetToolTip((TextBox)sender, $"{partInventoryLbl.Text} is required");
                }
            }
            else if (((TextBox)sender).Equals(MinTxtBox))
            {
                if (checkNumericTxtBox && !hasEmptyOrNullString(sender, e))
                {
                    toolTip.SetToolTip((TextBox)sender, $"{partInventoryLbl.Text} requires a number");
                }
                else
                {
                    toolTip.SetToolTip((TextBox)sender, $"{partInventoryLbl.Text} is required");
                }
            }
            else if (((TextBox)sender).Equals(MaxTxtBox))
            {
                if (checkNumericTxtBox && !hasEmptyOrNullString(sender, e))
                {
                    toolTip.SetToolTip((TextBox)sender, $"{partInventoryLbl.Text} requires a number");
                }
                else
                {
                    toolTip.SetToolTip((TextBox)sender, $"{partInventoryLbl.Text} is required");
                }
            }
            else if (((TextBox)sender).Equals(machineIDorCompanyNameTxtBox))
            {
                if (inHouseRdBtn.Checked)
                {
                    if (checkNumericTxtBox && !hasEmptyOrNullString(sender, e))
                    {
                        toolTip.SetToolTip((TextBox)sender, $"{partInventoryLbl.Text} requires a number");               
                    }
                    else
                    {
                        toolTip.SetToolTip((TextBox)sender, $"{partInventoryLbl.Text} is required");
                    }
                } else
                {
                    toolTip.SetToolTip((TextBox)sender, $"{partCompanyNameLbl.Text} is required");
                }
            }
        }

        //public bool validTextBoxText()
        //{
        //    foreach(var textBox in textBoxList)
        //    {
        //        try
        //        {
        //            Controller.Validate.ValidateNullorEmptyString(textBox.Text);
        //            if (Array.Exists(textBoxName, name => textBox.Name == name))
        //            {
        //                Validate.ValidateNumericInput(textBox);
        //            }
        //        }
        //        catch (NullReferenceException)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
    }
}
