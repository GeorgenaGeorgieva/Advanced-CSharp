namespace DefiningClasses
{
    using System;
    using DefiningClasses;
    
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person firstPerson = new Person();
            Person secondPerson = new Person(56);
            Person thirdPerson = new Person("Pesho", 28);
        }
    }
}
