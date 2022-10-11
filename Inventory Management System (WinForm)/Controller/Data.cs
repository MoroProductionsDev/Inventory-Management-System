using Inventory_Managment_System.Model;
using Inventory_Managment_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Controller
{
    internal class Data
    {
        private BindingList<Part> allPartList;
        private BindingList<Product> productList;
        public Data() {
            allPartList = Inventory.AllParts;
            productList = Inventory.Products;
            createPartList();
            createProductList();
        }

        public BindingList<Part> PartList
        {
            get
            {
                return allPartList;
            }
        }

        public BindingList<Product> ProductList
        {
            get
            {
                return productList;
            }
        }

        public void addPart(Part part)
        {
            allPartList.Add(part);
        }
        private void createPartList()
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

        private void createProductList()
        {
            Inventory.addProduct(new Product("Yellow Bicycle", 15.67M, 12, 20, 25));
            Inventory.addProduct(new Product("Red Bicycle", 19.34M, 15, 20, 25));
            Inventory.addProduct(new Product("Blue Bicycle", 23.86M, 19, 20, 25));


            Inventory.lookupProduct(0).addAssociatedPart(allPartList[2]);
            Inventory.lookupProduct(0).addAssociatedPart(allPartList[3]);

            Inventory.lookupProduct(1).addAssociatedPart(allPartList[5]);
            Inventory.lookupProduct(1).addAssociatedPart(allPartList[6]);
            Inventory.lookupProduct(1).addAssociatedPart(allPartList[0]);
            Inventory.lookupProduct(1).addAssociatedPart(allPartList[2]);

            Inventory.lookupProduct(2).addAssociatedPart(allPartList[1]);
            Inventory.lookupProduct(2).addAssociatedPart(allPartList[4]);
            Inventory.lookupProduct(2).addAssociatedPart(allPartList[7]);
        }
    }
}
