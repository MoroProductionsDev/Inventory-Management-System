using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.View
{
    internal static class Output
    {
        public static void PrintProductObj(Model.Product product)
        {
            Console.WriteLine($"{nameof(product)} {product}\n" +
            $"{nameof(product.Name)} {product.Name}\n" +
            $"{nameof(product.Price)} {product.Price}\n" +
            $"{nameof(product.InStock)} {product.InStock}\n" +
            $"{nameof(product.Min)} {product.Min}\n" +
            $"{nameof(product.Max)} {product.Max}");
        }
    }
}
