using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Calcular el promedio de 20 números ingresados por el usuario.

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, promedio;
            int suma = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un número:");
                num = Convert.ToInt32(Console.ReadLine());
                suma += num;
            }

            promedio = suma / 20;

            Console.WriteLine("El promedio de los 20 números es: " + promedio);

            Console.ReadKey();

        }
    }
}
