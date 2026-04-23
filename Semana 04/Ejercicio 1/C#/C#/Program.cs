using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1: Aplicar descuento por compra mínima.
            // Si el monto es mayor o igual a 100, se aplica un 10% de descuento.
            // En caso contrario, no se aplica ningún descuento.
            // El total a pagar es el monto ingresado menos el descuento calculado.

            // Ingresar el monto de la compra
            Console.WriteLine("Ingrese el monto de la compra:");
            int compra = int.Parse(Console.ReadLine());

            // Inicializar con descuento 0

            double descuento = 0;

            // Verificar si se aplica el descuento

            if (compra >= 100)
            {
                descuento = compra * 0.10; // Calcular el descuento del 10%
            }

            // calcular el total a pagar

            double totalPagar = compra - descuento;

            // Mostrar el resultado

            Console.WriteLine($"Monto de la compra: {compra}");
            Console.WriteLine($"Descuento aplicado: {descuento}");
            Console.WriteLine($"Total a pagar: {totalPagar}");
            Console.ReadKey();
        }
    }
}
