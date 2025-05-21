using System;

/*Calcular el promedio de una cantidad indeterminada de números, el rango de números ingresados es de 0 a 100.
El usuario no conoce en ningún momento la cantidad de números a ingresar.*/

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int suma = 0;
            int contador = 0;

            while (num != -1)
            {
                Console.WriteLine("Ingrese un número (0-100) o -1 para salir:");
                num = Convert.ToInt32(Console.ReadLine());
                if (num >= 0 && num <= 100)
                {
                    suma += num;
                    contador++;
                }
                else if (num != -1)
                {
                    Console.WriteLine("Número fuera de rango. Intente nuevamente.");
                }
            }

            if (contador > 0)
            {
                double promedio = (double)suma / contador;
                Console.WriteLine($"El promedio de los números ingresados es: {promedio}");
            }
            else
            {
                Console.WriteLine("No se ingresaron números.");
            }

            Console.ReadKey();
        }
    }
}
