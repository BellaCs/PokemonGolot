using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class fixingpokemongendercolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "female_gender",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "male_gender",
                table: "Pokemon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "female_gender",
                table: "Pokemon",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "male_gender",
                table: "Pokemon",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
