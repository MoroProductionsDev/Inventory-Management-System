using System.ComponentModel;

namespace Inventory_Managment_System.View
{
    partial class PartUC
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
            this.partIDLbl = new System.Windows.Forms.Label();
            this.partNameLbl = new System.Windows.Forms.Label();
            this.partInventoryLbl = new System.Windows.Forms.Label();
            this.partPriceLbl = new System.Windows.Forms.Label();
            this.partMinLbl = new System.Windows.Forms.Label();
            this.partMaxLbl = new System.Windows.Forms.Label();
            this.partCompanyNameLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.partIDTxtBox = new System.Windows.Forms.TextBox();
            this.partNameTxtBox = new System.Windows.Forms.TextBox();
            this.partInventoryTxtBox = new System.Windows.Forms.TextBox();
            this.partMinTxtBox = new System.Windows.Forms.TextBox();
            this.partMaxTxtBox = new System.Windows.Forms.TextBox();
            this.inHouseRdBtn = new System.Windows.Forms.RadioButton();
            this.outSourcedRdBtn = new System.Windows.Forms.RadioButton();
            this.machineIDorCompanyNameTxtBox = new System.Windows.Forms.TextBox();
            this.partPriceTxtBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.partMachineIDLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // partIDLbl
            // 
            this.partIDLbl.AutoSize = true;
            this.partIDLbl.Location = new System.Drawing.Point(112, 70);
            this.partIDLbl.Name = "partIDLbl";
            this.partIDLbl.Size = new System.Drawing.Size(18, 15);
            this.partIDLbl.TabIndex = 2;
            this.partIDLbl.Text = "ID";
            // 
            // partNameLbl
            // 
            this.partNameLbl.AutoSize = true;
            this.partNameLbl.Location = new System.Drawing.Point(91, 109);
            this.partNameLbl.Name = "partNameLbl";
            this.partNameLbl.Size = new System.Drawing.Size(39, 15);
            this.partNameLbl.TabIndex = 4;
            this.partNameLbl.Text = "Name";
            // 
            // partInventoryLbl
            // 
            this.partInventoryLbl.AutoSize = true;
            this.partInventoryLbl.Location = new System.Drawing.Point(73, 148);
            this.partInventoryLbl.Name = "partInventoryLbl";
            this.partInventoryLbl.Size = new System.Drawing.Size(57, 15);
            this.partInventoryLbl.TabIndex = 6;
            this.partInventoryLbl.Text = "Inventory";
            // 
            // partPriceLbl
            // 
            this.partPriceLbl.AutoSize = true;
            this.partPriceLbl.Location = new System.Drawing.Point(62, 187);
            this.partPriceLbl.Name = "partPriceLbl";
            this.partPriceLbl.Size = new System.Drawing.Size(68, 15);
            this.partPriceLbl.TabIndex = 8;
            this.partPriceLbl.Text = "Price / Cost";
            // 
            // partMinLbl
            // 
            this.partMinLbl.AutoSize = true;
            this.partMinLbl.Location = new System.Drawing.Point(277, 230);
            this.partMinLbl.Name = "partMinLbl";
            this.partMinLbl.Size = new System.Drawing.Size(28, 15);
            this.partMinLbl.TabIndex = 12;
            this.partMinLbl.Text = "Min";
            // 
            // partMaxLbl
            // 
            this.partMaxLbl.AutoSize = true;
            this.partMaxLbl.Location = new System.Drawing.Point(100, 230);
            this.partMaxLbl.Name = "partMaxLbl";
            this.partMaxLbl.Size = new System.Drawing.Size(30, 15);
            this.partMaxLbl.TabIndex = 10;
            this.partMaxLbl.Text = "Max";
            // 
            // partCompanyNameLbl
            // 
            this.partCompanyNameLbl.AutoSize = true;
            this.partCompanyNameLbl.Location = new System.Drawing.Point(36, 270);
            this.partCompanyNameLbl.Name = "partCompanyNameLbl";
            this.partCompanyNameLbl.Size = new System.Drawing.Size(94, 15);
            this.partCompanyNameLbl.TabIndex = 6;
            this.partCompanyNameLbl.Text = "Company Name";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(21, 14);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(0, 15);
            this.titleLbl.TabIndex = 7;
            // 
            // partIDTxtBox
            // 
            this.partIDTxtBox.Location = new System.Drawing.Point(153, 67);
            this.partIDTxtBox.Name = "partIDTxtBox";
            this.partIDTxtBox.ReadOnly = true;
            this.partIDTxtBox.Size = new System.Drawing.Size(119, 23);
            this.partIDTxtBox.TabIndex = 3;
            // 
            // partNameTxtBox
            // 
            this.partNameTxtBox.Location = new System.Drawing.Point(153, 107);
            this.partNameTxtBox.Name = "partNameTxtBox";
            this.partNameTxtBox.Size = new System.Drawing.Size(119, 23);
            this.partNameTxtBox.TabIndex = 5;
            this.partNameTxtBox.TextChanged += new System.EventHandler(this.partNameTxtBox_TextChanged);
            // 
            // partInventoryTxtBox
            // 
            this.partInventoryTxtBox.Location = new System.Drawing.Point(153, 147);
            this.partInventoryTxtBox.Name = "partInventoryTxtBox";
            this.partInventoryTxtBox.Size = new System.Drawing.Size(119, 23);
            this.partInventoryTxtBox.TabIndex = 7;
            this.partInventoryTxtBox.TextChanged += new System.EventHandler(this.partInventoryTxtBox_TextChanged);
            // 
            // partMinTxtBox
            // 
            this.partMinTxtBox.Location = new System.Drawing.Point(311, 227);
            this.partMinTxtBox.Name = "partMinTxtBox";
            this.partMinTxtBox.Size = new System.Drawing.Size(69, 23);
            this.partMinTxtBox.TabIndex = 13;
            this.partMinTxtBox.TextChanged += new System.EventHandler(this.partMinTxtBox_TextChanged);
            // 
            // partMaxTxtBox
            // 
            this.partMaxTxtBox.Location = new System.Drawing.Point(153, 227);
            this.partMaxTxtBox.Name = "partMaxTxtBox";
            this.partMaxTxtBox.Size = new System.Drawing.Size(69, 23);
            this.partMaxTxtBox.TabIndex = 11;
            this.partMaxTxtBox.TextChanged += new System.EventHandler(this.partMaxTxtBox_TextChanged);
            // 
            // inHouseRdBtn
            // 
            this.inHouseRdBtn.AutoSize = true;
            this.inHouseRdBtn.Location = new System.Drawing.Point(139, 23);
            this.inHouseRdBtn.Name = "inHouseRdBtn";
            this.inHouseRdBtn.Size = new System.Drawing.Size(74, 19);
            this.inHouseRdBtn.TabIndex = 0;
            this.inHouseRdBtn.TabStop = true;
            this.inHouseRdBtn.Text = "In-House";
            this.inHouseRdBtn.UseVisualStyleBackColor = true;
            this.inHouseRdBtn.CheckedChanged += new System.EventHandler(this.inHouseRdBtn_CheckedChanged);
            // 
            // outSourcedRdBtn
            // 
            this.outSourcedRdBtn.AutoSize = true;
            this.outSourcedRdBtn.Location = new System.Drawing.Point(241, 23);
            this.outSourcedRdBtn.Name = "outSourcedRdBtn";
            this.outSourcedRdBtn.Size = new System.Drawing.Size(87, 19);
            this.outSourcedRdBtn.TabIndex = 1;
            this.outSourcedRdBtn.TabStop = true;
            this.outSourcedRdBtn.Text = "Outsourced";
            this.outSourcedRdBtn.UseVisualStyleBackColor = true;
            this.outSourcedRdBtn.CheckedChanged += new System.EventHandler(this.outSourcedRdBtn_CheckedChanged);
            // 
            // machineIDorCompanyNameTxtBox
            // 
            this.machineIDorCompanyNameTxtBox.Location = new System.Drawing.Point(153, 267);
            this.machineIDorCompanyNameTxtBox.Name = "machineIDorCompanyNameTxtBox";
            this.machineIDorCompanyNameTxtBox.Size = new System.Drawing.Size(119, 23);
            this.machineIDorCompanyNameTxtBox.TabIndex = 14;
            this.machineIDorCompanyNameTxtBox.TextChanged += new System.EventHandler(this.machineIDorCompanyNameTxtBox_TextChanged);
            // 
            // partPriceTxtBox
            // 
            this.partPriceTxtBox.Location = new System.Drawing.Point(153, 187);
            this.partPriceTxtBox.Name = "partPriceTxtBox";
            this.partPriceTxtBox.Size = new System.Drawing.Size(119, 23);
            this.partPriceTxtBox.TabIndex = 9;
            this.partPriceTxtBox.TextChanged += new System.EventHandler(this.partPriceTxtBox_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(273, 309);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(55, 31);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(345, 309);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(55, 31);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // partMachineIDLbl
            // 
            this.partMachineIDLbl.AutoSize = true;
            this.partMachineIDLbl.Location = new System.Drawing.Point(62, 270);
            this.partMachineIDLbl.Name = "partMachineIDLbl";
            this.partMachineIDLbl.Size = new System.Drawing.Size(67, 15);
            this.partMachineIDLbl.TabIndex = 17;
            this.partMachineIDLbl.Text = "Machine ID";
            // 
            // PartUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.partMachineIDLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.machineIDorCompanyNameTxtBox);
            this.Controls.Add(this.outSourcedRdBtn);
            this.Controls.Add(this.inHouseRdBtn);
            this.Controls.Add(this.partMaxTxtBox);
            this.Controls.Add(this.partMinTxtBox);
            this.Controls.Add(this.partPriceTxtBox);
            this.Controls.Add(this.partInventoryTxtBox);
            this.Controls.Add(this.partNameTxtBox);
            this.Controls.Add(this.partIDTxtBox);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.partCompanyNameLbl);
            this.Controls.Add(this.partMaxLbl);
            this.Controls.Add(this.partMinLbl);
            this.Controls.Add(this.partPriceLbl);
            this.Controls.Add(this.partInventoryLbl);
            this.Controls.Add(this.partNameLbl);
            this.Controls.Add(this.partIDLbl);
            this.Name = "PartUC";
            this.Size = new System.Drawing.Size(461, 355);
            this.Load += new System.EventHandler(this.PartUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label partIDLbl;
        private Label partNameLbl;
        private Label partInventoryLbl;
        private Label partPriceLbl;
        private Label partMinLbl;
        private Label partMaxLbl;
        private Label partCompanyNameLbl;
        private Label titleLbl;
        private TextBox partIDTxtBox;
        private TextBox partNameTxtBox;
        private TextBox partInventoryTxtBox;
        private TextBox partPriceTxtBox;
        private TextBox partMinTxtBox;
        private TextBox partMaxTxtBox;
        private TextBox machineIDorCompanyNameTxtBox;
        private RadioButton inHouseRdBtn;
        private RadioButton outSourcedRdBtn;
        private Button saveBtn;
        private Button cancelBtn;
        private Label partMachineIDLbl;
    }
}
