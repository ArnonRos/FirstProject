using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public int Age
        {
            get { return age; }
            set { if (value > 0) age = value; }

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }



    }
}
