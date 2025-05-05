using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUniversity.CSharp.Generics;

public class StudentRepository : IRepository<Student>
{
    private FullName[] _fullNames = new FullName[7];

    public StudentRepository()
    {
        _fullNames[0] = new FullName("Daniel", "Cueto");
        _fullNames[1] = new FullName("Javier", "Sataolalla");
        _fullNames[2] = new FullName("Maria", "Serrano");
        _fullNames[3] = new FullName("Fernando", "Parra");
        _fullNames[4] = new FullName("Xenia", "Cueto");
        _fullNames[5] = new FullName("Yoel", "Matamoros");
        _fullNames[6] = new FullName("Aitor", "Santafé");
    }

    public IEnumerable<Student> List()
    {
        int index = 0;
        while (index < _fullNames.Length)
        {
            yield return new Student(_fullNames[index].Name, _fullNames[index].Surname);
            index++;
        }
    }
}
