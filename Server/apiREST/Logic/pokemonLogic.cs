

using apiREST.Data;
using apiREST.Model;

namespace apiREST.Logic
{
    public class pokemonLogic
    {
        public string? getPokemonImgFront(int? num_pokedex,  pokemonGolotApi context)
        {

            return context.Pokemon.FirstOrDefault(i => i.num_pokedex == num_pokedex)?.img_front;
        }

        public int? getPokemonCP(PokemonOwned pokemon, pokemonGolotApi context)
        {
            Pokemon? pokemonBase = context.Pokemon.FirstOrDefault(p => p.num_pokedex == pokemon.pokemon);

            if (pokemonBase == null)
                return null;

            PokemonLevel? pokemonLevel =  context.Pokemon_level.FirstOrDefault(l => l.pokemon_level == pokemon.level);


            //CP = (Base Atk + Atk IV) *(Base Def + Def IV)^0.5 * (Base Stam + Stam IV)^0.5 * Lvl ^ 2 / 10

            if (pokemonLevel == null)
                return null;

            return (int?)(
                    (pokemonBase.attack + pokemon.atack_iv) 
                    * Math.Pow((double)(pokemonBase.defense! + pokemon.defense_iv!), 0.5) 
                    * Math.Pow((double)(pokemonBase.stamina! + pokemon.stamina_iv!), 0.5)
                    * Math.Pow((double)(pokemonLevel!.cp_multiplier!), 2) 
                    / 10 
                );




        }
    }
}
