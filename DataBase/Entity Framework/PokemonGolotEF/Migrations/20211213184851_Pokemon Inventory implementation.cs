using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class PokemonInventoryimplementation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemon_owned",
                columns: table => new
                {
                    pokemonId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    pokemon = table.Column<int>(type: "integer", nullable: false),
                    owner = table.Column<string>(type: "character varying(20)", nullable: true),
                    atack_iv = table.Column<int>(type: "integer", nullable: false),
                    stamina_iv = table.Column<int>(type: "integer", nullable: false),
                    defense_iv = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true),
                    level = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon_owned", x => x.pokemonId);
                    table.ForeignKey(
                        name: "FK_Pokemon_owned_Pokemon_level_level",
                        column: x => x.level,
                        principalTable: "Pokemon_level",
                        principalColumn: "pokemon_level",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_owned_Pokemon_pokemon",
                        column: x => x.pokemon,
                        principalTable: "Pokemon",
                        principalColumn: "num_pokedex",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_owned_User_owner",
                        column: x => x.owner,
                        principalTable: "User",
                        principalColumn: "user_name");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_owned_level",
                table: "Pokemon_owned",
                column: "level");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_owned_owner",
                table: "Pokemon_owned",
                column: "owner");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_owned_pokemon",
                table: "Pokemon_owned",
                column: "pokemon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemon_owned");
        }
    }
}
