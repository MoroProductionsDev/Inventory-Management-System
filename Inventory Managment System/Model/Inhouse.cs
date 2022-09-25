using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Model
{
    internal class Inhouse : Part
    {
        public int MachineID { get; set; }

        public Inhouse(int machineID, string name, decimal price, int inStock, int min, int max) : base(name, price, inStock, min, max)
        {
            MachineID = machineID;
        }

        public override string ToString()
        {
            return $"{nameof(MachineID)}: {MachineID}\n" + base.ToString();
        }
    }
}
