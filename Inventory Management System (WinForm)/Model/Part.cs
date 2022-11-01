using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Model
{
    public abstract class Part
    {
        public int PartID { get; }
        private string name;
        private decimal price;
        private int min;
        private int max;
        private int inStock;

        private static int partCount; // keeps the count statically for all parts created.
        public Part(string name, decimal price, int min, int max, int inStock) {
            PartID = partCount++; // post increment
            Name = name;
            Price = price;
            Min = min;
            Max = max;
            InStock = inStock;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0.0M)
                {
                    throw new ArgumentOutOfRangeException("Price [ArgumentOutOfRangeException]",
                        $"\n<{nameof(Part)}> : <{nameof(Price)}> cannot a negative number!");
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
                    throw new ArgumentOutOfRangeException("Min [ArgumentOutOfRangeException]",
                        $"\n<{nameof(Part)}> : <{nameof(Min)}> {value} cannot be less than 0.");
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
                        $"\n<{nameof(Part)}> : <{nameof(Max)}> {value} cannot be less than {min}");
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
                        $"\n<{nameof(Part)}> : <{nameof(InStock)}> {value} cannot be less than {min}" + 
                                            $"and greather than {max}.");
                }

                inStock = value;
            }
        }

        public override string ToString()
        {
            return $"{nameof(PartID)}: {PartID}\n" +
                $"{nameof(Name)}: {Name}\n" +
                $"{nameof(Price)}: {Price}\n" +
                $"{nameof(InStock)}: {InStock}\n" +
                $"{nameof(Min)}: {Min}\n" +
                $"{nameof(Max)}: {Max}\n\n";
        }

        public string ToStringForProducts()
        {
            return $"---{nameof(PartID)}: {PartID}\n" +
                $"---{nameof(Name)}: {Name}\n" +
                $"---{nameof(Price)}: {Price}\n" +
                $"---{nameof(InStock)}: {InStock}\n" +
                $"---{nameof(Min)}: {Min}\n" +
                $"---{nameof(Max)}: {Max}\n";
        }
    }
}
