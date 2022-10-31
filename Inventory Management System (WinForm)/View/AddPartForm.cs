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
            UIValidator.modifyAllEmptyOrNullTextbox(partUC);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var isInhouseRdBtnChecked = ((RadioButton)partUC.Controls["inHouseRdBtn"]).Checked;

            if (!UIValidator.checkTextBoxesForEmptyString(partUC) && partUC.partUCValidator.checkTextBoxesForNumericInput(isInhouseRdBtnChecked))
            {
                if (isInhouseRdBtnChecked)
                {
                    Controller.Controller.addInhousePartToInventory(in partUC);
                }
                else
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
    }
}
