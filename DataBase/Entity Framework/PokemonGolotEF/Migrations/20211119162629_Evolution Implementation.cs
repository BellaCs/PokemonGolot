using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class EvolutionImplementation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Evolution_chain",
                columns: table => new
                {
                    pokemon_base = table.Column<int>(type: "integer", nullable: false),
                    pokemon_evolved = table.Column<int>(type: "integer", nullable: false),
                    candy_needed = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evolution_chain", x => new { x.pokemon_base, x.pokemon_evolved });
                    table.ForeignKey(
                        name: "FK_Evolution_chain_Pokemon_pokemon_base",
                        column: x => x.pokemon_base,
                        principalTable: "Pokemon",
                        principalColumn: "num_pokedex",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evolution_chain_Pokemon_pokemon_evolved",
                        column: x => x.pokemon_evolved,
                        principalTable: "Pokemon",
                        principalColumn: "num_pokedex",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evolution_chain_pokemon_evolved",
                table: "Evolution_chain",
                column: "pokemon_evolved");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evolution_chain");
        }
    }
}
