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
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; }
        public string Name { get; set; }
        private decimal price;
        private int min;
        private int max;
        private int inStock;
        private static int productCount;    // keeps the count statically for all products created.

        public Product(string name, decimal price, int min, int max, int inStock)
        {
            AssociatedParts = new BindingList<Part>();
            ProductID = productCount++;
            Name = name;
            Price = price;
            Min = min;
            Max = max;
            InStock = inStock;
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0.0M)
                {
                    throw new ArgumentOutOfRangeException("Price [ArgumentOutOfRangeException]",
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
                if (value < 0)
                {
                    Console.WriteLine(min);
                    throw new ArgumentOutOfRangeException("Min [ArgumentOutOfRangeException]",
                        $"\n<{nameof(Product)}> : <{nameof(Min)}> {value} cannot be less than 0.");
                }
                min = value;
            }
        }

        public int Max
        {
            get => max;
            set
            {
                if (value < min)
                {
                    throw new ArgumentOutOfRangeException("Max [ArgumentOutOfRangeException]",
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
                if (value > max || value < min)
                {
                    throw new ArgumentOutOfRangeException("InStock [ArgumentOutOfRangeException]",
                        $"\n<{nameof(Product)}> : <{nameof(InStock)}> {value} cannot be less than {min}" +
                                            $"and greather than {max}.");
                }

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
                $"<{nameof(Product)}> : <{nameof(index)}> {index} is out of range.\n" +
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
