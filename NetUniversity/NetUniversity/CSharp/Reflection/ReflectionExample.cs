using System.Reflection;

namespace NetUniversity.CSharp.Reflection;
public class ReflectionExample
{
    private static void ListGenericMethods(Type type)
    {
        int colWidth = 12;
        var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
        //Console.WriteLine($"Methods type are {type.Name}\n");
        string tableHeader = "Name".PadRight(colWidth) + "|" +
            "IsGeneric".PadRight(colWidth) + "|" +
            "IsGenericDef".PadRight(colWidth) + "|" +
            "ContainsGenParam".PadRight(colWidth);
        Console.WriteLine(tableHeader);

        foreach (var method in methods)
        {
            int maxNameLength = Math.Min(method.Name.Length, colWidth);
            Console.Write(method.Name.Substring(0, maxNameLength).PadRight(colWidth));
            Console.Write("|");
            Console.Write(method.IsGenericMethod.ToString().PadRight(colWidth));
            Console.Write("|");
            Console.Write(method.IsGenericMethodDefinition.ToString().PadRight(colWidth));
            Console.Write("|");
            Console.Write(method.ContainsGenericParameters.ToString().PadRight(colWidth));
            Console.WriteLine();
        }

        foreach (char ch in tableHeader) 
        {
            Console.Write("-");
        }

        Console.WriteLine("\n");
    }

    private static void ListTypeDetails(List<Type> types)
    {
        //Console.WriteLine($"Type Name".PadRight(20) + 
        //    "|" + "IsGenericType?".PadRight(20) + 
        //    "|" + "IsGenericDefinition?".PadRight(20)
        //);

        foreach (var type in types) {
            Console.WriteLine($"Type Name".PadRight(20) +
                "|" + "IsGenericType?".PadRight(20) +
                "|" + "IsGenericDefinition?".PadRight(20)
            );

            string output = type.Name.PadRight(20) + "|";
            output += type.IsGenericType.ToString().PadRight(20) + "|";
            output += type.IsGenericTypeDefinition.ToString();
            Console.WriteLine(output + "\n");

            ListGenericMethods(type);
        }
    }

    public static void Execute()
    {
        var types = new List<Type>
        {
            typeof(IProcessor<>),
            typeof(IProcessor<Client>),
            typeof(Processor<>),
            typeof(Processor<Client>),
            typeof(ClientProcessor)
        };

        ListTypeDetails(types);
        Console.WriteLine();

        var openInterface = typeof(IProcessor<>);
        Console.WriteLine($"Is IProcessor<> generic? {openInterface.IsGenericType}");
        Console.WriteLine($"Is IProcessor<> definition generic? {openInterface.IsGenericTypeDefinition}");

        var closedInterface = typeof(IProcessor<Client>);
        Console.WriteLine($"Is IProcessor<Client> generic? {closedInterface.IsGenericType}");
        Console.WriteLine($"Is IProcessor<Client> definition generic? {closedInterface.IsGenericTypeDefinition}");

        var definition = closedInterface.GetGenericTypeDefinition();

        var resultado = definition == openInterface;
        Console.WriteLine($"Definition result: {resultado}");
    }
}