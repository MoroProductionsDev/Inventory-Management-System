namespace Inventory_Managment_System.View
{
    partial class AddProductForm
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
            this.productUC = new Inventory_Managment_System.View.ProductUC();
            this.addProductLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productUC
            // 
            this.productUC.Location = new System.Drawing.Point(11, 32);
            this.productUC.Name = "productUC";
            this.productUC.Size = new System.Drawing.Size(1077, 578);
            this.productUC.TabIndex = 1;
            this.productUC.Load += new System.EventHandler(this.productUC_Load);
            // 
            // addProductLbl
            // 
            this.addProductLbl.AutoSize = true;
            this.addProductLbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addProductLbl.Location = new System.Drawing.Point(12, 9);
            this.addProductLbl.Name = "addProductLbl";
            this.addProductLbl.Size = new System.Drawing.Size(92, 20);
            this.addProductLbl.TabIndex = 0;
            this.addProductLbl.Text = "Add Product";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(965, 616);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(55, 31);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(893, 616);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(55, 31);
            this.saveBtn.TabIndex = 17;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 665);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.addProductLbl);
            this.Controls.Add(this.productUC);
            this.Name = "AddProductForm";
            this.Text = "Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProductUC productUC;
        private Label addProductLbl;
        private Button cancelBtn;
        private Button saveBtn;
    }
}