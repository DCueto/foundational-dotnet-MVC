using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUniversity.CSharp;

public static class Methods
{
    public static void PrintText(string text) => Console.WriteLine(text);

    public static void PrintRandomNumber(int rangeNumber = 2, string message = "The random number is:")
    {
        var random = new Random();

        for (int i = 1; i <= rangeNumber; i++)
        {
            var randomNumber = random.Next(1, 100);
            Console.WriteLine($"{message} {randomNumber}");
        }
    }

    // Get a value with a param by reference -> Not usual, normally you get the value by return
    public static void CalcTotalSalary(int salary, int tax, int healthInsurance, out int total)
    {
        total = salary - tax - healthInsurance;
    }

    public static string GetMessageByAge(int age) 
    {
        if (age < 18)
        {
            return "Is under-age";
        }

        return "Is of legal age";
    }

    public static void ManageTuples(bool printMessage)
    {
        Console.WriteLine("Explicit tuple");
        (int a, string b, bool c) myTupple = (20, "Daniel Cueto", printMessage);

        Console.WriteLine($"Print first tuple value: {myTupple.a}");
        Console.WriteLine(myTupple.c ? $"Print second tuple value: {myTupple.b}" : $"Print third tuple value: {myTupple.c}");

        Console.WriteLine("Implicit tuple");
        var mySecondTuple = (100, "Implicit tuple", !printMessage);

        Console.WriteLine($"First tuple value: {mySecondTuple.Item1}");
        Console.WriteLine($"Second tuple value: {mySecondTuple.Item2}");
        Console.WriteLine($"Third tuple value: {mySecondTuple.Item3}");
    }

    public static (string productName, double productPrice, int productStock) GetNewShopProduct()
    {
        Console.WriteLine("Insert product name:");
        string productName = Console.ReadLine()!;

        Console.WriteLine("Insert product price:");
        int productPrice = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Insert product stock:");
        int productStock = int.Parse(Console.ReadLine()!);

        double finalPrice = productPrice * 1.2;

        return (productName, finalPrice, productStock);
    }

}
