namespace Inventory_Managment_System.View
{
    partial class ProductUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle tableDataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.productMaxTxtBox = new System.Windows.Forms.TextBox();
            this.productMinTxtBox = new System.Windows.Forms.TextBox();
            this.productPriceTxtBox = new System.Windows.Forms.TextBox();
            this.productInventoryTxtBox = new System.Windows.Forms.TextBox();
            this.productNameTxtBox = new System.Windows.Forms.TextBox();
            this.productIDTxtBox = new System.Windows.Forms.TextBox();
            this.productMaxLbl = new System.Windows.Forms.Label();
            this.productMinLbl = new System.Windows.Forms.Label();
            this.productPriceLbl = new System.Windows.Forms.Label();
            this.productInventoryLbl = new System.Windows.Forms.Label();
            this.productNameLbl = new System.Windows.Forms.Label();
            this.productIDLbl = new System.Windows.Forms.Label();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.allPartsLbl = new System.Windows.Forms.Label();
            this.associatedPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.partsToProductLbl = new System.Windows.Forms.Label();
            this.searchControlUC = new Inventory_Managment_System.View.SearchControlUC();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGridView)).BeginInit();
            this.SuspendLayout();
            //
            // tableDataGridViewCellStyle
            //
            tableDataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            tableDataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // productMaxTxtBox
            // 
            this.productMaxTxtBox.Location = new System.Drawing.Point(115, 373);
            this.productMaxTxtBox.Name = "productMaxTxtBox";
            this.productMaxTxtBox.Size = new System.Drawing.Size(69, 23);
            this.productMaxTxtBox.TabIndex = 11;
            this.productMaxTxtBox.TextChanged += new System.EventHandler(this.productMaxTxtBox_TextChanged);
            // 
            // productMinTxtBox
            // 
            this.productMinTxtBox.Location = new System.Drawing.Point(273, 373);
            this.productMinTxtBox.Name = "productMinTxtBox";
            this.productMinTxtBox.Size = new System.Drawing.Size(69, 23);
            this.productMinTxtBox.TabIndex = 13;
            this.productMinTxtBox.TextChanged += new System.EventHandler(this.productMinTxtBox_TextChanged);
            // 
            // productPriceTxtBox
            // 
            this.productPriceTxtBox.Location = new System.Drawing.Point(115, 333);
            this.productPriceTxtBox.Name = "productPriceTxtBox";
            this.productPriceTxtBox.Size = new System.Drawing.Size(119, 23);
            this.productPriceTxtBox.TabIndex = 9;
            this.productPriceTxtBox.TextChanged += new System.EventHandler(this.productPriceTxtBox_TextChanged);
            // 
            // productInventoryTxtBox
            // 
            this.productInventoryTxtBox.Location = new System.Drawing.Point(115, 293);
            this.productInventoryTxtBox.Name = "productInventoryTxtBox";
            this.productInventoryTxtBox.Size = new System.Drawing.Size(119, 23);
            this.productInventoryTxtBox.TabIndex = 7;
            this.productInventoryTxtBox.TextChanged += new System.EventHandler(this.productInventoryTxtBox_TextChanged);
            // 
            // productNameTxtBox
            // 
            this.productNameTxtBox.Location = new System.Drawing.Point(115, 253);
            this.productNameTxtBox.Name = "productNameTxtBox";
            this.productNameTxtBox.Size = new System.Drawing.Size(119, 23);
            this.productNameTxtBox.TabIndex = 5;
            this.productNameTxtBox.TextChanged += new System.EventHandler(this.productNameTxtBox_TextChanged);
            // 
            // productIDTxtBox
            // 
            this.productIDTxtBox.Location = new System.Drawing.Point(115, 213);
            this.productIDTxtBox.Name = "productIDTxtBox";
            this.productIDTxtBox.ReadOnly = true;
            this.productIDTxtBox.Size = new System.Drawing.Size(119, 23);
            this.productIDTxtBox.TabIndex = 3;
            // 
            // productMaxLbl
            // 
            this.productMaxLbl.AutoSize = true;
            this.productMaxLbl.Location = new System.Drawing.Point(62, 376);
            this.productMaxLbl.Name = "productMaxLbl";
            this.productMaxLbl.Size = new System.Drawing.Size(30, 15);
            this.productMaxLbl.TabIndex = 10;
            this.productMaxLbl.Text = "Max";
            // 
            // productMinLbl
            // 
            this.productMinLbl.AutoSize = true;
            this.productMinLbl.Location = new System.Drawing.Point(239, 376);
            this.productMinLbl.Name = "productMinLbl";
            this.productMinLbl.Size = new System.Drawing.Size(28, 15);
            this.productMinLbl.TabIndex = 12;
            this.productMinLbl.Text = "Min";
            // 
            // productPriceLbl
            // 
            this.productPriceLbl.AutoSize = true;
            this.productPriceLbl.Location = new System.Drawing.Point(24, 333);
            this.productPriceLbl.Name = "productPriceLbl";
            this.productPriceLbl.Size = new System.Drawing.Size(68, 15);
            this.productPriceLbl.TabIndex = 8;
            this.productPriceLbl.Text = "Price / Cost";
            // 
            // productInventoryLbl
            // 
            this.productInventoryLbl.AutoSize = true;
            this.productInventoryLbl.Location = new System.Drawing.Point(35, 294);
            this.productInventoryLbl.Name = "productInventoryLbl";
            this.productInventoryLbl.Size = new System.Drawing.Size(57, 15);
            this.productInventoryLbl.TabIndex = 6;
            this.productInventoryLbl.Text = "Inventory";
            // 
            // productNameLbl
            // 
            this.productNameLbl.AutoSize = true;
            this.productNameLbl.Location = new System.Drawing.Point(53, 255);
            this.productNameLbl.Name = "productNameLbl";
            this.productNameLbl.Size = new System.Drawing.Size(39, 15);
            this.productNameLbl.TabIndex = 4;
            this.productNameLbl.Text = "Name";
            // 
            // productIDLbl
            // 
            this.productIDLbl.AutoSize = true;
            this.productIDLbl.Location = new System.Drawing.Point(74, 216);
            this.productIDLbl.Name = "productIDLbl";
            this.productIDLbl.Size = new System.Drawing.Size(18, 15);
            this.productIDLbl.TabIndex = 2;
            this.productIDLbl.Text = "ID";
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.AllowUserToAddRows = false;
            this.partsDataGridView.AllowUserToDeleteRows = false;
            this.partsDataGridView.AllowUserToResizeColumns = false;
            this.partsDataGridView.AllowUserToResizeRows = false;
            this.partsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.partName,
            this.partInventory,
            this.partPrice});
            this.partsDataGridView.Location = new System.Drawing.Point(421, 70);
            this.partsDataGridView.MultiSelect = false;
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.ReadOnly = true;
            this.partsDataGridView.RowHeadersVisible = false;
            this.partsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.partsDataGridView.RowsDefaultCellStyle = tableDataGridViewCellStyle;
            this.partsDataGridView.RowTemplate.Height = 25;
            this.partsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsDataGridView.Size = new System.Drawing.Size(503, 180);
            this.partsDataGridView.TabIndex = 14;
            // 
            // partsToProductLbl
            // 
            this.partsToProductLbl.AutoSize = true;
            this.partsToProductLbl.Location = new System.Drawing.Point(421, 312);
            this.partsToProductLbl.Name = "partsToProductLbl";
            this.partsToProductLbl.Size = new System.Drawing.Size(186, 15);
            this.partsToProductLbl.TabIndex = 16;
            this.partsToProductLbl.Text = "Parts Associated with this Product";
            // 
            // allPartsLbl
            // 
            this.allPartsLbl.AutoSize = true;
            this.allPartsLbl.Location = new System.Drawing.Point(421, 38);
            this.allPartsLbl.Name = "allPartsLbl";
            this.allPartsLbl.Size = new System.Drawing.Size(50, 15);
            this.allPartsLbl.TabIndex = 0;
            this.allPartsLbl.Text = "All Parts";
            // 
            // associatedPartsDataGridView
            // 
            this.associatedPartsDataGridView.AllowUserToAddRows = false;
            this.associatedPartsDataGridView.AllowUserToDeleteRows = false;
            this.associatedPartsDataGridView.AllowUserToResizeColumns = false;
            this.associatedPartsDataGridView.AllowUserToResizeRows = false;
            this.associatedPartsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.associatedPartID,
            this.associatedPartName,
            this.associatedPartInventory,
            this.associatedPartPrice});
            this.associatedPartsDataGridView.Location = new System.Drawing.Point(421, 341);
            this.associatedPartsDataGridView.MultiSelect = false;
            this.associatedPartsDataGridView.Name = "associatedPartsDataGridView";
            this.associatedPartsDataGridView.ReadOnly = true;
            this.associatedPartsDataGridView.RowHeadersVisible = false;
            this.associatedPartsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.associatedPartsDataGridView.RowsDefaultCellStyle = tableDataGridViewCellStyle;
            this.associatedPartsDataGridView.RowTemplate.Height = 25;
            this.associatedPartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsDataGridView.Size = new System.Drawing.Size(503, 180);
            this.associatedPartsDataGridView.TabIndex = 17;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(834, 543);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(55, 31);
            this.deleteBtn.TabIndex = 18;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(834, 272);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(55, 31);
            this.addBtn.TabIndex = 15;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // searchControlUC
            // 
            this.searchControlUC.Location = new System.Drawing.Point(672, 21);
            this.searchControlUC.Name = "searchControlUC";
            this.searchControlUC.Size = new System.Drawing.Size(252, 32);
            this.searchControlUC.TabIndex = 1;
            this.searchControlUC.Controls["searchBtn"].Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // partID
            // 
            this.partID.Frozen = true;
            this.partID.HeaderText = "Part ID";
            this.partID.MinimumWidth = 40;
            this.partID.Name = "partID";
            this.partID.ReadOnly = true;
            this.partID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.partID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.partID.Width = 125;
            // 
            // partName
            // 
            this.partName.Frozen = true;
            this.partName.HeaderText = "Name";
            this.partName.MinimumWidth = 40;
            this.partName.Name = "partName";
            this.partName.ReadOnly = true;
            this.partName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.partName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.partName.Width = 125;
            // 
            // partInventory
            // 
            this.partInventory.Frozen = true;
            this.partInventory.HeaderText = "Inventory";
            this.partInventory.MinimumWidth = 40;
            this.partInventory.Name = "partInventory";
            this.partInventory.ReadOnly = true;
            this.partInventory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.partInventory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.partInventory.Width = 125;
            // 
            // partPrice
            // 
            this.partPrice.Frozen = true;
            this.partPrice.HeaderText = "Price";
            this.partPrice.MinimumWidth = 40;
            this.partPrice.Name = "partPrice";
            this.partPrice.ReadOnly = true;
            this.partPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.partPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.partPrice.Width = 125;
            // 
            // associatedPartID
            // 
            this.associatedPartID.Frozen = true;
            this.associatedPartID.HeaderText = "Part ID";
            this.associatedPartID.MinimumWidth = 40;
            this.associatedPartID.Name = "associatedPartID";
            this.associatedPartID.ReadOnly = true;
            this.associatedPartID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.associatedPartID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.associatedPartID.Width = 125;
            // 
            // associatedPartName
            // 
            this.associatedPartName.Frozen = true;
            this.associatedPartName.HeaderText = "Name";
            this.associatedPartName.MinimumWidth = 40;
            this.associatedPartName.Name = "associatedPartName";
            this.associatedPartName.ReadOnly = true;
            this.associatedPartName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.associatedPartName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.associatedPartName.Width = 125;
            // 
            // associatedPartInventory
            // 
            this.associatedPartInventory.Frozen = true;
            this.associatedPartInventory.HeaderText = "Inventory";
            this.associatedPartInventory.MinimumWidth = 40;
            this.associatedPartInventory.Name = "associatedPartInventory";
            this.associatedPartInventory.ReadOnly = true;
            this.associatedPartInventory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.associatedPartInventory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.associatedPartInventory.Width = 125;
            // 
            // associatedPartPrice
            // 
            this.associatedPartPrice.Frozen = true;
            this.associatedPartPrice.HeaderText = "Price";
            this.associatedPartPrice.MinimumWidth = 40;
            this.associatedPartPrice.Name = "associatedPartPrice";
            this.associatedPartPrice.ReadOnly = true;
            this.associatedPartPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.associatedPartPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.associatedPartPrice.Width = 125;
            // 
            // ProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchControlUC);
            this.Controls.Add(this.partsToProductLbl);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.associatedPartsDataGridView);
            this.Controls.Add(this.allPartsLbl);
            this.Controls.Add(this.partsDataGridView);
            this.Controls.Add(this.productMaxTxtBox);
            this.Controls.Add(this.productMinTxtBox);
            this.Controls.Add(this.productPriceTxtBox);
            this.Controls.Add(this.productInventoryTxtBox);
            this.Controls.Add(this.productNameTxtBox);
            this.Controls.Add(this.productIDTxtBox);
            this.Controls.Add(this.productMaxLbl);
            this.Controls.Add(this.productMinLbl);
            this.Controls.Add(this.productPriceLbl);
            this.Controls.Add(this.productInventoryLbl);
            this.Controls.Add(this.productNameLbl);
            this.Controls.Add(this.productIDLbl);
            this.Name = "ProductUC";
            this.Size = new System.Drawing.Size(959, 592);
            this.Load += new System.EventHandler(this.ProductUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox productIDTxtBox;
        private TextBox productNameTxtBox;
        private TextBox productPriceTxtBox;
        private TextBox productInventoryTxtBox;
        private TextBox productMinTxtBox;
        private TextBox productMaxTxtBox;
        private Label productIDLbl;
        private Label productNameLbl;
        private Label productPriceLbl;
        private Label productInventoryLbl;
        private Label productMaxLbl;
        private Label productMinLbl;
        private DataGridView partsDataGridView;
        private DataGridView associatedPartsDataGridView;
        private Button addBtn;
        private Button deleteBtn;
        private Label allPartsLbl;
        private Label partsToProductLbl;
        private SearchControlUC searchControlUC;
        private DataGridViewTextBoxColumn partID;
        private DataGridViewTextBoxColumn partName;
        private DataGridViewTextBoxColumn partInventory;
        private DataGridViewTextBoxColumn partPrice;
        private DataGridViewTextBoxColumn associatedPartID;
        private DataGridViewTextBoxColumn associatedPartName;
        private DataGridViewTextBoxColumn associatedPartInventory;
        private DataGridViewTextBoxColumn associatedPartPrice;
    }
}
