using Inventory_Managment_System.Controller;
using Inventory_Managment_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System.View
{
    public partial class AddPartForm : Form
    {
        private readonly DataGridView partsDataGridView;
        public AddPartForm()
        {
            InitializeComponent();
            partsDataGridView = TabControlUC.tabControlUC_Instance.TableDataGridView["partsDataGridView"];
        }
        private void partUC_Load(object sender, EventArgs e)
        {
            UITextBoxValidator.modifyAllEmptyOrNullTextbox(partUC);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var isInhouseRdBtnChecked = ((RadioButton)partUC.Controls["inHouseRdBtn"]).Checked;

            if (!UITextBoxValidator.checkTextBoxesForEmptyString(partUC) && partUC.partUCValidator.checkTextBoxesForNumericInput(isInhouseRdBtnChecked))
            {
                try
                {
                    if (isInhouseRdBtnChecked)
                    {
                        Controller.Controller.addInhousePartToInventory(in partUC);
                    }
                    else
                    {
                        Controller.Controller.addOutsourcedPartToInventory(in partUC);
                    }

                    var newPartRowIndex = UIDataGridViewValidator.getTableRowCount(partsDataGridView);

                    UIDataGridViewValidator.recreateTableData(partsDataGridView, Inventory.AllParts, newPartRowIndex);

                    this.Close();
                    Program.ShowInitialAppForm();

                } catch(ArgumentOutOfRangeException argOutOfRangeExcp)
                {
                    if (argOutOfRangeExcp.ParamName != null && argOutOfRangeExcp.ParamName.Equals("Max [ArgumentOutOfRangeException]"))
                    {
                        UIMsgBox.displayMinExceedsMaxWarning(int.Parse(partUC.Controls["partMinTxtBox"].Text),
                                                    int.Parse(partUC.Controls["partMaxTxtBox"].Text));
                    }
                    else
                    {
                        throw argOutOfRangeExcp;
                    }
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.ShowInitialAppForm();
        }
    }
}
