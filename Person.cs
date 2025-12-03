using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharptest
{
    public class Person
    {
            
        private string name;

        
        public Person(string name)
        {
            this.name = name;
        }
        
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        
    }
}