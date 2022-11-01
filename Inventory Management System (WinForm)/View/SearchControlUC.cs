using Inventory_Managment_System.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Managment_System.View
{
    public partial class SearchControlUC : UserControl
    {
        private TabControl inventoryTabControl;
        private string[] tabPageNames;
        public readonly string[] tableNames = { "partsDataGridView", "productsDataGridView" };
        public SearchControlUC()
        {
            InitializeComponent();
        }
        private void SearchControlUC_Load(object sender, EventArgs e)
        {
            inventoryTabControl = TabControlUC.tabControlUC_Instance.InventoryTabControl;
            tabPageNames = new string[] { inventoryTabControl.TabPages[0].Name, inventoryTabControl.TabPages[1].Name };
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchString = searchTxtbox.Text.Trim();
            int matchingIndex = -1;

            if (inventoryTabControl.SelectedTab.Name == tabPageNames[0])
            {
                var partsDataGridView = TabControlUC.tabControlUC_Instance.TableDataGridView[tableNames[0]];

                if (!string.IsNullOrEmpty(searchString))
                {
                    matchingIndex = Controller.Controller.searchForPartNameInTheInventory(partsDataGridView, searchString);
                }

                if (matchingIndex != -1)
                {
                    UIDataGridViewValidator.setTableSelectedRowIndex(partsDataGridView, matchingIndex);
                } else
                {
                    UIDataGridViewValidator.unselectRowInTable(partsDataGridView);
                }
            }
            else if (inventoryTabControl.SelectedTab.Name == tabPageNames[1])
            {
                var productsDataGridView = TabControlUC.tabControlUC_Instance.TableDataGridView[tableNames[1]];

                if (!string.IsNullOrEmpty(searchString))
                {
                    matchingIndex = Controller.Controller.searchForProductNameInTheInventory(productsDataGridView, searchString);
                }

                if (matchingIndex != -1)
                {
                    UIDataGridViewValidator.setTableSelectedRowIndex(productsDataGridView, matchingIndex);
                } else
                {
                    UIDataGridViewValidator.unselectRowInTable(productsDataGridView);
                }
            }
        }
    }
}
