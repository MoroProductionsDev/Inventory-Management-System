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
            }
            else if (selectedPart.GetType().Equals(typeof(Outsourced)))
            {
                partUC.Controls["machineIDorCompanyNameTxtBox"].Text = ((Outsourced)selectedPart).CompanyName;
            }
        }
    }
}
