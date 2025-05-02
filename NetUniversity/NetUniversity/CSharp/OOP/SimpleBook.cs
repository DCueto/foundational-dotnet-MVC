using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUniversity.CSharp.OOP;

public class SimpleBook
{
    private string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            value = _name;
        }
    }
    private string _author;
    public string Author
    {
        get => _author;
        set => _author = value;
    }

    private int _numberPages;
    public int NumberPages { get => _numberPages; set => _numberPages = value; }

    public string RandomProperty { get; set; } = null!;


    public SimpleBook(string name, string author, int numberPages)
    {
        _name = name;
        _author = author;
        _numberPages = numberPages;
    }

    public string GetBookDetails() => $"{_name} by {_author}; pages: {_numberPages}";
    //public string GetName() => _name;
    //public void SetName(string newName) => _name = newName;
    //public string GetAuthor() => _author;
    //public void SetAuthor(string newAuthor) => _author = newAuthor;
    //public int GetNumberPages() => _numberPages;
    //public void SetNumberPages(int newNumberPages) => _numberPages = newNumberPages;
}
