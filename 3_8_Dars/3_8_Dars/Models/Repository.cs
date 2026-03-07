namespace _3_8_Dars.Models;

public class Repository<T>
{
    private List<T> Database = new List<T>();

    public void Add(T item)
    {
        Database.Add(item);
    }

    public void Remove(T item)
    {
        Database.Remove(item); 
    }

    public List<T> GetAll()
    {
        return Database; 
    }

   


}
