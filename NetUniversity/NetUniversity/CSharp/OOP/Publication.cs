using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NetUniversity.CSharp.OOP;

public class Publication
{
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public int NumberPages { get; set; }

    public Publication(string name, decimal price, int numberPages) 
    {
        Name = name;
        Price = price;
        NumberPages = numberPages;
    }

    public virtual string GetDetails() => $"{Name} with price {Price}$; pages: {NumberPages}";
}
