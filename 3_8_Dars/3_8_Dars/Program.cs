using _3_8_Dars.Models;

namespace _3_8_Dars;

internal class Program
{
    static void Main(string[] args)
    {
        //1-misol
        // Box<int> box = new Box<int>();
        // box.Set(10);
        //Console.WriteLine(box.Get());

        //2-misol
        //Console.WriteLine(Echo(10));

        //4-misol
        //var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
        //PrintArray(arr);

        //5-misol
        //List<int> ints = new List<int>() { 1, 2, 3, };
        //var res =FirstValue(ints);
        //Console.WriteLine(res);

        //6-misol
        //MyStack<int> myStack = new MyStack<int>();
        //myStack.Push(1);
        //myStack.Push(2);
        //myStack.Push(3);
        //myStack.Pop();
        //Console.WriteLine(myStack.Peek());

        //7-misol
        //MyQueue<int> myQueue = new MyQueue<int>();
        //myQueue.Enqueue(1);
        //myQueue.Enqueue(2);
        //myQueue.Enqueue(3);
        //Console.WriteLine(myQueue.Dequeue());
        //Console.WriteLine(myQueue.Dequeue());

        //8-misol
        //Wrapper<int> wrapper = new Wrapper<int>(10);
        //Console.WriteLine(wrapper.Get());

        ////9-misol
        //var res = AreEqual("salom", "salom");
        //Console.WriteLine(res);

        //10-misol

        // Repository<int> repository = new Repository<int>();

        // repository.Add(1);
        // repository.Add(2);
        // repository.Add(3);

        // repository.Remove(2);

        //var all = repository.GetAll();

        // foreach(var item in all)
        // {
        //     Console.WriteLine(item);
        // }

        //14-misol

        //System.Collections.Generic.Dictionary<int, string> dictionary = new System.Collections.Generic.Dictionary<int, string>();
        //dictionary.Add(500 , "olma");

     


    }

    //2-misol
    //static T Echo<T>(T value)
    //{
    //    return value;
    //}

    //4-misol
    //static void PrintArray<T>(T[] items)
    //{ 
    //    foreach (T item in items)
    //    {
    //        Console.WriteLine(item); 
    //    }
    //}

    //5-misol
    //static T FirstValue<T>(List<T> values)
    //{
    //    return values[0];
    //}

    //9-misol
    //static bool AreEqual<T>(T a, T b)
    //{
    //    return a.Equals(b);
    //}

    //13-misol

    //static T Create<T>() where T : class, new()
    //{
    //    T newObject = new T();

    //    return newObject;
    //}

    //16-misol

    static T Max<T>(T a, T b) where T : IComparable<T>
    {
        var res = a.CompareTo(b);

        

        if(res < 0)
        {
            return b;
        }
        return a;

        
    }












}

