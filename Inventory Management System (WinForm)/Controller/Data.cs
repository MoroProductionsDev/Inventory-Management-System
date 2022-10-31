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
        private readonly BindingList<Part> allPartList;
        private readonly BindingList<Product> productList;

        public Data() {
            allPartList = Inventory.AllParts;
            productList = Inventory.Products;
        }

        public BindingList<Part> AllPartList
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
    }
}
