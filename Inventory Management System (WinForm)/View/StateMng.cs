using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.View
{
    internal static class StateMng
    {
        private static Dictionary<string, object> stateMng = new Dictionary<string, object>(); // keep the state of certain object in the UI controller 

        public static Dictionary<string, object> State{
            get => stateMng; 
        }

        public static void setState(string key, object value)
        {
            stateMng.Add(key, value);
        }
    }
}
