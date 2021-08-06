using System;
using System.Collections.Generic;
using System.Linq;
using CSharp9.Features;

namespace CSharp9
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            #region Records

            var myCar = new Records.Car("x", "tesla");
            var myCar2 = new Records.Car("x", "tesla");

            var (model, brand) = myCar;

            Console.WriteLine($"model : {model} and brand : {brand}");
            Console.WriteLine($"myCar == myCar2 --> {myCar == myCar2}");
            Console.WriteLine(myCar);

            //--

            Records.User user = new("Mostafa", "kazemi");
            Console.WriteLine(user);

            //--

            var phoneNumbers = new string[2];
            Records.Employee employee = new("alex", "young", phoneNumbers);
            Records.Employee employee2 = new("alex", "young", phoneNumbers);
            Console.WriteLine(employee == employee2); // output: True

            employee.PhoneNumbers[0] = "555-1234";
            Console.WriteLine(employee == employee2); // output: True

            Console.WriteLine(ReferenceEquals(employee, employee2)); // output: False

            #endregion

            #region Use Enumerator in foreach

            //var numbers = new List<int> { 1, 2, 3, 4 };

            IEnumerator<int> numbers = Enumerable.Range(0, 20).GetEnumerator();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            #endregion

        }


    }
}
