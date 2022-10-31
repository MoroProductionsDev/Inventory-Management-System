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
       
        // Enum to identify the return from an unselected index row
        public enum IndexVal
        {
            Invalid = -1,
        }
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

            unselectRowInTable(this.partsDataGridView);
        }

        private void inventoryTbCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((TabControl)sender).SelectedIndex == 0)
            {
                unselectRowInTable(this.partsDataGridView);
            } else if (((TabControl)sender).SelectedIndex == 1)
            {
                unselectRowInTable(this.productsDataGridView);
            }
        }

        private void unselectRowInTable(DataGridView dataGridView)
        {
            dataGridView.ClearSelection();
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

        public int findMatchingPart(string searchString)
        {
            var partList = Inventory.AllParts;
            bool found = false;
            int matchingRow = 0; // this will match the size of the partList

            foreach (var part in partList)
            {
                if (part.Name.ToUpper().Contains(searchString.ToUpper()))
                {
                    found = true;
                    break;
                }
                ++matchingRow;
            }
            
            if (!found)
            {
                matchingRow = -1;
            }

            return matchingRow;
        }

        public void recreatePartsDataTable()
        {
            clearPartsDataTable();
            insertDataInPartsTable();
            unselectRowInTable(this.partsDataGridView);
        }

        public void recreatePartsDataTable(int index)
        {
            clearPartsDataTable();
            insertDataInPartsTable();
            setPartsSelectedRowIndex(index);
        }

        public void recreateProductsDataTable()
        {
            clearProductsDataTable();
            insertDataInProductsTable();
            unselectRowInTable(this.productsDataGridView);
        }

        public void recreateProductsDataTable(int index)
        {
            clearProductsDataTable();
            insertDataInProductsTable();
            setProductsSelectedRowIndex(index);
        }

        public int getPartsSelectedRowIndex()
        {
            var selectedRow = partsDataGridView.SelectedRows;
            int selectedRowIndex; 
            try
            {
                selectedRowIndex = selectedRow[0].Index;
            } catch (ArgumentOutOfRangeException)
            {
                selectedRowIndex = (int) IndexVal.Invalid;
            }

            return selectedRowIndex;
        }

        public int getProductsSelectedRowIndex()
        {
            var selectedRow = productsDataGridView.SelectedRows;
            int selectedRowIndex;
            try
            {
                selectedRowIndex = selectedRow[0].Index;
            }
            catch (ArgumentOutOfRangeException)
            {
                selectedRowIndex = (int) IndexVal.Invalid;
            }

            return selectedRowIndex;
        }

        public int getPartsRowCount()
        {
            return partsDataGridView.Rows.Count;
        }

        public int getProductsRowCount()
        {
            return productsDataGridView.Rows.Count;
        }

        public void setPartsSelectedRowIndex(in int index)
        {
            partsDataGridView.Rows[index].Selected = true;
        }
        public void setProductsSelectedRowIndex(in int index)
        {
            productsDataGridView.Rows[index].Selected = true;
        }
    }
}
