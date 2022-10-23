using System;
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
    public partial class ModifyPartForm : Form
    {
        private readonly Dictionary<string, string> textBoxesValues;
        public ModifyPartForm(Dictionary<string, string> selectedRowCellValues)
        {
            InitializeComponent();
            textBoxesValues = selectedRowCellValues;
        }

        private void ModifyPartForm_Load(object sender, EventArgs e)
        {
            foreach (string key in textBoxesValues.Keys)
            {
                partUC.Controls[$"{key}TxtBox"].Text = textBoxesValues[key];
            }
        }
    }
}
