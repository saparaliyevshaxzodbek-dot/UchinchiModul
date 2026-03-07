using System;
using System.Collections.Generic;
using System.Text;

namespace _3_8_Dars.Models;

public class MyQueue<T>
{
    List<T> Elements = new List<T>();

    public void Enqueue(T item)
    {
        Elements.Add(item); 
    }

    public T Dequeue()
    {
        T value = Elements[0];
        Elements.RemoveAt(0);
        return value;
    }
}
