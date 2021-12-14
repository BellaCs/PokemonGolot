using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class FriendShipsimplements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Friendships",
                columns: table => new
                {
                    user = table.Column<string>(type: "character varying(20)", nullable: false),
                    friend = table.Column<string>(type: "character varying(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friendships", x => new { x.user, x.friend });
                    table.ForeignKey(
                        name: "FK_Friendships_User_friend",
                        column: x => x.friend,
                        principalTable: "User",
                        principalColumn: "user_name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Friendships_User_user",
                        column: x => x.user,
                        principalTable: "User",
                        principalColumn: "user_name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_friend",
                table: "Friendships",
                column: "friend");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friendships");
        }
    }
}
