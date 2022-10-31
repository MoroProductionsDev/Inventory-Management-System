using Inventory_Managment_System.Controller;
using Inventory_Managment_System.Model;
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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void productUC_Load(object sender, EventArgs e)
        {
            UITextBoxValidator.modifyAllEmptyOrNullTextbox(productUC);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var isInhouseRdBtnChecked = false;

            //if (!productUC.productUCValidator.checkTextBoxesForEmptyString() 
            //    && productUC.productUCValidator.checkTextBoxesForNumericInput(isInhouseRdBtnChecked))
            //{
            //    if (isInhouseRdBtnChecked)
            //    {

            //        Controller.Controller.addInhousePartToInventory(in productUC);
            //    }
            //    else
            //    {
            //        Controller.Controller.addOutsourcedPartToInventory(in productUC);
            //    }
            //    TabControlUC.tabControlUC_Instance.recreateProductsDataTable();

            //    this.Close();
            //    Program.ShowInitialAppForm();
            //}
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.ShowInitialAppForm();
        }
    }
}
