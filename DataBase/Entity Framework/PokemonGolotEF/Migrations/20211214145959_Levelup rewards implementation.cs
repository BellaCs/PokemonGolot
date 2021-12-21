using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class Leveluprewardsimplementation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Present_PokeStop_pokeStop",
                table: "Present");

            migrationBuilder.DropForeignKey(
                name: "FK_Present_User_owner",
                table: "Present");

            migrationBuilder.RenameColumn(
                name: "recievedDate",
                table: "Present",
                newName: "getDate");

            migrationBuilder.AlterColumn<string>(
                name: "pokeStop",
                table: "Present",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "owner",
                table: "Present",
                type: "character varying(20)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "LevelupObjectReward",
                columns: table => new
                {
                    level = table.Column<short>(type: "smallint", nullable: false),
                    object_name = table.Column<string>(type: "text", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LevelupObjectReward", x => new { x.level, x.object_name });
                    table.ForeignKey(
                        name: "FK_LevelupObjectReward_Level_level",
                        column: x => x.level,
                        principalTable: "Level",
                        principalColumn: "level",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LevelupObjectReward_Object_object_name",
                        column: x => x.object_name,
                        principalTable: "Object",
                        principalColumn: "name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LevelupObjectReward_object_name",
                table: "LevelupObjectReward",
                column: "object_name");

            migrationBuilder.AddForeignKey(
                name: "FK_Present_PokeStop_pokeStop",
                table: "Present",
                column: "pokeStop",
                principalTable: "PokeStop",
                principalColumn: "location",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Present_User_owner",
                table: "Present",
                column: "owner",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Present_PokeStop_pokeStop",
                table: "Present");

            migrationBuilder.DropForeignKey(
                name: "FK_Present_User_owner",
                table: "Present");

            migrationBuilder.DropTable(
                name: "LevelupObjectReward");

            migrationBuilder.RenameColumn(
                name: "getDate",
                table: "Present",
                newName: "recievedDate");

            migrationBuilder.AlterColumn<string>(
                name: "pokeStop",
                table: "Present",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "owner",
                table: "Present",
                type: "character varying(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)");

            migrationBuilder.AddForeignKey(
                name: "FK_Present_PokeStop_pokeStop",
                table: "Present",
                column: "pokeStop",
                principalTable: "PokeStop",
                principalColumn: "location");

            migrationBuilder.AddForeignKey(
                name: "FK_Present_User_owner",
                table: "Present",
                column: "owner",
                principalTable: "User",
                principalColumn: "user_name");
        }
    }
}
