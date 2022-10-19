using Inventory_Managment_System.Controller;
using Inventory_Managment_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System.View
{
    public partial class PartUC : UserControl
    {
        private RadioButton InHouseRadioButton { get => inHouseRdBtn; }
        public RadioButton OutSourcedRadioButton { get => outSourcedRdBtn; }
        public TextBox IDTxtBox { get => partIDTxtBox; }
        public TextBox NameTxtBox { get => partNameTxtBox; }

        public TextBox InventoryTxtBox { get => partInventoryTxtBox; }
        public TextBox PriceTxtBox { get => partPriceTxtBox; }

        public TextBox MinTxtBox { get => partMinTxtBox; }
        public TextBox MaxTxtBox { get => partMaxTxtBox; }

        public Button SaveButton { get => saveBtn; }
        public Button CancelButton { get => cancelBtn; }

        private List<TextBox> textBoxList;

        private String[] textBoxName;

        public PartUC()
        {
            InitializeComponent();
            textBoxList = new List<TextBox>() { NameTxtBox, InventoryTxtBox,
                partPriceTxtBox, partMinTxtBox, partMaxTxtBox };
            textBoxName = new String[] {InventoryTxtBox.Name, partPriceTxtBox.Name,
                        partMinTxtBox.Text, partMaxTxtBox.Text };
        }

        private void inHouseRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.machineID.Visible = true;
            this.partCompanyNameLbl.Visible = false;
        }

        private void outSourcedRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.machineID.Visible = false;
            this.partCompanyNameLbl.Visible = true;
        }

        private void partNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            modifyNullOrEmptyTxtBox_TextChanged(sender, e);
        }

        private void partInventoryTxtBox_TextChanged(object sender, EventArgs e)
        {
            modifyNullOrEmptyTxtBox_TextChanged(sender, e);
            if (inHouseRdBtn.Checked)
            {
                modifyNonNumericTxtBox_TextChanged(sender, e);
            }
        }

        private void partPriceTxtBox_TextChanged(object sender, EventArgs e)
        {
            modifyNullOrEmptyTxtBox_TextChanged(sender, e);
            modifyNonNumericTxtBox_TextChanged(sender, e);
        }

        private void partMinTxtBox_TextChanged(object sender, EventArgs e)
        {
            modifyNullOrEmptyTxtBox_TextChanged(sender, e);
            modifyNonNumericTxtBox_TextChanged(sender, e);
        }

        private void partMaxTxtBox_TextChanged(object sender, EventArgs e)
        {
            modifyNullOrEmptyTxtBox_TextChanged(sender, e);
            modifyNonNumericTxtBox_TextChanged(sender, e);
        }

        private void machineIDorCompanyNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            modifyNullOrEmptyTxtBox_TextChanged(sender, e);

            if (inHouseRdBtn.Checked)
            {
                modifyNonNumericTxtBox_TextChanged(sender, e);
            }
        }

        private void modifyNullOrEmptyTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sender.GetType().Equals(typeof(TextBox)))
            {
                try
                {
                    Controller.Validate.ValidateNullorEmptyString(((TextBox)sender).Text);
                    ((TextBox)sender).BackColor = Color.White;
                }
                catch (NullReferenceException)
                {
                    ((TextBox)sender).BackColor = Color.OrangeRed;
                }
            }
        }

        private void modifyNonNumericTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sender.GetType().Equals(typeof(TextBox)))
            {

                if (Controller.Validate.ValidateNumericInput(((TextBox)sender).Text))
                {
                    ((TextBox)sender).BackColor = Color.White;
                }
                else
                {
                    ((TextBox)sender).BackColor = Color.OrangeRed;
                }
            }
        }

        //public bool validTextBoxText()
        //{
        //    foreach(var textBox in textBoxList)
        //    {
        //        try
        //        {
        //            Controller.Validate.ValidateNullorEmptyString(textBox.Text);
        //            if (Array.Exists(textBoxName, name => textBox.Name == name))
        //            {
        //                Validate.ValidateNumericInput(textBox);
        //            }
        //        }
        //        catch (NullReferenceException)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
    }
}
