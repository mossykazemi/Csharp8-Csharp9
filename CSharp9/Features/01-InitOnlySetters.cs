using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9.Features
{
    public static class InitOnlySetters
    {
        public static void InitOnlySetterMethod()
        {
            var person = new Person()
            {
                FirstName = "Mostafa",
                LastName = "Kazemi",
                NationalCode = "0794719024921"
            };

            //person.NationalCode = "21321321213";

            //Commands

            //person.NationalCode = "2131212412";
        }

    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; init; }

    }
}
