using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class userleveldatauploaded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Level",
                columns: new[] { "level", "necessary_xp" },
                values: new object[,]
                {
                    { (short)1, 0 },
                    { (short)2, 1000 },
                    { (short)3, 3000 },
                    { (short)4, 6000 },
                    { (short)5, 10000 },
                    { (short)6, 15000 },
                    { (short)7, 21000 },
                    { (short)8, 28000 },
                    { (short)9, 36000 },
                    { (short)10, 45000 },
                    { (short)11, 55000 },
                    { (short)12, 65000 },
                    { (short)13, 75000 },
                    { (short)14, 85000 },
                    { (short)15, 100000 },
                    { (short)16, 120000 },
                    { (short)17, 140000 },
                    { (short)18, 160000 },
                    { (short)19, 185000 },
                    { (short)20, 210000 },
                    { (short)21, 260000 },
                    { (short)22, 335000 },
                    { (short)23, 435000 },
                    { (short)24, 560000 },
                    { (short)25, 710000 },
                    { (short)26, 900000 },
                    { (short)27, 1100000 },
                    { (short)28, 1350000 },
                    { (short)29, 1650000 },
                    { (short)30, 2000000 },
                    { (short)31, 2500000 },
                    { (short)32, 3000000 },
                    { (short)33, 3750000 },
                    { (short)34, 4750000 },
                    { (short)35, 6000000 },
                    { (short)36, 7500000 },
                    { (short)37, 9500000 },
                    { (short)38, 12000000 },
                    { (short)39, 15000000 },
                    { (short)40, 20000000 },
                    { (short)41, 26000000 },
                    { (short)42, 33500000 },
                    { (short)43, 42500000 },
                    { (short)44, 53500000 },
                    { (short)45, 66500000 },
                    { (short)46, 82000000 },
                    { (short)47, 100000000 },
                    { (short)48, 121000000 },
                    { (short)49, 146000000 },
                    { (short)50, 176000000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)3);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)4);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)5);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)6);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)7);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)8);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)9);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)10);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)11);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)12);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)13);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)14);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)15);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)16);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)17);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)18);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)19);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)20);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)21);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)22);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)23);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)24);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)25);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)26);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)27);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)28);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)29);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)30);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)31);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)32);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)33);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)34);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)35);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)36);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)37);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)38);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)39);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)40);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)41);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)42);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)43);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)44);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)45);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)46);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)47);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)48);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)49);

            migrationBuilder.DeleteData(
                table: "Level",
                keyColumn: "level",
                keyValue: (short)50);
        }
    }
}
