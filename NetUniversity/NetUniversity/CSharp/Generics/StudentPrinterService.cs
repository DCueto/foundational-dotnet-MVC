namespace NetUniversity.CSharp.Generics;

public class StudentPrinterService
{
    private readonly IRepository<Student> _studentRepository;

    public StudentPrinterService(IRepository<Student> studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public void PrintStudents(int numToPrint = 100)
    {
        IEnumerable<Student> students = _studentRepository.List().Take(numToPrint);//.ToArray();
        //Array.Sort(students);

        //Console.WriteLine($"\nPrinting Student List from method {nameof(PrintStudents)}\n");

        //for (int i = 0; i < students.Length; i++)
        //{
        //    Console.WriteLine(students[i]);
        //}
        PrintStudentsFromEnumerable(students);
    }

    private void PrintStudentsFromEnumerable(IEnumerable<Student> students) 
    {
        Console.WriteLine($"Students:\n");
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
    }
}
