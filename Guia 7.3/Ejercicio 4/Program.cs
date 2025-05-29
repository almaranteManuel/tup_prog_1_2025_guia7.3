using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Mayor y menor (Para)
//Determinar el mayor y el menor de una cantidad de 30 números. El rango de números a ingresar se desconoce.

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nros = 30;
            int menor, mayor, num;

            Console.WriteLine("Ingrese un número:");
            num = Convert.ToInt32(Console.ReadLine());
            menor = num;
            mayor = num;

            for (int i = 1; i < nros; i++)
            {
                Console.WriteLine("Ingrese un número:");
                num = Convert.ToInt32(Console.ReadLine());

                    if (num < menor)
                    {
                        menor = num;
                    }
                    if (num > mayor)
                    {
                        mayor = num;
                    }

            }

            Console.WriteLine("El mayor número ingresado es: " + mayor);
            Console.WriteLine("El menor número ingresado es: " + menor);

            Console.ReadKey();

        }
    }
}
