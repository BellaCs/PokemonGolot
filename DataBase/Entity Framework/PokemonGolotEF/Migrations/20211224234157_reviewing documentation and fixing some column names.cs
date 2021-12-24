using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class reviewingdocumentationandfixingsomecolumnnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Object_inventories_Object_objectName",
                table: "Object_inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Package_items_Object_objectName",
                table: "Package_items");

            migrationBuilder.DropForeignKey(
                name: "FK_Present_PokeStop_pokeStop",
                table: "Present");

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
                name: "objectName",
                table: "Object_inventories",
                newName: "object_name");

            migrationBuilder.RenameColumn(
                name: "timesFeeded",
                table: "Gym_defensors",
                newName: "times_feeded");

            migrationBuilder.RenameColumn(
                name: "defenseTime",
                table: "Gym_defensors",
                newName: "defense_time");

            migrationBuilder.RenameColumn(
                name: "remainingKm",
                table: "Egg_inventory",
                newName: "remaining_km");

            migrationBuilder.AlterColumn<double>(
                name: "height",
                table: "Pokemon_register",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Object_inventories_Object_object_name",
                table: "Object_inventories",
                column: "object_name",
                principalTable: "Object",
                principalColumn: "name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Package_items_Object_object_name",
                table: "Package_items",
                column: "object_name",
                principalTable: "Object",
                principalColumn: "name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Present_PokeStop_pokestop",
                table: "Present",
                column: "pokestop",
                principalTable: "PokeStop",
                principalColumn: "location",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Object_inventories_Object_object_name",
                table: "Object_inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Package_items_Object_object_name",
                table: "Package_items");

            migrationBuilder.DropForeignKey(
                name: "FK_Present_PokeStop_pokestop",
                table: "Present");

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
                name: "object_name",
                table: "Object_inventories",
                newName: "objectName");

            migrationBuilder.RenameColumn(
                name: "times_feeded",
                table: "Gym_defensors",
                newName: "timesFeeded");

            migrationBuilder.RenameColumn(
                name: "defense_time",
                table: "Gym_defensors",
                newName: "defenseTime");

            migrationBuilder.RenameColumn(
                name: "remaining_km",
                table: "Egg_inventory",
                newName: "remainingKm");

            migrationBuilder.AlterColumn<int>(
                name: "height",
                table: "Pokemon_register",
                type: "integer",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AddForeignKey(
                name: "FK_Object_inventories_Object_objectName",
                table: "Object_inventories",
                column: "objectName",
                principalTable: "Object",
                principalColumn: "name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Package_items_Object_objectName",
                table: "Package_items",
                column: "objectName",
                principalTable: "Object",
                principalColumn: "name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Present_PokeStop_pokeStop",
                table: "Present",
                column: "pokeStop",
                principalTable: "PokeStop",
                principalColumn: "location",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
