namespace ApiMongo
{
    public class Fight
    {
        public DateTime Date { get; set; }

        public string? player1 { get; set; }

        public string? player2 { get; set; }

        public string? pokemonPlayer1 { get; set; }

        public string? pokemonPlayer2 { get; set; }

        public ICollection<Attacks> attack { get; set; }

        public class Attacks
        {
            public string? att_name { get; set; }

            public int att_dmg { get; set; }

            public string? att_attacker { get; set; }

            public string? att_defender { get; set; }

        }
    }
}