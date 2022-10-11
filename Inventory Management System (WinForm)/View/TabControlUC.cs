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
        public TabControl InventoryTbCtrl;
        private readonly static Data data = Controller.Controller.Data; // Data use by the Controller
        public TabControlUC()
        {
            InitializeComponent();
            tabControlUC_Instance = this;
            InventoryTbCtrl = this.inventoryTbCtrl;
        }

        private void tabControl_Load(object sender, EventArgs e)
        {
            var partList = data.PartList;
            var productList = data.ProductList;

            foreach (var part in partList)
            {
                this.partsDataGridView.Rows.Add(new object[] { part.PartID, part.Name, part.InStock,
                        part.Price, part.Min, part.Max
                });
            }

            foreach (var product in productList)
            {
                this.productsDataGridView.Rows.Add(new object[] { product.ProductID, product.Name, product.InStock,
                product.Price, product.Min, product.Max
                });
            }
        }
    }
}
