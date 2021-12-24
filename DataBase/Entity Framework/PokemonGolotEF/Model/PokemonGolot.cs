using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGolotEF.Model
{
    internal class PokemonGolot
    {
        public List<Pokemon> pokemons { get; set; }
        public List<Movement> moves { get; set; }
        public List<EvolutionChain> evolutions { get; set; }
        public List<Element> elements { get; set; }
        public List<PokemonLevel> pokemonsLevels { get; set; }
        public List<Level> userLevels { get; set; }
        public List<Gym> gyms { get; set; }
        public List<PokeStop> pokestops { get; set; }
        public List<Object> objects { get; set; }
        public List<LevelupObjectReward> levelupObjects { get; set; }
        public List<TypeTable> typeTable { get; set; }
        public List<Egg> eggs { get; set; }

        public PokemonGolot() 
        {
            pokemons = new List<Pokemon>();
            moves = new List<Movement>();
            evolutions = new List<EvolutionChain>();
            elements = new List<Element>();
            pokemonsLevels = new List<PokemonLevel>();
            userLevels = new List<Level>();
            gyms = new List<Gym>();
            pokestops = new List<PokeStop>();
            objects = new List<Object>();
            levelupObjects = new List<LevelupObjectReward>();
            typeTable = new List<TypeTable>();
            eggs = new List<Egg>();
        }

    }
}
