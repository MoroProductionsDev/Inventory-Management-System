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
        public readonly TabControl InventoryTbCtrl;
        public readonly Dictionary<string, DataGridView> tableDataGridView;
       
        public TabControlUC()
        {
            InitializeComponent();
            tabControlUC_Instance = this;
            InventoryTbCtrl = this.inventoryTbCtrl;
            tableDataGridView = new Dictionary<string, DataGridView>() { {partsDataGridView.Name, partsDataGridView }, 
                                            {productsDataGridView.Name, productsDataGridView }};
        }

        private void tabControl_Load(object sender, EventArgs e)
        {
            Controller.Controller.createPartList();
            Controller.Controller.createProductList();

            insertDataInPartsTable();
            insertDataInProductsTable();
        }

        private void clearPartsDataTable()
        {
            partsDataGridView.Rows.Clear();
        }

        private void clearProductsDataTable()
        {
            productsDataGridView.Rows.Clear();
        }

        private void insertDataInPartsTable()
        {
            var partList = Inventory.AllParts;

            foreach (var part in partList)
            {
                this.partsDataGridView.Rows.Add(new object[] { part.PartID, part.Name, part.InStock,
                        part.Price, part.Min, part.Max
                });
            }
        }

        private void insertDataInProductsTable()
        {
            var productList = Inventory.Products;

            foreach (var product in productList)
            {
                this.productsDataGridView.Rows.Add(new object[] { product.ProductID, product.Name, product.InStock,
                product.Price, product.Min, product.Max
                });
            }
        }

        public void recreatePartsDataTable()
        {
            clearPartsDataTable();
            insertDataInPartsTable();
        }

        public void recreateProductsDataTable()
        {
            clearProductsDataTable();
            insertDataInProductsTable();
        }


        public int getPartsSelectedRowIndex()
        {
            var selectedRow = partsDataGridView.SelectedRows;
            var selectedRowIndex = selectedRow[0].Index;

            return selectedRowIndex;
        }

        public int getProductsSelectedRowIndex()
        {
            var selectedRow = productsDataGridView.SelectedRows;
            var selectedRowIndex = selectedRow[0].Index;

            return selectedRowIndex;
        }
    }
}
