using Inventory_Managment_System.Model;
using Inventory_Managment_System.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Controller
{
    internal static class Controller
    {
        public static Data data = new Data();

        public static void createPartList()
        {
            Inventory.addPart(new Inhouse(133, "screw", 3.99M, 1, 1, 2));
            Inventory.addPart(new Inhouse(224, "nail", 10.34M, 3, 5, 10));
            Inventory.addPart(new Inhouse(332, "hammer", 3.99M, 5, 4, 8));
            Inventory.addPart(new Inhouse(578, "brush", 2.45M, 2, 3, 3));

            Inventory.addPart(new Outsourced("Lowes", "fence", 3.99M, 1, 1, 2));
            Inventory.addPart(new Outsourced("Home Depot", "block", 10.34M, 3, 5, 10));
            Inventory.addPart(new Outsourced("Intel", "Silicon Chip", 659.99M, 5, 4, 8));
            Inventory.addPart(new Outsourced("Asus", "MotherBoard", 479.98M, 2, 3, 3));
        }

        public static void createProductList()
        {

            Inventory.addProduct(new Product("Yellow Bicycle", 15.67M, 12, 20, 25));
            Inventory.addProduct(new Product("Red Bicycle", 19.34M, 15, 20, 25));
            Inventory.addProduct(new Product("Blue Bicycle", 23.86M, 19, 20, 25));


            Inventory.lookupProduct(0).addAssociatedPart(data.AllPartList[2]);
            Inventory.lookupProduct(0).addAssociatedPart(data.AllPartList[3]);

            Inventory.lookupProduct(1).addAssociatedPart(data.AllPartList[5]);
            Inventory.lookupProduct(1).addAssociatedPart(data.AllPartList[6]);
            Inventory.lookupProduct(1).addAssociatedPart(data.AllPartList[0]);
            Inventory.lookupProduct(1).addAssociatedPart(data.AllPartList[2]);

            Inventory.lookupProduct(2).addAssociatedPart(data.AllPartList[1]);
            Inventory.lookupProduct(2).addAssociatedPart(data.AllPartList[4]);
            Inventory.lookupProduct(2).addAssociatedPart(data.AllPartList[7]);
        }


        public static void addPart(Part part)
        {
            //AllPartList.Add(part);
        }
        public static void addInventoryPart(in PartUC partUC)
        {
            int id;
            Validate.ValidateNullorEmptyString(partUC.InventoryTxtBox.Text);
            Validate.ValidateNumericInput(partUC.IDTxtBox.Text, out id);
            Validate.ValidateNullorEmptyString(partUC.NameTxtBox.Text);
            Validate.ValidateNullorEmptyString(partUC.InventoryTxtBox.Text);
            Validate.ValidateNullorEmptyString(partUC.NameTxtBox.Text);
        }

        public static void validateUITextBox(in PartUC partUC)
        {
            foreach (var txtBox in partUC.Controls.OfType<TextBox>())
            {
                try
                {
                    Validate.ValidateNullorEmptyString(txtBox.Text);
                }
                catch (NullReferenceException nullRefExcp)
                {
                    txtBox.BackColor = Color.Red;
                    //Console.WriteLine($"{nullRefExcp.Message} CAUGHT!");
                }
            }
        }
    }


}
