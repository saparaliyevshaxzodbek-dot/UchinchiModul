namespace _3_7_Dars;

internal class Program
{
    static void Main(string[] args)
    {
        ////1-misol
        //var func = (int a, int b, int c) =>
        //{
        //    if (a > b && a > c)
        //    {
        //        return a;
        //    }
        //    else if (b > c && b > a)
        //    {
        //        return b;
        //    }
        //    else
        //    {
        //        return c;
        //    }
        //};

        //Console.WriteLine(func(2, 3, 4));

        //2-misol

        //var action = (string text1, string text2) => text1.Length + text2.Length;

        //Console.WriteLine(action.Invoke("salom", "salom"));

        //3-misol



        List<Book> books = new List<Book>()
        {
           new Book { Title = "O'tkan Kunlar", Price = 45000.50m },
           new Book { Title = "Mehrobdan Chayon", Price = 42000.00m },
           new Book { Title = "Kecha va Kunduz", Price = 38000.75m },
           new Book { Title = "Sariq devni minib", Price = 35000.00m },
           new Book { Title = "Yulduzli tunlar", Price = 55000.00m },
           new Book { Title = "Dunyoning ishlari", Price = 30000.25m },
           new Book { Title = "Ikki eshik orasi", Price = 48000.00m },
           new Book { Title = "Jimjitlik", Price = 32000.50m },
           new Book { Title = "Shaytanat", Price = 65000.00m },
           new Book { Title = "Alkimyogar", Price = 25000.00m }

        };

        var f2 = (List<Book> books) =>
        {
            var maxBook = books.MaxBy(b => b.Price);

            return maxBook;
        };

        Console.WriteLine(f2(books));


    }
}


