using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUniversity.CSharp;

public static class Exceptions
{
    public static void RunAcumWithException()
    {
        int acumulador = 0;
        int numero = 0;

        do
        {
            Console.WriteLine("Ingrese un numero a sumar: ");

            try
            {
                numero = int.Parse(Console.ReadLine()!);
            }
            catch (System.FormatException e)
            {
                Console.WriteLine($"Error: {e.Message}");

                if (e.Message is null)
                {
                    throw;
                }

                continue;
            }

            acumulador += numero;

        } while (numero != 0);

        Console.WriteLine($"El resultado de la suma es: {acumulador}");
    }
};