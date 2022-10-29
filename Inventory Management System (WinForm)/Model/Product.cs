using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Model
{
    internal class Product
    {
        public BindingList<Part> AssociatedParts { get; }
        public int ProductID { get; }
        public string Name { get; set; }
        private decimal price;
        private int inStock;
        private int min;
        private int max;
        private static int productCount;    // keeps the count statically for all products created.

        public Product(string name, decimal price, int inStock, int min, int max)
        {
            AssociatedParts = new BindingList<Part>();
            ProductID = ++productCount;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0.0M)
                {
                    throw new ArgumentOutOfRangeException(
                        $"\n<{nameof(Product)}> : <{nameof(Price)}> cannot a negative number!");
                }
                price = value;
            }
        }

        public int Min
        {
            get => min;
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine(min);
                    throw new ArgumentOutOfRangeException(
                        $"\n<{nameof(Product)}> : <{nameof(Min)}> {value} cannot be less than or equal to 0.");
                }
                min = value;
            }
        }

        public int Max
        {
            get => max;
            set
            {
                if (value == int.MaxValue)
                {
                    throw new ArgumentNullException(
                        $"\n<{nameof(Product)}> : <{nameof(Min)}> {min} hasn't been initialize yet!");
                }
                else if (value < min)
                {
                    throw new ArgumentOutOfRangeException(
                        $"\n<{nameof(Product)}> : <{nameof(Max)}> {value} cannot be less than {min}");
                }
                max = value;
            }
        }

        public int InStock
        {
            get => inStock;
            set
            {
                inStock = value;
            }
        }

        public void addAssociatedPart(Part addingPart)
        {
            AssociatedParts.Add(addingPart);
        }

        public bool removeAssociatedPart(int index)
        {
            bool isSuccessful;
            if (index < 0 || index >= AssociatedParts.Count) {
                isSuccessful = false;
            } else
            {
                AssociatedParts.RemoveAt(index);
                isSuccessful = true;
            }
            return isSuccessful;
        }

        public Part lookupAssociatedPart(int index)
        {
            if (index < 0 || index >= AssociatedParts.Count)
            {
                throw new IndexOutOfRangeException(
                $"\n<{nameof(Product)}> : <{nameof(index)}> {index} is out of range.\n" +
                $"{nameof(AssociatedParts)} list has {AssociatedParts.Count} elements.");
            }

            return AssociatedParts[index];
        }

        public override string ToString()
        {

            return $"{nameof(ProductID)}: {ProductID}\n" +
                $"{nameof(Name)}: {Name}\n" +
                $"{nameof(Price)}: {Price}\n" +
                $"{nameof(InStock)}: {InStock}\n" +
                $"{nameof(Min)}: {Min}\n" +
                $"{nameof(Max)}: {Max}\n" +
                $"{toStringParts()}";
        }

        // Returns a string concatination of all the parts listed in the psroduct
        private string toStringParts()
        {
            string productsParts = "";
            foreach(var part in AssociatedParts) {
                productsParts += $"{part.ToStringForProducts()}\n"; 
            }
            return productsParts;
        }
    }
}
