namespace NetUniversity.CSharp.Generics;

public class Student : IComparable<Student>
{
    public static int StudentsCount = 0;
    public string Name { get; set; }
    public string? Surname { get; set; }

    public Student(string name, string? surname)
    {
        Name = name;
        Surname = surname;
        StudentsCount++;
    }

    public override string ToString()
    {
        return $"{Name} {Surname ?? ""}".Trim();
    }

    public int CompareTo(Student? otherStudent)
    {
        if (otherStudent is null) 
            return 1;

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
}

public record FullName(string Name, string Surname);
