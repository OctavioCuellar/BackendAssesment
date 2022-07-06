using System;
using System.Linq;

namespace LINQApp
{
      
    public class Program
    {

        public static void Main(string[] args)
        {

            // Se muestra el título del programa en consola
            Console.WriteLine("Consultas LINQ en consola\r");
            Console.WriteLine("-------------------------\n");

            // Las 3 partes de una consulta LINQ (fuente de la información/data, creación de las consultas, ejecución de las consultas y sus resultados):
            // Fuente de la información.
            string[] Personas = new string[13];
            Personas [0] = "Juan" ;
            Personas [1] = "Pablo";
            Personas [2] = "Pedro";
            Personas [3] = "Pepe";
            Personas [4] = "Ana";
            Personas [5] = "Esteban";
            Personas [6] = "Daniel";
            Personas [7] = "Mariano";
            Personas [8] = "Carolina";
            Personas [9] = "Silvia";
            Personas [10] = "Roberto";
            Personas [11] = "Juanito";
            Personas [12] = "Juana";

            // Creación de las consultas.

            // Ejercicio 2.1 Funcion que recibe un arreglo de strings y retorna el arreglo ordenado de forma descendente.
            var consultaDescendente = Personas.OrderByDescending(n => n);

            // Ejecución de la consulta.
            Console.Write("Lista ordenada de manera descendente:\n");
            foreach (string personas in consultaDescendente)
            {
                Console.Write(personas + "\n");
            }

            // Ejercicio 2.2 Funcion que recibe un arreglo de strings y un string objetivo,
            // la funcion retorna true en caso de encontrar el string objetivo dentro del arreglo de string, false en caso contrario.
            // var consultaBuscar = from b in Personas
            //                     where b.StartsWith("P") && b.EndsWith("o")
            //                     select b;
            //
            // this.buscar = consultaBuscar.Any().ToString();

            // Ejercicio 2.3 Funcion que recibe un arreglo de strings y retorna los elementos del arreglo que empiecen con “Juan”.
            var consultaJuan = from juan in Personas
                               where juan.Contains("Juan")
                               select juan;

            Console.Write("\nPersonas que contienen o empiezan con 'Juan': \n");
            foreach (var juan in consultaJuan)
            {
                Console.WriteLine("Nombre de la persona: {0}", juan);
            }

            // Ejercicio 2.4 Funcion que recibe un arreglo de strings y concatena a cada uno de los elementos dentro del string el prefijo “hola ”. (ex. “Hola Juan”).

            var consultaSaludando = from personas in Personas
                                    select personas;

            Console.Write("\nSaludando a todas las personas: \n");
            foreach (string personas in consultaSaludando)
            {
                Console.WriteLine("Hola {0} ", personas);
            }

            Console.ReadKey();

        }
    }
}
