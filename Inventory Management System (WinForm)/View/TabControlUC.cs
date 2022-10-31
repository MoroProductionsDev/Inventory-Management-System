using Inventory_Managment_System.Model;
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
    public partial class TabControlUC : UserControl
    {
        public static TabControlUC tabControlUC_Instance;
        public Dictionary<string, DataGridView> TableDataGridView { get; private set; } // this will keep the dataGridView instance of the TabControl User Control
        public TabControl InventoryTabControl { get; private set; }
        // Enum to identify the return from an unselected index row
        public TabControlUC()
        {
            InitializeComponent();
            tabControlUC_Instance = this;
            TableDataGridView = new Dictionary<string, DataGridView>() { {partsDataGridView.Name, partsDataGridView }, 
                                                                    {productsDataGridView.Name, productsDataGridView }};
            InventoryTabControl = inventoryTbCtrl;
        }

        private void tabControl_Load(object sender, EventArgs e)
        {
            Controller.Controller.createPartList();
            Controller.Controller.createProductList();

            UIDataGridViewValidator.insertDataInTable(partsDataGridView, Inventory.AllParts);
            UIDataGridViewValidator.insertDataInTable(productsDataGridView, Inventory.Products);

            UIDataGridViewValidator.unselectRowInTable(partsDataGridView);
        }

        private void inventoryTbCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((TabControl)sender).SelectedIndex == 0)
            {
                UIDataGridViewValidator.unselectRowInTable(this.partsDataGridView);
            }
            else if (((TabControl)sender).SelectedIndex == 1)
            {
                UIDataGridViewValidator.unselectRowInTable(this.productsDataGridView);
            }
        }
    }
}
