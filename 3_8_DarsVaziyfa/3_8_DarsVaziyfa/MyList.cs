namespace _3_8_DarsVaziyfa;

public class MyList<T> : IMyList<T>
{

    private T[] _nums;
    private int arrIndex = 0;
    public int Capacity
    {
        get { return _nums.Length; }
    }

    public MyList(int capacity = 4)
    {
        _nums = new T[capacity];
    }

    public bool Add(T item)
    {
        if (arrIndex >= Capacity)
        {
            DoubleCapacity();
        }

        _nums[arrIndex] = item;
        arrIndex++;

        return true;
    }

    private void DoubleCapacity()
    {
        T[] newArr = new T[Capacity * 2];
        for (var i = 0; i < Capacity; i++)
        {
            newArr[i] = _nums[i];
        }
        _nums = newArr;
    }



    public bool Contains(T item)
    {
        foreach (var i in _nums)
        {
            if (i.Equals(item))
            {
                return true;
            }
        }
        return false;
    }

    public void DisplayElements()
    {
        foreach (var i in _nums)
        {
            Console.Write(i + " ");
        }
    }

    public T GetById(int index)
    {
        return _nums[index];
    }

    public int IndexOf(T item)
    {
        for (var i = 0; i < Capacity; i++)
        {
            if (_nums[i].Equals(item))
            {
                return i;
            }
        }

        return -1;
    }

    public bool Remove(T item)
    {
        for (var i = 0; i < Capacity; i++)
        {
            if (_nums[i].Equals(item))
            {
                for (var j = i; j < Capacity - 1; j++)
                {
                    _nums[j] = _nums[j + 1];
                }
                --arrIndex;
                return true;
            }
        }
        return false;
    }

    public bool RemoveAll(T item)
    {
        int counter = 0;
        while (true)
        {
            var res = Remove(item);

            if (res == false)
            {
                break;
            }
            ++counter;
        }
        return counter != 0;
    }

    public bool RemoveAt(int index)
    {
        return Remove(_nums[index]);
    }
}
