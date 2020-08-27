using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_triangulo {
    class Program {
        static void Main(string[] args){
            /*
            ========================================= Problema 1 =========================================

                1.- Se requiere conocer el área de un rectángulo. Como se sabe, para poder obtener el
                área del rectángulo, primeramente se tiene que conocer la base y la altura, y una vez
                obtenidas se presenta el resultado.

                    1. Inicio
                    2. Leer A, B
                    3. Hacer Área = B * A
                    4. Escribir Área
                    5. Fin

            ===============================================================================================
            */
            Console.Write("Ingrese el tamaño de la altura: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("\nIngrese el tamaño de la base: ");
            int B = int.Parse(Console.ReadLine());
            
            int area = B * A;

            Console.WriteLine("\nEl área del triángulo es: " + area);

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey(true);

        }
    }
}
