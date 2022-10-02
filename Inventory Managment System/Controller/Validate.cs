using Inventory_Managment_System.Model;
using Inventory_Managment_System.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inventory_Managment_System.Controller
{
    internal static class Validate
    {
        public static bool ValidateNumericInput(ref string userInput, out int id)
        {
            //if (id.All(char.IsNumber)) {
            //    Console.WriteLine($"{id} is a num!");
            //} else
            //{
            //    Console.WriteLine($"{id} is a not num!");
            //}

            return int.TryParse(userInput, out id);

        }

        public static void ValidateNullorEmptyString(ref string userinput)
        {
            if (string.IsNullOrWhiteSpace(userinput))
            {
                throw new NullReferenceException(
                    $"\n<{nameof(Part)}> : <{nameof(userinput)}> " +
                    $"cannot be empty or whitespace only.\nMust have characters!");
            }
        }
    }
}
