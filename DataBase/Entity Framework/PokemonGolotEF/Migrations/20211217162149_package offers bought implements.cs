using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class packageoffersboughtimplements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Package_offers_bought",
                columns: table => new
                {
                    package = table.Column<string>(type: "text", nullable: false),
                    user = table.Column<string>(type: "character varying(20)", nullable: false),
                    last_bought_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package_offers_bought", x => new { x.package, x.user });
                    table.ForeignKey(
                        name: "FK_Package_offers_bought_Package_offer_package",
                        column: x => x.package,
                        principalTable: "Package_offer",
                        principalColumn: "name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Package_offers_bought_User_user",
                        column: x => x.user,
                        principalTable: "User",
                        principalColumn: "user_name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Package_offers_bought_user",
                table: "Package_offers_bought",
                column: "user");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Package_offers_bought");
        }
    }
}
