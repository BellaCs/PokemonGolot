using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    public class PokemonElement
    {
         [ForeignKey("Pokemon")]
         public int pokemon { get; set; }
         [ForeignKey("Element")]
         public string element { get; set; }

        [ForeignKey("pokemon")]
        internal virtual Pokemon Pokemon { get; set; }
        [ForeignKey("element")]
        internal virtual Element Element { get; set; }

    }
}
