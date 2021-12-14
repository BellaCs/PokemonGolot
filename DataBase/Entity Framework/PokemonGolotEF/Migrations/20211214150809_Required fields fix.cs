using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class Requiredfieldsfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LevelupObjectReward_Level_level",
                table: "LevelupObjectReward");

            migrationBuilder.DropForeignKey(
                name: "FK_LevelupObjectReward_Object_object_name",
                table: "LevelupObjectReward");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_owned_User_owner",
                table: "Pokemon_owned");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LevelupObjectReward",
                table: "LevelupObjectReward");

            migrationBuilder.RenameTable(
                name: "LevelupObjectReward",
                newName: "Levelup_object_rewards");

            migrationBuilder.RenameIndex(
                name: "IX_LevelupObjectReward_object_name",
                table: "Levelup_object_rewards",
                newName: "IX_Levelup_object_rewards_object_name");

            migrationBuilder.AlterColumn<string>(
                name: "owner",
                table: "Pokemon_owned",
                type: "character varying(20)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Pokemon_owned",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Levelup_object_rewards",
                table: "Levelup_object_rewards",
                columns: new[] { "level", "object_name" });

            migrationBuilder.AddForeignKey(
                name: "FK_Levelup_object_rewards_Level_level",
                table: "Levelup_object_rewards",
                column: "level",
                principalTable: "Level",
                principalColumn: "level",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Levelup_object_rewards_Object_object_name",
                table: "Levelup_object_rewards",
                column: "object_name",
                principalTable: "Object",
                principalColumn: "name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_owned_User_owner",
                table: "Pokemon_owned",
                column: "owner",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Levelup_object_rewards_Level_level",
                table: "Levelup_object_rewards");

            migrationBuilder.DropForeignKey(
                name: "FK_Levelup_object_rewards_Object_object_name",
                table: "Levelup_object_rewards");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_owned_User_owner",
                table: "Pokemon_owned");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Levelup_object_rewards",
                table: "Levelup_object_rewards");

            migrationBuilder.RenameTable(
                name: "Levelup_object_rewards",
                newName: "LevelupObjectReward");

            migrationBuilder.RenameIndex(
                name: "IX_Levelup_object_rewards_object_name",
                table: "LevelupObjectReward",
                newName: "IX_LevelupObjectReward_object_name");

            migrationBuilder.AlterColumn<string>(
                name: "owner",
                table: "Pokemon_owned",
                type: "character varying(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Pokemon_owned",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LevelupObjectReward",
                table: "LevelupObjectReward",
                columns: new[] { "level", "object_name" });

            migrationBuilder.AddForeignKey(
                name: "FK_LevelupObjectReward_Level_level",
                table: "LevelupObjectReward",
                column: "level",
                principalTable: "Level",
                principalColumn: "level",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LevelupObjectReward_Object_object_name",
                table: "LevelupObjectReward",
                column: "object_name",
                principalTable: "Object",
                principalColumn: "name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_owned_User_owner",
                table: "Pokemon_owned",
                column: "owner",
                principalTable: "User",
                principalColumn: "user_name");
        }
    }
}
