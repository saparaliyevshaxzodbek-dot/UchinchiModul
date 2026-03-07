namespace _3_10_Dars;

internal class Program
{
    static void Main(string[] args)
    {



        Book book = new Book()
        {
            Name = "Test",
            Guid = Guid.NewGuid(),
        };

        Book book1 = new Book()
        {
            Name = "Kitob",
            Guid = Guid.NewGuid(),
        };

        Book book2 = new Book()
        {
            Name = "Kitob2",
            Guid = Guid.NewGuid(),
        };

        Book book3 = new Book()
        {
            Name = "Kitob3",
            Guid = Guid.NewGuid(),
        };

        Dictionary<Book, string> keyValuePairs = new Dictionary<Book, string>();

        keyValuePairs.Add(book, book.Name);
        keyValuePairs.Add(book1, book1.Name);
        keyValuePairs.Add(book1, book2.Name);




         








        //3-misol

        //Stack<int> ints = new Stack<int>();

        //ints.Push(1);
        //ints.Push(2);
        //ints.Push(3);
        //ints.Push(4);
        //ints.Push(5);
        //ints.Push(6);

        //var res = ints.Max(s  => s);
        //Console.WriteLine(res);

        //5-misol


        //Stack<int> stack = new Stack<int>();

        //stack.Push(1);
        //stack.Push(2);
        //stack.Push(3);
        //stack.Push(4);
        //stack.Push(5);
        //stack.Push(6);
        //stack.Push(7);
        //stack.Push(8);
        //stack.Push(9);


        //foreach (int i in stack)
        //{
        //    if(i %  2 == 0)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}


        //Stack<int> stack = new Stack<int>();

        //Stack<int> ints = new Stack<int>();

        //stack.Push(1);
        //stack.Push(2);
        //stack.Push(3);
        //stack.Push(4);
        //stack.Push(15);
        //stack.Push(6);
        //stack.Push(5);

        //foreach(int i in stack)
        //{
        //    ints.Push(i);
        //}

        //foreach(int i in ints)
        //{
        //    Console.WriteLine(i);
        //}






    }
}
