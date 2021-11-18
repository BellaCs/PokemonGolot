using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class primeraMigracio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "levels",
                columns: table => new
                {
                    level = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    necessary_xp = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_levels", x => x.level);
                });

            migrationBuilder.CreateTable(
                name: "objects",
                columns: table => new
                {
                    name = table.Column<string>(type: "text", nullable: false),
                    type = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objects", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "pokemmons",
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
                    table.PrimaryKey("PK_pokemmons", x => x.num_pokedex);
                });

            migrationBuilder.CreateTable(
                name: "teams",
                columns: table => new
                {
                    team_name = table.Column<string>(type: "text", nullable: false),
                    color = table.Column<string>(type: "text", nullable: false),
                    image = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teams", x => x.team_name);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    user_name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    team_name = table.Column<string>(type: "text", nullable: true),
                    gender = table.Column<char>(type: "character(1)", nullable: false),
                    level = table.Column<short>(type: "smallint", nullable: false),
                    birth_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    inventory_capacity = table.Column<int>(type: "integer", nullable: false),
                    remaining_experience = table.Column<int>(type: "integer", nullable: false),
                    pokemon_slots = table.Column<int>(type: "integer", nullable: false),
                    won_battles = table.Column<int>(type: "integer", nullable: false),
                    caputred_pokemon = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.user_name);
                    table.ForeignKey(
                        name: "FK_users_levels_level",
                        column: x => x.level,
                        principalTable: "levels",
                        principalColumn: "level",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_teams_team_name",
                        column: x => x.team_name,
                        principalTable: "teams",
                        principalColumn: "team_name");
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_level",
                table: "users",
                column: "level");

            migrationBuilder.CreateIndex(
                name: "IX_users_team_name",
                table: "users",
                column: "team_name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "objects");

            migrationBuilder.DropTable(
                name: "pokemmons");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "levels");

            migrationBuilder.DropTable(
                name: "teams");
        }
    }
}
