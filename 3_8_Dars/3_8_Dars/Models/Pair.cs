using System;
using System.Collections.Generic;
using System.Text;

namespace _3_8_Dars.Models;

public class Pair<T>
{
    public T First { get; set; }
    public T Second { get; set; }

    public Pair(T firstvalue, T secondvalue )
    {
        First = firstvalue;
        Second = secondvalue;
    }
}
