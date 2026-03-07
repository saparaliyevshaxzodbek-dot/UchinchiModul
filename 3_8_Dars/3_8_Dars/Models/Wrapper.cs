using System;
using System.Collections.Generic;
using System.Text;

namespace _3_8_Dars.Models;

public class Wrapper<T>
{
    private T value;

    public string Get()
    {

        return $"Type : {value.GetType().Name}, Value : {value}";

    }
    public Wrapper(T item)
    {
         value = item ; 
    }

    
}
