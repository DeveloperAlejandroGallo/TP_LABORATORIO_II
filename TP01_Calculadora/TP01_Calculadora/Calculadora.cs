using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01_Calculadora
{
    public class Calculadora
    {
        /// <summary>
        /// Recibe 2 objetos Numero y un operador, y devuelve la operacion entre ellos
        /// o cero si la operacion es inválida.
        /// </summary>
        /// <param name="numero1">Variable Tipo Numero</param>
        /// <param name="numero2">Variable Tipo Numero</param>
        /// <param name="operador">Variable string +,-,*,/</param>
        /// <returns>Resultado de la operacion entre ambos numeros</returns>
        public static double Operar(Numero numero1, Numero numero2,string operador)
        {
            double result = 0, nro1, nro2;
            

            nro1 = numero1.GetNumero();
            nro2 = numero2.GetNumero();

            switch (ValidarOperador(operador))
            {
                case "+":
                    result = nro1 + nro2;
                    break;
                case "-":
                    result = nro1 - nro2;
                    break;
                case "*":
                    result = nro1 * nro2;
                    break;
                case "/":
                    if (nro2 != 0)
                        result = nro1 / nro2;
                    else
                    {
                        result = 0;
                    }
                    break;
                default:
                    break;
            }

            return result;
        }
        /// <summary>
        /// Verifica si es uno de los signos +,-,*,/. Caso contrario devuelve +.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static string ValidarOperador(string operador)
        {
            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
                return operador;
            else
                return "+";
        }

    }
}
