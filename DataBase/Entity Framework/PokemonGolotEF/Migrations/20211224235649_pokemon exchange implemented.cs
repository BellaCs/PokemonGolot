using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class pokemonexchangeimplemented : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PokemonExchange",
                columns: table => new
                {
                    ex_owner = table.Column<string>(type: "character varying(20)", nullable: false),
                    pokemon = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonExchange", x => new { x.pokemon, x.ex_owner });
                    table.ForeignKey(
                        name: "FK_PokemonExchange_Pokemon_pokemon",
                        column: x => x.pokemon,
                        principalTable: "Pokemon",
                        principalColumn: "num_pokedex",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonExchange_User_ex_owner",
                        column: x => x.ex_owner,
                        principalTable: "User",
                        principalColumn: "user_name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonExchange_ex_owner",
                table: "PokemonExchange",
                column: "ex_owner");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonExchange");
        }
    }
}
