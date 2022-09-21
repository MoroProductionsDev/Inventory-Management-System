using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Model
{
    internal abstract class Part
    {
        public int PartID { get; set; }
        public abstract string Name { get; set; }
        public abstract decimal Price { get; set; }
        public abstract int InStock { get; set; }
        public abstract int Min { get; set; }
        public abstract int Max { get; set; }

        public Part(string name, decimal price, int inStock, int min, int max) {

        }
    }
}
