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
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
        }
        private void partUC_Load(object sender, EventArgs e)
        {
            //partUC.Inventory.Text);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Save
            //AddInventoryPart();
            //data.addInventoryPart(in partUC);
            Controller.Controller.validateUITextBox(in partUC);
            //Controller.Controller.addInventoryPart(in partUC);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
