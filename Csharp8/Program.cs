using System;
using System.Threading.Tasks;
using CSharp8.Features;

namespace Csharp8
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            //var res = TuplePattern.RockPaperScissors("rock", "paper");
            //Console.WriteLine(res);

            //Phone myPhone = new Phone
            //{
            //    Color = "Pink",
            //    Price = 10000000
            //};

            //var res = PropertyPattern.GetTotalPrice(myPhone);
            //Console.WriteLine(res.ToString("#,0"));

            await foreach (var number in AsynchronousStreams.GenerateNumbers())
            {
                Console.WriteLine(number);
            }
            
            Console.ReadKey();
        }
    }
}
