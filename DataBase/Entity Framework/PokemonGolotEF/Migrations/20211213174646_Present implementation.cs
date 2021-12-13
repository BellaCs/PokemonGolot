using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class Presentimplementation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Present",
                columns: table => new
                {
                    presentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    owner = table.Column<string>(type: "character varying(20)", nullable: true),
                    pokeStop = table.Column<string>(type: "text", nullable: true),
                    receptor = table.Column<string>(type: "character varying(20)", nullable: true),
                    opened = table.Column<bool>(type: "boolean", nullable: false),
                    sendDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    recievedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Present", x => x.presentId);
                    table.ForeignKey(
                        name: "FK_Present_PokeStop_pokeStop",
                        column: x => x.pokeStop,
                        principalTable: "PokeStop",
                        principalColumn: "location");
                    table.ForeignKey(
                        name: "FK_Present_User_owner",
                        column: x => x.owner,
                        principalTable: "User",
                        principalColumn: "user_name");
                    table.ForeignKey(
                        name: "FK_Present_User_receptor",
                        column: x => x.receptor,
                        principalTable: "User",
                        principalColumn: "user_name");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Present_owner",
                table: "Present",
                column: "owner");

            migrationBuilder.CreateIndex(
                name: "IX_Present_pokeStop",
                table: "Present",
                column: "pokeStop");

            migrationBuilder.CreateIndex(
                name: "IX_Present_receptor",
                table: "Present",
                column: "receptor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Present");
        }
    }
}
