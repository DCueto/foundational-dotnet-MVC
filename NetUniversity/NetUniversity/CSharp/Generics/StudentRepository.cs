using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUniversity.CSharp.Generics;

public class StudentRepository : IStudentRepository
{
    public Student[] List()
    {
        Student[] students = new Student[7];

        students[0] = new Student("Daniel", "Cueto");
        students[1] = new Student("Javier", "Sataolalla");
        students[2] = new Student("Maria", "Serrano");
        students[3] = new Student("Fernando", null);
        students[4] = new Student("Xenia", "Cueto");
        students[5] = new Student("Yoel", "Matamoros");
        students[6] = new Student("Aitor", "Santafé");

        return students;
    }
}
