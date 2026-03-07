using System.Collections;

namespace _3_9_Dars;

internal class Program
{
    static void Main(string[] args)
    {
        //12-misol

        //ArrayList arrayList = new ArrayList();

        //arrayList.Add(1);
        //arrayList.Add(2);
        //arrayList.Add(3);
        //arrayList.Add(4);

        //var res = MaxNamber(arrayList);

        //Console.WriteLine(res);

        //var res = SumNamber(arrayList);

        //Console.WriteLine(res);





    }

    //11-misol

    //static int SumNamber(ArrayList arrayList)
    //{
    //    var sum = arrayList.Cast<int>().Sum();
    //    return sum;

    //}

    //12-misol
    static int MaxNamber(ArrayList arrayList)
    {
        var res = arrayList.Cast<int>().Max();

        return res;
    }
}
