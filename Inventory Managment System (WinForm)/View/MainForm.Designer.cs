namespace Inventory_Managment_System
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inventoryTbCtrl = new System.Windows.Forms.TabControl();
            this.partsTabPage = new System.Windows.Forms.TabPage();
            this.productsTabPage = new System.Windows.Forms.TabPage();
            this.appNameLbl = new System.Windows.Forms.Label();
            this.modifcationControls1 = new Inventory_Managment_System.View.ModifcationControls();
            this.searchControl1 = new Inventory_Managment_System.View.SearchControl();
            this.inventoryTbCtrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventoryTbCtrl
            // 
            this.inventoryTbCtrl.Controls.Add(this.partsTabPage);
            this.inventoryTbCtrl.Controls.Add(this.productsTabPage);
            this.inventoryTbCtrl.Location = new System.Drawing.Point(16, 68);
            this.inventoryTbCtrl.Name = "inventoryTbCtrl";
            this.inventoryTbCtrl.SelectedIndex = 0;
            this.inventoryTbCtrl.Size = new System.Drawing.Size(557, 278);
            this.inventoryTbCtrl.TabIndex = 0;
            // 
            // partsTabPage
            // 
            this.partsTabPage.Location = new System.Drawing.Point(4, 24);
            this.partsTabPage.Name = "partsTabPage";
            this.partsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.partsTabPage.Size = new System.Drawing.Size(549, 250);
            this.partsTabPage.TabIndex = 0;
            this.partsTabPage.Text = "Parts";
            this.partsTabPage.UseVisualStyleBackColor = true;
            // 
            // productsTabPage
            // 
            this.productsTabPage.Location = new System.Drawing.Point(4, 24);
            this.productsTabPage.Name = "productsTabPage";
            this.productsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.productsTabPage.Size = new System.Drawing.Size(549, 250);
            this.productsTabPage.TabIndex = 1;
            this.productsTabPage.Text = "Products";
            this.productsTabPage.UseVisualStyleBackColor = true;
            // 
            // appNameLbl
            // 
            this.appNameLbl.AutoSize = true;
            this.appNameLbl.Font = new System.Drawing.Font("Segoe UI Historic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appNameLbl.Location = new System.Drawing.Point(16, 9);
            this.appNameLbl.Name = "appNameLbl";
            this.appNameLbl.Size = new System.Drawing.Size(213, 20);
            this.appNameLbl.TabIndex = 0;
            this.appNameLbl.Text = "Inventory Management System";
            this.appNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modifcationControls1
            // 
            this.modifcationControls1.Location = new System.Drawing.Point(343, 352);
            this.modifcationControls1.Name = "modifcationControls1";
            this.modifcationControls1.Size = new System.Drawing.Size(226, 35);
            this.modifcationControls1.TabIndex = 3;
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(321, 39);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Size = new System.Drawing.Size(252, 32);
            this.searchControl1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.modifcationControls1);
            this.Controls.Add(this.appNameLbl);
            this.Controls.Add(this.inventoryTbCtrl);
            this.Name = "MainForm";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.inventoryTbCtrl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl inventoryTbCtrl;
        private TabPage partsTabPage;
        private TabPage productsTabPage;
        private Label appNameLbl;
        private View.ModifcationControls modifcationControls1;
        private View.SearchControl searchControl1;
    }
}