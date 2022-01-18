using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class fixpokemontable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_Egg_Eggkm_egg",
                table: "Pokemon");

            migrationBuilder.DropIndex(
                name: "IX_Pokemon_Eggkm_egg",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Eggkm_egg",
                table: "Pokemon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Eggkm_egg",
                table: "Pokemon",
                type: "double precision",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Eggkm_egg",
                table: "Pokemon",
                column: "Eggkm_egg");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_Egg_Eggkm_egg",
                table: "Pokemon",
                column: "Eggkm_egg",
                principalTable: "Egg",
                principalColumn: "km_egg");
        }
    }
}
