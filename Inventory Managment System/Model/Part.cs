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
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;
        public Part(string name, decimal price, int inStock, int min, int max) {

        }

        public string Name
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

        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0.0M)
                {
                    throw new ArgumentOutOfRangeException(
                        $"\n<{nameof(Inventory_Managment_System.Model.Product)}> : <{nameof(this.Price)}> cannot a negative number!");
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
                        $"\n<{nameof(Inventory_Managment_System.Model.Product)}> : <{nameof(this.Min)}> {value} cannot be less than or equal to 0.");
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

        public int InStock
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

        public override string ToString()
        {
            return $"{nameof(PartID)} {PartID}\n" +
                $"{nameof(Name)} {Name}\n" +
                $"{nameof(Price)} {Price}\n" +
                $"{nameof(InStock)} {InStock}\n" +
                $"{nameof(Min)} {Min}\n" +
                $"{nameof(Max)} {Max}\n";
        }

    }
}
