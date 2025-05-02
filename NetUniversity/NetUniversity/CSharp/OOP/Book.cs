using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUniversity.CSharp.OOP;

public class Book : Publication
{
    private string _author;
    public string Author
    {
        get => _author;
        set => _author = value;
    }

    public Book(string name, string author, int numberPages, decimal price) : 
        base(name, price, numberPages)
    {
        _author = author;
    }

    public override string GetDetails() => $"Book {Name} by {Author} with price {Price}$; pages: {NumberPages}";
}
