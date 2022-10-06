namespace Inventory_Managment_System.View
{
    partial class AddPartForm
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
            this.partuc1 = new Inventory_Managment_System.View.PartUC();
            this.addPartLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // partuc1
            // 
            this.partuc1.Location = new System.Drawing.Point(12, 12);
            this.partuc1.Name = "partuc1";
            this.partuc1.Size = new System.Drawing.Size(461, 355);
            this.partuc1.TabIndex = 1;
            // 
            // addPartLbl
            // 
            this.addPartLbl.AutoSize = true;
            this.addPartLbl.Location = new System.Drawing.Point(12, 36);
            this.addPartLbl.Name = "addPartLbl";
            this.addPartLbl.Size = new System.Drawing.Size(53, 15);
            this.addPartLbl.TabIndex = 0;
            this.addPartLbl.Text = "Add Part";
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 380);
            this.Controls.Add(this.addPartLbl);
            this.Controls.Add(this.partuc1);
            this.Name = "AddPartForm";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PartUC partuc1;
        private Label addPartLbl;
    }
}