namespace NetUniversity.CSharp.Generics;

public class Author : IComparable<Author>
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public Author(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Surname}";
    }

    public int CompareTo(Author? otherAuthor)
    {
        if (otherAuthor == null) return 1;

        return this.ToString().CompareTo(otherAuthor.ToString());
    }
}
