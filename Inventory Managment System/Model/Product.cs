using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Model
{
    internal class Product : Part
    {
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        private string name;
        private decimal price;

        public Product(string name, decimal price, int inStock, int min, int max) : 
            base(name, price, inStock, min, max)
        {
            Name = name;
            Price = price;
        }

        public override string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException(
                        $"\n<{nameof(Inventory_Managment_System)}> : <{nameof(this.Name)}> cannot be empty or whitespace only.\nMust have characters!");
                }
                name = value;
            }
        }

        public override decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0.0M)
                {
                    throw new ArgumentException(
                        $"\n<{nameof(Inventory_Managment_System)}> : <{nameof(this.Price)}> cannot a negative number!");
                }
                price = value;
            }
        }
    }
}
