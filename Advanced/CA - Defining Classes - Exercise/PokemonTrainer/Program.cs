namespace PokemonTrainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Trainer> trainers = new List<Trainer>();
            while (command != "Tournament")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Trainer t = trainers.Find(x => x.Name == tokens[0]);
                if (t == null)
                {
                    t = new Trainer();
                    string trainerName = tokens[0];
                    t.Name = trainerName;
                    t.Pokemons = new List<Pokemon>();
                    trainers.Add(t);
                }
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                t.Pokemons.Add(pokemon);
                command = Console.ReadLine();
            }
            string element = Console.ReadLine();
            while (element!="End")
            {
                foreach (var trainer in trainers)
                {
                    int currAdd = 0;
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        if (element==pokemon.Element)
                        {
                            trainer.NumberOfBadges++;
                            currAdd++;
                            break;
                        }
                    }
                    if (currAdd==0)
                    {
                        for (int i = 0; i < trainer.Pokemons.Count; i++)
                        {
                            trainer.Pokemons[i].Health -= 10;
                            if (trainer.Pokemons[i].Health <= 0)
                            {
                                trainer.Pokemons.Remove(trainer.Pokemons[i]);
                                i--;
                            }
                        }
                           
                        
                    }
                }
                element = Console.ReadLine();
            }
            foreach (var tr in trainers.OrderByDescending(x=>x.NumberOfBadges))
            {
                Console.WriteLine($"{tr.Name} {tr.NumberOfBadges} {tr.Pokemons.Count}");
            }
        }
    }
}