﻿using System;
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
        private Dictionary<string, Form> partForms;
        private Dictionary<string, Form> productForms;
        public ModifcationControlsUC()
        {
            InitializeComponent();
            partForms = new Dictionary<string, Form>();
            productForms = new Dictionary<string, Form>();
        }
        private void addBtn_Click(object sender, EventArgs e) {
            closeAllPartsForms();
            closeAllProductsForms();
            if (TabControlUC.tabControlUC_Instance.InventoryTbCtrl.SelectedTab.Name == tabPageNames[0])
            {
                partForms["addPartForm"] = new AddPartForm(); // Form has to be added her to avoid opening disposed object
                partForms["addPartForm"].Show();
            }
            else if (TabControlUC.tabControlUC_Instance.InventoryTbCtrl.SelectedTab.Name == tabPageNames[1])
            {
                productForms["addProductForm"] = new AddProductForm(); // Form has to be added her to avoid opening disposed object
                productForms["addProductForm"].Show();
            }
        }
        private void modifyBtn_Click(object sender, EventArgs e)
        {
            closeAllPartsForms();
            closeAllProductsForms();
            if (TabControlUC.tabControlUC_Instance.InventoryTbCtrl.SelectedTab.Name == tabPageNames[0])
            {
                partForms["modifyPartForm"] = new ModifyPartForm(); // Form has to be added her to avoid opening disposed object
                partForms["modifyPartForm"].Show();
            }
            else if (TabControlUC.tabControlUC_Instance.InventoryTbCtrl.SelectedTab.Name == tabPageNames[1])
            {
                productForms["modifyProductForm"] = new ModifyProductForm(); // Form has to be added her to avoid opening disposed object
                productForms["modifyProductForm"].Show();
            }

        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {

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
