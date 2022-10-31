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

namespace Inventory_Managment_System.View
{
    public partial class SearchControlUC : UserControl
    {
        private static string[] tabPageNames = {TabControlUC.tabControlUC_Instance.PartsPage.Name,
                                                TabControlUC.tabControlUC_Instance.ProductsPage.Name};
        public SearchControlUC()
        {
            InitializeComponent();
        }

        private void searchLbl_Click(object sender, EventArgs e)
        {
            string searchString = searchTxtbox.Text.Trim();
            int matchingIndex = -1;

            if (TabControlUC.tabControlUC_Instance.InventoryTbCtrl.SelectedTab.Name == tabPageNames[0])
            {
                if (!string.IsNullOrEmpty(searchString))
                {
                    matchingIndex = Controller.Controller.searchForPartNameInTheInventory(searchString);
                }

                if (matchingIndex != -1)
                {
                    TabControlUC.tabControlUC_Instance.setPartsSelectedRowIndex(matchingIndex);
                } else
                {
                    TabControlUC.unselectRowInTable(TabControlUC.tabControlUC_Instance.tableDataGridView["partsDataGridView"]);
                }
            }
            else if (TabControlUC.tabControlUC_Instance.InventoryTbCtrl.SelectedTab.Name == tabPageNames[1])
            {
                if (!string.IsNullOrEmpty(searchString))
                {
                    matchingIndex = Controller.Controller.searchForProductNameInTheInventory(searchString);
                }

                if (matchingIndex != -1)
                {
                    TabControlUC.tabControlUC_Instance.setProductsSelectedRowIndex(matchingIndex);
                } else
                {
                    TabControlUC.unselectRowInTable(TabControlUC.tabControlUC_Instance.tableDataGridView["productsDataGridView"]);
                }
            }
        }
    }
}
