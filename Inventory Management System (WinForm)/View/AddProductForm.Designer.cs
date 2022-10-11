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
            this.productuc1 = new Inventory_Managment_System.View.ProductUC();
            this.SuspendLayout();
            // 
            // productuc1
            // 
            this.productuc1.Location = new System.Drawing.Point(12, 12);
            this.productuc1.Name = "productuc1";
            this.productuc1.Size = new System.Drawing.Size(1077, 549);
            this.productuc1.TabIndex = 0;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 573);
            this.Controls.Add(this.productuc1);
            this.Name = "AddProductForm";
            this.Text = "Add Product";
            this.ResumeLayout(false);

        }

        #endregion

        private ProductUC productuc1;
    }
}