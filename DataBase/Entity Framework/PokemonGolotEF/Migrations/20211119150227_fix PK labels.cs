using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class fixPKlabels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gym_Team_team_name",
                table: "Gym");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Team_team_name",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "team_name",
                table: "User",
                newName: "team");

            migrationBuilder.RenameIndex(
                name: "IX_User_team_name",
                table: "User",
                newName: "IX_User_team");

            migrationBuilder.RenameColumn(
                name: "team_name",
                table: "Team",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "team_name",
                table: "Gym",
                newName: "team");

            migrationBuilder.RenameIndex(
                name: "IX_Gym_team_name",
                table: "Gym",
                newName: "IX_Gym_team");

            migrationBuilder.AddForeignKey(
                name: "FK_Gym_Team_team",
                table: "Gym",
                column: "team",
                principalTable: "Team",
                principalColumn: "name");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Team_team",
                table: "User",
                column: "team",
                principalTable: "Team",
                principalColumn: "name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gym_Team_team",
                table: "Gym");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Team_team",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "team",
                table: "User",
                newName: "team_name");

            migrationBuilder.RenameIndex(
                name: "IX_User_team",
                table: "User",
                newName: "IX_User_team_name");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Team",
                newName: "team_name");

            migrationBuilder.RenameColumn(
                name: "team",
                table: "Gym",
                newName: "team_name");

            migrationBuilder.RenameIndex(
                name: "IX_Gym_team",
                table: "Gym",
                newName: "IX_Gym_team_name");

            migrationBuilder.AddForeignKey(
                name: "FK_Gym_Team_team_name",
                table: "Gym",
                column: "team_name",
                principalTable: "Team",
                principalColumn: "team_name");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Team_team_name",
                table: "User",
                column: "team_name",
                principalTable: "Team",
                principalColumn: "team_name");
        }
    }
}
