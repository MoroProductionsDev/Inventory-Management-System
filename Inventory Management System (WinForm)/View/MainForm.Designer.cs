namespace Inventory_Managment_System.View
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
            this.modifcationControlsUC = new Inventory_Managment_System.View.ModifcationControlsUC();
            this.searchControlUC = new Inventory_Managment_System.View.SearchControlUC();
            this.exitBtn = new System.Windows.Forms.Button();
            this.appNameLbl = new System.Windows.Forms.Label();
            this.tabControlUC = new Inventory_Managment_System.View.TabControlUC();
            this.SuspendLayout();
            // 
            // modifcationControlsUC
            // 
            this.modifcationControlsUC.Location = new System.Drawing.Point(307, 369);
            this.modifcationControlsUC.Name = "modifcationControlsUC";
            this.modifcationControlsUC.Size = new System.Drawing.Size(226, 35);
            this.modifcationControlsUC.TabIndex = 3;
            // 
            // searchControlUC
            // 
            this.searchControlUC.Location = new System.Drawing.Point(281, 40);
            this.searchControlUC.Name = "searchControlUC";
            this.searchControlUC.Size = new System.Drawing.Size(252, 32);
            this.searchControlUC.TabIndex = 4;
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
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(476, 408);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(56, 27);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // tabControlUC
            // 
            this.tabControlUC.Location = new System.Drawing.Point(16, 77);
            this.tabControlUC.Name = "tabControlUC";
            this.tabControlUC.Size = new System.Drawing.Size(523, 285);
            this.tabControlUC.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 452);
            this.Controls.Add(this.tabControlUC);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.searchControlUC);
            this.Controls.Add(this.modifcationControlsUC);
            this.Controls.Add(this.appNameLbl);
            this.Name = "MainForm";
            this.Text = "Main Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private View.ModifcationControlsUC modifcationControlsUC;
        private View.SearchControlUC searchControlUC;
        private Label appNameLbl;
        private Button exitBtn;
        private TabControlUC tabControlUC;
    }
}