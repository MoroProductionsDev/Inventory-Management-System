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
        private Part selectedModifiablePart;
        bool switchedRadioButton; // stop if from triggering the radio button changed when the form load.
        public ModifyPartForm(in int rowIndex)
        {
            InitializeComponent();
            selectedRowIndex = rowIndex;
        }

        private void ModifyPartForm_Load(object sender, EventArgs e)
        {
            selectedModifiablePart = Controller.Controller.lookUpPartFromTheInventory(selectedRowIndex);
            partUC.Controls["partIDTxtBox"].Text = selectedModifiablePart.PartID.ToString();
            partUC.Controls["partNameTxtBox"].Text = selectedModifiablePart.Name;
            partUC.Controls["partInventoryTxtBox"].Text = selectedModifiablePart.InStock.ToString();
            partUC.Controls["partPriceTxtBox"].Text = selectedModifiablePart.Price.ToString();
            partUC.Controls["partMinTxtBox"].Text = selectedModifiablePart.Min.ToString();
            partUC.Controls["partMaxTxtBox"].Text = selectedModifiablePart.Max.ToString();

            if (selectedModifiablePart.GetType().Equals(typeof(Inhouse)))
            {
                partUC.Controls["machineIDorCompanyNameTxtBox"].Text = ((Inhouse)selectedModifiablePart).MachineID.ToString();
                partUC.Controls["inHouseRdBtn"].Select();
            }
            else if (selectedModifiablePart.GetType().Equals(typeof(Outsourced)))
            {
                partUC.Controls["machineIDorCompanyNameTxtBox"].Text = ((Outsourced)selectedModifiablePart).CompanyName;
                partUC.Controls["outSourcedRdBtn"].Select();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var isInhouseRdBtnChecked = ((RadioButton)partUC.Controls["inHouseRdBtn"]).Checked;
            var isOutsourcedRdBtnChecked = ((RadioButton)partUC.Controls["outSourcedRdBtn"]).Checked;

            if (!UIValidator.checkTextBoxesForEmptyString(partUC) && partUC.partUCValidator.checkTextBoxesForNumericInput(isInhouseRdBtnChecked))
            {
                var selectedPartsRowIndex = TabControlUC.tabControlUC_Instance.getPartsSelectedRowIndex();
                if (isInhouseRdBtnChecked)
                {
                    Controller.Controller.updateInhousePartToInventory(in selectedPartsRowIndex, in partUC);
                }
                else if (isOutsourcedRdBtnChecked)
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


        private void inHouseRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.partUC.Controls["partMachineIDLbl"].Visible = true;
            this.partUC.Controls["partCompanyNameLbl"].Visible = false;
            partUC.partUCValidator.toolTip.RemoveAll();

            if (switchedRadioButton)
            {
                ((TextBox)this.partUC.Controls["machineIDorCompanyNameTxtBox"]).Clear();
            }
            switchedRadioButton = true;
        }

        private void outSourcedRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.partUC.Controls["partMachineIDLbl"].Visible = false;
            this.partUC.Controls["partCompanyNameLbl"].Visible = true;
            partUC.partUCValidator.toolTip.RemoveAll();
            //((TextBox)this.partUC.Controls["machineIDorCompanyNameTxtBox"]).Clear();

            if (switchedRadioButton)
            {
                ((TextBox)this.partUC.Controls["machineIDorCompanyNameTxtBox"]).Clear();
            }
            switchedRadioButton = true;
        }
    }
}
