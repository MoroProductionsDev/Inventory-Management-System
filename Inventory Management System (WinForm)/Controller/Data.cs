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
        private BindingList<Part> partList;
        private BindingList<Product> productList;
        public Data() {
            partList = new BindingList<Part>();
            productList = new BindingList<Product>();
            createPartList();
            createProductList();
        }

        public BindingList<Part> PartList
        {
            get
            {
                return partList;
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
            partList.Add(part);
        }
        private void createPartList()
        {
            partList.Add(new Inhouse(133, "screw", 3.99M, 1, 1, 2));
            partList.Add(new Inhouse(224, "nail", 10.34M, 3, 5, 10));
            partList.Add(new Inhouse(332, "hammer", 3.99M, 5, 4, 8));
            partList.Add(new Inhouse(578, "brush", 2.45M, 2, 3, 3));

            partList.Add(new Outsourced("Lowes", "fence", 3.99M, 1, 1, 2));
            partList.Add(new Outsourced("Home Depot", "block", 10.34M, 3, 5, 10));
            partList.Add(new Outsourced("Intel", "Silicon Chip", 659.99M, 5, 4, 8));
            partList.Add(new Outsourced("Asus", "MotherBoard", 479.98M, 2, 3, 3));
        }

        private void createProductList()
        {
            productList.Add(new Product("Yellow Bicycle", 15.67M, 12, 20, 25));
            productList.Add(new Product("Red Bicycle", 19.34M, 15, 20, 25));
            productList.Add(new Product("Blue Bicycle", 23.86M, 19, 20, 25));

            productList[0].addAssociatedPart(partList[2]);
            productList[0].addAssociatedPart(partList[3]);

            productList[1].addAssociatedPart(partList[5]);
            productList[1].addAssociatedPart(partList[6]);
            productList[1].addAssociatedPart(partList[0]);
            productList[1].addAssociatedPart(partList[2]);

            productList[2].addAssociatedPart(partList[1]);
            productList[2].addAssociatedPart(partList[4]);
            productList[2].addAssociatedPart(partList[7]);
        }
    }
}
