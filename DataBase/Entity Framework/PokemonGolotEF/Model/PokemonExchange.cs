using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    internal class PokemonExchange
    {
        [ForeignKey("ExOwner")]
        public string ex_owner { get; set; }
        [ForeignKey("Pokemon")]
        public int pokemon { get; set; }    

        [ForeignKey("pokemon")]
        public virtual Pokemon Pokemon { get; set; }
        [ForeignKey("ex_owner")]
        public virtual User ExOwner { get; set; }
    }
}
