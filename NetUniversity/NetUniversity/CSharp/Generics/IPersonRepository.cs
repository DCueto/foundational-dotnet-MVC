using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUniversity.CSharp.Generics;
public interface IPersonRepository<T> : IRepository<T> where T : Person, IComparable<T>, new()
{
    IEnumerable<T> Search(string name);
    T Create(FullName fullName);
    T CreateByDefault();
}

public interface IPersonRepository
{
    IEnumerable<T> Search<T>(string name) where T : Person;
    T Create<T>(FullName fullName) where T : Person;
    T CreateByDefault<T>() where T : Person;
}
