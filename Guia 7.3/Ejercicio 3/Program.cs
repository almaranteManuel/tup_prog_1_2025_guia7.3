using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Menor Mayor(Mientras, centinela)
//Determinar el mayor y el menor valor de una cantidad indeterminada de números. El usuario no conoce en ningún momento la cantidad de números a ingresar.
//El rango de valores posibles es entre 0 y 100.


namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int menor, mayor, num;

            Console.WriteLine("Ingrese un número (0-100) o -1 para salir:");
            num = Convert.ToInt32(Console.ReadLine());

            menor = num;
            mayor = num;

            while (num != -1)
            {
                Console.WriteLine("Ingrese un número (0-100) o -1 para salir:");
                num = Convert.ToInt32(Console.ReadLine());

                if (num >= 0 && num <= 100)
                {
                    if (num < menor)
                    {
                        menor = num;
                    }
                    if (num > mayor)
                    {
                        mayor = num;
                    }
                }
                else if (num != -1)
                {
                    Console.WriteLine("Número fuera de rango. Intente nuevamente.");
                }
            }

            Console.WriteLine("El mayor número ingresado es: " + mayor);
            Console.WriteLine("El menor número ingresado es: " + menor);

            Console.ReadKey();
        }
    }
}
