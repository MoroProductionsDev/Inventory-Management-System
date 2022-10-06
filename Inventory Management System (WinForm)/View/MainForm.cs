namespace Inventory_Managment_System.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StateMng.setState("partPage", this.tabControlUC.PartsPage);
        }


    }
}