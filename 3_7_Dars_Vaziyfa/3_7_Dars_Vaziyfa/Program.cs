namespace _3_7_Dars_Vaziyfa;

internal class Program
{
    static void Main(string[] args)
    {
        //1-misol

        //User user = new User()
        //{
        //    Name = "Test",
        //    Age = 5,
        //};

        //var func = ( User users1) =>
        //{


        //        if (user.Age >= 18)
        //        {
        //            return "Adult";
        //        }


        //    return "Minor";
        //};

        //Console.WriteLine(func(user)); 

        //2-misol

        //Car car = new Car()
        //{
        //    Model = "Chevrolet",
        //    Year = new DateTime(2020 ,1 ,1)
        //};

        //var action = (Car car1) =>
        //{
        //    var res = DateTime.Now - car1.Year;

        //    Console.WriteLine(res.Days / 365);
        //};

        //action.Invoke(car);

        //3-misol

        //List<Product> products = new List<Product>()
        //{
        //    new Product {Name = "Olma" , Price = 12000},
        //    new Product {Name = "Banan" , Price = 20000},
        //    new Product {Name = "Behi" , Price = 15000},
        //    new Product {Name = "Mandarin" , Price = 16000},
        //    new Product {Name = "Nok" , Price = 11000},
        //};

        //var func = (List<Product> products1) =>
        //{
        //    var res = products1.MinBy(p => p.Price);
        //    return res;
        //};

        //var res = func(products);

        //Console.WriteLine(res);

        //4-misol

        //var action = (int quantity, decimal price) =>
        //{
        //    var res = quantity * price;

        //    Console.WriteLine(res);
        //};

        //action(3, 10000);

        //5-misol

        //List<Student> students = new List<Student>()
        //{
        //    new Student{Name = "Azamat", Grade = 80},
        //    new Student{Name = "Sardor", Grade = 100},
        //    new Student{Name = "Vali", Grade = 70},
        //    new Student{Name = "Ali", Grade = 95},
        //    new Student{Name = "Gani", Grade = 110},
        //};

        //var func = (List<Student> students1) =>
        //{
        //    var res = students1.Where(s => s.Grade > 90).ToList();
        //    return res;
        //};

        //var result = func(students);

        //result.ForEach(student => Console.WriteLine(student));

        //6-misol

        //Employee employee = new Employee()
        //{
        //    Name = "Ali",
        //    Salary = 1000000
        //};

        //var func = (Employee employee1) =>
        //{
        //    var res = employee1.Salary * 0.15;

        //    var newsalary = employee1.Salary + res;
        //    return newsalary;
        //};

        //var res = func(employee);
        //Console.WriteLine(res);

        //7-misol

        //var func = (string text) =>
        //{
        //    List<char> chars = new List<char>()
        //    {
        //        'a', 'u', 'o', 'i','e',
        //        'A', 'U', 'O', 'I','E'
        //    };

        //    var sum = 0;

        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        if (chars.Contains(text[i]))
        //        {
        //            sum++;
        //        }
        //    }

        //    return sum;

        //};

        //Console.WriteLine(func("sAlom"));

        //8-misol

        //var action = (int number1, int number2) =>
        //{
        //    if(number1 >  number2)
        //    {
        //        Console.WriteLine(number1);
        //    }
        //    else
        //    {
        //        Console.WriteLine(number2);
        //    }
        //};

        //action(10 , 20);

        //9-misol

        //var func = (int number) => 
        //{
        //    if(number %  2 == 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //};

        //Console.WriteLine(func.Invoke(9));

        //10-misol

        //var func = (string text) =>
        //{
        //    var str = string.Empty;

        //    for (int i = text.Length - 1; i >= 0; i--)
        //    {
        //        str += text[i];
        //    }
        //    return str;

        //};

        //Console.WriteLine(func.Invoke("salom"));





    }
}
