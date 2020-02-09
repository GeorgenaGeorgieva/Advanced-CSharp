namespace DefiningClasses
{
    using System;
    
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Family family = new Family();

            int numberOfFamilyMembers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfFamilyMembers; i++)
            {
                string[] currentMemberInformation = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = currentMemberInformation[0];
                int age = int.Parse(currentMemberInformation[1]);

                Person member = new Person(name, age);
                family.AddMember(member);
            }

            Person oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
