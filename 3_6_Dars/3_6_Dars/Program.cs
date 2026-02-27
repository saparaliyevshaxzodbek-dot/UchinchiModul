namespace _3_6_Dars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Func
            //1-misol
            //Func<string, string> Add;

            //Add = Add1;

            //var res = Add.Invoke("Sardor");
            //Console.WriteLine(res);

            //2-misol

            //Func<string, string> Tekshir;

            //Tekshir = Tekshir1;

            //var res = Tekshir.Invoke("salom");
            //Console.WriteLine(res);

            //3-misol
            //Func<string, string> Tekshir;

            //Tekshir = Tekshir1;

            //var res = Tekshir.Invoke("salom1");
            //Console.WriteLine(res);

            //Action

            Action<int> action;



        }

        //Func
        //1-misol
        //static string Add1(string text )
        //{
        //    return text + " Hello How are you";
        //}

        //2-misol

        //static string Tekshir1(string text)
        //{
        //    if(text.Length >= 5)
        //    {
        //        return "Hammasi joyida";
        //    }

        //    return "Nozozlik bor??";
        //}

        //3-misol

        //static string Tekshir1(string Text)
        //{
        //    for(int i = 0; i < Text.Length; i++)
        //    {
        //        if(char.IsDigit(Text[i]))
        //        {
        //            return "Textda raqam qatnashgan";
        //        }
        //    }

        //    return "Textda raqam qatnashmagan";
        //}

        //Action
        static void Tekshir(string text, int num)
        {
            Console.WriteLine   
        }



    }
}
