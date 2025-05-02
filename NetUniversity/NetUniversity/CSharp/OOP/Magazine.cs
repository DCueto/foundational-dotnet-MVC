using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUniversity.CSharp.OOP;

public class Magazine : Publication
{
    public string? Journalist { get; set; }
    
    public Magazine(string? journalist, string name, int numberPages, decimal price) : 
        base(name, price, numberPages)
    {
        Journalist = journalist;
    }

    public override string GetDetails() => $"Magazine {Name} managed by {Journalist} has a price of {Price}$; pages: {NumberPages}";
}
