namespace Inventory_Managment_System.View
{
    partial class ModifyProductForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productuc1 = new Inventory_Managment_System.View.ProductUC();
            this.modifyProductLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productUC
            // 
            this.productuc1.Location = new System.Drawing.Point(12, 12);
            this.productuc1.Name = "productUC";
            this.productuc1.Size = new System.Drawing.Size(1077, 549);
            this.productuc1.TabIndex = 0;
            // 
            // modifyProductLbl
            // 
            this.modifyProductLbl.AutoSize = true;
            this.modifyProductLbl.Location = new System.Drawing.Point(57, 30);
            this.modifyProductLbl.Name = "modifyProductLbl";
            this.modifyProductLbl.Size = new System.Drawing.Size(90, 15);
            this.modifyProductLbl.TabIndex = 1;
            this.modifyProductLbl.Text = "Modify Product";
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 573);
            this.Controls.Add(this.modifyProductLbl);
            this.Controls.Add(this.productuc1);
            this.Name = "ModifyProductForm";
            this.Text = "Modify Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProductUC productuc1;
        private Label modifyProductLbl;
    }
}