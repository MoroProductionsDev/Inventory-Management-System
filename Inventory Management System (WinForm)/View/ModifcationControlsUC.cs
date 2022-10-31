using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private Dictionary<string, Form> partForms;
        private Dictionary<string, Form> productForms;
        private TabControl inventoryTabControl;
        private string[] tabPageNames;
        private readonly string[] tableNames = {"partsDataGridView", "productsDataGridView"};
        public ModifcationControlsUC()
        {
            InitializeComponent();
            partForms = new Dictionary<string, Form>();
            productForms = new Dictionary<string, Form>();
        }

        private void ModifcationControlsUC_Load(object sender, EventArgs e)
        {
            inventoryTabControl = (TabControl)TabControlUC.tabControlUC_Instance.Controls["InventoryTbCtrl"];
            tabPageNames = new string[] { inventoryTabControl.TabPages[0].Name, inventoryTabControl.TabPages[1].Name };
        }
        private void addBtn_Click(object sender, EventArgs e) {
            closeAllPartsForms();
            closeAllProductsForms();
            
            if (inventoryTabControl.SelectedTab.Name == tabPageNames[0])
            {
                partForms["addPartForm"] = new AddPartForm(); // Form has to be added her to avoid opening disposed object
                partForms["addPartForm"].Show();
                Program.HideInitialAppForm();
            }
            else if (inventoryTabControl.SelectedTab.Name == tabPageNames[1])
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
            if (inventoryTabControl.SelectedTab.Name == tabPageNames[0])
            {
                var obj = "part";
                var partsDataGridView = TabControlUC.tabControlUC_Instance.TableDataGridView[tableNames[0]];
                var selectedPartsRowIndex = UIDataGridViewValidator.getTableSelectedRowIndex(partsDataGridView);

                if (selectedPartsRowIndex != (int) UIDataGridViewValidator.IndexVal.Invalid)
                {
                    partForms["modifyPartForm"] = new ModifyPartForm(selectedPartsRowIndex); // Form has to be added her to avoid opening disposed object
                    partForms["modifyPartForm"].Show();
                    Program.HideInitialAppForm();
                }
                else
                {
                    UIMsgBox.displayUnselectedRowWarning(obj, action);
                }
            }
            else if (inventoryTabControl.SelectedTab.Name == tabPageNames[1])
            {
                var obj = "product";
                var productsDataGridView = TabControlUC.tabControlUC_Instance.TableDataGridView[tableNames[1]];

                var selectedProductsRowIndex = UIDataGridViewValidator.getTableSelectedRowIndex(productsDataGridView);

                if (selectedProductsRowIndex != (int) UIDataGridViewValidator.IndexVal.Invalid)
                {
                    productForms["modifyProductForm"] = new ModifyProductForm(selectedProductsRowIndex); // Form has to be added her to avoid opening disposed object
                    productForms["modifyProductForm"].Show();
                    Program.HideInitialAppForm();
                }
                else
                {
                    UIMsgBox.displayUnselectedRowWarning(obj, action);
                }
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            const string action = "delete";

            if (inventoryTabControl.SelectedTab.Name == tabPageNames[0])
            {
                var obj = "part";
                var partsDataGridView = TabControlUC.tabControlUC_Instance.TableDataGridView[tableNames[0]];
                var selectedPartsRowIndex = UIDataGridViewValidator.getTableSelectedRowIndex(partsDataGridView);

                if (selectedPartsRowIndex != (int) UIDataGridViewValidator.IndexVal.Invalid)
                {
                    var confirmedDeletion = UIMsgBox.displayDeletionWarning();

                    if (confirmedDeletion)
                    {
                        Controller.Controller.deletePartFromInventory(selectedPartsRowIndex);

                        UIDataGridViewValidator.recreateTableData(partsDataGridView, Inventory.AllParts);
                    }
                } else
                {
                    UIMsgBox.displayUnselectedRowWarning(obj, action);
                }
            }
            else if (inventoryTabControl.SelectedTab.Name == tabPageNames[1])
            {
                var obj = "product";
                var productsDataGridView = TabControlUC.tabControlUC_Instance.TableDataGridView[tableNames[1]];
                var selectedProductsRowIndex = UIDataGridViewValidator.getTableSelectedRowIndex(productsDataGridView);

                if (selectedProductsRowIndex != (int) UIDataGridViewValidator.IndexVal.Invalid)
                {
                    var confirmedDeletion = UIMsgBox.displayDeletionWarning();

                    if (confirmedDeletion)
                    {
                        //Controller.Controller.deleteProductFromInventory(selectedProductsRowIndex);
                        UIDataGridViewValidator.recreateTableData(productsDataGridView, Inventory.Products);
                    }
                } else
                {
                    UIMsgBox.displayUnselectedRowWarning(obj, action);
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
    }
}
