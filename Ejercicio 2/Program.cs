using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_circunferencia {
    class Program {
        static void Main(string[] args){

            /* 
             *   2.- Se requiere obtener el área de una circunferencia.
             *
             *        1. Inicio
             *        2. Leer R
             *        3. Hacer PI = 3.1416
             *        4. Hacer Área = PI * R * R
             *        5. Escribir Área
             *        6. Fin 
             */

            Console.Write("Ingresa el radio: ");
            double R = int.Parse(Console.ReadLine());

            const double PI = 3.1416;

            double area = PI * (R * R);

            Console.WriteLine("EL área de la crcunferencia es: " + area);

            Console.Write("\nPresiona cualquier tecla para salir...");
            Console.ReadKey(true);
        }
    }
}
