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

        public static void addInhousePartToInventory(in PartUC partUserComponent) {
            var newInhousePart = new Inhouse(
                 int.Parse(partUserComponent.Controls["machineIDorCompanyNameTxtBox"].Text),
                 partUserComponent.Controls["partNameTxtBox"].Text,
                 decimal.Parse(partUserComponent.Controls["partPriceTxtBox"].Text),
                 int.Parse(partUserComponent.Controls["partInventoryTxtBox"].Text),
                 int.Parse(partUserComponent.Controls["partMinTxtBox"].Text),
                 int.Parse(partUserComponent.Controls["partMaxTxtBox"].Text));

            Inventory.addPart(newInhousePart);
        }

        public static void addOutsourcedPartToInventory(in PartUC partUserComponent)
        {
            var newOutsourcedPart = new Outsourced(
                 partUserComponent.Controls["machineIDorCompanyNameTxtBox"].Text,
                 partUserComponent.Controls["partNameTxtBox"].Text,
                 decimal.Parse(partUserComponent.Controls["partPriceTxtBox"].Text),
                 int.Parse(partUserComponent.Controls["partInventoryTxtBox"].Text),
                 int.Parse(partUserComponent.Controls["partMinTxtBox"].Text),
                 int.Parse(partUserComponent.Controls["partMaxTxtBox"].Text));

            Inventory.addPart(newOutsourcedPart);
        }

        public static void updateInhousePartToInventory(in int index, in PartUC partUserComponent)
        {
            var storedInhousePart = Inventory.lookupPart(index);

            storedInhousePart.Name = partUserComponent.Controls["partNameTxtBox"].Text;
            storedInhousePart.Price = decimal.Parse(partUserComponent.Controls["partPriceTxtBox"].Text);
            storedInhousePart.InStock = int.Parse(partUserComponent.Controls["partInventoryTxtBox"].Text);
            storedInhousePart.Min = int.Parse(partUserComponent.Controls["partMinTxtBox"].Text);
            storedInhousePart.Max = int.Parse(partUserComponent.Controls["partMaxTxtBox"].Text);
            ((Inhouse)storedInhousePart).MachineID = int.Parse(partUserComponent.Controls["machineIDorCompanyNameTxtBox"].Text);

            Inventory.updatePart(index, storedInhousePart);
        }

        public static void updateOutsourcedPartToInventory(in int index, in PartUC partUserComponent)
        {
            var storedOutsourcedPart = Inventory.lookupPart(index);

            storedOutsourcedPart.Name = partUserComponent.Controls["partNameTxtBox"].Text;
            storedOutsourcedPart.Price = decimal.Parse(partUserComponent.Controls["partPriceTxtBox"].Text);
            storedOutsourcedPart.InStock = int.Parse(partUserComponent.Controls["partInventoryTxtBox"].Text);
            storedOutsourcedPart.Min = int.Parse(partUserComponent.Controls["partMinTxtBox"].Text);
            storedOutsourcedPart.Max = int.Parse(partUserComponent.Controls["partMaxTxtBox"].Text);
            ((Outsourced)storedOutsourcedPart).CompanyName = partUserComponent.Controls["machineIDorCompanyNameTxtBox"].Text;

            Inventory.updatePart(index, storedOutsourcedPart);
        }

        public static Part lookUpPartFromTheInventory(in int index)
        {
            return Inventory.lookupPart(index);
        }


        //public static void addPart(Part part)
        //{
        //    //AllPartList.Add(part);
        //}
        //public static void addInventoryPart(in PartUC partUC)
        //{
        //    int id;
        //    Validate.ValidateNullorEmptyString(partUC.InventoryTxtBox.Text);
        //    Validate.ValidateNumericInput(partUC.IDTxtBox.Text, out id);
        //    Validate.ValidateNullorEmptyString(partUC.NameTxtBox.Text);
        //    Validate.ValidateNullorEmptyString(partUC.InventoryTxtBox.Text);
        //    Validate.ValidateNullorEmptyString(partUC.NameTxtBox.Text);
        //}
    }


}
