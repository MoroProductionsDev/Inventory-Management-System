﻿using System;
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
                var partList = new BindingList<Part>();
                partList.Add(new Inhouse(133, "screw", 3.99M, 1, 1, 2));
                partList.Add(new Inhouse(224, "nail", 10.34M, 3, 5, 10));
                partList.Add(new Inhouse(332, "hammer", 3.99M, 5, 4, 8));
                partList.Add(new Inhouse(578, "brush", 2.45M, 2, 3, 3));

                partList.Add(new Outsourced("Lowes", "fence", 3.99M, 1, 1, 2));
                partList.Add(new Outsourced("Home Depot", "block", 10.34M, 3, 5, 10));
                partList.Add(new Outsourced("Intel", "Silicon Chip", 659.99M, 5, 4, 8));
                partList.Add(new Outsourced("Asus", "MotherBoard", 479.98M, 2, 3, 3));

                //foreach (var part in partList)
                //{
                //    Console.WriteLine(part);
                //}

                var productList = new BindingList<Product>();
                productList.Add(new Product("Yellow Bicycle", 15.67M, 12, 20, 25));
                productList.Add(new Product("Red Bicycle", 19.34M, 15, 20, 25));
                productList.Add(new Product("Blue Bicycle", 23.86M, 19, 20, 25));

                productList[0].addAssociatedPart(partList[2]);
                productList[0].addAssociatedPart(partList[3]);

                productList[1].addAssociatedPart(partList[5]);
                productList[1].addAssociatedPart(partList[6]);
                productList[1].addAssociatedPart(partList[0]);
                productList[1].addAssociatedPart(partList[2]);

                productList[2].addAssociatedPart(partList[1]);
                productList[2].addAssociatedPart(partList[4]);
                productList[2].addAssociatedPart(partList[7]);

                //foreach (var product in productList)
                //{
                //    Console.WriteLine(product);
                //}

                //Console.WriteLine($"Part ID:\"{partList[0].PartID}\" Name:\"{partList[0].Name}\" removed / does not exists in " +
                //                   $"Product ID:\"{productList[2].ProductID}\" Name:\"{productList[2].Name}\"? " + productList[2].removeAssociatedPart(0));

                //Console.WriteLine($"Part ID:\"{partList[1].PartID}\" Name:\"{partList[1].Name}\" removed / does not exists in " +
                //                   $"Product ID:\"{productList[2].ProductID}\" Name:\"{productList[2].Name}\"? " + productList[2].removeAssociatedPart(1));

                //foreach (var product in productList)
                //{
                //    Console.WriteLine(product);
                //}
                //}

                //Console.WriteLine(productList[1] + "\n------------\n");
                //Console.WriteLine(productList[1].lookupAssociatedPart(1).ToString());

                Inventory.addProduct(productList[0]);
                Inventory.addProduct(productList[1]);

                //Console.WriteLine(Inventory.ToString());

                //Console.WriteLine(Inventory.Products.Count);
                Console.WriteLine(Inventory.removeProduct(0));
                //Console.WriteLine(Inventory.Products.Count);
                //Console.WriteLine(Inventory.ToString());


                //Console.WriteLine(Inventory.lookupProduct(0));
                // Inventory.lookupProduct(1); // exception.

                Inventory.updateProduct(0, productList[2]);
                Console.WriteLine(Inventory.ToString());

                Console.WriteLine(productList[2]);

                //productList[2] = productList[0];

                //Console.WriteLine(productList[2]);

                Console.WriteLine(Inventory.ToString());
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
