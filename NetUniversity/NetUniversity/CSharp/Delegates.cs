
namespace NetUniversity.CSharp;

public delegate string MyDelegate(int arg1, int arg2);
public delegate int MyDelegate2(int i, string s);
public delegate void PrintDelegate(int arg1, int arg2);

public static class Delegates
{
    public static void RunDelegates()
    {
        MyDelegate sum = SumNumbers;
        Console.WriteLine($"The result is {sum(10, 100)}");

        MyDelegate mult = MultiplifyNumbers;
        Console.WriteLine($"The result is {mult(10, 100)}");

        // Anonymous delegate
        MyDelegate2 anonDel = delegate(int i, string s)
        {
            return i + 100;
        };

        Console.WriteLine($"Delegate result is {anonDel(250, "Daniel Cueto")}");

        // Compound Delegates
        Console.WriteLine("Compound Delegates");
        PrintDelegate printSum = PrintSum;
        PrintDelegate printMult = PrintMult;
        PrintDelegate printSumMult = printSum + printMult;

        int arg1 = 10;
        int arg2 = 25;

        Console.WriteLine("Running first delegate");
        printSum(arg1, arg2);

        Console.WriteLine("Running second delegate");
        printMult(arg1, arg2);

        Console.WriteLine("Running compound delegate (first and second)");
        printSumMult(arg1, arg2);

        Console.WriteLine("Running compund delegate but without multiply one");
        printSumMult -= printMult;
        printSumMult(arg1, arg2); 
    }

    public static string SumNumbers(int a, int b) => (a + b).ToString();

    public static string MultiplifyNumbers(int a, int b) => (a * b).ToString();

    public static void PrintSum(int a, int b) => Console.WriteLine(SumNumbers(a, b));

    public static void PrintMult(int a, int b) => Console.WriteLine(MultiplifyNumbers(a, b));
}
