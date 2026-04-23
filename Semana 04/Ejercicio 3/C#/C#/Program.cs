using System;

namespace EjercicioIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 3: Clasificación de IMC (rangos + funciones matemáticas)
            // Enunciado: El Índice de Masa Corporal se calcula como IMC = peso / (estatura)^2. 
            // Clasifica a la persona según la tabla: <18.5 (Bajo), 18.5-25 (Normal), 25-30 (Sobrepeso), >30 (Obesidad).
            // El programa debe mostrar el IMC redondeado a 2 decimales usando Math.Pow y Math.Round.

            Console.Write("Ingrese el peso en kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la estatura en metros: ");
            double estatura = double.Parse(Console.ReadLine());

            // Cálculo del IMC elevando la estatura al cuadrado
            double imc = peso / Math.Pow(estatura, 2);

            // Redondeo del resultado a 2 posiciones decimales
            double imcRed = Math.Round(imc, 2);

            Console.WriteLine($"\nTu IMC es: {imcRed}");

            // Evaluación de rangos según la tabla de salud
            if (imc < 18.5)
            {
                Console.WriteLine("Clasificación: Bajo peso (Color: Azul)");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Clasificación: Normal (Color: Verde)");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Clasificación: Sobrepeso (Color: Amarillo)");
            }
            else
            {
                Console.WriteLine("Clasificación: Obesidad (Color: Rojo)");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}