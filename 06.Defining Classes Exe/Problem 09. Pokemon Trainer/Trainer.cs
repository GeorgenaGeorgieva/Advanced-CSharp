namespace DefiningClasses
{
    using System.Linq;
    using System.Collections.Generic;

    public class Trainer
    {
        private string name;
        private int numberBadges;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.Name = name;
            this.BadgesCount = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }

        public int BadgesCount { get; set; } 

        public List<Pokemon> Pokemons { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.BadgesCount} {this.Pokemons.Count}";
        }
    }
}
