namespace _3_8_Dars.Models;

public class MyStack<T>
{
    List<T> Elements = new List<T>();

    public void Push(T item)
    {
        Elements.Add(item); 
    }

    public T Pop()
    {
        if(Elements.Count == 0)
        {
            throw new Exception("Stack bosh");
        }

        T item = Elements[Elements.Count - 1];
        Elements.RemoveAt(Elements.Count - 1);
        return item;
    }

    public T Peek()
    {
        if (Elements.Count == 0) throw new Exception("Stack bo'sh");
        
        return Elements[Elements.Count - 1];
    }

}
