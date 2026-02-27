using System;
using System.Collections.Generic;
using System.Text;

namespace _3_7_Dars_Vaziyfa.Models;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return $"{Name} - {Price} so'm";
    }
}
