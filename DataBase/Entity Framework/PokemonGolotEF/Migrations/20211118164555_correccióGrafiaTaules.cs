using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class correccióGrafiaTaules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_levels_level",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "FK_users_teams_team_name",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_teams",
                table: "teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pokemmons",
                table: "pokemmons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_objects",
                table: "objects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_levels",
                table: "levels");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "teams",
                newName: "Team");

            migrationBuilder.RenameTable(
                name: "pokemmons",
                newName: "Pokemmon");

            migrationBuilder.RenameTable(
                name: "objects",
                newName: "Object");

            migrationBuilder.RenameTable(
                name: "levels",
                newName: "Level");

            migrationBuilder.RenameIndex(
                name: "IX_users_team_name",
                table: "User",
                newName: "IX_User_team_name");

            migrationBuilder.RenameIndex(
                name: "IX_users_level",
                table: "User",
                newName: "IX_User_level");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "user_name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                column: "team_name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pokemmon",
                table: "Pokemmon",
                column: "num_pokedex");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Object",
                table: "Object",
                column: "name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Level",
                table: "Level",
                column: "level");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Level_level",
                table: "User",
                column: "level",
                principalTable: "Level",
                principalColumn: "level",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Team_team_name",
                table: "User",
                column: "team_name",
                principalTable: "Team",
                principalColumn: "team_name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Level_level",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Team_team_name",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pokemmon",
                table: "Pokemmon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Object",
                table: "Object");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Level",
                table: "Level");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "Team",
                newName: "teams");

            migrationBuilder.RenameTable(
                name: "Pokemmon",
                newName: "pokemmons");

            migrationBuilder.RenameTable(
                name: "Object",
                newName: "objects");

            migrationBuilder.RenameTable(
                name: "Level",
                newName: "levels");

            migrationBuilder.RenameIndex(
                name: "IX_User_team_name",
                table: "users",
                newName: "IX_users_team_name");

            migrationBuilder.RenameIndex(
                name: "IX_User_level",
                table: "users",
                newName: "IX_users_level");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "user_name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_teams",
                table: "teams",
                column: "team_name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pokemmons",
                table: "pokemmons",
                column: "num_pokedex");

            migrationBuilder.AddPrimaryKey(
                name: "PK_objects",
                table: "objects",
                column: "name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_levels",
                table: "levels",
                column: "level");

            migrationBuilder.AddForeignKey(
                name: "FK_users_levels_level",
                table: "users",
                column: "level",
                principalTable: "levels",
                principalColumn: "level",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_teams_team_name",
                table: "users",
                column: "team_name",
                principalTable: "teams",
                principalColumn: "team_name");
        }
    }
}
