using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Model
{
    internal class Product
    {
       
        public int ProductID { get; set; }
        private BindingList<Part> associatedParts;

        //private int min = int.MaxValue; // these value will facilitate the validation between min and max. In case of a default constructor
        //private int max = int.MinValue; 

        //public Product(BindingList<Part> partList, string name, decimal price, int inStock, int min, int max) :
        //    base(name, price, inStock, min, max)
        //{
        //    associatedParts = partList;

        //    // abstract overriden base parameters
        //    Name = name;
        //    Price = price;
        //    InStock = inStock;
        //    Min = min;
        //    Max = max;
        //}

        //public BindingList<Part> AssociatedParts
        //{
        //    get => associatedParts;
        //}

        //

        //public void addAssociatedPart(Part addingPart)
        //{
        //    associatedParts.Add(addingPart);
        //}

        //public bool removeAssociatedPart(int index)
        //{
        //    if (associatedParts[])
        //    {

        //    }
        //}

        //public Part lookupAssociatedPart(int index)
        //{

        //}
    }
}
