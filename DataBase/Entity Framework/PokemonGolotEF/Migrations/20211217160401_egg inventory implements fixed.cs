using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class egginventoryimplementsfixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Egg_inventory_User_user_name",
                table: "Egg_inventory");

            migrationBuilder.DropIndex(
                name: "IX_Egg_inventory_user_name",
                table: "Egg_inventory");

            migrationBuilder.DropColumn(
                name: "user_name",
                table: "Egg_inventory");

            migrationBuilder.AlterColumn<string>(
                name: "user",
                table: "Egg_inventory",
                type: "character varying(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateIndex(
                name: "IX_Egg_inventory_user",
                table: "Egg_inventory",
                column: "user");

            migrationBuilder.AddForeignKey(
                name: "FK_Egg_inventory_Egg_egg",
                table: "Egg_inventory",
                column: "egg",
                principalTable: "Egg",
                principalColumn: "km_egg",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Egg_inventory_User_user",
                table: "Egg_inventory",
                column: "user",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Egg_inventory_Egg_egg",
                table: "Egg_inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Egg_inventory_User_user",
                table: "Egg_inventory");

            migrationBuilder.DropIndex(
                name: "IX_Egg_inventory_user",
                table: "Egg_inventory");

            migrationBuilder.AlterColumn<string>(
                name: "user",
                table: "Egg_inventory",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)");

            migrationBuilder.AddColumn<string>(
                name: "user_name",
                table: "Egg_inventory",
                type: "character varying(20)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Egg_inventory_user_name",
                table: "Egg_inventory",
                column: "user_name");

            migrationBuilder.AddForeignKey(
                name: "FK_Egg_inventory_User_user_name",
                table: "Egg_inventory",
                column: "user_name",
                principalTable: "User",
                principalColumn: "user_name");
        }
    }
}
