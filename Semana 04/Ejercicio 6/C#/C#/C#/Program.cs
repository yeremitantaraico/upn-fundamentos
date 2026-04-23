using System;

namespace EjercicioCalificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 6: Calificación cualitativa según promedio
            // Enunciado: Dado el promedio de un estudiante (0-20), asigna una calificación
            // cualitativa (Deficiente, Regular, Bueno, Excelente) usando rangos.
            // Se utiliza if - else if - else para evaluar las condiciones en orden.

            Console.Write("Ingrese el promedio (0-20): ");
            double promedio = double.Parse(Console.ReadLine());

            // Validación de valor fuera de rango
            if (promedio < 0 || promedio > 20)
            {
                Console.WriteLine("Valor inválido");
            }
            // Evaluación de rangos según la tabla
            else if (promedio <= 5)
            {
                Console.WriteLine("Calificación: Deficiente");
            }
            else if (promedio <= 10)
            {
                Console.WriteLine("Calificación: Regular");
            }
            else if (promedio <= 14)
            {
                Console.WriteLine("Calificación: Bueno");
            }
            else
            {
                Console.WriteLine("Calificación: Excelente");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}