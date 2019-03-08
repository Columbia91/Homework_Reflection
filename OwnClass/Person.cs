using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnClass
{
    class Person
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Homeland { get; set; }

        public Person(string fullName, DateTime dateOfBirth, string homeland)
        {
            FullName = fullName; DateOfBirth = dateOfBirth; Homeland = homeland;
        }
    }
}
