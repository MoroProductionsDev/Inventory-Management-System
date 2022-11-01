using Inventory_Managment_System.Model;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Inventory_Managment_System.View
{
    partial class TabControlUC
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
            this.inventoryTbCtrl = new System.Windows.Forms.TabControl();
            this.partsTabPage = new System.Windows.Forms.TabPage();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.productsTabPage = new System.Windows.Forms.TabPage();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryTbCtrl.SuspendLayout();
            this.partsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            this.productsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            //
            // tableDataGridViewCellStyle
            //
            tableDataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            tableDataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // inventoryTbCtrl
            // 
            this.inventoryTbCtrl.Controls.Add(this.partsTabPage);
            this.inventoryTbCtrl.Controls.Add(this.productsTabPage);
            this.inventoryTbCtrl.Location = new System.Drawing.Point(3, 3);
            this.inventoryTbCtrl.Name = "inventoryTbCtrl";
            this.inventoryTbCtrl.SelectedIndex = 0;
            this.inventoryTbCtrl.Size = new System.Drawing.Size(517, 278);
            this.inventoryTbCtrl.TabIndex = 1;
            this.inventoryTbCtrl.SelectedIndexChanged += new System.EventHandler(this.inventoryTbCtrl_SelectedIndexChanged);
            // 
            // partsTabPage
            // 
            this.partsTabPage.Controls.Add(this.partsDataGridView);
            this.partsTabPage.Location = new System.Drawing.Point(4, 24);
            this.partsTabPage.Name = "partsTabPage";
            this.partsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.partsTabPage.Size = new System.Drawing.Size(509, 250);
            this.partsTabPage.TabIndex = 0;
            this.partsTabPage.Text = "Parts";
            this.partsTabPage.UseVisualStyleBackColor = true;
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.AllowUserToAddRows = false;
            this.partsDataGridView.AllowUserToDeleteRows = false;
            this.partsDataGridView.AllowUserToResizeColumns = false;
            this.partsDataGridView.AllowUserToResizeRows = false;
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.partsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.partName,
            this.partInventory,
            this.partPrice});
            this.partsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.partsDataGridView.MultiSelect = false;
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.ReadOnly = true;
            this.partsDataGridView.RowHeadersVisible = false;
            this.partsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.partsDataGridView.RowsDefaultCellStyle = tableDataGridViewCellStyle;
            this.partsDataGridView.RowTemplate.Height = 25;
            this.partsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsDataGridView.Size = new System.Drawing.Size(503, 244);
            this.partsDataGridView.TabIndex = 0;
            // 
            // productsTabPage
            // 
            this.productsTabPage.Controls.Add(this.productsDataGridView);
            this.productsTabPage.Location = new System.Drawing.Point(4, 24);
            this.productsTabPage.Name = "productsTabPage";
            this.productsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.productsTabPage.Size = new System.Drawing.Size(509, 250);
            this.productsTabPage.TabIndex = 1;
            this.productsTabPage.Text = "Products";
            this.productsTabPage.UseVisualStyleBackColor = true;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.AllowUserToResizeColumns = false;
            this.productsDataGridView.AllowUserToResizeRows = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.productInventory,
            this.productPrice});
            this.productsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.productsDataGridView.MultiSelect = false;
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.RowHeadersVisible = false;
            this.productsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productsDataGridView.RowsDefaultCellStyle = tableDataGridViewCellStyle;
            this.productsDataGridView.RowTemplate.Height = 25;
            this.productsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGridView.Size = new System.Drawing.Size(503, 244);
            this.productsDataGridView.TabIndex = 1;
            // 
            // partID
            // 
            this.partID.Frozen = true;
            this.partID.HeaderText = "Part ID";
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
            this.partPrice.Name = "partPrice";
            this.partPrice.ReadOnly = true;
            this.partPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.partPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.partPrice.Width = 125;
            // 
            // productID
            // 
            this.productID.Frozen = true;
            this.productID.HeaderText = "Product ID";
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.productID.Width = 125;
            // 
            // productName
            // 
            this.productName.Frozen = true;
            this.productName.HeaderText = "Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.productName.Width = 125;
            // 
            // productInventory
            // 
            this.productInventory.Frozen = true;
            this.productInventory.HeaderText = "Inventory";
            this.productInventory.Name = "productInventory";
            this.productInventory.ReadOnly = true;
            this.productInventory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productInventory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.productInventory.Width = 125;
            // 
            // productPrice
            // 
            this.productPrice.Frozen = true;
            this.productPrice.HeaderText = "Price";
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            this.productPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.productPrice.Width = 125;
            // 
            // TabControlUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inventoryTbCtrl);
            this.Name = "TabControlUC";
            this.Size = new System.Drawing.Size(522, 285);
            this.Load += new System.EventHandler(this.tabControl_Load);
            this.inventoryTbCtrl.ResumeLayout(false);
            this.partsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            this.productsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private TabControl inventoryTbCtrl;
        private TabPage partsTabPage;
        private TabPage productsTabPage;
        private DataGridView partsDataGridView;
        private DataGridView productsDataGridView;
        private DataGridViewTextBoxColumn partID;
        private DataGridViewTextBoxColumn partName;
        private DataGridViewTextBoxColumn partInventory;
        private DataGridViewTextBoxColumn partPrice;
        private DataGridViewTextBoxColumn productID;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn productInventory;
        private DataGridViewTextBoxColumn productPrice;
    }
}
