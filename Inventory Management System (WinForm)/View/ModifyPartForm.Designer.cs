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
            this.partUC = new Inventory_Managment_System.View.PartUC();
            this.modifyPartLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // partUC
            // 
            this.partUC.Location = new System.Drawing.Point(12, 12);
            this.partUC.Name = "partUC";
            this.partUC.Size = new System.Drawing.Size(461, 355);
            this.partUC.TabIndex = 2;
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
            this.Controls.Add(this.partUC);
            this.Name = "ModifyPartForm";
            this.Text = "Modify Part";
            this.Load += new System.EventHandler(this.ModifyPartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PartUC partUC;
        private Label modifyPartLbl;
    }
}