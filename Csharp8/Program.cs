using System;
using CSharp8.Features;

namespace Csharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var res = TuplePattern.RockPaperScissors("rock", "paper");
            Console.WriteLine(res);


            Console.ReadKey();
        }
    }
}
