using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class trophiestablenamefix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymTrophies_Gym_gym",
                table: "GymTrophies");

            migrationBuilder.DropForeignKey(
                name: "FK_GymTrophies_User_user",
                table: "GymTrophies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GymTrophies",
                table: "GymTrophies");

            migrationBuilder.RenameTable(
                name: "GymTrophies",
                newName: "Gym_trophies");

            migrationBuilder.RenameIndex(
                name: "IX_GymTrophies_user",
                table: "Gym_trophies",
                newName: "IX_Gym_trophies_user");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gym_trophies",
                table: "Gym_trophies",
                columns: new[] { "gym", "user" });

            migrationBuilder.AddForeignKey(
                name: "FK_Gym_trophies_Gym_gym",
                table: "Gym_trophies",
                column: "gym",
                principalTable: "Gym",
                principalColumn: "location",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gym_trophies_User_user",
                table: "Gym_trophies",
                column: "user",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gym_trophies_Gym_gym",
                table: "Gym_trophies");

            migrationBuilder.DropForeignKey(
                name: "FK_Gym_trophies_User_user",
                table: "Gym_trophies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gym_trophies",
                table: "Gym_trophies");

            migrationBuilder.RenameTable(
                name: "Gym_trophies",
                newName: "GymTrophies");

            migrationBuilder.RenameIndex(
                name: "IX_Gym_trophies_user",
                table: "GymTrophies",
                newName: "IX_GymTrophies_user");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GymTrophies",
                table: "GymTrophies",
                columns: new[] { "gym", "user" });

            migrationBuilder.AddForeignKey(
                name: "FK_GymTrophies_Gym_gym",
                table: "GymTrophies",
                column: "gym",
                principalTable: "Gym",
                principalColumn: "location",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GymTrophies_User_user",
                table: "GymTrophies",
                column: "user",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
