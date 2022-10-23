using Inventory_Managment_System.Controller;
using Inventory_Managment_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System.View
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
        }
        private void partUC_Load(object sender, EventArgs e)
        {
            modifyAllEmptyOrNullTextbox();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!hasEmptyStringOrNullTextBoxes() && areAllNumericInput())
            {
            }
                // Save
            if (((RadioButton)partUC.Controls["inHouseRdBtn"]).Checked) {

                    Controller.Controller.addInhousePartToInventory(in partUC);
            } 
            else if (((RadioButton)partUC.Controls["outSourcedRdBtn"]).Checked)
            {
                Controller.Controller.addOutsourcedPartToInventory(in partUC);
            }
            //AddInventoryPart();
            //data.addInventoryPart(in partUC);
            //Controller.Controller.validateUITextBox(in partUC);
            //Controller.Controller.addInventoryPart(in partUC);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyAllEmptyOrNullTextbox()
        {
            foreach (var textBox in partUC.Controls.OfType<TextBox>())
            {
                if (textBox.Text == null || textBox.Text == String.Empty && textBox.ReadOnly == false)
                {
                    textBox.BackColor = Color.OrangeRed;
                }
            }
        }
        private bool hasEmptyStringOrNullTextBoxes()
        {
            bool hasEmptyStringOrNullValue = false;
            foreach (var textBox in partUC.Controls.OfType<TextBox>())
            {
                if (textBox.Text == null || textBox.Text == String.Empty && textBox.ReadOnly == false) // readonly to skip the partID text box
                {
                    hasEmptyStringOrNullValue = true;
                    break;
                }
            }

            return hasEmptyStringOrNullValue;
        }

        private bool areAllNumericInput()
        {
            bool isItNumeric = true;

            try
            {
                Decimal.Parse(partUC.Controls["partPriceTxtBox"].Text);
            } catch(FormatException)
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

            foreach (var numericTextBoxName in partUC.numericIntegerTextBoxName)
            {
                numericTextBoxes.Add((TextBox)partUC.Controls[numericTextBoxName]);
            }

            return numericTextBoxes;
        }
    }
}
