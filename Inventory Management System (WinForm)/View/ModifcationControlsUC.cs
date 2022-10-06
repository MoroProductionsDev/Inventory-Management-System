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
        public ModifcationControlsUC()
        {
            InitializeComponent();
        }
        private void addBtn_Click(object sender, EventArgs e) {
            // StateMng.State["partPage"].;
            //if ( )
            //{
            //    var addPartForm = new AddPartForm();
            //    addPartForm.Show();

            //}
            //else if ()
            //{

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
