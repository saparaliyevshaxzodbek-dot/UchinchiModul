namespace _3_8_Dars.Models;

public class Box<T>
{
    private T Value;

    public void Set(T value)
    {
        Value = value;
    }

    public T Get()
    {
        return Value; 
    }
}
