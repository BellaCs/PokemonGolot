using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class addingrols : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Player_rols",
                column: "rol",
                values: new object[]
                {
                    "Admin",
                    "Player"
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Player_rols",
                keyColumn: "rol",
                keyValue: "Admin");

            migrationBuilder.DeleteData(
                table: "Player_rols",
                keyColumn: "rol",
                keyValue: "Player");
        }
    }
}
