using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class inventoryimplements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Object_inventories",
                columns: table => new
                {
                    objectName = table.Column<string>(type: "text", nullable: false),
                    user = table.Column<string>(type: "character varying(20)", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Object_inventories", x => new { x.objectName, x.user });
                    table.ForeignKey(
                        name: "FK_Object_inventories_Object_objectName",
                        column: x => x.objectName,
                        principalTable: "Object",
                        principalColumn: "name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Object_inventories_User_user",
                        column: x => x.user,
                        principalTable: "User",
                        principalColumn: "user_name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Object_inventories_user",
                table: "Object_inventories",
                column: "user");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Object_inventories");
        }
    }
}
