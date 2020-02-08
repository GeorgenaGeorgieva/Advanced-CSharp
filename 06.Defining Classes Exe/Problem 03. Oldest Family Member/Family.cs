namespace DefiningClasses
{
    using System.Linq;
    using System.Collections.Generic;

    public class Family
    {
        private List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.members.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.members.OrderBy(x => x.Age).Last();
        }

        public List<Person> Person { get; set; }
    }
}
