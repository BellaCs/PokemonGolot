using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class trophysimplements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GymTrophies",
                columns: table => new
                {
                    gym = table.Column<string>(type: "text", nullable: false),
                    user = table.Column<string>(type: "character varying(20)", nullable: false),
                    fights_won = table.Column<int>(type: "integer", nullable: false),
                    pokemon_time = table.Column<int>(type: "integer", nullable: false),
                    times_feeded = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymTrophies", x => new { x.gym, x.user });
                    table.ForeignKey(
                        name: "FK_GymTrophies_Gym_gym",
                        column: x => x.gym,
                        principalTable: "Gym",
                        principalColumn: "location",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GymTrophies_User_user",
                        column: x => x.user,
                        principalTable: "User",
                        principalColumn: "user_name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GymTrophies_user",
                table: "GymTrophies",
                column: "user");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GymTrophies");
        }
    }
}
