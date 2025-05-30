﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUniversity.CSharp.Generics;

public interface IRepository<T> where T : Person, IComparable<T>
{
    IEnumerable<T> List();
    IEnumerable<T> GetOrderedList();
}
