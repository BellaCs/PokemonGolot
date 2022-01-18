using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class exchangetablenameuserwithplayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Egg_inventory_User_player",
                table: "Egg_inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Friendships_User_friend",
                table: "Friendships");

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
                name: "FK_Package_offers_bought_User_user",
                table: "Package_offers_bought");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Player_rols_rol",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_exchange_User_ex_owner",
                table: "Pokemon_exchange");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_owned_User_owner",
                table: "Pokemon_owned");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_register_User_player",
                table: "Pokemon_register");

            migrationBuilder.DropForeignKey(
                name: "FK_Present_User_owner",
                table: "Present");

            migrationBuilder.DropForeignKey(
                name: "FK_Present_User_receptor",
                table: "Present");

            migrationBuilder.DropForeignKey(
                name: "FK_Raid_participants_User_player",
                table: "Raid_participants");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Level_level",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Player_user_name",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Team_team",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_level",
                table: "User");

            migrationBuilder.DropColumn(
                name: "caputred_pokemon",
                table: "User");

            migrationBuilder.DropColumn(
                name: "current_level_experience",
                table: "User");

            migrationBuilder.DropColumn(
                name: "experience",
                table: "User");

            migrationBuilder.DropColumn(
                name: "inventory_capacity",
                table: "User");

            migrationBuilder.DropColumn(
                name: "level",
                table: "User");

            migrationBuilder.DropColumn(
                name: "pokemon_slots",
                table: "User");

            migrationBuilder.DropColumn(
                name: "won_battles",
                table: "User");

            migrationBuilder.DropColumn(
                name: "birth_date",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Player");

            migrationBuilder.RenameColumn(
                name: "team",
                table: "User",
                newName: "rol");

            migrationBuilder.RenameIndex(
                name: "IX_User_team",
                table: "User",
                newName: "IX_User_rol");

            migrationBuilder.RenameColumn(
                name: "rol",
                table: "Player",
                newName: "team");

            migrationBuilder.RenameIndex(
                name: "IX_Player_rol",
                table: "Player",
                newName: "IX_Player_team");

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

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "User",
                type: "text",
                nullable: true);

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

            migrationBuilder.AddColumn<int>(
                name: "caputred_pokemon",
                table: "Player",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "current_level_experience",
                table: "Player",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "experience",
                table: "Player",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "inventory_capacity",
                table: "Player",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<short>(
                name: "level",
                table: "Player",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<int>(
                name: "pokemon_slots",
                table: "Player",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "won_battles",
                table: "Player",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Movements",
                columns: new[] { "element", "name", "duration", "energy", "isCharged", "power" },
                values: new object[] { "ice", "Icicle Spear", 2200, 33.0, true, 60 });

            migrationBuilder.CreateIndex(
                name: "IX_Player_level",
                table: "Player",
                column: "level");

            migrationBuilder.AddForeignKey(
                name: "FK_Egg_inventory_Player_player",
                table: "Egg_inventory",
                column: "player",
                principalTable: "Player",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Friendships_Player_friend",
                table: "Friendships",
                column: "friend",
                principalTable: "Player",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Friendships_Player_player",
                table: "Friendships",
                column: "player",
                principalTable: "Player",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gym_trophies_Player_player",
                table: "Gym_trophies",
                column: "player",
                principalTable: "Player",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Object_inventories_Player_player",
                table: "Object_inventories",
                column: "player",
                principalTable: "Player",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Package_offers_bought_Player_user",
                table: "Package_offers_bought",
                column: "user",
                principalTable: "Player",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Level_level",
                table: "Player",
                column: "level",
                principalTable: "Level",
                principalColumn: "level",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Team_team",
                table: "Player",
                column: "team",
                principalTable: "Team",
                principalColumn: "name");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_User_user_name",
                table: "Player",
                column: "user_name",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_exchange_Player_ex_owner",
                table: "Pokemon_exchange",
                column: "ex_owner",
                principalTable: "Player",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_owned_Player_owner",
                table: "Pokemon_owned",
                column: "owner",
                principalTable: "Player",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_register_Player_player",
                table: "Pokemon_register",
                column: "player",
                principalTable: "Player",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Present_Player_owner",
                table: "Present",
                column: "owner",
                principalTable: "Player",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Present_Player_receptor",
                table: "Present",
                column: "receptor",
                principalTable: "Player",
                principalColumn: "user_name");

            migrationBuilder.AddForeignKey(
                name: "FK_Raid_participants_Player_player",
                table: "Raid_participants",
                column: "player",
                principalTable: "Player",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Player_rols_rol",
                table: "User",
                column: "rol",
                principalTable: "Player_rols",
                principalColumn: "rol");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Egg_inventory_Player_player",
                table: "Egg_inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Friendships_Player_friend",
                table: "Friendships");

            migrationBuilder.DropForeignKey(
                name: "FK_Friendships_Player_player",
                table: "Friendships");

            migrationBuilder.DropForeignKey(
                name: "FK_Gym_trophies_Player_player",
                table: "Gym_trophies");

            migrationBuilder.DropForeignKey(
                name: "FK_Object_inventories_Player_player",
                table: "Object_inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Package_offers_bought_Player_user",
                table: "Package_offers_bought");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Level_level",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Team_team",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_User_user_name",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_exchange_Player_ex_owner",
                table: "Pokemon_exchange");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_owned_Player_owner",
                table: "Pokemon_owned");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_register_Player_player",
                table: "Pokemon_register");

            migrationBuilder.DropForeignKey(
                name: "FK_Present_Player_owner",
                table: "Present");

            migrationBuilder.DropForeignKey(
                name: "FK_Present_Player_receptor",
                table: "Present");

            migrationBuilder.DropForeignKey(
                name: "FK_Raid_participants_Player_player",
                table: "Raid_participants");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Player_rols_rol",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Player_level",
                table: "Player");

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ice", "Icicle Spear" });

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

            migrationBuilder.DropColumn(
                name: "caputred_pokemon",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "current_level_experience",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "experience",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "inventory_capacity",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "level",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "pokemon_slots",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "won_battles",
                table: "Player");

            migrationBuilder.RenameColumn(
                name: "rol",
                table: "User",
                newName: "team");

            migrationBuilder.RenameIndex(
                name: "IX_User_rol",
                table: "User",
                newName: "IX_User_team");

            migrationBuilder.RenameColumn(
                name: "team",
                table: "Player",
                newName: "rol");

            migrationBuilder.RenameIndex(
                name: "IX_Player_team",
                table: "Player",
                newName: "IX_Player_rol");

            migrationBuilder.AddColumn<int>(
                name: "caputred_pokemon",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "current_level_experience",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "experience",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "inventory_capacity",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<short>(
                name: "level",
                table: "User",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<int>(
                name: "pokemon_slots",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "won_battles",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "birth_date",
                table: "Player",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Player",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "Player",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Player",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Player",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_User_level",
                table: "User",
                column: "level");

            migrationBuilder.AddForeignKey(
                name: "FK_Egg_inventory_User_player",
                table: "Egg_inventory",
                column: "player",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Friendships_User_friend",
                table: "Friendships",
                column: "friend",
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
                name: "FK_Package_offers_bought_User_user",
                table: "Package_offers_bought",
                column: "user",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Player_rols_rol",
                table: "Player",
                column: "rol",
                principalTable: "Player_rols",
                principalColumn: "rol");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_exchange_User_ex_owner",
                table: "Pokemon_exchange",
                column: "ex_owner",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_owned_User_owner",
                table: "Pokemon_owned",
                column: "owner",
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
                name: "FK_Present_User_owner",
                table: "Present",
                column: "owner",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Present_User_receptor",
                table: "Present",
                column: "receptor",
                principalTable: "User",
                principalColumn: "user_name");

            migrationBuilder.AddForeignKey(
                name: "FK_Raid_participants_User_player",
                table: "Raid_participants",
                column: "player",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Level_level",
                table: "User",
                column: "level",
                principalTable: "Level",
                principalColumn: "level",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Player_user_name",
                table: "User",
                column: "user_name",
                principalTable: "Player",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Team_team",
                table: "User",
                column: "team",
                principalTable: "Team",
                principalColumn: "name");
        }
    }
}
