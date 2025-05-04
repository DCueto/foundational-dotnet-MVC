namespace NetUniversity.CSharp.Generics;

public class StudentPrinterService
{
    private readonly IStudentRepository _studentRepository;

    public StudentPrinterService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public void PrintStudents()
    {
        Student[] students = _studentRepository.List();
        Array.Sort(students);

        Console.WriteLine($"\nPrinting Student List from method {nameof(PrintStudents)}\n");
        foreach (Student student in students) 
        {
            Console.WriteLine(student);
        }
    }
}
