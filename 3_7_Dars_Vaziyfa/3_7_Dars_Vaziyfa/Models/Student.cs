using System;
using System.Collections.Generic;
using System.Text;

namespace _3_7_Dars_Vaziyfa.Models;

public class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }

    public override string ToString()
    {
        return $" Ismi : {Name} , Bahosi {Grade} ";
        
    }
}
