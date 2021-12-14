using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class GymDefenseimplements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gym_defensors",
                columns: table => new
                {
                    gym = table.Column<string>(type: "text", nullable: false),
                    pokemon = table.Column<int>(type: "integer", nullable: false),
                    defenseTime = table.Column<int>(type: "integer", nullable: false),
                    timesFeeded = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gym_defensors", x => new { x.gym, x.pokemon });
                    table.ForeignKey(
                        name: "FK_Gym_defensors_Gym_gym",
                        column: x => x.gym,
                        principalTable: "Gym",
                        principalColumn: "location",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gym_defensors_Pokemon_pokemon",
                        column: x => x.pokemon,
                        principalTable: "Pokemon",
                        principalColumn: "num_pokedex",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gym_defensors_pokemon",
                table: "Gym_defensors",
                column: "pokemon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gym_defensors");
        }
    }
}
