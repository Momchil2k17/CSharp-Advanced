using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;

        public Trainer() 
        {
        }

        public Trainer(string name, List<Pokemon> pokemons)
        {
            Name = name;
            NumberOfBadges = 0;
            Pokemons = pokemons;
        }

        public string Name { get => name; set => name = value; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    }
}
