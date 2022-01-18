using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class pokedeximplements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemon_register",
                columns: table => new
                {
                    pokemon = table.Column<int>(type: "integer", nullable: false),
                    user = table.Column<string>(type: "character varying(20)", nullable: false),
                    gender = table.Column<char>(type: "character(1)", nullable: false),
                    sawed = table.Column<bool>(type: "boolean", nullable: false),
                    weight = table.Column<double>(type: "double precision", nullable: false),
                    height = table.Column<int>(type: "integer", nullable: false),
                    capturedNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon_register", x => new { x.pokemon, x.user, x.gender });
                    table.ForeignKey(
                        name: "FK_Pokemon_register_Pokemon_pokemon",
                        column: x => x.pokemon,
                        principalTable: "Pokemon",
                        principalColumn: "num_pokedex",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_register_User_user",
                        column: x => x.user,
                        principalTable: "User",
                        principalColumn: "user_name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_register_user",
                table: "Pokemon_register",
                column: "user");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemon_register");
        }
    }
}
