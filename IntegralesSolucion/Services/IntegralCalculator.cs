using System;
using YourNamespace.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Symbolics;


using System;
using YourNamespace.Utilities;
namespace YourNamespace.Models
{
    public class IntegralCalculator
    {
        public string CalcularIntegral(string expresion)
        {
            try
            {
                // Usar el Parser para crear una instancia de Expression
                Parser parser = new Parser();
                Expression expression = parser.Parse(expresion);

                // Calcular la integral indefinida
                var resultado = CalculateIndefiniteIntegral(expression.Expresion);
                return resultado.ToString(); // Convertir el resultado a cadena
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        private SymbolicExpression CalculateIndefiniteIntegral(string expresion)
        {
            // Definir la variable
            var x = SymbolicExpression.Variable("x");

            // Intentar parsear la expresión
            SymbolicExpression expr;
            try
            {
                expr = SymbolicExpression.Parse(expresion);
            }
            catch (Exception)
            {
                throw new Exception("Error al parsear la expresión. Asegúrate de que la sintaxis sea correcta.");
            }

            // Calcular la integral
            SymbolicExpression integral;
            try
            {
                integral = expr.Integrate(x);
            }
            catch (Exception)
            {
                throw new Exception("Error al calcular la integral. Asegúrate de que la expresión sea compatible.");
            }

            // Devolver el resultado
            return integral;
        }
    }
}