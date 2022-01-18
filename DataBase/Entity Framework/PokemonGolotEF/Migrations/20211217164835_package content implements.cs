using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class packagecontentimplements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Package_items",
                columns: table => new
                {
                    objectName = table.Column<string>(type: "text", nullable: false),
                    package = table.Column<string>(type: "text", nullable: false),
                    units = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package_items", x => new { x.objectName, x.package });
                    table.ForeignKey(
                        name: "FK_Package_items_Object_objectName",
                        column: x => x.objectName,
                        principalTable: "Object",
                        principalColumn: "name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Package_items_Package_offer_package",
                        column: x => x.package,
                        principalTable: "Package_offer",
                        principalColumn: "name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Package_items_package",
                table: "Package_items",
                column: "package");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Package_items");
        }
    }
}
