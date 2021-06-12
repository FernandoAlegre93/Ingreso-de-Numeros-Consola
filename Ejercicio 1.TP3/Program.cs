using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_1.TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, i;
            int pos = 0;
            int neg = 0;

            for (i = 1; i <= 20; i++)
            {

                Console.WriteLine("Ingrese un numero ");
                numero = Int32.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    neg = numero + neg;
                }
                else
                {
                    pos = pos + 1;
                }
            }

            Console.WriteLine("La cantidad de numeros positivos ingresados es: {0}", pos);
            Console.WriteLine("La suma de todos los numeros negativos ingresados es: {0}", neg);
            Console.ReadKey();
        }
    }
}
