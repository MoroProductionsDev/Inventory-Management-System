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
        private List<TextBox> textBoxList;

        public readonly String[] numericIntegerTextBoxName;

        private ToolTip toolTip; //to display the textbox tool messages

        private enum ValType
        {
            NullAndEmptyString,
            Integer,
            Decimal
        }
        public PartUC()
        {
            InitializeComponent();
            toolTip = new ToolTip();
            textBoxList = new List<TextBox>() { partNameTxtBox, partInventoryTxtBox,
                partPriceTxtBox, partMinTxtBox, partMaxTxtBox };
            numericIntegerTextBoxName = new String[] {partInventoryTxtBox.Name,
                        partMinTxtBox.Name, partMaxTxtBox.Name };
        }

        private void inHouseRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.partMachineIDLbl.Visible = true;
            this.partCompanyNameLbl.Visible = false;
            toolTip.RemoveAll();
            //machineIDorCompanyNameTxtBox.BackColor = Color.White;
            machineIDorCompanyNameTxtBox.Clear();
        }

        private void outSourcedRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.partMachineIDLbl.Visible = false;
            this.partCompanyNameLbl.Visible = true;
            toolTip.RemoveAll();
            //machineIDorCompanyNameTxtBox.BackColor = Color.White;
            machineIDorCompanyNameTxtBox.Clear();
        }

        private void partNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            modifyTextbox(sender, e, ValType.NullAndEmptyString);
        }

        private void partInventoryTxtBox_TextChanged(object sender, EventArgs e)
        {
           modifyTextbox(sender, e, ValType.Integer);
        }

        private void partPriceTxtBox_TextChanged(object sender, EventArgs e)
        {
            modifyTextbox(sender, e, ValType.Decimal);
        }

        private void partMinTxtBox_TextChanged(object sender, EventArgs e)
        {
            modifyTextbox(sender, e, ValType.Integer);
        }

        private void partMaxTxtBox_TextChanged(object sender, EventArgs e)
        {
            modifyTextbox(sender, e, ValType.Integer);
        }

        private void machineIDorCompanyNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (inHouseRdBtn.Checked)
            {
                modifyTextbox(sender, e, ValType.Integer);
            } else
            {
                modifyTextbox(sender, e, ValType.NullAndEmptyString);
            }            
        }
        private void modifyTextbox(object sender, EventArgs e, ValType validationType)
        {
            if (validationType.Equals(ValType.NullAndEmptyString))
            {
                if (!hasEmptyOrNullString(sender, e))
                {
                    ((TextBox)sender).BackColor = Color.White;
                }
                else
                {
                    ((TextBox)sender).BackColor = Color.OrangeRed;
                    displayTheIndicatedToolTip(sender, e, ValType.NullAndEmptyString);
                }
            } 
            else if (validationType.Equals(ValType.Integer))
            {
                if (!hasEmptyOrNullString(sender, e) && hasIntegerNumericInput(sender, e))
                {
                    ((TextBox)sender).BackColor = Color.White;
                } else
                {
                    ((TextBox)sender).BackColor = Color.OrangeRed;
                    displayTheIndicatedToolTip(sender, e, ValType.Integer);
                }
            } 
            else if (validationType.Equals(ValType.Decimal))
            {
                if (!hasEmptyOrNullString(sender, e) && hasDecimalNumericInput(sender, e))
                {
                    ((TextBox)sender).BackColor = Color.White;
                }
                else
                {
                    ((TextBox)sender).BackColor = Color.OrangeRed;
                    displayTheIndicatedToolTip(sender, e, ValType.Decimal);
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

        private bool hasIntegerNumericInput(object sender, EventArgs e)
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

        private bool hasDecimalNumericInput(object sender, EventArgs e)
        {
            bool isItADecimal;
            try
            {
                Decimal.Parse(((TextBox) sender).Text);
                isItADecimal = true;
            }
            catch (FormatException)
            {
                isItADecimal = false;
            }
            return isItADecimal;
        }

        private void displayTheIndicatedToolTip(object sender, EventArgs e, ValType validationType)
        {
            string userInputVarName = null;
            if (validationType.Equals(ValType.NullAndEmptyString))
            {
                if (((TextBox)sender).Equals(partNameTxtBox))
                {
                    userInputVarName = partNameLbl.Text;
                }
                toolTip.SetToolTip((TextBox)sender, $"{userInputVarName} is required");
            }
            else if (validationType.Equals(ValType.Integer) || validationType.Equals(ValType.Decimal))
            {
                if (((TextBox)sender).Equals(partInventoryTxtBox))
                {
                    userInputVarName = partInventoryLbl.Text;
                } 
                else if (((TextBox)sender).Equals(partMinTxtBox.Text))
                {
                    userInputVarName = partMinTxtBox.Text;
                }
                else if (((TextBox)sender).Equals(partMaxTxtBox.Text))
                {
                    userInputVarName = partMaxTxtBox.Text;
                }
                else if (((TextBox)sender).Equals(partPriceTxtBox))
                {
                    userInputVarName = partPriceLbl.Text;
                }

                toolTip.SetToolTip((TextBox)sender, $"{userInputVarName} requires a number");
            } 
        }

        //public bool validTextBoxText()
        //{
        //    foreach(var textBox in textBoxList)
        //    {
        //        try
        //        {
        //            Controller.Validate.ValidateNullorEmptyString(textBox.Text);
        //            if (Array.Exists(numericIntegerTextBoxName, name => textBox.Name == name))
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
