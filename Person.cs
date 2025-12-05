using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;


namespace csharptest
{
    public class Person
    {
        private string name;
        private int age;
        private string lastname;
       

        public Person(string Name, string lastName)
        {
            name = Name;
            lastname = lastName;
        }

        public string Name
        {
            get { return name; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
    }
}