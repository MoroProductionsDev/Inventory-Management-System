using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Model
{
    internal abstract class Part
    {
        public int PartID { get; }
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;

        private static int partCount; // keeps the count statically for all parts created.
        public Part(string name, decimal price, int inStock, int min, int max) {
            PartID = ++partCount;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
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
                    throw new ArgumentOutOfRangeException(
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
                if (value <= 0)
                {
                    Console.WriteLine(min);
                    throw new ArgumentOutOfRangeException(
                        $"\n<{nameof(Part)}> : <{nameof(Min)}> {value} cannot be less than or equal to 0.");
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
                        $"\n<{nameof(Part)}> : <{nameof(Min)}> {min} hasn't been initialize yet!");
                }
                else if (value < min)
                {
                    throw new ArgumentOutOfRangeException(
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
                //if (value > max || value < min)
                //{
                //    throw new ArgumentOutOfRangeException(
                //        $"\n<{nameof(.Part)}> : <{nameof(this.inStock)}> {value} cannot be less than {min} " +
                //        $"nor greather than {max}");
                //}
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
