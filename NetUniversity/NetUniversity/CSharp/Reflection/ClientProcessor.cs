using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUniversity.CSharp.Reflection;
public class ClientProcessor : IProcessor<Client>
{
    public void Process(Client client)
    {
        Console.WriteLine($"Processing Client: {client}");
    }
}