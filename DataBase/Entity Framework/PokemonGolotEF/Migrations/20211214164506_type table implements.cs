using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class typetableimplements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Type_table",
                columns: table => new
                {
                    element = table.Column<string>(type: "text", nullable: false),
                    affected_element = table.Column<string>(type: "text", nullable: false),
                    multiplier = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_table", x => new { x.element, x.affected_element });
                    table.ForeignKey(
                        name: "FK_Type_table_Element_affected_element",
                        column: x => x.affected_element,
                        principalTable: "Element",
                        principalColumn: "name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Type_table_Element_element",
                        column: x => x.element,
                        principalTable: "Element",
                        principalColumn: "name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Type_table_affected_element",
                table: "Type_table",
                column: "affected_element");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Type_table");
        }
    }
}
