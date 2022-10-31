using Inventory_Managment_System.Model;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System.View
{
    public class UITextBoxValidator
    {
        private dynamic userControl; // This will be the partUC or the productUC (User Controller)s
        public static readonly Color validTextBox_Color = Color.White;
        public static readonly Color invalidTextBox_Color = Color.OrangeRed;
        public readonly ToolTip toolTip; //to display the textbox tool message
        public readonly string[] ucNumericIntegerTextBoxNames;
        private bool validatingPartUC;
        private List<TextBox> ucTextBoxList;
        private List<Label> ucLabelList;

        public enum ValType
        {
            NullAndEmptyString,
            Integer,
            Decimal
        }

        private enum Prop
        {
            Name = 0,
            Inventory = 1,
            Price = 2,
            Min = 3,
            Max = 4,
        }

        public UITextBoxValidator(UserControl uc)
        {
            toolTip = new ToolTip();

            if (uc.GetType() == typeof(PartUC))
            {
                this.userControl = (PartUC)uc;
                ucTextBoxList = new List<TextBox>() { userControl.Controls["partNameTxtBox"], userControl.Controls["partInventoryTxtBox"],
                                userControl.Controls["partPriceTxtBox"], userControl.Controls["partMinTxtBox"], userControl.Controls["partMaxTxtBox"]};

                ucLabelList = new List<Label>() { userControl.Controls["partNameLbl"], userControl.Controls["partInventoryLbl"],
                                userControl.Controls["partPriceLbl"], userControl.Controls["partMinLbl"], userControl.Controls["partMaxLbl"] };

                ucNumericIntegerTextBoxNames = new string[] {userControl.Controls["partInventoryTxtBox"].Name,
                        userControl.Controls["partMinTxtBox"].Name, userControl.Controls["partMaxTxtBox"].Name };
                
                validatingPartUC = true;

            } else if (uc.GetType() == typeof(ProductUC))
            {
                this.userControl = (ProductUC) uc;
                ucTextBoxList = new List<TextBox>() { userControl.Controls["productNameTxtBox"], userControl.Controls["productInventoryTxtBox"],
                                userControl.Controls["productPriceTxtBox"], userControl.Controls["productMinTxtBox"], userControl.Controls["productMaxTxtBox"]};
                ucLabelList = new List<Label>() { userControl.Controls["productNameLbl"], userControl.Controls["productInventoryLbl"],
                                userControl.Controls["productPriceLbl"], userControl.Controls["productMinLbl"], userControl.Controls["productMaxLbl"]};

                ucNumericIntegerTextBoxNames = new string[] {userControl.Controls["productInventoryTxtBox"].Name,
                        userControl.Controls["productMinTxtBox"].Name, userControl.Controls["productMaxTxtBox"].Name};

                validatingPartUC = false;
            }
        }


        public void modifyTextbox(object sender, EventArgs e, ValType validationType)
        {
            if (sender.GetType().Equals(typeof(TextBox)))
            {
                if (validationType.Equals(ValType.NullAndEmptyString))
                {
                    if (!hasEmptyOrNullString(sender, e))
                    {
                        ((TextBox)sender).BackColor = validTextBox_Color;
                    }
                    else
                    {
                        ((TextBox)sender).BackColor = invalidTextBox_Color;
                        displayTheIndicatedToolTip(sender, e, ValType.NullAndEmptyString);
                    }
                }
                else if (validationType.Equals(ValType.Integer))
                {
                    if (!hasEmptyOrNullString(sender, e) && hasIntegerNumericInput(sender, e))
                    {
                        ((TextBox)sender).BackColor = validTextBox_Color;
                    }
                    else
                    {
                        ((TextBox)sender).BackColor = invalidTextBox_Color;
                        displayTheIndicatedToolTip(sender, e, ValType.Integer);
                    }
                }
                else if (validationType.Equals(ValType.Decimal))
                {
                    if (!hasEmptyOrNullString(sender, e) && hasDecimalNumericInput(sender, e))
                    {
                        ((TextBox)sender).BackColor = validTextBox_Color;
                    }
                    else
                    {
                        ((TextBox)sender).BackColor = invalidTextBox_Color;
                        displayTheIndicatedToolTip(sender, e, ValType.Decimal);
                    }
                }
            }
            else
            {
                // covers scenerio when the radiobutton [Inhouse, Outsource] are toggle
                displayTheIndicatedToolTip(userControl.Controls["machineIDorCompanyNameTxtBox"], e, ValType.Decimal);
            }
        }

        public bool checkTextBoxesForNumericInput(bool isInhouseChecked)
        {
            bool isItNumeric = true;

            try
            {
                if (validatingPartUC && isInhouseChecked)
                {
                    int.Parse(userControl.Controls["machineIDorCompanyNameTxtBox"].Text);
                }

                Decimal.Parse(ucTextBoxList[(int)Prop.Price].Text);
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

        public static bool checkTextBoxesForEmptyString(UserControl uc)
        {
            bool hasEmptyStringOrNullValue = false;
            foreach (var textBox in uc.Controls.OfType<TextBox>())
            {
                if (textBox.Text == null || textBox.Text == String.Empty && textBox.ReadOnly == false) // readonly to skip the partID text box
                {
                    hasEmptyStringOrNullValue = true;
                    break;
                }
            }

            return hasEmptyStringOrNullValue;
        }

        public static void modifyAllEmptyOrNullTextbox(UserControl uc)
        {
            foreach (var textBox in uc.Controls.OfType<TextBox>())
            {
                if (textBox.Text == null || textBox.Text == String.Empty && textBox.ReadOnly == false)
                {
                    textBox.BackColor = invalidTextBox_Color;
                }
            }
        }
        //--------------------------------------------------------------------

        private bool hasEmptyOrNullString(object sender, EventArgs e)
        {
            bool isItEmptyOrNull = true;
            if (sender.GetType().Equals(typeof(TextBox)))
            {
                try
                {
                    Controller.Validate.ValidateNullorEmptyString(((TextBox)sender).Text);
                    isItEmptyOrNull = false;

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
                Decimal.Parse(((TextBox)sender).Text);
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
                if (((TextBox)sender).Equals(ucTextBoxList[(int) Prop.Name]))
                {
                    userInputVarName = ucLabelList[(int) Prop.Name].Text;
                }
                else if (validatingPartUC && ((TextBox)sender).Equals(userControl.Controls["machineIDorCompanyNameTxtBox"]) 
                    && userControl.Controls["outSourcedRdBtn"].Checked)
                {
                    userInputVarName = userControl.Controls["partCompanyNameLbl"].Text;
                }

                toolTip.SetToolTip((TextBox)sender, $"{userInputVarName} is required");
            }
            else if (validationType.Equals(ValType.Integer) || validationType.Equals(ValType.Decimal))
            {
                if (((TextBox)sender).Equals(ucTextBoxList[(int) Prop.Inventory])) 
                {
                    userInputVarName = ucLabelList[(int) Prop.Inventory].Text;
                }
                else if (((TextBox)sender).Equals(ucTextBoxList[(int) Prop.Min]))
                {
                    userInputVarName = ucLabelList[(int) Prop.Min].Text;
                }
                else if (((TextBox)sender).Equals(ucTextBoxList[(int) Prop.Max]))
                {
                    userInputVarName = ucLabelList[(int) Prop.Max].Text;
                }
                else if (((TextBox)sender).Equals(ucTextBoxList[(int) Prop.Price]))
                {
                    userInputVarName = ucLabelList[(int) Prop.Price].Text;
                }
                else if (validatingPartUC && ((TextBox)sender).Equals(userControl.Controls["machineIDorCompanyNameTxtBox"]) 
                        && userControl.Controls["inHouseRdBtn"].Checked)
                {
                    userInputVarName = userControl.Controls["partMachineIDLbl"].Text;
                }

                toolTip.SetToolTip((TextBox)sender, $"{userInputVarName} requires a number");
            }
        }
        
        private List<TextBox> getNumericTextBoxes()
        {
            var numericTextBoxes = new List<TextBox>();

            foreach (var numericTextBoxName in ucNumericIntegerTextBoxNames)
            {
                numericTextBoxes.Add((TextBox)userControl.Controls[numericTextBoxName]);
            }

            return numericTextBoxes;
        }
    }
}
