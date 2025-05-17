using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_que_permita_digitar_10_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            Console.WriteLine("Ingrese 10 números desordenados:");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Número {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.WriteLine("Ingrese un número válido:");
                    Console.Write($"Número {i + 1}: ");
                }
            }

            Array.Sort(numeros);
            Console.WriteLine("Los números ordenados son:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}