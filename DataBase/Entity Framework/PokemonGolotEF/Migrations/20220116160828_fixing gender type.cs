using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class fixinggendertype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "gender",
                table: "Player",
                type: "text",
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<char>(
                name: "gender",
                table: "Player",
                type: "character(1)",
                nullable: false,
                defaultValue: ' ',
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
