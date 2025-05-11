namespace NetUniversity.CSharp.Generics;

public class StudentPrinterService
{
    private readonly IPersonRepository<Student> _studentRepository;

    public StudentPrinterService(IPersonRepository<Student> studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public void PrintStudents(int numToPrint = 100)
    {
        //IEnumerable<Student> students = _studentRepository.List().Take(numToPrint);//.ToArray();
        //Array.Sort(students);

        //Console.WriteLine($"\nPrinting Student List from method {nameof(PrintStudents)}\n");

        //for (int i = 0; i < students.Length; i++)
        //{
        //    Console.WriteLine(students[i]);
        //}
        
        IEnumerable<Student> students = _studentRepository.GetOrderedList().Take(numToPrint).ToList();
        PrintStudentsFromEnumerable(students);

        IEnumerable<Student> searchedStudents = _studentRepository.Search("Cueto");
        PrintSearchedStudents(searchedStudents);
    }

    private void PrintStudentsFromEnumerable(IEnumerable<Student> students) 
    {
        Console.WriteLine($"\nStudents:\n");
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
    }

    private void PrintSearchedStudents(IEnumerable<Student> students)
    {
        Console.WriteLine($"\nSearched Students:\n");
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
    }
}
