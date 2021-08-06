using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9.Features
{
    class Records
    {
        public record Car(string Model, string Brand);

        public record User(string FirstName, string LastName);

        public record Employee(string FirstName, string LastName, string[] PhoneNumbers);
    }
}
