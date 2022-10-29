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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.partMaxTxtBox = new System.Windows.Forms.TextBox();
            this.partMinTxtBox = new System.Windows.Forms.TextBox();
            this.partPriceTxtBox = new System.Windows.Forms.TextBox();
            this.partInventoryTxtBox = new System.Windows.Forms.TextBox();
            this.partNameTxtBox = new System.Windows.Forms.TextBox();
            this.partIDTxtBox = new System.Windows.Forms.TextBox();
            this.partMaxLbl = new System.Windows.Forms.Label();
            this.partMinLbl = new System.Windows.Forms.Label();
            this.partPriceLbl = new System.Windows.Forms.Label();
            this.partInventoryLbl = new System.Windows.Forms.Label();
            this.partNameLbl = new System.Windows.Forms.Label();
            this.partIDLbl = new System.Windows.Forms.Label();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allPartsLbl = new System.Windows.Forms.Label();
            this.associatedPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.associatedPartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.partsToProductLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // partMaxTxtBox
            // 
            this.partMaxTxtBox.Location = new System.Drawing.Point(108, 356);
            this.partMaxTxtBox.Name = "partMaxTxtBox";
            this.partMaxTxtBox.Size = new System.Drawing.Size(69, 23);
            this.partMaxTxtBox.TabIndex = 23;
            // 
            // partMinTxtBox
            // 
            this.partMinTxtBox.Location = new System.Drawing.Point(266, 356);
            this.partMinTxtBox.Name = "partMinTxtBox";
            this.partMinTxtBox.Size = new System.Drawing.Size(69, 23);
            this.partMinTxtBox.TabIndex = 25;
            // 
            // partPriceTxtBox
            // 
            this.partPriceTxtBox.Location = new System.Drawing.Point(108, 316);
            this.partPriceTxtBox.Name = "partPriceTxtBox";
            this.partPriceTxtBox.Size = new System.Drawing.Size(119, 23);
            this.partPriceTxtBox.TabIndex = 21;
            // 
            // partInventoryTxtBox
            // 
            this.partInventoryTxtBox.Location = new System.Drawing.Point(108, 276);
            this.partInventoryTxtBox.Name = "partInventoryTxtBox";
            this.partInventoryTxtBox.Size = new System.Drawing.Size(119, 23);
            this.partInventoryTxtBox.TabIndex = 19;
            // 
            // partNameTxtBox
            // 
            this.partNameTxtBox.Location = new System.Drawing.Point(108, 236);
            this.partNameTxtBox.Name = "partNameTxtBox";
            this.partNameTxtBox.Size = new System.Drawing.Size(119, 23);
            this.partNameTxtBox.TabIndex = 17;
            // 
            // partIDTxtBox
            // 
            this.partIDTxtBox.Location = new System.Drawing.Point(108, 196);
            this.partIDTxtBox.Name = "partIDTxtBox";
            this.partIDTxtBox.ReadOnly = true;
            this.partIDTxtBox.Size = new System.Drawing.Size(119, 23);
            this.partIDTxtBox.TabIndex = 15;
            // 
            // partMaxLbl
            // 
            this.partMaxLbl.AutoSize = true;
            this.partMaxLbl.Location = new System.Drawing.Point(55, 359);
            this.partMaxLbl.Name = "partMaxLbl";
            this.partMaxLbl.Size = new System.Drawing.Size(30, 15);
            this.partMaxLbl.TabIndex = 22;
            this.partMaxLbl.Text = "Max";
            // 
            // partMinLbl
            // 
            this.partMinLbl.AutoSize = true;
            this.partMinLbl.Location = new System.Drawing.Point(232, 359);
            this.partMinLbl.Name = "partMinLbl";
            this.partMinLbl.Size = new System.Drawing.Size(28, 15);
            this.partMinLbl.TabIndex = 24;
            this.partMinLbl.Text = "Min";
            // 
            // partPriceLbl
            // 
            this.partPriceLbl.AutoSize = true;
            this.partPriceLbl.Location = new System.Drawing.Point(17, 316);
            this.partPriceLbl.Name = "partPriceLbl";
            this.partPriceLbl.Size = new System.Drawing.Size(68, 15);
            this.partPriceLbl.TabIndex = 20;
            this.partPriceLbl.Text = "Price / Cost";
            // 
            // partInventoryLbl
            // 
            this.partInventoryLbl.AutoSize = true;
            this.partInventoryLbl.Location = new System.Drawing.Point(28, 277);
            this.partInventoryLbl.Name = "partInventoryLbl";
            this.partInventoryLbl.Size = new System.Drawing.Size(57, 15);
            this.partInventoryLbl.TabIndex = 18;
            this.partInventoryLbl.Text = "Inventory";
            // 
            // partNameLbl
            // 
            this.partNameLbl.AutoSize = true;
            this.partNameLbl.Location = new System.Drawing.Point(46, 238);
            this.partNameLbl.Name = "partNameLbl";
            this.partNameLbl.Size = new System.Drawing.Size(39, 15);
            this.partNameLbl.TabIndex = 16;
            this.partNameLbl.Text = "Name";
            // 
            // partIDLbl
            // 
            this.partIDLbl.AutoSize = true;
            this.partIDLbl.Location = new System.Drawing.Point(67, 199);
            this.partIDLbl.Name = "partIDLbl";
            this.partIDLbl.Size = new System.Drawing.Size(18, 15);
            this.partIDLbl.TabIndex = 14;
            this.partIDLbl.Text = "ID";
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
            this.partPrice,
            this.partMin,
            this.partMax});
            this.partsDataGridView.Location = new System.Drawing.Point(414, 53);
            this.partsDataGridView.MultiSelect = false;
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.ReadOnly = true;
            this.partsDataGridView.RowHeadersVisible = false;
            this.partsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Yellow;
            this.partsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.partsDataGridView.RowTemplate.Height = 25;
            this.partsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsDataGridView.Size = new System.Drawing.Size(623, 180);
            this.partsDataGridView.TabIndex = 26;
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
            this.partName.Width = 120;
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
            // 
            // partMin
            // 
            this.partMin.Frozen = true;
            this.partMin.HeaderText = "Min";
            this.partMin.MinimumWidth = 40;
            this.partMin.Name = "partMin";
            this.partMin.ReadOnly = true;
            this.partMin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.partMin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // partMax
            // 
            this.partMax.Frozen = true;
            this.partMax.HeaderText = "Max";
            this.partMax.MinimumWidth = 40;
            this.partMax.Name = "partMax";
            this.partMax.ReadOnly = true;
            this.partMax.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.partMax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // allPartsLbl
            // 
            this.allPartsLbl.AutoSize = true;
            this.allPartsLbl.Location = new System.Drawing.Point(414, 21);
            this.allPartsLbl.Name = "allPartsLbl";
            this.allPartsLbl.Size = new System.Drawing.Size(50, 15);
            this.allPartsLbl.TabIndex = 28;
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
            this.associatedPartPrice,
            this.associatedPartMin,
            this.associatedPartMax});
            this.associatedPartsDataGridView.Location = new System.Drawing.Point(414, 324);
            this.associatedPartsDataGridView.MultiSelect = false;
            this.associatedPartsDataGridView.Name = "associatedPartsDataGridView";
            this.associatedPartsDataGridView.ReadOnly = true;
            this.associatedPartsDataGridView.RowHeadersVisible = false;
            this.associatedPartsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Yellow;
            this.associatedPartsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.associatedPartsDataGridView.RowTemplate.Height = 25;
            this.associatedPartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsDataGridView.Size = new System.Drawing.Size(623, 180);
            this.associatedPartsDataGridView.TabIndex = 29;
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
            this.associatedPartName.Width = 120;
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
            // 
            // associatedPartMin
            // 
            this.associatedPartMin.Frozen = true;
            this.associatedPartMin.HeaderText = "Min";
            this.associatedPartMin.MinimumWidth = 40;
            this.associatedPartMin.Name = "associatedPartMin";
            this.associatedPartMin.ReadOnly = true;
            this.associatedPartMin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.associatedPartMin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // associatedPartMax
            // 
            this.associatedPartMax.Frozen = true;
            this.associatedPartMax.HeaderText = "Max";
            this.associatedPartMax.MinimumWidth = 40;
            this.associatedPartMax.Name = "associatedPartMax";
            this.associatedPartMax.ReadOnly = true;
            this.associatedPartMax.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.associatedPartMax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(947, 525);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(55, 31);
            this.deleteBtn.TabIndex = 31;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(947, 254);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(55, 31);
            this.addBtn.TabIndex = 30;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // partsToProductLbl
            // 
            this.partsToProductLbl.AutoSize = true;
            this.partsToProductLbl.Location = new System.Drawing.Point(414, 295);
            this.partsToProductLbl.Name = "partsToProductLbl";
            this.partsToProductLbl.Size = new System.Drawing.Size(186, 15);
            this.partsToProductLbl.TabIndex = 32;
            this.partsToProductLbl.Text = "Parts Associated with this Product";
            // 
            // ProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.partsToProductLbl);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.associatedPartsDataGridView);
            this.Controls.Add(this.allPartsLbl);
            this.Controls.Add(this.partsDataGridView);
            this.Controls.Add(this.partMaxTxtBox);
            this.Controls.Add(this.partMinTxtBox);
            this.Controls.Add(this.partPriceTxtBox);
            this.Controls.Add(this.partInventoryTxtBox);
            this.Controls.Add(this.partNameTxtBox);
            this.Controls.Add(this.partIDTxtBox);
            this.Controls.Add(this.partMaxLbl);
            this.Controls.Add(this.partMinLbl);
            this.Controls.Add(this.partPriceLbl);
            this.Controls.Add(this.partInventoryLbl);
            this.Controls.Add(this.partNameLbl);
            this.Controls.Add(this.partIDLbl);
            this.Name = "ProductUC";
            this.Size = new System.Drawing.Size(1077, 576);
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox partIDTxtBox;
        private TextBox partNameTxtBox;
        private TextBox partPriceTxtBox;
        private TextBox partInventoryTxtBox;
        private TextBox partMinTxtBox;
        private TextBox partMaxTxtBox;
        private Label partIDLbl;
        private Label partNameLbl;
        private Label partPriceLbl;
        private Label partInventoryLbl;
        private Label partMaxLbl;
        private Label partMinLbl;
        private DataGridView partsDataGridView;
        private DataGridView associatedPartsDataGridView;
        private DataGridViewTextBoxColumn partID;
        private DataGridViewTextBoxColumn partName;
        private DataGridViewTextBoxColumn partInventory;
        private DataGridViewTextBoxColumn partPrice;
        private DataGridViewTextBoxColumn partMin;
        private DataGridViewTextBoxColumn partMax;
        private DataGridViewTextBoxColumn associatedPartID;
        private DataGridViewTextBoxColumn associatedPartName;
        private DataGridViewTextBoxColumn associatedPartInventory;
        private DataGridViewTextBoxColumn associatedPartPrice;
        private DataGridViewTextBoxColumn associatedPartMin;
        private DataGridViewTextBoxColumn associatedPartMax;
        private Button addBtn;
        private Button deleteBtn;
        private Label allPartsLbl;
        private Label partsToProductLbl;
    }
}
