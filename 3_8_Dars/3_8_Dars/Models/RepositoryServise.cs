namespace _3_8_Dars.Models;

public class RepositoryServise<T> where T : class
{
    private List<T> Elements = new List<T>();

    public void Add(T element)
    {
        if (element == null) throw new ArgumentNullException("Malumotda xatolik bor ...?");
        Elements.Add(element);
    }

    public void Remove(T element)
    {
        Elements.Remove(element);
    }

    public T GetById(int index)
    {
        if (index >= 0 && index < Elements.Count)
        {
            return Elements[index];
        }
        return null;
    }

    public List<T> GetAll()
    {
        return Elements;
    }

    public void Update(int index, T newelement)
    {
        if (index >= 0 && index <= Elements.Count && newelement != null)
        {
            Elements[index] = newelement;
        }
    }

}
