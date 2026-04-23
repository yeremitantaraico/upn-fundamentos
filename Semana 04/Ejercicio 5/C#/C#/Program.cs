using System;

namespace EjercicioAcceso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 5: Acceso a un servicio por edad (condicional doble)
            // Enunciado: Validar si un usuario tiene 18 años o más para registrarse.
            // Si es menor, calcular cuántos años le faltan usando Math.Abs para obtener
            // la diferencia como un valor absoluto (siempre positivo).

            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            // Estructura condicional doble
            if (edad >= 18)
            {
                Console.WriteLine("Acceso permitido. Bienvenido.");
            }
            else
            {
                // Math.Abs asegura que (edad - 18) no devuelva un número negativo
                int faltantes = Math.Abs(edad - 18);

                Console.WriteLine("Acceso denegado.");
                Console.WriteLine($"Te faltan {faltantes} año(s) para registrarte.");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}