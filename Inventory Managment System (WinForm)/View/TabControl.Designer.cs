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
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.productsTabPage = new System.Windows.Forms.TabPage();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryTbCtrl.SuspendLayout();
            this.partsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryTbCtrl
            // 
            this.inventoryTbCtrl.Controls.Add(this.partsTabPage);
            this.inventoryTbCtrl.Controls.Add(this.productsTabPage);
            this.inventoryTbCtrl.Location = new System.Drawing.Point(3, 3);
            this.inventoryTbCtrl.Name = "inventoryTbCtrl";
            this.inventoryTbCtrl.SelectedIndex = 0;
            this.inventoryTbCtrl.Size = new System.Drawing.Size(616, 278);
            this.inventoryTbCtrl.TabIndex = 1;
            // 
            // partsTabPage
            // 
            this.partsTabPage.Controls.Add(this.inventoryDataGridView);
            this.partsTabPage.Location = new System.Drawing.Point(4, 24);
            this.partsTabPage.Name = "partsTabPage";
            this.partsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.partsTabPage.Size = new System.Drawing.Size(608, 250);
            this.partsTabPage.TabIndex = 0;
            this.partsTabPage.Text = "Parts";
            this.partsTabPage.UseVisualStyleBackColor = true;
            // 
            // inventoryDataGridView
            // 
            this.inventoryDataGridView.AllowUserToAddRows = false;
            this.inventoryDataGridView.AllowUserToDeleteRows = false;
            this.inventoryDataGridView.AllowUserToResizeColumns = false;
            this.inventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.name,
            this.inventory,
            this.price,
            this.min,
            this.max});
            this.inventoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryDataGridView.Location = new System.Drawing.Point(3, 3);
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.ReadOnly = true;
            this.inventoryDataGridView.RowHeadersVisible = false;
            this.inventoryDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.inventoryDataGridView.RowTemplate.Height = 25;
            this.inventoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryDataGridView.Size = new System.Drawing.Size(602, 244);
            this.inventoryDataGridView.TabIndex = 0;
            // 
            // productsTabPage
            // 
            this.productsTabPage.Location = new System.Drawing.Point(4, 24);
            this.productsTabPage.Name = "productsTabPage";
            this.productsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.productsTabPage.Size = new System.Drawing.Size(609, 250);
            this.productsTabPage.TabIndex = 1;
            this.productsTabPage.Text = "Products";
            this.productsTabPage.UseVisualStyleBackColor = true;
            // 
            // partID
            // 
            this.partID.Frozen = true;
            this.partID.HeaderText = "Part ID";
            this.partID.MinimumWidth = 40;
            this.partID.Name = "partID";
            this.partID.ReadOnly = true;
            this.partID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.partID.Width = 80;
            //
            // productID
            //
            this.productID.Frozen = true;
            this.productID.HeaderText = "Product ID";
            this.productID.Name = "partID";
            this.productID.ReadOnly = true;
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 40;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 100;
            // 
            // inventory
            // 
            this.inventory.Frozen = true;
            this.inventory.HeaderText = "Inventory";
            this.inventory.Name = "inventory";
            this.inventory.ReadOnly = true;
            // 
            // price
            // 
            this.price.Frozen = true;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // min
            // 
            this.min.Frozen = true;
            this.min.HeaderText = "Min";
            this.min.Name = "min";
            this.min.ReadOnly = true;
            // 
            // max
            // 
            this.max.Frozen = true;
            this.max.HeaderText = "Max";
            this.max.Name = "max";
            this.max.ReadOnly = true;
            // 
            // TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inventoryTbCtrl);
            this.Name = "TabControl";
            this.Size = new System.Drawing.Size(621, 285);
            this.inventoryTbCtrl.ResumeLayout(false);
            this.partsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        // 
        private void ModifiedComponent()
        {

            this.inventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.name,
            this.inventory,
            this.price,
            this.min,
            this.max});
        }

        #endregion

        private System.Windows.Forms.TabControl inventoryTbCtrl;
        private TabPage partsTabPage;
        private TabPage productsTabPage;
        private DataGridView inventoryDataGridView;
        private DataGridViewTextBoxColumn partID;
        private DataGridViewTextBoxColumn productID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn inventory;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn min;
        private DataGridViewTextBoxColumn max;
    }
}
