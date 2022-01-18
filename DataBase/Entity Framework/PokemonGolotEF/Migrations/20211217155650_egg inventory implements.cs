using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class egginventoryimplements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Egg_inventory",
                columns: table => new
                {
                    egg = table.Column<double>(type: "double precision", nullable: false),
                    user = table.Column<string>(type: "text", nullable: false),
                    remainingKm = table.Column<double>(type: "double precision", nullable: false),
                    user_name = table.Column<string>(type: "character varying(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egg_inventory", x => new { x.egg, x.user });
                    table.ForeignKey(
                        name: "FK_Egg_inventory_User_user_name",
                        column: x => x.user_name,
                        principalTable: "User",
                        principalColumn: "user_name");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Egg_inventory_user_name",
                table: "Egg_inventory",
                column: "user_name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Egg_inventory");
        }
    }
}
