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
            // [char.IsNumber] will also validate for negative numbers.
            // For this case it is convinient.
            if (userInput.All(char.IsNumber))
            {
                isNumeric = true;
            }
            else
            {
                isNumeric = false;
            }

            return isNumeric;
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
    }
}
