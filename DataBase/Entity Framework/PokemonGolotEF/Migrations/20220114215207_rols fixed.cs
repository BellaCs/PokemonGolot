using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class rolsfixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "rol",
                table: "Player",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Player_rol",
                table: "Player",
                column: "rol");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Player_rols_rol",
                table: "Player",
                column: "rol",
                principalTable: "Player_rols",
                principalColumn: "rol");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Player_rols_rol",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_rol",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "rol",
                table: "Player");
        }
    }
}
