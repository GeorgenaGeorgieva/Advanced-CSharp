namespace DefiningClasses
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            while (true)
            {
                string[] splitedInput = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (splitedInput[0] == "Tournament")
                {
                    break;
                }

                string trainerName = splitedInput[0];
                string pokemonName = splitedInput[1];
                string element = splitedInput[2];
                int pokemonHealth = int.Parse(splitedInput[3]);

                Pokemon currentPokemon = new Pokemon(pokemonName, element, pokemonHealth);

                Trainer trainer = trainers.FirstOrDefault(x => x.Name == trainerName);

                if (trainer == null)
                {
                    trainer = new Trainer(trainerName);
                    trainers.Add(trainer);
                }

                trainer.Pokemons.Add(currentPokemon);
            }

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "End")
                {
                    break;
                }

                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(x => x.Element == inputLine))
                    {
                        trainer.BadgesCount++;
                    }
                    else
                    {
                        ReduceHealth(trainer.Pokemons);
                    }
                }
            }

            var orderedTrainers = trainers
                .OrderByDescending(x => x.BadgesCount);

            Console.WriteLine(string.Join(Environment.NewLine, orderedTrainers));
        }

        static void ReduceHealth(List<Pokemon> pokemons)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                Pokemon pokemon = pokemons[i];

                pokemon.Health -= 10;

                if (IsDead(pokemon.Health))
                {
                    pokemons.RemoveAt(i);
                    i--;
                }
            }
        }

        static bool IsDead(int pokemonHealth)
        {
            return pokemonHealth <= 0;
        }
    }
}
