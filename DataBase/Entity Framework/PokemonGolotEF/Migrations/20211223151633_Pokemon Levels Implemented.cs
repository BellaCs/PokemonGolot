using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class PokemonLevelsImplemented : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "remaining_experience",
                table: "User",
                newName: "experience");

            migrationBuilder.RenameColumn(
                name: "pc_multiplier",
                table: "Pokemon_level",
                newName: "cp_multiplier");

            migrationBuilder.InsertData(
                table: "Pokemon_level",
                columns: new[] { "pokemon_level", "candy_to_upgrade", "cp_multiplier", "stardust_to_upgrade" },
                values: new object[,]
                {
                    { 1f, 1, 0.093999996781349182, 200 },
                    { 1.5f, 1, 0.13513743132352829, 200 },
                    { 2f, 1, 0.16639786958694458, 200 },
                    { 2.5f, 1, 0.19265091419219971, 200 },
                    { 3f, 1, 0.21573247015476227, 400 },
                    { 3.5f, 1, 0.23657265305519104, 400 },
                    { 4f, 1, 0.25572004914283752, 400 },
                    { 4.5f, 1, 0.27353037893772125, 400 },
                    { 5f, 1, 0.29024988412857056, 600 },
                    { 5.5f, 1, 0.30605737864971161, 600 },
                    { 6f, 1, 0.32108759880065918, 600 },
                    { 6.5f, 1, 0.33544503152370453, 600 },
                    { 7f, 1, 0.34921267628669739, 800 },
                    { 7.5f, 1, 0.36245773732662201, 800 },
                    { 8f, 1, 0.37523558735847473, 800 },
                    { 8.5f, 1, 0.38759241108516856, 800 },
                    { 9f, 1, 0.39956727623939514, 1000 },
                    { 9.5f, 1, 0.41119354951725062, 1000 },
                    { 10f, 1, 0.4225000143051148, 1000 },
                    { 10.5f, 1, 0.43292641341041438, 1000 },
                    { 11f, 2, 0.44310754537582397, 1300 },
                    { 11.5f, 2, 0.45305995387198578, 1300 },
                    { 12f, 2, 0.46279838681221003, 1300 },
                    { 12.5f, 2, 0.47233607806265349, 1300 },
                    { 13f, 2, 0.48168495297431951, 1600 },
                    { 13.5f, 2, 0.4908558102324605, 1600 },
                    { 14f, 2, 0.49985843896865839, 1600 },
                    { 14.5f, 2, 0.50870175659656525, 1600 },
                    { 15f, 2, 0.51739394664764404, 1900 },
                    { 15.5f, 2, 0.52594251185655594, 1900 },
                    { 16f, 2, 0.53435432910919189, 1900 },
                    { 16.5f, 2, 0.54263576120138168, 1900 },
                    { 17f, 2, 0.55079269409179688, 2200 },
                    { 17.5f, 2, 0.55883059930056334, 2200 },
                    { 18f, 2, 0.56675451993942261, 2200 },
                    { 18.5f, 2, 0.57456914708018303, 2200 },
                    { 19f, 2, 0.58227890729904175, 2500 },
                    { 19.5f, 2, 0.5898879119195044, 2500 },
                    { 20f, 2, 0.5974000096321106, 2500 },
                    { 20.5f, 2, 0.60482365638017654, 2500 },
                    { 21f, 3, 0.61215728521347046, 3000 },
                    { 21.5f, 3, 0.61940411105751991, 3000 },
                    { 22f, 3, 0.62656712532043457, 3000 },
                    { 22.5f, 3, 0.63364918157458305, 3000 },
                    { 23f, 3, 0.64065295457839966, 3500 },
                    { 23.5f, 3, 0.64758096635341644, 3500 },
                    { 24f, 3, 0.654435634613037, 3500 },
                    { 24.5f, 3, 0.6612192690372467, 3500 },
                    { 25f, 3, 0.66793400049209595, 4000 },
                    { 25.5f, 3, 0.67458190023899078, 4000 },
                    { 26f, 4, 0.68116492033004761, 4000 },
                    { 26.5f, 4, 0.68768490850925446, 4000 },
                    { 27f, 4, 0.69414365291595459, 4500 },
                    { 27.5f, 4, 0.70054289698600769, 4500 },
                    { 28f, 4, 0.70688420534133911, 4500 },
                    { 28.5f, 4, 0.71316909790039062, 4500 },
                    { 29f, 4, 0.719399094581604, 5000 },
                    { 29.5f, 4, 0.72557561099529266, 5000 },
                    { 30f, 4, 0.73170000314712524, 5000 },
                    { 30.5f, 4, 0.73474101722240448, 5000 },
                    { 31f, 6, 0.7377694845199585, 6000 },
                    { 31.5f, 6, 0.74078557640314102, 6000 },
                    { 32f, 6, 0.7437894344329834, 6000 },
                    { 32.5f, 6, 0.74678121507167816, 6000 },
                    { 33f, 8, 0.74976104497909546, 7000 },
                    { 33.5f, 8, 0.75272910296916962, 7000 },
                    { 34f, 8, 0.75568550825119019, 7000 },
                    { 34.5f, 8, 0.75863036513328552, 7000 },
                    { 35f, 10, 0.76156383752822876, 8000 },
                    { 35.5f, 10, 0.76448606699705124, 8000 },
                    { 36f, 10, 0.76739716529846191, 8000 },
                    { 36.5f, 10, 0.77029727399349213, 8000 },
                    { 37f, 12, 0.77318650484085083, 9000 },
                    { 37.5f, 12, 0.77606494724750519, 9000 },
                    { 38f, 12, 0.77893275022506714, 9000 },
                    { 38.5f, 12, 0.78179005999999995, 9000 },
                    { 39f, 15, 0.78463696999999999, 10000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 1f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 1.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 2f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 2.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 3f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 3.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 4f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 4.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 5.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 6f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 6.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 7f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 7.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 8f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 8.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 9f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 9.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 10f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 10.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 11f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 11.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 12f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 12.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 13f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 13.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 14f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 14.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 15f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 15.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 16f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 16.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 17f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 17.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 18f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 18.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 19f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 19.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 20f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 20.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 21f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 21.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 22f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 22.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 23f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 23.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 24f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 24.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 25f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 25.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 26f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 26.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 27f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 27.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 28f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 28.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 29f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 29.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 30f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 30.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 31f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 31.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 32f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 32.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 33f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 33.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 34f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 34.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 35f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 35.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 36f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 36.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 37f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 37.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 38f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 38.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 39f);

            migrationBuilder.RenameColumn(
                name: "experience",
                table: "User",
                newName: "remaining_experience");

            migrationBuilder.RenameColumn(
                name: "cp_multiplier",
                table: "Pokemon_level",
                newName: "pc_multiplier");
        }
    }
}
