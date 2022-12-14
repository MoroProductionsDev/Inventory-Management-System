using Inventory_Managment_System.Model;
using Inventory_Managment_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System.Controller
{
    internal static class Controller
    {
        public static Data data = new Data();
        public static void createPartList()
        {
            Inventory.addPart(new Inhouse(133, "screw", 3.99M, 1, 2, 1));
            Inventory.addPart(new Inhouse(224, "nail", 10.34M, 5, 10, 8));
            Inventory.addPart(new Inhouse(332, "hammer", 3.99M, 4, 8, 5));
            Inventory.addPart(new Inhouse(578, "brush", 2.45M, 3, 4, 3));

            Inventory.addPart(new Outsourced("Lowes", "fence", 3.99M, 1, 2, 1));
            Inventory.addPart(new Outsourced("Home Depot", "block", 10.34M, 5, 10, 7));
            Inventory.addPart(new Outsourced("Intel", "Silicon Chip", 659.99M, 4, 10, 8));
            Inventory.addPart(new Outsourced("Asus", "MotherBoard", 479.98M, 1, 3, 3));
        }

        public static void createProductList()
        {

            Inventory.addProduct(new Product("Yellow Bicycle", 15.67M, 12, 25, 20));
            Inventory.addProduct(new Product("Red Bicycle", 19.34M, 15, 25, 20));
            Inventory.addProduct(new Product("Blue Bicycle", 23.86M, 5, 25, 23));

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
                 int.Parse(partUserComponent.Controls["partMachineIDorCompanyNameTxtBox"].Text.Trim()),
                 partUserComponent.Controls["partNameTxtBox"].Text.Trim(),
                 decimal.Parse(partUserComponent.Controls["partPriceTxtBox"].Text.Trim()),
                 int.Parse(partUserComponent.Controls["partMinTxtBox"].Text.Trim()),
                 int.Parse(partUserComponent.Controls["partMaxTxtBox"].Text.Trim()),
                 int.Parse(partUserComponent.Controls["partInventoryTxtBox"].Text.Trim()));

            Inventory.addPart(newInhousePart);
        }

        public static void addOutsourcedPartToInventory(in PartUC partUserComponent)
        {
            var newOutsourcedPart = new Outsourced(
                 partUserComponent.Controls["partMachineIDorCompanyNameTxtBox"].Text.Trim(),
                 partUserComponent.Controls["partNameTxtBox"].Text.Trim(),
                 decimal.Parse(partUserComponent.Controls["partPriceTxtBox"].Text.Trim()),
                 int.Parse(partUserComponent.Controls["partMinTxtBox"].Text.Trim()),
                 int.Parse(partUserComponent.Controls["partMaxTxtBox"].Text.Trim()),
                 int.Parse(partUserComponent.Controls["partInventoryTxtBox"].Text.Trim()));

            Inventory.addPart(newOutsourcedPart);
        }

        public static void updateInhousePartInInventory(in PartUC partUserComponent, in int index)
        {
            var storedInhousePart = Inventory.lookupPart(index);

            if (storedInhousePart.GetType().Equals(typeof(Inhouse)))
            {
                storedInhousePart.Name = partUserComponent.Controls["partNameTxtBox"].Text.Trim();
                storedInhousePart.Price = decimal.Parse(partUserComponent.Controls["partPriceTxtBox"].Text.Trim());
                storedInhousePart.Min = int.Parse(partUserComponent.Controls["partMinTxtBox"].Text.Trim());
                storedInhousePart.Max = int.Parse(partUserComponent.Controls["partMaxTxtBox"].Text.Trim());
                storedInhousePart.InStock = int.Parse(partUserComponent.Controls["partInventoryTxtBox"].Text.Trim());
                ((Inhouse)storedInhousePart).MachineID = int.Parse(partUserComponent.Controls["partMachineIDorCompanyNameTxtBox"].Text.Trim());

                Inventory.updatePart(index, storedInhousePart);
            }
            else
            {
                var newInhousePart = modifyPartTypes(partUserComponent, storedInhousePart); // this will store the same part but modified.
                Inventory.updatePart(index, newInhousePart);
            }
        }

        public static void updateOutsourcedPartInInventory(in PartUC partUserComponent, in int index)
        {
            var storedOutsourcedPart = Inventory.lookupPart(index);

            if (storedOutsourcedPart.GetType().Equals(typeof(Outsourced)))
            {   
                storedOutsourcedPart.Name = partUserComponent.Controls["partNameTxtBox"].Text.Trim();
                storedOutsourcedPart.Price = decimal.Parse(partUserComponent.Controls["partPriceTxtBox"].Text.Trim());
                storedOutsourcedPart.Min = int.Parse(partUserComponent.Controls["partMinTxtBox"].Text.Trim());
                storedOutsourcedPart.Max = int.Parse(partUserComponent.Controls["partMaxTxtBox"].Text.Trim());
                storedOutsourcedPart.InStock = int.Parse(partUserComponent.Controls["partInventoryTxtBox"].Text.Trim());
                ((Outsourced)storedOutsourcedPart).CompanyName = partUserComponent.Controls["partMachineIDorCompanyNameTxtBox"].Text.Trim();

                Inventory.updatePart(index, storedOutsourcedPart);
            }
            else
            {
                var newOutsourcedPart = modifyPartTypes(partUserComponent, storedOutsourcedPart); // this will store the same part but modified.
                Inventory.updatePart(index, newOutsourcedPart);
            }
        }

        public static void deletePartFromInventory(in int index)
        {
            var deletePart = Inventory.lookupPart(index);
            Inventory.deletePart(deletePart);
        }

        public static Part lookUpPartFromTheInventory(in int index)
        {
            return Inventory.lookupPart(index);
        }

        public static int searchForPartNameInTheInventory(in DataGridView partsDataGridView, in string searchString)
        {
            return UIDataGridViewValidator.findMatchingPart(partsDataGridView, Inventory.AllParts,searchString);
        }

        private static Part modifyPartTypes(PartUC partUserComponent, in Part storedpart)
        {
            Part modifiablePart;
            if (storedpart.GetType().Equals(typeof(Inhouse)))
            {
                modifiablePart = new Outsourced(
                    partUserComponent.Controls["partMachineIDorCompanyNameTxtBox"].Text.Trim(),
                    partUserComponent.Controls["partNameTxtBox"].Text.Trim(),
                    decimal.Parse(partUserComponent.Controls["partPriceTxtBox"].Text.Trim()),
                    int.Parse(partUserComponent.Controls["partMinTxtBox"].Text.Trim()),
                    int.Parse(partUserComponent.Controls["partMaxTxtBox"].Text.Trim()),
                    int.Parse(partUserComponent.Controls["partInventoryTxtBox"].Text.Trim()));
            }
            else
            {
                modifiablePart = new Inhouse(
                    int.Parse(partUserComponent.Controls["partMachineIDorCompanyNameTxtBox"].Text.Trim()),
                    partUserComponent.Controls["partNameTxtBox"].Text.Trim(),
                    decimal.Parse(partUserComponent.Controls["partPriceTxtBox"].Text.Trim()),
                    int.Parse(partUserComponent.Controls["partMinTxtBox"].Text.Trim()),
                    int.Parse(partUserComponent.Controls["partMaxTxtBox"].Text.Trim()),
                    int.Parse(partUserComponent.Controls["partInventoryTxtBox"].Text.Trim()));
            }
            return modifiablePart;
        }

        public static void addProductToInventory(in ProductUC productUserComponent, in BindingList<Part> newAssociatedParts)
        {
            var newProduct = new Product(
                 productUserComponent.Controls["productNameTxtBox"].Text.Trim(),
                 decimal.Parse(productUserComponent.Controls["productPriceTxtBox"].Text.Trim()),
                 int.Parse(productUserComponent.Controls["productMinTxtBox"].Text.Trim()),
                 int.Parse(productUserComponent.Controls["productMaxTxtBox"].Text.Trim()),
                 int.Parse(productUserComponent.Controls["productInventoryTxtBox"].Text.Trim()));

            addAssociatedPartsToProduct(newProduct, newAssociatedParts);

            Inventory.addProduct(newProduct);
        }

        public static void updateProductInInventory(in ProductUC productUserComponent, in BindingList<Part> newAssociatedParts, in int index)
        {
            var storedProduct = Inventory.lookupProduct(index);

            storedProduct.Name = productUserComponent.Controls["productNameTxtBox"].Text.Trim();
            storedProduct.Price = decimal.Parse(productUserComponent.Controls["productPriceTxtBox"].Text.Trim());
            storedProduct.Min = int.Parse(productUserComponent.Controls["productMinTxtBox"].Text.Trim());
            storedProduct.Max = int.Parse(productUserComponent.Controls["productMaxTxtBox"].Text.Trim());
            storedProduct.InStock = int.Parse(productUserComponent.Controls["productInventoryTxtBox"].Text.Trim());

            storedProduct.AssociatedParts = newAssociatedParts;

            Inventory.updateProduct(index, storedProduct);
        }

        private static void addAssociatedPartsToProduct(in Product product, in BindingList<Part> associatedParts)
        {
            foreach (var part in associatedParts)
            {
                product.addAssociatedPart(part);
            }
        }

        public static Product lookUpProductFromTheInventory(in int index)
        {
            return Inventory.lookupProduct(index);
        }


        public static int searchForProductNameInTheInventory(in DataGridView productsDataGridView, in string searchString)
        {
            return UIDataGridViewValidator.findMatchingPart(productsDataGridView, Inventory.Products, searchString);
        }
        public static void deleteProductFromInventory(in int index)
        {
            Inventory.removeProduct(index);
        }
    }
}
