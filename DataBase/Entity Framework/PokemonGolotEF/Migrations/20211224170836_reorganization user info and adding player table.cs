using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class reorganizationuserinfoandaddingplayertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Egg_inventory_User_user",
                table: "Egg_inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Friendships_User_user",
                table: "Friendships");

            migrationBuilder.DropForeignKey(
                name: "FK_Gym_trophies_User_user",
                table: "Gym_trophies");

            migrationBuilder.DropForeignKey(
                name: "FK_Object_inventories_User_user",
                table: "Object_inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_register_User_user",
                table: "Pokemon_register");

            migrationBuilder.DropForeignKey(
                name: "FK_Raid_participants_User_user",
                table: "Raid_participants");

            migrationBuilder.DropColumn(
                name: "birth_date",
                table: "User");

            migrationBuilder.DropColumn(
                name: "email",
                table: "User");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "User");

            migrationBuilder.DropColumn(
                name: "name",
                table: "User");

            migrationBuilder.DropColumn(
                name: "password",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "user",
                table: "Raid_participants",
                newName: "player");

            migrationBuilder.RenameIndex(
                name: "IX_Raid_participants_user",
                table: "Raid_participants",
                newName: "IX_Raid_participants_player");

            migrationBuilder.RenameColumn(
                name: "user",
                table: "Pokemon_register",
                newName: "player");

            migrationBuilder.RenameIndex(
                name: "IX_Pokemon_register_user",
                table: "Pokemon_register",
                newName: "IX_Pokemon_register_player");

            migrationBuilder.RenameColumn(
                name: "user",
                table: "Object_inventories",
                newName: "player");

            migrationBuilder.RenameIndex(
                name: "IX_Object_inventories_user",
                table: "Object_inventories",
                newName: "IX_Object_inventories_player");

            migrationBuilder.RenameColumn(
                name: "user",
                table: "Gym_trophies",
                newName: "player");

            migrationBuilder.RenameIndex(
                name: "IX_Gym_trophies_user",
                table: "Gym_trophies",
                newName: "IX_Gym_trophies_player");

            migrationBuilder.RenameColumn(
                name: "user",
                table: "Friendships",
                newName: "player");

            migrationBuilder.RenameColumn(
                name: "user",
                table: "Egg_inventory",
                newName: "player");

            migrationBuilder.RenameIndex(
                name: "IX_Egg_inventory_user",
                table: "Egg_inventory",
                newName: "IX_Egg_inventory_player");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Egg",
                newName: "name");

            migrationBuilder.AlterColumn<float>(
                name: "male_gender",
                table: "Pokemon",
                type: "real",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<float>(
                name: "female_gender",
                table: "Pokemon",
                type: "real",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    user_name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    gender = table.Column<char>(type: "character(1)", nullable: false),
                    birth_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.user_name);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Egg_inventory_User_player",
                table: "Egg_inventory",
                column: "player",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Friendships_User_player",
                table: "Friendships",
                column: "player",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gym_trophies_User_player",
                table: "Gym_trophies",
                column: "player",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Object_inventories_User_player",
                table: "Object_inventories",
                column: "player",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_register_User_player",
                table: "Pokemon_register",
                column: "player",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Raid_participants_User_player",
                table: "Raid_participants",
                column: "player",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Player_user_name",
                table: "User",
                column: "user_name",
                principalTable: "Player",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Egg_inventory_User_player",
                table: "Egg_inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Friendships_User_player",
                table: "Friendships");

            migrationBuilder.DropForeignKey(
                name: "FK_Gym_trophies_User_player",
                table: "Gym_trophies");

            migrationBuilder.DropForeignKey(
                name: "FK_Object_inventories_User_player",
                table: "Object_inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_register_User_player",
                table: "Pokemon_register");

            migrationBuilder.DropForeignKey(
                name: "FK_Raid_participants_User_player",
                table: "Raid_participants");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Player_user_name",
                table: "User");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.RenameColumn(
                name: "player",
                table: "Raid_participants",
                newName: "user");

            migrationBuilder.RenameIndex(
                name: "IX_Raid_participants_player",
                table: "Raid_participants",
                newName: "IX_Raid_participants_user");

            migrationBuilder.RenameColumn(
                name: "player",
                table: "Pokemon_register",
                newName: "user");

            migrationBuilder.RenameIndex(
                name: "IX_Pokemon_register_player",
                table: "Pokemon_register",
                newName: "IX_Pokemon_register_user");

            migrationBuilder.RenameColumn(
                name: "player",
                table: "Object_inventories",
                newName: "user");

            migrationBuilder.RenameIndex(
                name: "IX_Object_inventories_player",
                table: "Object_inventories",
                newName: "IX_Object_inventories_user");

            migrationBuilder.RenameColumn(
                name: "player",
                table: "Gym_trophies",
                newName: "user");

            migrationBuilder.RenameIndex(
                name: "IX_Gym_trophies_player",
                table: "Gym_trophies",
                newName: "IX_Gym_trophies_user");

            migrationBuilder.RenameColumn(
                name: "player",
                table: "Friendships",
                newName: "user");

            migrationBuilder.RenameColumn(
                name: "player",
                table: "Egg_inventory",
                newName: "user");

            migrationBuilder.RenameIndex(
                name: "IX_Egg_inventory_player",
                table: "Egg_inventory",
                newName: "IX_Egg_inventory_user");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Egg",
                newName: "description");

            migrationBuilder.AddColumn<DateTime>(
                name: "birth_date",
                table: "User",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<char>(
                name: "gender",
                table: "User",
                type: "character(1)",
                nullable: false,
                defaultValue: ' ');

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<bool>(
                name: "male_gender",
                table: "Pokemon",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<bool>(
                name: "female_gender",
                table: "Pokemon",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddForeignKey(
                name: "FK_Egg_inventory_User_user",
                table: "Egg_inventory",
                column: "user",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Friendships_User_user",
                table: "Friendships",
                column: "user",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gym_trophies_User_user",
                table: "Gym_trophies",
                column: "user",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Object_inventories_User_user",
                table: "Object_inventories",
                column: "user",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_register_User_user",
                table: "Pokemon_register",
                column: "user",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Raid_participants_User_user",
                table: "Raid_participants",
                column: "user",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
