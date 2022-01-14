using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class rolscreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 563);

            migrationBuilder.CreateTable(
                name: "Player_rols",
                columns: table => new
                {
                    rol = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player_rols", x => x.rol);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player_rols");

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "num_pokedex", "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[,]
                {
                    { 52, 92.0, 78.0, "Meowth withdraws its sharp claws into its paws to slinkily sneak about without making any incriminating footsteps. For some reason, this Pokémon loves shiny coins that glitter with light.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/52.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/52.png", null, true, 0.5f, "Meowth", "common", 120.0 },
                    { 53, 150.0, 136.0, "Persian has six bold whiskers that give it a look of toughness. The whiskers sense air movements to determine what is in the Pokémon's surrounding vicinity. It becomes docile if grabbed by the whiskers.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/53.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/53.png", null, true, 0.5f, "Persian", "common", 163.0 },
                    { 83, 124.0, 115.0, "Farfetch'd is always seen with a stalk from a plant of some sort. Apparently, there are good stalks and bad stalks. This Pokémon has been known to fight with others over stalks.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/83.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/83.png", null, true, 0.5f, "Farfetch'd", "common", 141.0 },
                    { 122, 192.0, 205.0, "Mr. Mime is a master of pantomime. Its gestures and motions convince watchers that something unseeable actually exists. Once the watchers are convinced, the unseeable thing exists as if it were real.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/122.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/122.png", null, true, 0.5f, "Mr. Mime", "common", 120.0 },
                    { 263, 58.0, 80.0, "Zigzagoon restlessly wanders everywhere at all times. This Pokémon does so because it is very curious. It becomes interested in anything that it happens to see.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/263.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/263.png", null, true, 0.5f, "Zigzagoon", "common", 116.0 },
                    { 264, 142.0, 128.0, "Linoone always runs full speed and only in straight lines. If facing an obstacle, it makes a right-angle turn to evade it. This Pokémon is very challenged by gently curving roads.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/264.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/264.png", null, true, 0.5f, "Linoone", "common", 186.0 },
                    { 439, 125.0, 142.0, "When this gifted mimic surprises an opponent, Mime Jr. feels so happy that it ends up forgetting it was imitating something.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/439.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/439.png", null, true, 0.5f, "Mime Jr.", "common", 85.0 },
                    { 562, 95.0, 141.0, "Each of them carries a mask that used to be its face when it was human. Sometimes they look at it and cry.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/562.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/562.png", null, true, 0.5f, "Yamask", "common", 116.0 },
                    { 563, 163.0, 237.0, "Grave robbers who mistake them for real coffins and get too close end up trapped inside their bodies.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/563.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/563.png", null, true, 0.5f, "Cofagrigus", "common", 151.0 }
                });
        }
    }
}
