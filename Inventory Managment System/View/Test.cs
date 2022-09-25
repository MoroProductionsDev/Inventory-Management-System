using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
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
                var list = new BindingList<Part>();
                list.Add(new Inhouse(133, "screw", 3.99M, 1, 1, 2));
                list.Add(new Inhouse(224, "nail", 10.34M, 3, 5, 10));
                list.Add(new Inhouse(332, "hammer", 3.99M, 5, 4, 8));
                list.Add(new Inhouse(578, "brush", 2.45M, 2, 3, 3));

                list.Add(new Outsourced("Lowes", "fence", 3.99M, 1, 1, 2));
                list.Add(new Outsourced("Home Depot", "block", 10.34M, 3, 5, 10));
                list.Add(new Outsourced("Intel", "Silicon Chip", 659.99M, 5, 4, 8));
                list.Add(new Outsourced("Asus", "MotherBoard", 479.98M, 2, 3, 3));

                foreach (var part in list)
                {
                    Console.WriteLine(part);
                }
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
