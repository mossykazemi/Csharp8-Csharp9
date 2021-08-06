using System;
using CSharp8.Features;

namespace Csharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            //var res = TuplePattern.RockPaperScissors("rock", "paper");
            //Console.WriteLine(res);

            Phone myPhone = new Phone
            {
                Color = "Pink",
                Price = 10000000
            };

            var res = PropertyPattern.GetTotalPrice(myPhone);
            Console.WriteLine(res.ToString("#,0"));

            Console.ReadKey();
        }
    }
}
