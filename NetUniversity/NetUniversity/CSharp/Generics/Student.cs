using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUniversity.CSharp.Generics;

public class Student : IComparable
{
    public string Name { get; set; }
    public string? Surname { get; set; }

    public Student(string name, string? surname)
    {
        Name = name;
        Surname = surname;
    }

    public override string ToString()
    {
        return $"{Name} {Surname ?? ""}".Trim();
    }

    public int CompareTo(object? obj)
    {
        if (obj is null) 
            return 1;

        if (obj is Student otherStudent)
        {
            if (otherStudent.Surname == this.Surname)
            {
                return this.Name.CompareTo(otherStudent.Name);
            }

            if (this.Surname is null || otherStudent.Surname is null)
            {
                return -1;
            }

            return this.Surname!.CompareTo(otherStudent.Surname);
        }

        throw new ArgumentException("It isn't an object of type 'student'", nameof(obj));
    }
}
