using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class Raidparticipantsimplementationfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RaidParticipant_Gym_gym",
                table: "RaidParticipant");

            migrationBuilder.DropForeignKey(
                name: "FK_RaidParticipant_Raid_Raidlocation",
                table: "RaidParticipant");

            migrationBuilder.DropForeignKey(
                name: "FK_RaidParticipant_User_user",
                table: "RaidParticipant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RaidParticipant",
                table: "RaidParticipant");

            migrationBuilder.RenameTable(
                name: "RaidParticipant",
                newName: "Raid_participants");

            migrationBuilder.RenameIndex(
                name: "IX_RaidParticipant_user",
                table: "Raid_participants",
                newName: "IX_Raid_participants_user");

            migrationBuilder.RenameIndex(
                name: "IX_RaidParticipant_Raidlocation",
                table: "Raid_participants",
                newName: "IX_Raid_participants_Raidlocation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Raid_participants",
                table: "Raid_participants",
                columns: new[] { "gym", "user" });

            migrationBuilder.AddForeignKey(
                name: "FK_Raid_participants_Gym_gym",
                table: "Raid_participants",
                column: "gym",
                principalTable: "Gym",
                principalColumn: "location",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Raid_participants_Raid_Raidlocation",
                table: "Raid_participants",
                column: "Raidlocation",
                principalTable: "Raid",
                principalColumn: "location");

            migrationBuilder.AddForeignKey(
                name: "FK_Raid_participants_User_user",
                table: "Raid_participants",
                column: "user",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Raid_participants_Gym_gym",
                table: "Raid_participants");

            migrationBuilder.DropForeignKey(
                name: "FK_Raid_participants_Raid_Raidlocation",
                table: "Raid_participants");

            migrationBuilder.DropForeignKey(
                name: "FK_Raid_participants_User_user",
                table: "Raid_participants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Raid_participants",
                table: "Raid_participants");

            migrationBuilder.RenameTable(
                name: "Raid_participants",
                newName: "RaidParticipant");

            migrationBuilder.RenameIndex(
                name: "IX_Raid_participants_user",
                table: "RaidParticipant",
                newName: "IX_RaidParticipant_user");

            migrationBuilder.RenameIndex(
                name: "IX_Raid_participants_Raidlocation",
                table: "RaidParticipant",
                newName: "IX_RaidParticipant_Raidlocation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RaidParticipant",
                table: "RaidParticipant",
                columns: new[] { "gym", "user" });

            migrationBuilder.AddForeignKey(
                name: "FK_RaidParticipant_Gym_gym",
                table: "RaidParticipant",
                column: "gym",
                principalTable: "Gym",
                principalColumn: "location",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaidParticipant_Raid_Raidlocation",
                table: "RaidParticipant",
                column: "Raidlocation",
                principalTable: "Raid",
                principalColumn: "location");

            migrationBuilder.AddForeignKey(
                name: "FK_RaidParticipant_User_user",
                table: "RaidParticipant",
                column: "user",
                principalTable: "User",
                principalColumn: "user_name",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
