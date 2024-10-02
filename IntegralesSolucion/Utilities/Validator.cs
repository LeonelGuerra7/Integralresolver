using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace YourNamespace.Utilities
{
    public class Validator
    {
        public bool IsValidExpression(string expresion)
        {
            // Validación de la expresión, permitiendo funciones trigonométricas
            return Regex.IsMatch(expresion, @"^[0-9a-zA-Z\s\+\-\*\/\^()sin|cos|tan]*$");
        }
    }
}


