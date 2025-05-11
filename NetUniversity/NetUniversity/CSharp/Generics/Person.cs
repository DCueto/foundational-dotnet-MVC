using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUniversity.CSharp.Generics;
public abstract class Person
{
    public string Name { get; set; } = null!;
    public string? Surname { get; set; }
}

public record FullName(string Name, string Surname);