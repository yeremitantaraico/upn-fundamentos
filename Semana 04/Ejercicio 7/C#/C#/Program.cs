using System;

namespace EjercicioPromedioFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 7: Promedio final del alumno (2 mejores prácticas)
            // Enunciado: El sistema descarta la práctica más baja de tres y calcula el promedio
            // combinando: (parcial + final + promedio de las 2 mejores prácticas) / 3.
            // Se usa Math.Min anidado para encontrar la menor nota en C#.

            Console.Write("Ingresa examen parcial: ");
            double parcial = double.Parse(Console.ReadLine());
            Console.Write("Ingresa examen final: ");
            double final = double.Parse(Console.ReadLine());
            Console.Write("Ingresa práctica 1: ");
            double p1 = double.Parse(Console.ReadLine());
            Console.Write("Ingresa práctica 2: ");
            double p2 = double.Parse(Console.ReadLine());
            Console.Write("Ingresa práctica 3: ");
            double p3 = double.Parse(Console.ReadLine());

            // Paso 1: Encontrar la nota más baja para descartarla
            double minPrac = Math.Min(p1, Math.Min(p2, p3));

            // Paso 2: Calcular promedio de las 2 mejores prácticas
            double promPrac = (p1 + p2 + p3 - minPrac) / 2;

            // Paso 3: Calcular promedio final
            double promFinal = (parcial + final + promPrac) / 3;

            Console.WriteLine($"\nPromedio de prácticas: {promPrac}");
            Console.WriteLine($"Promedio final: {Math.Round(promFinal, 0)}");

            // Clasificación según el promedio final
            if (promFinal >= 18) Console.WriteLine("Excelente");
            else if (promFinal >= 14) Console.WriteLine("Bueno");
            else if (promFinal >= 10) Console.WriteLine("Regular");
            else Console.WriteLine("Deficiente");

            Console.ReadKey();
        }
    }
}