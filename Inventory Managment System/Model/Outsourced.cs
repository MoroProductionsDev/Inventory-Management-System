using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inventory_Managment_System.Model
{
    internal class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(string companyName, string name, decimal price, int inStock, int min, int max) : base(name, price, inStock, min, max)
        {
            CompanyName = companyName;
        }

        public override string ToString()
        {
            return $"{nameof(CompanyName)}: {CompanyName}\n" + base.ToString();
        }
    }
}
