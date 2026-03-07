namespace _3_8_Dars.Models;

public class Dictionary<TKey, TValue>
{
    List<TKey> keys = new List<TKey>();
    List<TValue> values = new List<TValue>();

    public bool Add(TKey key, TValue value)
    {

        if (keys.Contains(key))
        {
            Console.WriteLine("Bu kalit allaqachon mavjud ?");
            return false;
        }

        keys.Add(key);
        values.Add(value);
        return true;
    }

    public TValue GetByKey(TKey key)
    {
        var index = keys.IndexOf(key);

        if (index != -1)
        {
            return values[index];
        }

        Console.WriteLine("Kalit topilmadi");
        return default;
    }
}
