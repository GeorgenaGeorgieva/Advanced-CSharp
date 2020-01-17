using System;
using System.Linq;
using DefiningClasses_Person;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person firstPerson = new Person();

            firstPerson.Name = "Pesho";
            firstPerson.Age = 20;

            Person thirdPerson = new Person
            {
                Name = "Stamat"
            };

            thirdPerson.Age = 43;


            Person secondPerson = new Person
            {
                Name = "Gosho",
                Age = 18
            };
        }
    }
}
