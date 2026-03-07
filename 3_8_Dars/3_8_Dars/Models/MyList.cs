using System;
using System.Collections.Generic;
using System.Text;

namespace _3_8_Dars.Models;

public interface IEntity
{
    public Guid Guid { get; set; }
}

public class MyList<T> where T : IEntity
{
    private List<T> Elements = new List<T>();

    public void Add(T entity)
    {
        Elements.Add(entity); 
    }

    public T GetById(Guid guid)
    {
        foreach (var element in Elements)
        {
            if (element.Guid == guid) return element;
        }
        return default;
    }
}
