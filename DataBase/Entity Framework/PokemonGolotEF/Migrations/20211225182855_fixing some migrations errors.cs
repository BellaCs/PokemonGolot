using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class fixingsomemigrationserrors : Migration
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
                name: "FK_Object_inventories_Object_objectName",
                table: "Object_inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Object_inventories_User_user",
                table: "Object_inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Package_items_Object_objectName",
                table: "Package_items");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_register_User_user",
                table: "Pokemon_register");

            migrationBuilder.DropForeignKey(
                name: "FK_Present_PokeStop_pokeStop",
                table: "Present");

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
                name: "pokeStop",
                table: "Present",
                newName: "pokestop");

            migrationBuilder.RenameColumn(
                name: "sendDate",
                table: "Present",
                newName: "send_date");

            migrationBuilder.RenameColumn(
                name: "getDate",
                table: "Present",
                newName: "get_date");

            migrationBuilder.RenameColumn(
                name: "presentId",
                table: "Present",
                newName: "present_id");

            migrationBuilder.RenameIndex(
                name: "IX_Present_pokeStop",
                table: "Present",
                newName: "IX_Present_pokestop");

            migrationBuilder.RenameColumn(
                name: "user",
                table: "Pokemon_register",
                newName: "player");

            migrationBuilder.RenameIndex(
                name: "IX_Pokemon_register_user",
                table: "Pokemon_register",
                newName: "IX_Pokemon_register_player");

            migrationBuilder.RenameColumn(
                name: "pokemonId",
                table: "Pokemon_owned",
                newName: "pokemon_id");

            migrationBuilder.RenameColumn(
                name: "units",
                table: "Package_items",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "objectName",
                table: "Package_items",
                newName: "object_name");

            migrationBuilder.RenameColumn(
                name: "user",
                table: "Object_inventories",
                newName: "player");

            migrationBuilder.RenameColumn(
                name: "objectName",
                table: "Object_inventories",
                newName: "object_name");

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
                name: "timesFeeded",
                table: "Gym_defensors",
                newName: "times_feeded");

            migrationBuilder.RenameColumn(
                name: "defenseTime",
                table: "Gym_defensors",
                newName: "defense_time");

            migrationBuilder.RenameColumn(
                name: "user",
                table: "Friendships",
                newName: "player");

            migrationBuilder.RenameColumn(
                name: "remainingKm",
                table: "Egg_inventory",
                newName: "remaining_km");

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

            migrationBuilder.AlterColumn<double>(
                name: "height",
                table: "Pokemon_register",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<double>(
                name: "Eggkm_egg",
                table: "Pokemon",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "female_gender_rate",
                table: "Pokemon",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "male_gender_rate",
                table: "Pokemon",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "Egg_pokemon_pool",
                columns: table => new
                {
                    egg = table.Column<double>(type: "double precision", nullable: false),
                    pokemon = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egg_pokemon_pool", x => new { x.pokemon, x.egg });
                    table.ForeignKey(
                        name: "FK_Egg_pokemon_pool_Egg_egg",
                        column: x => x.egg,
                        principalTable: "Egg",
                        principalColumn: "km_egg",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Egg_pokemon_pool_Pokemon_pokemon",
                        column: x => x.pokemon,
                        principalTable: "Pokemon",
                        principalColumn: "num_pokedex",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Pokemon_exchange",
                columns: table => new
                {
                    ex_owner = table.Column<string>(type: "character varying(20)", nullable: false),
                    pokemon = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon_exchange", x => new { x.pokemon, x.ex_owner });
                    table.ForeignKey(
                        name: "FK_Pokemon_exchange_Pokemon_pokemon",
                        column: x => x.pokemon,
                        principalTable: "Pokemon",
                        principalColumn: "num_pokedex",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_exchange_User_ex_owner",
                        column: x => x.ex_owner,
                        principalTable: "User",
                        principalColumn: "user_name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Element",
                columns: new[] { "name", "image" },
                values: new object[,]
                {
                    { "bug", null },
                    { "dark", null },
                    { "dragon", null },
                    { "electric", null },
                    { "fairy", null },
                    { "fighting", null },
                    { "fire", null },
                    { "flying", null },
                    { "ghost", null },
                    { "grass", null },
                    { "ground", null },
                    { "ice", null },
                    { "normal", null },
                    { "poison", null },
                    { "psychic", null },
                    { "rock", null },
                    { "shadow", null },
                    { "steel", null },
                    { "unknown", null },
                    { "water", null }
                });

            migrationBuilder.InsertData(
                table: "Pokemon_level",
                columns: new[] { "pokemon_level", "candy_to_upgrade", "cp_multiplier", "stardust_to_upgrade" },
                values: new object[] { 39.5f, 15, 0.78747358000000001, 10000 });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Eggkm_egg",
                table: "Pokemon",
                column: "Eggkm_egg");

            migrationBuilder.CreateIndex(
                name: "IX_Egg_pokemon_pool_egg",
                table: "Egg_pokemon_pool",
                column: "egg");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_exchange_ex_owner",
                table: "Pokemon_exchange",
                column: "ex_owner");

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
                name: "FK_Object_inventories_Object_object_name",
                table: "Object_inventories",
                column: "object_name",
                principalTable: "Object",
                principalColumn: "name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Object_inventories_User_player",
                table: "Object_inventories",
                column: "player",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Package_items_Object_object_name",
                table: "Package_items",
                column: "object_name",
                principalTable: "Object",
                principalColumn: "name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_Egg_Eggkm_egg",
                table: "Pokemon",
                column: "Eggkm_egg",
                principalTable: "Egg",
                principalColumn: "km_egg");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_register_User_player",
                table: "Pokemon_register",
                column: "player",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Present_PokeStop_pokestop",
                table: "Present",
                column: "pokestop",
                principalTable: "PokeStop",
                principalColumn: "location",
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
                name: "FK_Object_inventories_Object_object_name",
                table: "Object_inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Object_inventories_User_player",
                table: "Object_inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Package_items_Object_object_name",
                table: "Package_items");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_Egg_Eggkm_egg",
                table: "Pokemon");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_register_User_player",
                table: "Pokemon_register");

            migrationBuilder.DropForeignKey(
                name: "FK_Present_PokeStop_pokestop",
                table: "Present");

            migrationBuilder.DropForeignKey(
                name: "FK_Raid_participants_User_player",
                table: "Raid_participants");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Player_user_name",
                table: "User");

            migrationBuilder.DropTable(
                name: "Egg_pokemon_pool");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Pokemon_exchange");

            migrationBuilder.DropIndex(
                name: "IX_Pokemon_Eggkm_egg",
                table: "Pokemon");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "bug");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "dark");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "dragon");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "electric");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "fairy");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "fighting");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "fire");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "flying");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "ghost");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "grass");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "ground");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "ice");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "normal");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "poison");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "psychic");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "rock");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "shadow");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "steel");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "unknown");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "water");

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 39.5f);

            migrationBuilder.DropColumn(
                name: "Eggkm_egg",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "female_gender_rate",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "male_gender_rate",
                table: "Pokemon");

            migrationBuilder.RenameColumn(
                name: "player",
                table: "Raid_participants",
                newName: "user");

            migrationBuilder.RenameIndex(
                name: "IX_Raid_participants_player",
                table: "Raid_participants",
                newName: "IX_Raid_participants_user");

            migrationBuilder.RenameColumn(
                name: "pokestop",
                table: "Present",
                newName: "pokeStop");

            migrationBuilder.RenameColumn(
                name: "send_date",
                table: "Present",
                newName: "sendDate");

            migrationBuilder.RenameColumn(
                name: "get_date",
                table: "Present",
                newName: "getDate");

            migrationBuilder.RenameColumn(
                name: "present_id",
                table: "Present",
                newName: "presentId");

            migrationBuilder.RenameIndex(
                name: "IX_Present_pokestop",
                table: "Present",
                newName: "IX_Present_pokeStop");

            migrationBuilder.RenameColumn(
                name: "player",
                table: "Pokemon_register",
                newName: "user");

            migrationBuilder.RenameIndex(
                name: "IX_Pokemon_register_player",
                table: "Pokemon_register",
                newName: "IX_Pokemon_register_user");

            migrationBuilder.RenameColumn(
                name: "pokemon_id",
                table: "Pokemon_owned",
                newName: "pokemonId");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "Package_items",
                newName: "units");

            migrationBuilder.RenameColumn(
                name: "object_name",
                table: "Package_items",
                newName: "objectName");

            migrationBuilder.RenameColumn(
                name: "player",
                table: "Object_inventories",
                newName: "user");

            migrationBuilder.RenameColumn(
                name: "object_name",
                table: "Object_inventories",
                newName: "objectName");

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
                name: "times_feeded",
                table: "Gym_defensors",
                newName: "timesFeeded");

            migrationBuilder.RenameColumn(
                name: "defense_time",
                table: "Gym_defensors",
                newName: "defenseTime");

            migrationBuilder.RenameColumn(
                name: "player",
                table: "Friendships",
                newName: "user");

            migrationBuilder.RenameColumn(
                name: "remaining_km",
                table: "Egg_inventory",
                newName: "remainingKm");

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

            migrationBuilder.AlterColumn<int>(
                name: "height",
                table: "Pokemon_register",
                type: "integer",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

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
                name: "FK_Object_inventories_Object_objectName",
                table: "Object_inventories",
                column: "objectName",
                principalTable: "Object",
                principalColumn: "name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Object_inventories_User_user",
                table: "Object_inventories",
                column: "user",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Package_items_Object_objectName",
                table: "Package_items",
                column: "objectName",
                principalTable: "Object",
                principalColumn: "name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_register_User_user",
                table: "Pokemon_register",
                column: "user",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Present_PokeStop_pokeStop",
                table: "Present",
                column: "pokeStop",
                principalTable: "PokeStop",
                principalColumn: "location",
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
