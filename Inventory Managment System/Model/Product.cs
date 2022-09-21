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
       
        public int ProductID { get; set; }
        private BindingList<Part> associatedParts;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;
        //private int min = int.MaxValue; // these value will facilitate the validation between min and max. In case of a default constructor
        //private int max = int.MinValue; 

        public Product(BindingList<Part> partList, string name, decimal price, int inStock, int min, int max) :
            base(name, price, inStock, min, max)
        {
            associatedParts = partList;

            // abstract overriden base parameters
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public BindingList<Part> AssociatedParts
        {
            get => associatedParts;
        }

        public override string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException(
                        $"\n<{nameof(Inventory_Managment_System.Model.Product)}> : <{nameof(this.Name)}> " +
                        $"cannot be empty or whitespace only.\nMust have characters!");
                }
                name = value;
            }
        }

        public override decimal Price
        {
            get => price;
            set{
                if (value < 0.0M)
                {
                    throw new ArgumentOutOfRangeException(
                        $"\n<{nameof(Inventory_Managment_System.Model.Product)}> : <{nameof(this.Price)}> cannot a negative number!");
                }
                price = value;
            }
        }

        public override int Min {
            get => min;
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine(min);
                    throw new ArgumentOutOfRangeException(
                        $"\n<{nameof(Inventory_Managment_System.Model.Product)}> : <{nameof(this.Min)}> {value} cannot be less than or equal to 0.");
                }
                min = value;
            }
        }

        public override int Max
        {
            get => max;
            set
            {
                if (value == int.MaxValue)
                {
                    throw new ArgumentNullException(
                        $"\n<{nameof(Inventory_Managment_System.Model.Product)}> : <{nameof(this.Min)}> {min} hasn't been initialize yet!");
                }
                else if (value < min)
                {
                    throw new ArgumentOutOfRangeException(
                        $"\n<{nameof(Inventory_Managment_System.Model.Product)}> : <{nameof(this.Max)}> {value} cannot be less than {min}");
                }
                max = value;
            }
        }

        public override int InStock
        {
            get => inStock;
            set
            {
                //if (value > max || value < min)
                //{
                //    throw new ArgumentOutOfRangeException(
                //        $"\n<{nameof(Inventory_Managment_System.Model.Product)}> : <{nameof(this.inStock)}> {value} cannot be less than {min} " +
                //        $"nor greather than {max}");
                //}
                inStock = value;
            }
        }

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
