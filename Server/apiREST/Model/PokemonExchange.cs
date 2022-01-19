using System.ComponentModel.DataAnnotations.Schema;

namespace apiREST.Model
{
    public class PokemonExchange
    {
        [ForeignKey("ExOwner")]
        public string? ex_owner { get; set; }
        [ForeignKey("Pokemon")]
        public int? pokemon { get; set; }    

        [ForeignKey("pokemon")]
        public virtual Pokemon? Pokemon { get; set; }
        [ForeignKey("ex_owner")]
        public virtual Player? ExOwner { get; set; }
    }
}
