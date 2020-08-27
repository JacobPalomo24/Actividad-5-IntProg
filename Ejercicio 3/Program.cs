using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cotizador_precio_leche {
    class Program {
        static void Main(string[] args){
            /*
             * 3.- Un productor de leche lleva el registro de lo que produce en litros, pero cuando entrega
             *     le pagan en galones. Ayude al productor a saber cuánto recibirá por la entrega de su
             *     producción de un día (1 galón = 3.785 litros).
             *
             *          1. Inicio
             *          2. Leer L, PG
             *          3. Hacer TG = (L / 3.785)
             *          4. Hacer GA = PG * TG
             *          5. Escribir GA
             *          6. Fin
             */

            Console.Write("Ingrese los litros producidos: ");
            double l = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio por galón: ");
            double pg = double.Parse(Console.ReadLine());

            double tg = l / 3.785;
            double ganancia = pg * tg;

            Console.Write("\nLas ganancias por la producción de " + l + " litros (" + tg + " galones) es de $" + ganancia + " pesos.");

            Console.Write("\nPresione cualquier tecla para salir...");
            Console.ReadKey(true);
        }
    }
}
