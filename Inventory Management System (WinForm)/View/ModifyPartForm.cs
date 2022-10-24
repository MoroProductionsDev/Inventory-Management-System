using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Managment_System.Controller;
using Inventory_Managment_System.Model;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Inventory_Managment_System.View
{
    public partial class ModifyPartForm : Form
    {
        private readonly int selectedRowIndex;
        public ModifyPartForm(in int rowIndex)
        {
            InitializeComponent();
            selectedRowIndex = rowIndex;
        }

        private void ModifyPartForm_Load(object sender, EventArgs e)
        {
            Part selectedPart = Controller.Controller.lookUpPartFromTheInventory(selectedRowIndex);
            partUC.Controls["partIDTxtBox"].Text = selectedPart.PartID.ToString();
            partUC.Controls["partNameTxtBox"].Text = selectedPart.Name;
            partUC.Controls["partInventoryTxtBox"].Text = selectedPart.InStock.ToString();
            partUC.Controls["partPriceTxtBox"].Text = selectedPart.Price.ToString();
            partUC.Controls["partMinTxtBox"].Text = selectedPart.Min.ToString();
            partUC.Controls["partMaxTxtBox"].Text = selectedPart.Max.ToString();

            if (selectedPart.GetType().Equals(typeof(Inhouse)))
            {
                partUC.Controls["machineIDorCompanyNameTxtBox"].Text = ((Inhouse)selectedPart).MachineID.ToString();
                partUC.Controls["inHouseRdBtn"].Select();
                partUC.Controls["outSourcedRdBtn"].Enabled = false;
            }
            else if (selectedPart.GetType().Equals(typeof(Outsourced)))
            {
                partUC.Controls["machineIDorCompanyNameTxtBox"].Text = ((Outsourced)selectedPart).CompanyName;
                partUC.Controls["outSourcedRdBtn"].Select();
                partUC.Controls["inHouseRdBtn"].Enabled = false;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var isInhouseRdBtnChecked = ((RadioButton)partUC.Controls["inHouseRdBtn"]).Checked;

            if (!partUC.checkTextBoxesForEmptyString() && partUC.checkTextBoxesForNumericInput(isInhouseRdBtnChecked))
            {
                var selectedPartsRowIndex = TabControlUC.tabControlUC_Instance.getPartsSelectedRowIndex();
                if (isInhouseRdBtnChecked)
                {
                    Controller.Controller.updateInhousePartToInventory(in selectedPartsRowIndex, in partUC);
                }
                else
                {
                    Controller.Controller.updateOutsourcedPartToInventory(in selectedPartsRowIndex, in partUC);
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
