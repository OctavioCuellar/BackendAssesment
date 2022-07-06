using System;

namespace CalculadoraApp
{
    public class Calculadora
    {
        public static double HacerOperacion(double num1, double num2, string op) // Este método lo usaremos en la clase Programa
        {
            double resultado = double.NaN; // Si un valor dado no es un número o no es valido como el 0 en una división, entonces genera un error

            // Utilizo switch para elegir entre las operaciones a realizar
            switch (op)
            {
                case "s":
                    resultado = num1 + num2;
                    break;
                case "r":
                    resultado = num1 - num2;
                    break;
                case "m":
                    resultado = num1 * num2;
                    break;
                case "d":
                    // Para el divisor se le pide al usuario que ingrese un número diferente de 0
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    break;

                default: // Se devuelve un aviso en caso de ingresar una opción incorrecta
                    break;
            }
            return resultado;

        }
    }

}
