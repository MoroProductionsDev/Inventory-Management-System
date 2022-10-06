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
    public partial class TabControlUC : UserControl
    {
        public TabControlUC()
        {
            InitializeComponent();
        }

        private void tabControl_Load(object sender, EventArgs e)
        {
            loadDataTable();
        }

        private void loadDataTable()
        {
            var partList = new BindingList<Part>();
            partList.Add(new Inhouse(133, "screw", 3.99M, 1, 1, 2));
            partList.Add(new Inhouse(224, "nail", 10.34M, 3, 5, 10));
            partList.Add(new Inhouse(332, "hammer", 3.99M, 5, 4, 8));
            partList.Add(new Inhouse(578, "brush", 2.45M, 2, 3, 3));

            partList.Add(new Outsourced("Lowes", "fence", 3.99M, 1, 1, 2));
            partList.Add(new Outsourced("Home Depot", "block", 10.34M, 3, 5, 10));
            partList.Add(new Outsourced("Intel", "Silicon Chip", 659.99M, 5, 4, 8));
            partList.Add(new Outsourced("Asus", "MotherBoard", 479.98M, 2, 3, 3));

            foreach (var part in partList)
            {
                this.partsDataGridView.Rows.Add(new object[] { part.PartID, part.Name, part.InStock,
                    part.Price, part.Min, part.Max });
            }
        }
    }
}
