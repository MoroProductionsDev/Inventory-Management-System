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
            this.productUC = new Inventory_Managment_System.View.ProductUC();
            this.modifyProductLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productUC
            // 
            this.productUC.Location = new System.Drawing.Point(12, 12);
            this.productUC.Name = "productUC";
            this.productUC.Size = new System.Drawing.Size(1077, 578);
            this.productUC.TabIndex = 0;
            this.productUC.Load += new System.EventHandler(this.productUC_Load);
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
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(966, 596);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(55, 31);
            this.cancelBtn.TabIndex = 20;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click); // cancel btn event for its child
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(894, 596);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(55, 31);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click); // save btn event for its child
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 643);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.modifyProductLbl);
            this.Controls.Add(this.productUC);
            this.Name = "ModifyProductForm";
            this.Text = "Modify Product";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private ProductUC productUC;
        private Label modifyProductLbl;
        private Button cancelBtn;
        private Button saveBtn;
    }
}