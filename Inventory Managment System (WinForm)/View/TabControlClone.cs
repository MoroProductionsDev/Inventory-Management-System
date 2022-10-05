//namespace Inventory_Managment_System.View
//{
//    partial class TabControl
//    {
//        /// <summary> 
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary> 
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Component Designer generated / modified code

//        /// <summary> 
//        /// Required method for Designer support - do not modify 
//        /// the contents of this method with the code editor.
//        /// </summary>
//        /// 

//        private void InitializeTabControlComponent()
//        {
//            // 
//            // inventoryTbCtrl
//            // 
//            // Creating a Tab View controller
//            this.inventoryTbCtrl = new System.Windows.Forms.TabControl();

//            // Layout & Style & Data and Behavior
//            this.inventoryTbCtrl.SuspendLayout();
//            this.inventoryTbCtrl.Location = new System.Drawing.Point(3, 3);
//            this.inventoryTbCtrl.Name = "inventoryTbCtrl";
//            this.inventoryTbCtrl.SelectedIndex = 0;
//            this.inventoryTbCtrl.Size = new System.Drawing.Size(616, 278);
//            this.inventoryTbCtrl.TabIndex = 1;

//            // Adding the partsTabePage and the productsTabPage to the inventoryTabController
//            this.inventoryTbCtrl.Controls.Add(this.partsTabPage);
//            this.inventoryTbCtrl.Controls.Add(this.productsTabPage);
//        }

//        private void InitializePartsPageComponent()
//        {
//            // 
//            // partsTabPage
//            // 
//            this.partsTabPage = new System.Windows.Forms.TabPage();

//            // Layout and Style and Attribute Data
//            this.partsTabPage.SuspendLayout();
//            this.partsTabPage.Location = new System.Drawing.Point(4, 24);
//            this.partsTabPage.Name = "partsTabPage";
//            this.partsTabPage.Padding = new System.Windows.Forms.Padding(3);
//            this.partsTabPage.Size = new System.Drawing.Size(608, 250);
//            this.partsTabPage.TabIndex = 0;
//            this.partsTabPage.Text = "Parts";
//            this.partsTabPage.UseVisualStyleBackColor = true;

//            // Adding the partsDataGridView to the partsTabPage
//            this.partsTabPage.Controls.Add(this.partsDataGridView);
//        }

//        private void InitializeProductsgeComponent()
//        {
//            // 
//            // productsTabPage
//            // 
//            this.productsTabPage = new System.Windows.Forms.TabPage();

//            this.productsTabPage.Location = new System.Drawing.Point(4, 24);
//            this.productsTabPage.Name = "productsTabPage";
//            this.productsTabPage.Padding = new System.Windows.Forms.Padding(3);
//            this.productsTabPage.Size = new System.Drawing.Size(609, 250);
//            this.productsTabPage.TabIndex = 1;
//            this.productsTabPage.Text = "Products";
//            this.productsTabPage.UseVisualStyleBackColor = true;

//            // Adding the productsDataGridView to the productsTabPage
//            this.productsTabPage.Controls.Add(this.productsDataGridView);
//        }

//        private void initializePartsDataView()
//        {
//            // Creating the [Parts] Data Grid View
//            this.partsDataGridView = new System.Windows.Forms.DataGridView();

//            // Layout & Style & Data and Behavior
//            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
//            this.SuspendLayout();

//            this.partsDataGridView.AllowUserToAddRows = false;
//            this.partsDataGridView.AllowUserToDeleteRows = false;
//            this.partsDataGridView.AllowUserToResizeColumns = false;

//            this.partsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.partsDataGridView.Location = new System.Drawing.Point(3, 3);
//            this.partsDataGridView.Name = "partsDataGridView";
//            this.partsDataGridView.ReadOnly = true;
//            this.partsDataGridView.RowHeadersVisible = false;
//            this.partsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
//            this.partsDataGridView.RowTemplate.Height = 25;
//            this.partsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
//            this.partsDataGridView.Size = new System.Drawing.Size(602, 244);
//            this.partsDataGridView.TabIndex = 0;

//            // Adding the [Parts] Data Grid View Columns to the header row.
//            this.partsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
//            this.column["partID"],
//            this.column["partName"],
//            this.column["partInventory"],
//            this.column["partPrice"],
//            this.column["partMin"],
//            this.column["partMax"]});

//        }

//        private void initializeProductsDataView()
//        {
//            // Creating the [Products] Data Grid View
//            this.productsDataGridView = new System.Windows.Forms.DataGridView();

//            // Layout & Style & Data and Behavior
//            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
//            this.SuspendLayout();
//            this.productsDataGridView.AllowUserToAddRows = false;
//            this.productsDataGridView.AllowUserToDeleteRows = false;
//            this.productsDataGridView.AllowUserToResizeColumns = false;

//            this.productsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.productsDataGridView.Location = new System.Drawing.Point(3, 3);
//            this.productsDataGridView.Name = "productsDataGridView";
//            this.productsDataGridView.ReadOnly = true;
//            this.productsDataGridView.RowHeadersVisible = false;
//            this.productsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
//            this.productsDataGridView.RowTemplate.Height = 25;
//            this.productsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
//            this.productsDataGridView.Size = new System.Drawing.Size(602, 244);
//            this.productsDataGridView.TabIndex = 0;


//            // Adding the [Products] Data Grid View Columns to the header row.
//            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
//            this.column["productID"],
//            this.column["productName"],
//            this.column["productInventory"],
//            this.column["productPrice"],
//            this.column["productMin"],
//            this.column["productMax"]});
//        }

//        public void InitializeDataViewColumnComponent()
//        {
//            this.column = new Dictionary<string, DataGridViewTextBoxColumn>();

