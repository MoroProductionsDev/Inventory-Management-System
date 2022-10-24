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
            if (!partUC.hasEmptyStringOrNullTextBoxes() && partUC.areAllNumericInput())
            {
                if (((RadioButton)partUC.Controls["inHouseRdBtn"]).Checked)
                {

                    Controller.Controller.addInhousePartToInventory(in partUC);
                }
                else if (((RadioButton)partUC.Controls["outSourcedRdBtn"]).Checked)
                {
                    Controller.Controller.addOutsourcedPartToInventory(in partUC);
                }
                TabControlUC.tabControlUC_Instance.recreatePartsDataTable();
                
                this.Close();
                Program.ShowInitialAppForm();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.ShowInitialAppForm();
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
    }
}
