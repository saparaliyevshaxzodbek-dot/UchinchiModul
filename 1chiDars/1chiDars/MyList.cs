namespace _1chiDars;

public class MyList : IMyList
{
    private int[] _nums;
    private int Capacity;
    private int arrIndex = 0;

    public int MyProperty
    {
        get { return Capacity; }
    }


    public MyList(int capacity = 4)
    {
        _nums = new int[capacity];
    }
    public bool Add(int num)
    {
        if (arrIndex >= Capacity)
        {
            DoubleCapacity();

        }

        _nums[arrIndex] = num;
        arrIndex++;

        return true;
    }

    private void DoubleCapacity()
    {
        int[] newArr = new int[Capacity * 2];
        for (int i = 0; i < Capacity; i++)
        {
            newArr[i] = _nums[i];

        }

        _nums = newArr;
    }

    public bool Contains(int num)
    {
        foreach (int i in _nums)
        {
            if (i == num)
            {
                return true;
            }
        }
        return false;
    }

    public int GetById(int index)
    {
        return _nums[index];
    }

    public int IndexOf(int num)
    {
        for (var i = 0; i < _nums.Length; i++)
        {
            if (_nums[i] == num)
            {
                return i;
            }
        }
        return -1;
    }

    public bool Remove(int num)
    {
        for (var i = 0; i < _nums.Length; i++)
        {
            if( _nums[i] == num)
            {
                for(var j = i; j < Capacity - 1; j++)
                {
                    _nums[j] = _nums[j + 1];
                }
                return true;
            }
        }
        return false;
    }

    public bool RemoveAll(int num)
    {
        int counter = 0;
        while (true)
        {
            var res = Remove(num);  

            if(res == false)
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

    public void DisplayElements()
    {
        foreach(var i in _nums)
        {
            Console.Write(i + " ");
        }
    }

    
}
