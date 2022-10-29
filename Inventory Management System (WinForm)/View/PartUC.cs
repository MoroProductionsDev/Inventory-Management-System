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
        public readonly string[] numericIntegerTextBoxName;
        private ToolTip toolTip; //to display the textbox tool messages

        // Enum type use to validate Textbox inputs.
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
            numericIntegerTextBoxName = new string[] {partInventoryTxtBox.Name,
                        partMinTxtBox.Name, partMaxTxtBox.Name };
        }


        private void PartUC_Load(object sender, EventArgs e)
        {
            machineIDorCompanyNameTxtBox.BackColor = Color.White;
            machineIDorCompanyNameTxtBox.Clear();
        }

        private void inHouseRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.partMachineIDLbl.Visible = true;
            this.partCompanyNameLbl.Visible = false;
            toolTip.RemoveAll();
        }

        private void outSourcedRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.partMachineIDLbl.Visible = false;
            this.partCompanyNameLbl.Visible = true;
            toolTip.RemoveAll();
            //machineIDorCompanyNameTxtBox.Clear();
            // covers scenerio when the radiobutton [Inhouse, Outsource] are toggle
            machineIDorCompanyNameTxtBox_TextChanged(sender, e);
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
            }
            else
            {
                modifyTextbox(sender, e, ValType.NullAndEmptyString);
            }
        }
        private void modifyTextbox(object sender, EventArgs e, ValType validationType)
        {
            if (sender.GetType().Equals(typeof(TextBox)))
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
                    }
                    else
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
            } else
            {
                // covers scenerio when the radiobutton [Inhouse, Outsource] are toggle
                displayTheIndicatedToolTip(machineIDorCompanyNameTxtBox, e, ValType.Decimal);
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
                else if (((TextBox)sender).Equals(machineIDorCompanyNameTxtBox) && outSourcedRdBtn.Checked)
                {
                    userInputVarName = partCompanyNameLbl.Text;
                }

                toolTip.SetToolTip((TextBox)sender, $"{userInputVarName} is required");
            }
            else if (validationType.Equals(ValType.Integer) || validationType.Equals(ValType.Decimal))
            {
                if (((TextBox)sender).Equals(partInventoryTxtBox))
                {
                    userInputVarName = partInventoryLbl.Text;
                }
                else if (((TextBox)sender).Equals(partMinTxtBox))
                {
                    userInputVarName = partMinLbl.Text;
                }
                else if (((TextBox)sender).Equals(partMaxTxtBox))
                {
                    userInputVarName = partMaxLbl.Text;
                }
                else if (((TextBox)sender).Equals(partPriceTxtBox))
                {
                    userInputVarName = partPriceLbl.Text;
                }
                else if (((TextBox)sender).Equals(machineIDorCompanyNameTxtBox) && inHouseRdBtn.Checked)
                {
                    userInputVarName = partMachineIDLbl.Text;
                }

                toolTip.SetToolTip((TextBox)sender, $"{userInputVarName} requires a number");
            } 
        }

        public bool checkTextBoxesForEmptyString()
        {
            bool hasEmptyStringOrNullValue = false;
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                if (textBox.Text == null || textBox.Text == String.Empty && textBox.ReadOnly == false) // readonly to skip the partID text box
                {
                    hasEmptyStringOrNullValue = true;
                    break;
                }
            }

            return hasEmptyStringOrNullValue;
        }

        public bool checkTextBoxesForNumericInput(bool isInhouseChecked)
        {
            bool isItNumeric = true;

            try
            {
                if (isInhouseChecked)
                {
                    int.Parse(machineIDorCompanyNameTxtBox.Text);
                }

                Decimal.Parse(partPriceTxtBox.Text);
            }
            catch (FormatException)
            {
                return false;
            }

            foreach (var textBox in getNumericTextBoxes())
            {
                if (!Controller.Validate.ValidateNumericInput(textBox.Text))
                {
                    isItNumeric = false;
                    break;
                }
            }
            return isItNumeric;
        }
        private List<TextBox> getNumericTextBoxes()
        {
            var numericTextBoxes = new List<TextBox>();

            foreach (var numericTextBoxName in numericIntegerTextBoxName)
            {
                numericTextBoxes.Add((TextBox) Controls[numericTextBoxName]);
            }

            return numericTextBoxes;
        }
    }
}
