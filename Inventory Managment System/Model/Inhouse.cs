using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Model
{
    internal class Inhouse : Part
    {
        public int MachineID { get; set; }
        private static int partCount;
        public Inhouse(string name, decimal price, int inStock, int min, int max) : base(name, price, inStock, min, max)
        {
            PartID = ++partCount;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
    }
}
