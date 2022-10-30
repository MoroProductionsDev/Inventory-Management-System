using Inventory_Managment_System.Controller;

namespace Inventory_Managment_System.View
{
    public partial class MainForm : Form
    {
        //public static MainForm mainForm_Instance;
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Program.Exit();
        }
    }
}