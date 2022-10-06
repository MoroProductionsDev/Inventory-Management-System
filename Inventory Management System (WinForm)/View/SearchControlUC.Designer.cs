namespace Inventory_Managment_System.View
{
    partial class SearchControlUC
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
            this.searchTxtbox = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchTxtbox
            // 
            this.searchTxtbox.Location = new System.Drawing.Point(78, 3);
            this.searchTxtbox.Name = "searchTxtbox";
            this.searchTxtbox.Size = new System.Drawing.Size(168, 23);
            this.searchTxtbox.TabIndex = 4;
            // 
            // searchLbl
            // 
            this.searchLbl.Location = new System.Drawing.Point(3, 3);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(55, 23);
            this.searchLbl.TabIndex = 3;
            this.searchLbl.Text = "Search";
            this.searchLbl.UseVisualStyleBackColor = true;
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchTxtbox);
            this.Controls.Add(this.searchLbl);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(252, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox searchTxtbox;
        private Button searchLbl;
    }
}
