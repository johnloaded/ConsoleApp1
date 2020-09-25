using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public Person(string name, string make, string model, string year)
        {
            Name = name;
            Car myCar = new Car();

            myCar.Year = "2012";

        }
    }
}
