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
            this.appNameLbl = new System.Windows.Forms.Label();
            this.modifcationControls = new Inventory_Managment_System.View.ModifcationControls();
            this.searchControl = new Inventory_Managment_System.View.SearchControl();
            this.inventoryTabController = new Inventory_Managment_System.View.TabControl();
            this.SuspendLayout();
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
            // modifcationControls
            // 
            this.modifcationControls.Location = new System.Drawing.Point(423, 368);
            this.modifcationControls.Name = "modifcationControls";
            this.modifcationControls.Size = new System.Drawing.Size(226, 35);
            this.modifcationControls.TabIndex = 3;
            this.modifcationControls.Load += new System.EventHandler(this.modifcationControls_Load);
            // 
            // searchControl
            // 
            this.searchControl.Location = new System.Drawing.Point(397, 39);
            this.searchControl.Name = "searchControl";
            this.searchControl.Size = new System.Drawing.Size(252, 32);
            this.searchControl.TabIndex = 4;
            // 
            // inventoryTabController
            // 
            this.inventoryTabController.Location = new System.Drawing.Point(16, 77);
            this.inventoryTabController.Name = "inventoryTabController";
            this.inventoryTabController.Size = new System.Drawing.Size(645, 285);
            this.inventoryTabController.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 427);
            this.Controls.Add(this.inventoryTabController);
            this.Controls.Add(this.searchControl);
            this.Controls.Add(this.modifcationControls);
            this.Controls.Add(this.appNameLbl);
            this.Name = "MainForm";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label appNameLbl;
        private View.ModifcationControls modifcationControls;
        private View.SearchControl searchControl;
        private View.TabControl inventoryTabController;
    }
}