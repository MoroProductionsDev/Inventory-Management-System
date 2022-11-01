using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Model
{
    internal static class Inventory
    {
        private static BindingList<Product> products = new BindingList<Product>();
        public static BindingList<Product> Products { get => products; }
        private static BindingList<Part> allParts = new BindingList<Part>();
        public static BindingList<Part> AllParts { get => allParts; }

        public static void addProduct(Product addingProduct)
        {
            products.Add(addingProduct);
        }

        public static bool removeProduct(int index)
        {
            bool isSuccessful;
            if (index < 0 || index >= Products.Count)
            {
                isSuccessful = false;
            }
            else
            {
                products.RemoveAt(index);
                isSuccessful = true;
            }
            return isSuccessful;
        }

        public static Product lookupProduct(int index)
        {
            if (index < 0 || index >= products.Count)
            {
                throw new IndexOutOfRangeException(
                $"\n<{nameof(Inventory)}> : <{nameof(index)}> {index} is out of range.\n" +
                $"{nameof(products)} list has {products.Count} elements.");
            }

            return products[index];
        }

        public static void updateProduct(int index, Product updatingProduct)
        {
            if (index < 0 || index >= Products.Count)
            {
                throw new IndexOutOfRangeException(
                $"\n<{nameof(Inventory)}> : <{nameof(index)}> {index} is out of range.\n" +
                $"{nameof(products)} list has {products.Count} elements.");
            }

            products[index] = updatingProduct;
        }

        //--------------------------------------------------------------
        public static void addPart(Part addingPart)
        {
            allParts.Add(addingPart);
        }

        public static bool deletePart(Part deletingPart)
        {
            return allParts.Remove(deletingPart);
        }

        public static Part lookupPart(int index)
        {
            if (index < 0 || index >= allParts.Count)
            {
                throw new IndexOutOfRangeException(
                $"\n<{nameof(Inventory)}> : <{nameof(index)}> {index} is out of range.\n" +
                $"{nameof(allParts)} list has {allParts.Count} element(s).");
            }

            return allParts[index];
        }

        public static void updatePart(int index, Part updatingPart)
        {
            if (index < 0 || index >= allParts.Count)
            {
                throw new IndexOutOfRangeException(
                $"\n<{nameof(Inventory)}> : <{nameof(index)}> {index} is out of range.\n" +
                $"{nameof(allParts)} list has {allParts.Count} element(s).");
            }

            allParts[index] = updatingPart;
        }

        public static new string ToString()
        {
            string prodList = "";
            foreach (var prod in products)
            {
                prodList += prod;
            }
            return prodList;
        }
    }
}
