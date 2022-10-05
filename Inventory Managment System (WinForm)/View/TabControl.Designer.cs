namespace Inventory_Managment_System.View
{
    partial class TabControl
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
            this.inventoryTbCtrl = new System.Windows.Forms.TabControl();
            this.partsTabPage = new System.Windows.Forms.TabPage();
            this.productsTabPage = new System.Windows.Forms.TabPage();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();

            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            

            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
            this.inventoryTbCtrl.SuspendLayout();
            this.partsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            this.productsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryTbCtrl
            // 
            this.inventoryTbCtrl.Controls.Add(this.partsTabPage);
            this.inventoryTbCtrl.Controls.Add(this.productsTabPage);
            this.inventoryTbCtrl.Location = new System.Drawing.Point(3, 3);
            this.inventoryTbCtrl.Name = "inventoryTbCtrl";
            this.inventoryTbCtrl.SelectedIndex = 0;
            this.inventoryTbCtrl.Size = new System.Drawing.Size(636, 278);
            this.inventoryTbCtrl.TabIndex = 1;
            // 
            // partsTabPage
            // 
            this.partsTabPage.Controls.Add(this.partsDataGridView);
            this.partsTabPage.Location = new System.Drawing.Point(4, 24);
            this.partsTabPage.Name = "partsTabPage";
            this.partsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.partsTabPage.Size = new System.Drawing.Size(628, 250);
            this.partsTabPage.TabIndex = 0;
            this.partsTabPage.Text = "Parts";
            this.partsTabPage.UseVisualStyleBackColor = true;
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.AllowUserToAddRows = false;
            this.partsDataGridView.AllowUserToDeleteRows = false;
            this.partsDataGridView.AllowUserToResizeColumns = false;
            this.partsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.partName,
            this.partInventory,
            this.partPrice,
            this.partMin,
            this.partMax});
            this.partsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.ReadOnly = true;
            this.partsDataGridView.RowHeadersVisible = false;
            this.partsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.partsDataGridView.RowTemplate.Height = 25;
            this.partsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsDataGridView.Size = new System.Drawing.Size(622, 244);
            this.partsDataGridView.TabIndex = 0;
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
            // productsTabPage
            // 
            this.productsTabPage.Controls.Add(this.productsDataGridView);
            this.productsTabPage.Location = new System.Drawing.Point(4, 24);
            this.productsTabPage.Name = "productsTabPage";
            this.productsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.productsTabPage.Size = new System.Drawing.Size(628, 250);
            this.productsTabPage.TabIndex = 1;
            this.productsTabPage.Text = "Products";
            this.productsTabPage.UseVisualStyleBackColor = true;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.AllowUserToResizeColumns = false;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.productInventory,
            this.productPrice,
            this.productMin,
            this.productMax});
            this.productsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.productsDataGridView.Name = "dataGridView1";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.RowHeadersVisible = false;
            this.productsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productsDataGridView.RowTemplate.Height = 25;
            this.productsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGridView.Size = new System.Drawing.Size(622, 244);
            this.productsDataGridView.TabIndex = 1;
            // 
            // productID
            // 
            this.productID.Frozen = true;
            this.productID.HeaderText = "Product ID";
            this.productID.MinimumWidth = 40;
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // productName
            // 
            this.productName.Frozen = true;
            this.productName.HeaderText = "Name";
            this.productName.MinimumWidth = 40;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.productName.Width = 120;
            // 
            // productInventory
            // 
            this.productInventory.Frozen = true;
            this.productInventory.HeaderText = "Inventory";
            this.productInventory.MinimumWidth = 40;
            this.productInventory.Name = "productInventory";
            this.productInventory.ReadOnly = true;
            this.productInventory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productInventory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // productPrice
            // 
            this.productPrice.Frozen = true;
            this.productPrice.HeaderText = "Price";
            this.productPrice.MinimumWidth = 40;
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            this.productPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // productMin
            // 
            this.productMin.Frozen = true;
            this.productMin.HeaderText = "Min";
            this.productMin.MinimumWidth = 40;
            this.productMin.Name = "productMin";
            this.productMin.ReadOnly = true;
            this.productMin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productMin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // productMax
            // 
            this.productMax.Frozen = true;
            this.productMax.HeaderText = "Max";
            this.productMax.MinimumWidth = 40;
            this.productMax.Name = "productMax";
            this.productMax.ReadOnly = true;
            this.productMax.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productMax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inventoryTbCtrl);
            this.Name = "TabControl";
            this.Size = new System.Drawing.Size(641, 285);
            this.inventoryTbCtrl.ResumeLayout(false);
            this.partsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            this.productsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        // 
        #endregion

        private System.Windows.Forms.TabControl inventoryTbCtrl;
        private TabPage partsTabPage;
        private TabPage productsTabPage;
        private DataGridView partsDataGridView;
        private DataGridView productsDataGridView;
        private DataGridViewTextBoxColumn partID;
        private DataGridViewTextBoxColumn partName;
        private DataGridViewTextBoxColumn partInventory;
        private DataGridViewTextBoxColumn partPrice;
        private DataGridViewTextBoxColumn partMin;
        private DataGridViewTextBoxColumn partMax;
        private DataGridViewTextBoxColumn productID;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn productInventory;
        private DataGridViewTextBoxColumn productPrice;
        private DataGridViewTextBoxColumn productMin;
        private DataGridViewTextBoxColumn productMax;
    }
}
