using System;

namespace EjercicioSueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 4: Sueldo final de un empleado (condición anidada)
            // Enunciado: Calcula el sueldo basándose en una tarifa por hora según la categoría (A, B, C)
            // y aplica una bonificación sobre el sueldo bruto según los años de servicio.
            // Se debe mostrar el sueldo final con dos decimales.

            Console.Write("Categoría (A/B/C): ");
            string cat = Console.ReadLine().ToUpper();

            Console.Write("Horas trabajadas: ");
            double horas = double.Parse(Console.ReadLine()); // Completa: double.Parse

            Console.Write("Años de servicio: ");
            int anios = int.Parse(Console.ReadLine()); // Completa: int.Parse

            double tarifa = 0;

            // Selección de tarifa por categoría
            if (cat == "A") tarifa = 33.50;      // Completa: "A" y 33.50
            else if (cat == "B") tarifa = 29.80; // Completa: "B" y 29.80
            else if (cat == "C") tarifa = 25.70; // Completa: "C" y 25.70
            else
            {
                Console.WriteLine("Categoría inválida");
                return;
            }

            double bono = 0;

            // Selección de bonificación por años de servicio
            if (anios <= 3) bono = 0.00; // 0-3 años
            else if (anios >= 4 && anios <= 10) bono = 0.10; // 4-10 años
            else if (anios >= 11 && anios <= 17) bono = 0.20; // 11-17 años
            else bono = 0.30; // 18 o más

            // Cálculo final: Sueldo Bruto * (1 + %bonificación)
            double sueldoFinal = tarifa * horas * (1 + bono);
            Console.WriteLine($"Sueldo: S/. {sueldoFinal:F2}");

            Console.ReadKey();
        }
    }
}