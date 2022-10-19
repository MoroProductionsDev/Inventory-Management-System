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
        public static bool ValidateNumericInput(string userInput)
        {
            bool isNumeric;
            if (userInput.All(char.IsNumber))
            {
                isNumeric = true;
            }
            else
            {
                isNumeric = false;
            }

            return isNumeric;
            //return int.TryParse(userInput, out id);

        }

        public static void ValidateNullorEmptyString(string userinput)
        {
            if (string.IsNullOrWhiteSpace(userinput))
            {
                throw new NullReferenceException(
                    $"\n<{nameof(Part)}> : <{nameof(userinput)}> " +
                    $"cannot be empty or whitespace only.\nMust have characters!");
            }
        }

        public static void ValidateType(Part part)
        {
            if (part is Inhouse)
            {
                Console.WriteLine(part.GetType());
            } else if (part is Outsourced)
            {
                Console.WriteLine(part.GetType());
            }
        }
    }
}
