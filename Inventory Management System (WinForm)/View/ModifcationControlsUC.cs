using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Managment_System.Controller;
using Inventory_Managment_System.Model;
using Inventory_Managment_System.View;
using static Inventory_Managment_System.View.TabControlUC;

namespace Inventory_Managment_System.View
{
    public partial class ModifcationControlsUC : UserControl
    {
        private static string[] tabPageNames = {TabControlUC.tabControlUC_Instance.PartsPage.Name,
                                                TabControlUC.tabControlUC_Instance.ProductsPage.Name};
        private Dictionary<string, Form> partForms;
        private Dictionary<string, Form> productForms;
        public ModifcationControlsUC()
        {
            InitializeComponent();
            partForms = new Dictionary<string, Form>();
            productForms = new Dictionary<string, Form>();
        }
        private void addBtn_Click(object sender, EventArgs e) {
            closeAllPartsForms();
            closeAllProductsForms();
            if (TabControlUC.tabControlUC_Instance.InventoryTbCtrl.SelectedTab.Name == tabPageNames[0])
            {
                partForms["addPartForm"] = new AddPartForm(); // Form has to be added her to avoid opening disposed object
                partForms["addPartForm"].Show();
                Program.HideInitialAppForm();
            }
            else if (TabControlUC.tabControlUC_Instance.InventoryTbCtrl.SelectedTab.Name == tabPageNames[1])
            {
                productForms["addProductForm"] = new AddProductForm(); // Form has to be added her to avoid opening disposed object
                productForms["addProductForm"].Show();
                Program.HideInitialAppForm();
            }
        }
        private void modifyBtn_Click(object sender, EventArgs e)
        {
            const string action = "modify";

            closeAllPartsForms();
            closeAllProductsForms();
            if (TabControlUC.tabControlUC_Instance.InventoryTbCtrl.SelectedTab.Name == tabPageNames[0])
            {
                var selectedPartsRowIndex = TabControlUC.tabControlUC_Instance.getPartsSelectedRowIndex();

                if (selectedPartsRowIndex != (int)TabControlUC.IndexVal.Invalid)
                {
                    partForms["modifyPartForm"] = new ModifyPartForm(selectedPartsRowIndex); // Form has to be added her to avoid opening disposed object
                    partForms["modifyPartForm"].Show();
                    Program.HideInitialAppForm();
                }
                else
                {
                    displayUnselectedRowWarning(action);
                }
            }
            else if (TabControlUC.tabControlUC_Instance.InventoryTbCtrl.SelectedTab.Name == tabPageNames[1])
            {
                var selectedProductsRowIndex = TabControlUC.tabControlUC_Instance.getProductsSelectedRowIndex();

                if (selectedProductsRowIndex != (int)TabControlUC.IndexVal.Invalid)
                {
                    //productForms["modifyProductForm"] = new ModifyProductForm(selectedProductsRowIndex); // Form has to be added her to avoid opening disposed object
                    //productForms["modifyProductForm"].Show();
                    //Program.HideInitialAppForm();
                }
                else
                {
                    displayUnselectedRowWarning(action);
                }
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            const string action = "delete";

            if (TabControlUC.tabControlUC_Instance.InventoryTbCtrl.SelectedTab.Name == tabPageNames[0])
            {
                var selectedPartsRowIndex = TabControlUC.tabControlUC_Instance.getPartsSelectedRowIndex();

                if (selectedPartsRowIndex != (int) TabControlUC.IndexVal.Invalid)
                {
                    var confirmedDeletion = displayDeletionWarning();

                    if (confirmedDeletion)
                    {
                        Controller.Controller.deletePartFromInventory(selectedPartsRowIndex);
                        TabControlUC.tabControlUC_Instance.recreatePartsDataTable();
                    }
                } else
                {
                    displayUnselectedRowWarning(action);
                }
            }
            else if (TabControlUC.tabControlUC_Instance.InventoryTbCtrl.SelectedTab.Name == tabPageNames[1])
            {
                var selectedProductsRowIndex = TabControlUC.tabControlUC_Instance.getProductsSelectedRowIndex();

                if (selectedProductsRowIndex != (int)TabControlUC.IndexVal.Invalid)
                {
                    var confirmedDeletion = displayDeletionWarning();

                    if (confirmedDeletion)
                    {
                        //Controller.Controller.deletePartFromInventory(selectedProductsRowIndex);
                        TabControlUC.tabControlUC_Instance.recreateProductsDataTable();
                    }
                } else
                {
                    displayUnselectedRowWarning(action);
                }
            }
        }
        private void closeAllPartsForms()
        {
            foreach (var form in partForms)
            {
                form.Value.Close();
            }
        }

        private void closeAllProductsForms()
        {
            foreach (var form in productForms)
            {
                form.Value.Close();
            }
        }

        private bool displayDeletionWarning()
        {
            string warningMsg = "Are you sure you want to delete this part?";
            MessageBoxButtons msgBoxButtons = MessageBoxButtons.YesNo;

            var result = MessageBox.Show(warningMsg, "Warning", msgBoxButtons, MessageBoxIcon.Warning);

            return result == DialogResult.Yes;
        }

        public void displayUnselectedRowWarning(string action)
        {
            string informationMsg = $"Please select something to {action}.";
            MessageBoxButtons msgBoxButtons = MessageBoxButtons.OK;

            MessageBox.Show(informationMsg, "Information", msgBoxButtons, MessageBoxIcon.Information);
        }
    }
}
