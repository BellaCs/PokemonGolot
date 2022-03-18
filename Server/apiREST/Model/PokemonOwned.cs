using apiREST.Data;
using apiREST.Logic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiREST.Model
{
    public class PokemonOwned
    {
        [Key]
        public int? pokemon_id { get; set; }
        [ForeignKey("Pokemon")]
        [Required]
        public int? pokemon { get; set; }
        [ForeignKey("Owner")]
        [Required]
        public string? owner { get; set; }
        [Required]
        public int? atack_iv { get; set; }
        [Required]
        public int? stamina_iv { get; set; }
        [Required]
        public int? defense_iv { get; set; }
        [Required]
        public string? name { get; set; }
        [ForeignKey("Level")]
        [Required]
        public float? level { get; set; }

        [ForeignKey("pokemon")]
        public virtual Pokemon? Pokemon { get; set; }
        [ForeignKey("owner")]
        public virtual Player? Owner { get; set; }
        [ForeignKey("level")]
        public virtual PokemonLevel? Level { get; set; }

        public PokemonOwnedForList ToPokemonOwnedForList(pokemonGolotApi context) {

            PokemonOwnedForList pokemonOwnedForList = new();
            pokemonLogic _logic = new pokemonLogic();

            pokemonOwnedForList.pokemon_id = pokemon_id;
            pokemonOwnedForList.num_pokedex = pokemon;
            pokemonOwnedForList.name = name;
            pokemonOwnedForList.img_front = _logic.getPokemonImgFront(pokemon, context);

            return pokemonOwnedForList;
        }
    }

    public class PokemonOwnedForList {

        public int? pokemon_id { get; set; }
        public int? num_pokedex { get; set; }
        public string? img_front { get; set; }
        public string? name { get; set; }
        public int? cp { get; set; }


    }


}
