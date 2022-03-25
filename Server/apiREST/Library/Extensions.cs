using apiREST.Data;
using apiREST.Model;

namespace ExtensionMethods
{
    public static class MyExtensions
    {


        /// <summary>
        /// List user extension that convert a list of users to simple user class
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static List<SimpleUserData> toSimpleResponseListUserData(this List<User> users)
        {
            List<SimpleUserData> response = new List<SimpleUserData>();

            foreach (User admin in users)
            {
                response.Add(admin.toSimpleResponseUserData());
            }

            return response;
        }



        public static List<PokemonOwnedForList> toPokemonOwnedForListList(this List<PokemonOwned> pokemons, pokemonGolotApi context) 
        {
            List<PokemonOwnedForList> response = new List<PokemonOwnedForList>();

            foreach (PokemonOwned pokemon in pokemons) 
            {
                response.Add(pokemon.ToPokemonOwnedForList(context));
            }

            return response;
        }
    }
}
