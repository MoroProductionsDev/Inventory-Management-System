namespace Inventory_Managment_System.View
{
    partial class ModifyPartForm
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
            this.modifyPartLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // partuc1
            // 
            this.partuc1.Location = new System.Drawing.Point(12, 12);
            this.partuc1.Name = "partuc1";
            this.partuc1.Size = new System.Drawing.Size(461, 355);
            this.partuc1.TabIndex = 2;
            // 
            // modifyPartLbl
            // 
            this.modifyPartLbl.AutoSize = true;
            this.modifyPartLbl.Location = new System.Drawing.Point(12, 36);
            this.modifyPartLbl.Name = "modifyPartLbl";
            this.modifyPartLbl.Size = new System.Drawing.Size(69, 15);
            this.modifyPartLbl.TabIndex = 3;
            this.modifyPartLbl.Text = "Modify Part";
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 380);
            this.Controls.Add(this.modifyPartLbl);
            this.Controls.Add(this.partuc1);
            this.Name = "ModifyPartForm";
            this.Text = "ModifyPartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PartUC partuc1;
        private Label modifyPartLbl;
    }
}