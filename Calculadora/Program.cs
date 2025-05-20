using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("Calculadora");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Elevar un número a la potencia");
                Console.WriteLine("6. Salir");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingrese un numero valido");
                    continue;
                }

                if (opcion >= 1 && opcion <= 5)
                {
                    Console.WriteLine("Ingrese el primer número:");
                    if (!Double.TryParse(Console.ReadLine(), out double num1))
                    {
                        Console.WriteLine("Ingrese un número válido");
                        continue;
                    }
                    double num2 = 0;
                    if (opcion != 5)
                    {
                        Console.Write("Ingrese el segundo número: ");
                        if (!double.TryParse(Console.ReadLine(), out num2))
                        {
                            Console.WriteLine("Ingrese un número valido.\n");
                            continue;
                        }
                    }

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine($"La suma de {num1} + {num2} es: {num1 + num2}");
                            break;
                        case 2:
                            Console.WriteLine($"La resta de {num1} - {num2} es: {num1 - num2}");
                            break;
                        case 3:
                            Console.WriteLine($"La multiplicacion de {num1} * {num2} es: {num1 * num2}");
                            break;
                        case 4:
                            if (num2 == 0)
                            {
                                Console.WriteLine("No se puede dividir entre cero.");
                            }
                            else
                            {
                                Console.WriteLine($"La division de {num1} / {num2} es: {num1 / num2}");
                            }
                            break;
                        case 5:
                            Console.WriteLine($"La potencia de {num1} elevado a {num2} es: {Math.Pow(num1, num2)}");
                            break;


                    }

                }
                else if (opcion == 6)
                {
                    Console.WriteLine("Gracias por usar la calculadora.");
                }
                else
                {
                    Console.WriteLine("Seleccione una opción válida.\n");
                }

            } while (opcion != 6);
        }
    
      }
  }
