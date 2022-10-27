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
        private static string[] tabPageNames = { "partsTabPage", "productsTabPage" };
        private Dictionary<string, Form> partForms;
        public SearchControlUC()
        {
            InitializeComponent();
        }

        private void searchLbl_Click(object sender, EventArgs e)
        {
            if (TabControlUC.tabControlUC_Instance.InventoryTbCtrl.SelectedTab.Name == tabPageNames[0])
            {
                var matchingIndex = Controller.Controller.searchForPartNameInTheInventory(searchTxtbox.Text.Trim());
                
                if(matchingIndex != -1)
                {
                    TabControlUC.tabControlUC_Instance.setPartsSelectedRowIndex(matchingIndex);
                }
            }
            else if (TabControlUC.tabControlUC_Instance.InventoryTbCtrl.SelectedTab.Name == tabPageNames[1])
            {
                var matchingIndex = Controller.Controller.searchForPartNameInTheInventory(searchTxtbox.Text.Trim());

                if (matchingIndex != -1)
                {
                    TabControlUC.tabControlUC_Instance.setProductsSelectedRowInd(matchingIndex);
                }
            }
        }
    }
}
