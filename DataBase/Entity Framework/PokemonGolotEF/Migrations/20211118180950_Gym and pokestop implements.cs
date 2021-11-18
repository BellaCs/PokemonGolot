using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class Gymandpokestopimplements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemmon");

            migrationBuilder.AlterColumn<string>(
                name: "user_name",
                table: "User",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    num_pokedex = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    attack = table.Column<double>(type: "double precision", nullable: false),
                    stamina = table.Column<double>(type: "double precision", nullable: false),
                    defense = table.Column<double>(type: "double precision", nullable: false),
                    male_gender = table.Column<bool>(type: "boolean", nullable: false),
                    female_gender = table.Column<bool>(type: "boolean", nullable: false),
                    rarity = table.Column<string>(type: "text", nullable: false),
                    img_front = table.Column<string>(type: "text", nullable: false),
                    img_back = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.num_pokedex);
                });

            migrationBuilder.CreateTable(
                name: "PokeStop",
                columns: table => new
                {
                    location = table.Column<string>(type: "text", nullable: false),
                    image = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokeStop", x => x.location);
                });

            migrationBuilder.CreateTable(
                name: "Gym",
                columns: table => new
                {
                    location = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    team_name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gym", x => x.location);
                    table.ForeignKey(
                        name: "FK_Gym_PokeStop_location",
                        column: x => x.location,
                        principalTable: "PokeStop",
                        principalColumn: "location",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gym_Team_team_name",
                        column: x => x.team_name,
                        principalTable: "Team",
                        principalColumn: "team_name");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gym_team_name",
                table: "Gym",
                column: "team_name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gym");

            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "PokeStop");

            migrationBuilder.AlterColumn<string>(
                name: "user_name",
                table: "User",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.CreateTable(
                name: "Pokemmon",
                columns: table => new
                {
                    num_pokedex = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    attack = table.Column<double>(type: "double precision", nullable: false),
                    defense = table.Column<double>(type: "double precision", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    female_gender = table.Column<bool>(type: "boolean", nullable: false),
                    img_back = table.Column<string>(type: "text", nullable: false),
                    img_front = table.Column<string>(type: "text", nullable: false),
                    male_gender = table.Column<bool>(type: "boolean", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    rarity = table.Column<string>(type: "text", nullable: false),
                    stamina = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemmon", x => x.num_pokedex);
                });
        }
    }
}
