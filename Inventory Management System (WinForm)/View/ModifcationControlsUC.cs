using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Managment_System.View;

namespace Inventory_Managment_System.View
{
    public partial class ModifcationControlsUC : UserControl
    {
        private static string[] tabPageNames = { "partsTabPage", "productsTabPage" };
        public ModifcationControlsUC()
        {
            InitializeComponent();
        }
        private void addBtn_Click(object sender, EventArgs e) {

            if (TabControlUC.Instance.InventoryTbCtrl.SelectedTab.Name == tabPageNames[0])
            {
                var addPartForm = new AddPartForm();
                addPartForm.Show();

            }
            //else if (TabControlUC.Instance.InventoryTbCtrl.SelectedTab.Name == tabPageNames[1])
            //{
            //    var addProductForm = new AddProductForm();
            //    AddProductForm.Show();
            //}
        }
        private void modifyBtn_Click(object sender, EventArgs e)
        {
            var modifyPartForm = new ModifyPartForm();
            modifyPartForm.Show();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
