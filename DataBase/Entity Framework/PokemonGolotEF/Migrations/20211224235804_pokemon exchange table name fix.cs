using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class pokemonexchangetablenamefix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokemonExchange_Pokemon_pokemon",
                table: "PokemonExchange");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonExchange_User_ex_owner",
                table: "PokemonExchange");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PokemonExchange",
                table: "PokemonExchange");

            migrationBuilder.RenameTable(
                name: "PokemonExchange",
                newName: "Pokemon_exchange");

            migrationBuilder.RenameIndex(
                name: "IX_PokemonExchange_ex_owner",
                table: "Pokemon_exchange",
                newName: "IX_Pokemon_exchange_ex_owner");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pokemon_exchange",
                table: "Pokemon_exchange",
                columns: new[] { "pokemon", "ex_owner" });

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_exchange_Pokemon_pokemon",
                table: "Pokemon_exchange",
                column: "pokemon",
                principalTable: "Pokemon",
                principalColumn: "num_pokedex",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_exchange_User_ex_owner",
                table: "Pokemon_exchange",
                column: "ex_owner",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_exchange_Pokemon_pokemon",
                table: "Pokemon_exchange");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_exchange_User_ex_owner",
                table: "Pokemon_exchange");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pokemon_exchange",
                table: "Pokemon_exchange");

            migrationBuilder.RenameTable(
                name: "Pokemon_exchange",
                newName: "PokemonExchange");

            migrationBuilder.RenameIndex(
                name: "IX_Pokemon_exchange_ex_owner",
                table: "PokemonExchange",
                newName: "IX_PokemonExchange_ex_owner");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PokemonExchange",
                table: "PokemonExchange",
                columns: new[] { "pokemon", "ex_owner" });

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonExchange_Pokemon_pokemon",
                table: "PokemonExchange",
                column: "pokemon",
                principalTable: "Pokemon",
                principalColumn: "num_pokedex",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonExchange_User_ex_owner",
                table: "PokemonExchange",
                column: "ex_owner",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
