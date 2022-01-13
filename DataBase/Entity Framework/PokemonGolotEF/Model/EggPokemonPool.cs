using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    internal class EggPokemonPool
    {
        [ForeignKey("Egg")]
        public double egg { get; set; }
        [ForeignKey("Pokemon")]
        public int pokemon { get; set; }

        [ForeignKey("pokemon")]
        public virtual Pokemon Pokemon { get; set; }
        [ForeignKey("egg")]
        public virtual Egg Egg { get; set; }
    }
}
