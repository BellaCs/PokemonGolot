using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class Raidimplementation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RaidParticipant",
                columns: table => new
                {
                    gym = table.Column<string>(type: "text", nullable: false),
                    user = table.Column<string>(type: "character varying(20)", nullable: false),
                    Raidlocation = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaidParticipant", x => new { x.gym, x.user });
                    table.ForeignKey(
                        name: "FK_RaidParticipant_Gym_gym",
                        column: x => x.gym,
                        principalTable: "Gym",
                        principalColumn: "location",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaidParticipant_Raid_Raidlocation",
                        column: x => x.Raidlocation,
                        principalTable: "Raid",
                        principalColumn: "location");
                    table.ForeignKey(
                        name: "FK_RaidParticipant_User_user",
                        column: x => x.user,
                        principalTable: "User",
                        principalColumn: "user_name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RaidParticipant_Raidlocation",
                table: "RaidParticipant",
                column: "Raidlocation");

            migrationBuilder.CreateIndex(
                name: "IX_RaidParticipant_user",
                table: "RaidParticipant",
                column: "user");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RaidParticipant");
        }
    }
}
