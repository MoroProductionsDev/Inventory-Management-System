using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Inventory_Managment_System.Model; // Part, Product class

namespace Inventory_Managment_System.View
{
    internal class Test
    {
        // Test Case 1: Create an Product Object
        public static void RunTest()
        {
            try
            {
                var product = new Product("screw", 3.99M, 1, 1, 2);
                Output.PrintProductObj(product);
            }
            catch (NullReferenceException nullRefExcp)
            {
                Console.WriteLine($"{nullRefExcp.Message} CAUGHT!");
            }
            catch (ArgumentOutOfRangeException argOutofRangeExcp)
            {
                Console.WriteLine($"{argOutofRangeExcp.Message} CAUGHT!");
            }
            catch (ArgumentException argNullExcp)
            {
                Console.WriteLine($"{argNullExcp.Message} CAUGHT!");
            }
            //catch (ArgumentException argExcp)
            //{
            //    Console.WriteLine($"{argExcp.Message} CAUGHT!");
            //}
        }
    }
}