//            // Creating Data Grid View  Columns for each table type
//            this.column.Add("partID", new System.Windows.Forms.DataGridViewTextBoxColumn());
//            this.column.Add("productID", new System.Windows.Forms.DataGridViewTextBoxColumn());

//            this.column.Add("partName", new System.Windows.Forms.DataGridViewTextBoxColumn());
//            this.column.Add("productName", new System.Windows.Forms.DataGridViewTextBoxColumn());

//            this.column.Add("partInventory", new System.Windows.Forms.DataGridViewTextBoxColumn());
//            this.column.Add("productInventory", new System.Windows.Forms.DataGridViewTextBoxColumn());

//            this.column.Add("partPrice", new System.Windows.Forms.DataGridViewTextBoxColumn());
//            this.column.Add("productPrice", new System.Windows.Forms.DataGridViewTextBoxColumn());

//            this.column.Add("partMin", new System.Windows.Forms.DataGridViewTextBoxColumn());
//            this.column.Add("productMin", new System.Windows.Forms.DataGridViewTextBoxColumn());

//            this.column.Add("partMax", new System.Windows.Forms.DataGridViewTextBoxColumn());
//            this.column.Add("productMax", new System.Windows.Forms.DataGridViewTextBoxColumn());

//            // 
//            // partID
//            // 
//            this.column["partID"].Frozen = true;
//            this.column["partID"].HeaderText = "Part ID";
//            this.column["partID"].MinimumWidth = 40;
//            this.column["partID"].Name = "partID";
//            this.column["partID"].ReadOnly = true;
//            this.column["partID"].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
//            this.column["partID"].Width = 80;
//            //
//            // productID
//            //
//            this.column["productID"].Frozen = true;
//            this.column["productID"].HeaderText = "Product ID";
//            this.column["productID"].MinimumWidth = 40;
//            this.column["productID"].Name = "productID";
//            this.column["productID"].ReadOnly = true;
//            this.column["productID"].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
//            this.column["productID"].Width = 80;
//            // 
//            // part Name
//            // 
//            this.column["partName"].Frozen = true;
//            this.column["partName"].HeaderText = "Name";
//            this.column["partName"].MinimumWidth = 40;
//            this.column["partName"].Name = "partName";
//            this.column["partName"].ReadOnly = true;
//            this.column["partName"].Width = 100;
//            // 
//            // product Name
//            // 
//            this.column["productName"].Frozen = true;
//            this.column["productName"].HeaderText = "Name";
//            this.column["productName"].MinimumWidth = 40;
//            this.column["productName"].Name = "productName";
//            this.column["productName"].ReadOnly = true;
//            this.column["productName"].Width = 100;
//            // 
//            // part Inventory
//            // 
//            this.column["partInventory"].Frozen = true;
//            this.column["partInventory"].HeaderText = "Inventory";
//            this.column["partInventory"].Name = "partInventory";
//            this.column["partInventory"].ReadOnly = true;
//            // 
//            // product Inventory
//            // 
//            this.column["productInventory"].Frozen = true;
//            this.column["productInventory"].HeaderText = "Inventory";
//            this.column["productInventory"].Name = "productInventory";
//            this.column["productInventory"].ReadOnly = true;
//            // 
//            // part Price
//            // 
//            this.column["partPrice"].Frozen = true;
//            this.column["partPrice"].HeaderText = "Inventory";
//            this.column["partPrice"].Name = "partPrice";
//            this.column["partPrice"].ReadOnly = true;
//            // 
//            // product Price
//            // 
//            this.column["productPrice"].Frozen = true;
//            this.column["productPrice"].HeaderText = "Inventory";
//            this.column["productPrice"].Name = "productPrice";
//            this.column["productPrice"].ReadOnly = true;
//            // 
//            // part Min
//            // 
//            this.column["partMin"].Frozen = true;
//            this.column["partMin"].HeaderText = "Inventory";
//            this.column["partMin"].Name = "partMin";
//            this.column["partMin"].ReadOnly = true;
//            // 
//            // product Min
//            // 
//            this.column["productMin"].Frozen = true;
//            this.column["productMin"].HeaderText = "Inventory";
//            this.column["productMin"].Name = "productMin";
//            this.column["productMin"].ReadOnly = true;
//            // 
//            // part Max
//            // 
//            this.column["partMax"].Frozen = true;
//            this.column["partMax"].HeaderText = "Inventory";
//            this.column["partMax"].Name = "partMax";
//            this.column["partMax"].ReadOnly = true;
//            // 
//            // product Max
//            // 
//            this.column["productMax"].Frozen = true;
//            this.column["productMax"].HeaderText = "Inventory";
//            this.column["productMax"].Name = "productMax";
//            this.column["productMax"].ReadOnly = true;
//        }
//        private void InitializeComponent()
//        {
//            InitializeDataViewColumnComponent();
//            initializePartsDataView();
//            initializeProductsDataView();
//            InitializePartsPageComponent();
//            InitializeProductsgeComponent();
//            InitializeTabControlComponent();

//            this.SuspendLayout();
//            // 
//            // TabControl
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.Controls.Add(this.inventoryTbCtrl);
//            this.Name = "TabControl";
//            this.Size = new System.Drawing.Size(636, 285);
//            this.inventoryTbCtrl.ResumeLayout(false);
//            this.partsTabPage.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
//            this.ResumeLayout(false);

//        }

//        // 

//        #endregion

//        private System.Windows.Forms.TabControl inventoryTbCtrl;
//        private TabPage partsTabPage;
//        private TabPage productsTabPage;
//        private DataGridView partsDataGridView;
//        private DataGridView productsDataGridView;
//        private Dictionary<string, DataGridViewTextBoxColumn> column;
//    }
//}
