using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExcepciones
{
    internal class Program
    {
     
            static void Main()
            {
                Operaciones operaciones = new Operaciones();

                Console.Write("Ingresa el primer número: ");
                if (double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.Write("Ingresa el segundo número: ");
                    if (double.TryParse(Console.ReadLine(), out double num2))
                    {
                        try
                        {
                            Console.WriteLine($"Suma: {operaciones.Sumar(num1, num2)}");
                            Console.WriteLine($"Resta: {operaciones.Restar(num1, num2)}");
                            Console.WriteLine($"Multiplicación: {operaciones.Multiplicar(num1, num2)}");
                            Console.WriteLine($"División: {operaciones.Dividir(num1, num2)}");
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El segundo valor ingresado no es válido.");
                    }
                }
                else
                {
                    Console.WriteLine("El primer valor ingresado no es válido.");
                }
            }
    }
 }

