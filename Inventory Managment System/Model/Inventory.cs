using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Model
{
    internal class Inventory
    {
        public BindingList<Product> Products { get; }
        public BindingList<Part> AllParts { get; }

        public Inventory() {
            Products = new BindingList<Product>();
            AllParts = new BindingList<Part>();
        }

        public void addProduct(Product addingProduct)
        {
            Products.Add(addingProduct);
        }

        public bool removeProduct(int index)
        {
            bool isSuccessful;
            if (index < 0 || index >= Products.Count)
            {
                isSuccessful = false;
            }
            else
            {
                Products.RemoveAt(index);
                isSuccessful = true;
            }
            return isSuccessful;
        }

        public Product lookupProduct(int index)
        {
            if (index < 0 || index >= Products.Count)
            {
                throw new IndexOutOfRangeException(
                $"\n<{nameof(Inventory)}> : <{nameof(index)}> {index} is out of range.\n" +
                $"{nameof(Products)} list has {Products.Count} elements.");
            }

            return Products[index];
        }

        public void updateProduct(int index, Product updatingProduct)
        {
            if (index < 0 || index >= Products.Count)
            {
                throw new IndexOutOfRangeException(
                $"\n<{nameof(Inventory)}> : <{nameof(index)}> {index} is out of range.\n" +
                $"{nameof(Products)} list has {Products.Count} elements.");
            }

            Products[index] = updatingProduct;
        }

        //--------------------------------------------------------------
        public void addPart(Part addingPart)
        {
            AllParts.Add(addingPart);
        }

        public void deletePart(Part deletingPart)
        {
            AllParts.Remove(deletingPart);
        }

        public Part lookupPart(int index)
        {
            if (index < 0 || index >= AllParts.Count)
            {
                throw new IndexOutOfRangeException(
                $"\n<{nameof(Inventory)}> : <{nameof(index)}> {index} is out of range.\n" +
                $"{nameof(AllParts)} list has {AllParts.Count} elements.");
            }

            return AllParts[index];
        }

        public void updatePart(int index, Part updatingPart)
        {
            if (index < 0 || index >= AllParts.Count)
            {
                throw new IndexOutOfRangeException(
                $"\n<{nameof(Inventory)}> : <{nameof(index)}> {index} is out of range.\n" +
                $"{nameof(AllParts)} list has {AllParts.Count} elements.");
            }

            AllParts[index] = updatingPart;
        }
    }
}
