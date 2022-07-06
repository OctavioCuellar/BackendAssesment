using System;

namespace CalculadoraApp
{
    public class Operaciones
    {
        public static void Main(string[] args)
        {
            bool terminarPrograma = false; // El programa seguirá corriendo en consola de manera indefinida hasta que el usuario ingrese la letra "n"

            // Se muestra el título del programa en consola
            Console.WriteLine("Calculadora en consola\r");
            Console.WriteLine("----------------------\n");

            while (!terminarPrograma)
            {
                // Declarar variables como vacías.
                string numInput1 = "";
                string numInput2 = "";
                double resultado = 0;

                // Preguntar al usuario por el primer número
                Console.Write("Ingresa el primer número y presiona Enter: ");
                numInput1 = Console.ReadLine();

                double vaciarNum1 = 0;
                while (!double.TryParse(numInput1, out vaciarNum1))
                {
                    Console.Write("Este número no es válido. Por favor ingresa un valor entero: ");
                    numInput1 = Console.ReadLine();
                }

                // Preguntar al usuario por el segundo número
                Console.Write("Ingresa el segundo número y presiona Enter: ");
                numInput2 = Console.ReadLine();

                double vaciarNum2 = 0;
                while (!double.TryParse(numInput2, out vaciarNum2))
                {
                    Console.Write("Este número no es válido. Por favor ingresa un valor entero: ");
                    numInput2 = Console.ReadLine();
                }

                // Pedir al usuario que ingrese la opción de la operación a realizar.
                Console.WriteLine("Selecciona una operación de la siguiente lista:");
                Console.WriteLine("\ts - Sumar");
                Console.WriteLine("\tr - Restar");
                Console.WriteLine("\tm - Multiplicar");
                Console.WriteLine("\td - Dividir");
                Console.Write("¿Cuál es tu operación a realizar? ");

                string op = Console.ReadLine(); // op = operación

                try
                {
                    resultado = Calculadora.HacerOperacion(vaciarNum1, vaciarNum2, op);
                    if (double.IsNaN(resultado))
                    {
                        Console.WriteLine("Esta operación resultará en un error matemático.\n");
                    }
                    else Console.WriteLine("Tu resultado es: {0:0.##}\n", resultado);
                }
                catch (Exception e)
                {
                    Console.WriteLine("¡Ay no! Una excepción ha occurrido intentado hacer la operación.\n - Details: " + e.Message);
                }

                Console.WriteLine("----------------------\n");

                // Esperar al usuario antes de cerrar.
                Console.Write("Presiona 'n' y luego Enter para cerrar el programa, o presione cualquier otra tecla y luego Enter para continuar: ");
                if (Console.ReadLine() == "n") terminarPrograma = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }

}
