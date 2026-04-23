using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 2: Implementar un menú de opciones usando switch en C#.
            // El usuario selecciona una opción numérica y se ejecuta la acción correspondiente.
            // Cada caso dentro del switch representa una opción del menú.
            // Permite manejar múltiples decisiones de forma ordenada y clara.

            Console.WriteLine("=== Menú de Operaciones===");
            Console.WriteLine("1. Calcular el area de un circulo ");
            Console.WriteLine("2. Calcular el area de un cuadrado ");
            Console.WriteLine("3. Calcular el area de un triangulo ");
            Console.Write("4. Salir ");

            // Seleccion de la opcion
            int option = int.Parse(Console.ReadLine());

            // Select de opciones
            switch (option) // evalua el valor de la variable

            {
                case 1:
                    Console.WriteLine("Area circulo = p x r2");
                    break; // obligatorio en C# - termina el case
                case 2:
                    Console.WriteLine("Area cuadrdado = lado2");
                    break;
                case 3:
                    Console.WriteLine("Area triangulo = (base x altura)/2)");
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa");
                    break;

                default: // si ningun case coincide
                    Console.WriteLine("Opcion invalida. Ingresa un numero del 1 al 4.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
