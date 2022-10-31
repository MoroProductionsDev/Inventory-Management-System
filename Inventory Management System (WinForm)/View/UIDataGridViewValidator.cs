using Inventory_Managment_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Inventory_Managment_System.View.TabControlUC;

namespace Inventory_Managment_System.View
{
    public static class UIDataGridViewValidator
    {
        public static void unselectRowInTable(in DataGridView dataGridView)
        {
            dataGridView.ClearSelection();
        }

        private static void clearTableData(in DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
        }

        public static int getTableSelectedRowIndex(in DataGridView dataGridView)
        {
            var selectedRow = dataGridView.SelectedRows;
            int selectedRowIndex;
            try
            {
                selectedRowIndex = selectedRow[0].Index;
            }
            catch (ArgumentOutOfRangeException)
            {
                selectedRowIndex = (int)IndexVal.Invalid;
            }

            return selectedRowIndex;
        }

        public static void setTableSelectedRowIndex(in DataGridView dataGridView, in int index)
        {
            dataGridView.Rows[index].Selected = true;
        }

        // Generic functions to make the function more dynamically adjustible.
        public static void insertDataInTable<Type>(in DataGridView dataGridView, in BindingList<Type> list)
        {
            if (list.GetType().Equals(typeof(BindingList<Part>)))
            {
                var partList = list.Cast<Part>();
                foreach (var part in partList)
                {
                    dataGridView.Rows.Add(new object[] {part.PartID, part.Name, part.InStock,
                        part.Price, part.Min, part.Max
                    });
                }
            } else if (list.GetType().Equals(typeof(BindingList<Part>)))
            {
                var productList = list.Cast<Product>();
                foreach (var product in productList)
                {
                    dataGridView.Rows.Add(new object[] {product.ProductID, product.Name, product.InStock,
                        product.Price, product.Min, product.Max
                    });
                }
            }
        }

        public static int findMatchingPart<Type>(in DataGridView dataGridView, in BindingList<Type> list, in string searchString)
        {
            bool found = false;
            int matchingRow = 0; // this will match the size of the partList

            if (list.GetType().Equals(typeof(BindingList<Part>)))
            {
                var partList = list.Cast<Part>();

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
            } else if (list.GetType().Equals(typeof(BindingList<Product>)))
            {
                var productList = list.Cast<Product>();

                foreach (var product in productList)
                {
                    if (product.Name.ToUpper().Contains(searchString.ToUpper()))
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
            }
            
            return matchingRow;
        }


        public static void recreateTableData<Type>(in DataGridView dataGridView, in BindingList<Type> list)
        {
            clearTableData(dataGridView);
            insertDataInTable(dataGridView, list);
            unselectRowInTable(dataGridView);
        }

        public static void recreateTableData<Type>(in DataGridView dataGridView, in BindingList<Type> list, in int index)
        {
            clearTableData(dataGridView);
            insertDataInTable(dataGridView, list);
            setTableSelectedRowIndex(dataGridView, index);
        }
    }
}
