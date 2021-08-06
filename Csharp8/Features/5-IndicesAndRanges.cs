
using System;

namespace CSharp8.Features
{
    public static class IndicesAndRanges
    {
        public static void Demo()
        {
            // myCourses[0] = "ASP.NET Core"
            // myCourses[4] = "Machine Learning"
            // var myCourses = new string[] { "ASP.NET Core", "Angular", "Ionic", "Blazor", "Machine learning" };
            // Console.WriteLine(myCourses[myCourses.Length - 1]);
            // Console.WriteLine(myCourses[^1]);
            // Console.WriteLine(myCourses[^2]);
            var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            /*foreach (var number in numbers[..^1])
            {
                Console.WriteLine(number);
            }*/

            foreach (var number in numbers[2..])
            {
                Console.WriteLine(number);
            }
        }
    }
}
