using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class uploaddatamoveandchangingmovementpk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movement_Element_element",
                table: "Movement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movement",
                table: "Movement");

            migrationBuilder.DropColumn(
                name: "type",
                table: "Movement");

            migrationBuilder.RenameTable(
                name: "Movement",
                newName: "Movements");

            migrationBuilder.RenameIndex(
                name: "IX_Movement_element",
                table: "Movements",
                newName: "IX_Movements_element");

            migrationBuilder.AddColumn<bool>(
                name: "isCharged",
                table: "Movements",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movements",
                table: "Movements",
                columns: new[] { "name", "element" });

            migrationBuilder.InsertData(
                table: "Movements",
                columns: new[] { "element", "name", "duration", "energy", "isCharged", "power" },
                values: new object[,]
                {
                    { "poison", "Acid", 800, 8.0, false, 9 },
                    { "poison", "Acid Spray", 3000, 50.0, true, 20 },
                    { "flying", "Aerial Ace", 2400, 33.0, true, 55 },
                    { "flying", "Aeroblast", 3400, 100.0, true, 180 },
                    { "flying", "Air Cutter", 2700, 50.0, true, 60 },
                    { "flying", "Air Slash", 1200, 10.0, false, 14 },
                    { "rock", "Ancient Power", 3500, 33.0, true, 70 },
                    { "water", "Aqua Jet", 2600, 33.0, true, 45 },
                    { "water", "Aqua Tail", 1900, 33.0, true, 50 },
                    { "ghost", "Astonish", 1100, 14.0, false, 8 },
                    { "fighting", "Aura Sphere", 1800, 50.0, true, 90 },
                    { "ice", "Aurora Beam", 3550, 50.0, true, 80 },
                    { "ice", "Avalanche", 2700, 50.0, true, 90 },
                    { "dark", "Bite", 500, 4.0, false, 6 },
                    { "fire", "Blast Burn", 3300, 50.0, true, 110 },
                    { "fire", "Blaze Kick", 1200, 33.0, true, 45 },
                    { "ice", "Blizzard", 3100, 100.0, true, 130 },
                    { "normal", "Body Slam", 1900, 33.0, true, 50 },
                    { "ground", "Bone Club", 1600, 33.0, true, 40 },
                    { "flying", "Brave Bird", 2000, 100.0, true, 130 },
                    { "fighting", "Brick Break", 1600, 33.0, true, 40 },
                    { "water", "Brine", 2300, 50.0, true, 60 },
                    { "water", "Bubble", 1200, 14.0, false, 12 },
                    { "water", "Bubble Beam", 1900, 33.0, true, 45 },
                    { "bug", "Bug Bite", 500, 6.0, false, 5 },
                    { "bug", "Bug Buzz", 3700, 50.0, true, 100 },
                    { "ground", "Bulldoze", 3500, 50.0, true, 80 },
                    { "steel", "Bullet Punch", 900, 10.0, false, 9 },
                    { "grass", "Bullet Seed", 1100, 14.0, false, 8 },
                    { "electric", "Charge Beam", 1100, 15.0, false, 8 },
                    { "fairy", "Charm", 1500, 11.0, false, 20 },
                    { "fighting", "Close Combat", 2300, 100.0, true, 100 },
                    { "psychic", "Confusion", 1600, 15.0, false, 20 },
                    { "fighting", "Counter", 900, 8.0, false, 12 },
                    { "water", "Crabhammer", 1900, 50.0, true, 85 },
                    { "fighting", "Cross Chop", 1500, 50.0, true, 50 },
                    { "poison", "Cross Poison", 1500, 33.0, true, 40 },
                    { "dark", "Crunch", 3200, 33.0, true, 70 },
                    { "normal", "Crush Claw", 1900, 0.0, true, 0 },
                    { "normal", "Cut", 500, 5.0, false, 5 },
                    { "dark", "Dark Pulse", 3000, 50.0, true, 80 },
                    { "fairy", "Dazzling Gleam", 3500, 50.0, true, 100 },
                    { "ground", "Dig", 4700, 50.0, true, 100 },
                    { "fairy", "Disarming Voice", 3900, 33.0, true, 70 },
                    { "electric", "Discharge", 2500, 33.0, true, 65 },
                    { "steel", "Doom Desire", 1700, 33.0, true, 70 },
                    { "dragon", "Draco Meteor", 3600, 100.0, true, 150 },
                    { "dragon", "Dragon Breath", 500, 4.0, false, 6 },
                    { "dragon", "Dragon Claw", 1700, 33.0, true, 50 },
                    { "dragon", "Dragon Pulse", 3600, 50.0, true, 90 },
                    { "dragon", "Dragon Tail", 1100, 9.0, false, 15 },
                    { "fighting", "Drain Punch", 2400, 0.0, true, 0 },
                    { "fairy", "Draining Kiss", 2600, 50.0, true, 60 },
                    { "flying", "Drill Peck", 2300, 33.0, true, 65 },
                    { "ground", "Drill Run", 2800, 50.0, true, 80 },
                    { "fighting", "Dynamic Punch", 2700, 50.0, true, 90 },
                    { "ground", "Earth Power", 3600, 50.0, true, 100 },
                    { "ground", "Earthquake", 3600, 100.0, true, 140 },
                    { "fire", "Ember", 1000, 10.0, false, 10 },
                    { "grass", "Energy Ball", 3900, 50.0, true, 90 },
                    { "psychic", "Extrasensory", 1100, 12.0, false, 12 },
                    { "flying", "Feather Dance", 2800, 50.0, true, 35 },
                    { "dark", "Feint Attack", 900, 9.0, false, 10 },
                    { "bug", "Fell Stinger", 2200, 33.0, true, 50 },
                    { "fire", "Fire Blast", 4200, 100.0, true, 140 },
                    { "fire", "Fire Fang", 900, 8.0, false, 12 },
                    { "fire", "Fire Punch", 2200, 33.0, true, 55 },
                    { "fire", "Fire Spin", 1100, 10.0, false, 14 },
                    { "ground", "Fissure", 2800, 0.0, true, 0 },
                    { "fire", "Flame Burst", 2600, 50.0, true, 70 },
                    { "fire", "Flame Charge", 3800, 33.0, true, 70 },
                    { "fire", "Flame Wheel", 2700, 50.0, true, 60 },
                    { "fire", "Flamethrower", 2200, 50.0, true, 70 },
                    { "steel", "Flash Cannon", 2700, 100.0, true, 100 },
                    { "flying", "Fly", 1800, 50.0, true, 80 },
                    { "fighting", "Flying Press", 2300, 50.0, true, 110 },
                    { "fighting", "Focus Blast", 3500, 100.0, true, 140 },
                    { "dark", "Foul Play", 2000, 50.0, true, 70 },
                    { "grass", "Frenzy Plant", 2600, 50.0, true, 100 },
                    { "ice", "Frost Breath", 900, 8.0, false, 10 },
                    { "normal", "Frustration", 2000, 33.0, true, 10 },
                    { "bug", "Fury Cutter", 400, 6.0, false, 3 },
                    { "psychic", "Future Sight", 2700, 100.0, true, 120 },
                    { "grass", "Giga Drain", 3900, 100.0, true, 50 },
                    { "normal", "Giga Impact", 4700, 100.0, true, 200 },
                    { "grass", "Grass Knot", 2600, 50.0, true, 90 },
                    { "poison", "Gunk Shot", 3100, 100.0, true, 130 },
                    { "flying", "Gust", 2000, 20.0, false, 25 },
                    { "steel", "Gyro Ball", 3300, 50.0, true, 80 },
                    { "psychic", "Heart Stamp", 1900, 33.0, true, 40 },
                    { "fire", "Heat Wave", 3000, 100.0, true, 95 },
                    { "steel", "Heavy Slam", 2100, 50.0, true, 70 },
                    { "ghost", "Hex", 1200, 16.0, false, 10 },
                    { "normal", "Hidden Power", 1500, 15.0, false, 15 },
                    { "normal", "Horn Attack", 1850, 33.0, true, 40 },
                    { "normal", "Horn Drill", 1900, 0.0, true, 0 },
                    { "flying", "Hurricane", 2700, 100.0, true, 110 },
                    { "water", "Hydro Cannon", 1900, 50.0, true, 90 },
                    { "water", "Hydro Pump", 3300, 100.0, true, 130 },
                    { "normal", "Hyper Beam", 3800, 100.0, true, 150 },
                    { "normal", "Hyper Fang", 2500, 50.0, true, 80 },
                    { "ice", "Ice Beam", 3300, 50.0, true, 90 },
                    { "ice", "Ice Fang", 1500, 20.0, false, 12 },
                    { "ice", "Ice Punch", 1900, 33.0, true, 50 },
                    { "ice", "Ice Shard", 1200, 12.0, false, 12 },
                    { "ice", "Icy Wind", 3300, 33.0, true, 60 },
                    { "fire", "Incinerate", 2300, 20.0, false, 29 },
                    { "bug", "Infestation", 1100, 14.0, false, 10 },
                    { "steel", "Iron Head", 1900, 50.0, true, 60 },
                    { "steel", "Iron Tail", 1100, 7.0, false, 15 },
                    { "fighting", "Karate Chop", 800, 10.0, false, 8 },
                    { "normal", "Last Resort", 2900, 50.0, true, 90 },
                    { "grass", "Leaf Blade", 2400, 33.0, true, 70 },
                    { "grass", "Leaf Storm", 2500, 100.0, true, 130 },
                    { "grass", "Leaf Tornado", 3100, 33.0, true, 45 },
                    { "bug", "Leech Life", 2500, 0.0, true, 0 },
                    { "ghost", "Lick", 500, 6.0, false, 5 },
                    { "normal", "Lock-On", 300, 6.0, false, 1 },
                    { "fighting", "Low Kick", 600, 6.0, false, 6 },
                    { "fighting", "Low Sweep", 1900, 33.0, true, 40 },
                    { "bug", "Lunge", 2900, 33.0, true, 55 },
                    { "steel", "Magnet Bomb", 2800, 33.0, true, 70 },
                    { "grass", "Mega Drain", 2600, 50.0, true, 25 },
                    { "bug", "Megahorn", 2200, 100.0, true, 110 },
                    { "steel", "Metal Claw", 700, 7.0, false, 8 },
                    { "steel", "Meteor Mash", 2600, 50.0, true, 100 },
                    { "psychic", "Mirror Coat", 2600, 50.0, true, 60 },
                    { "steel", "Mirror Shot", 2400, 33.0, true, 50 },
                    { "fairy", "Moonblast", 3900, 100.0, true, 130 },
                    { "ground", "Mud Bomb", 2300, 33.0, true, 55 },
                    { "ground", "Mud Shot", 600, 7.0, false, 5 },
                    { "ground", "Mud-Slap", 1400, 12.0, false, 18 },
                    { "water", "Muddy Water", 2200, 33.0, true, 50 },
                    { "ghost", "Night Shade", 2600, 50.0, true, 60 },
                    { "dark", "Night Slash", 2200, 33.0, true, 50 },
                    { "water", "Octazooka", 2300, 50.0, true, 50 },
                    { "ghost", "Ominous Wind", 2300, 33.0, true, 50 },
                    { "water", "Origin Pulse", 1700, 100.0, true, 130 },
                    { "dragon", "Outrage", 3900, 50.0, true, 110 },
                    { "fire", "Overheat", 4000, 100.0, true, 160 },
                    { "electric", "Parabolic Charge", 2800, 50.0, true, 25 },
                    { "dark", "Payback", 2200, 100.0, true, 100 },
                    { "flying", "Peck", 1000, 10.0, false, 10 },
                    { "grass", "Petal Blizzard", 2600, 100.0, true, 110 },
                    { "fairy", "Play Rough", 2900, 50.0, true, 90 },
                    { "poison", "Poison Fang", 1700, 33.0, true, 35 },
                    { "poison", "Poison Jab", 800, 7.0, false, 10 },
                    { "poison", "Poison Sting", 600, 7.0, false, 5 },
                    { "normal", "Pound", 600, 6.0, false, 7 },
                    { "ice", "Powder Snow", 1000, 15.0, false, 6 },
                    { "rock", "Power Gem", 2900, 50.0, true, 80 },
                    { "grass", "Power Whip", 2600, 50.0, true, 90 },
                    { "fighting", "Power-Up Punch", 2000, 33.0, true, 50 },
                    { "ground", "Precipice Blades", 1700, 100.0, true, 130 },
                    { "normal", "Present", 1300, 20.0, false, 5 },
                    { "psychic", "Psybeam", 3200, 50.0, true, 70 },
                    { "psychic", "Psychic", 2800, 50.0, true, 90 },
                    { "psychic", "Psychic Fangs", 1200, 33.0, true, 30 },
                    { "psychic", "Psycho Boost", 4000, 50.0, true, 70 },
                    { "psychic", "Psycho Cut", 600, 8.0, false, 5 },
                    { "psychic", "Psyshock", 2700, 33.0, true, 65 },
                    { "psychic", "Psystrike", 2300, 50.0, true, 90 },
                    { "normal", "Quick Attack", 800, 10.0, false, 8 },
                    { "grass", "Razor Leaf", 1000, 7.0, false, 13 },
                    { "water", "Razor Shell", 1300, 33.0, true, 45 },
                    { "normal", "Rest", 1900, 33.0, true, 50 },
                    { "normal", "Return", 700, 33.0, true, 35 },
                    { "rock", "Rock Blast", 2100, 33.0, true, 50 },
                    { "rock", "Rock Slide", 2700, 50.0, true, 80 },
                    { "fighting", "Rock Smash", 1300, 10.0, false, 15 },
                    { "rock", "Rock Throw", 900, 7.0, false, 12 },
                    { "rock", "Rock Tomb", 3200, 50.0, true, 70 },
                    { "rock", "Rock Wrecker", 3600, 50.0, true, 110 },
                    { "fighting", "Sacred Sword", 1200, 33.0, true, 55 },
                    { "ground", "Sand Tomb", 4000, 33.0, true, 60 },
                    { "water", "Scald", 3700, 50.0, true, 80 },
                    { "normal", "Scratch", 500, 4.0, false, 6 },
                    { "grass", "Seed Bomb", 2100, 33.0, true, 55 },
                    { "ghost", "Shadow Ball", 3000, 50.0, true, 100 },
                    { "ghost", "Shadow Bone", 2800, 50.0, true, 80 },
                    { "ghost", "Shadow Claw", 700, 6.0, false, 9 },
                    { "ghost", "Shadow Punch", 1700, 33.0, true, 40 },
                    { "ghost", "Shadow Sneak", 2900, 33.0, true, 50 },
                    { "bug", "Signal Beam", 2900, 50.0, true, 75 },
                    { "bug", "Silver Wind", 3700, 33.0, true, 70 },
                    { "normal", "Skull Bash", 3100, 100.0, true, 130 },
                    { "flying", "Sky Attack", 2000, 50.0, true, 80 },
                    { "poison", "Sludge", 2100, 33.0, true, 50 },
                    { "poison", "Sludge Bomb", 2300, 50.0, true, 80 },
                    { "poison", "Sludge Wave", 3200, 100.0, true, 110 },
                    { "rock", "Smack Down", 1200, 8.0, false, 16 },
                    { "dark", "Snarl", 1100, 14.0, false, 12 },
                    { "grass", "Solar Beam", 4900, 100.0, true, 180 },
                    { "electric", "Spark", 700, 9.0, false, 6 },
                    { "water", "Splash", 1730, 20.0, false, 0 },
                    { "steel", "Steel Wing", 800, 6.0, false, 11 },
                    { "normal", "Stomp", 1700, 50.0, true, 55 },
                    { "rock", "Stone Edge", 2300, 100.0, true, 100 },
                    { "normal", "Struggle", 2200, 0.0, true, 35 },
                    { "bug", "Struggle Bug", 1500, 15.0, false, 15 },
                    { "fighting", "Submission", 2200, 50.0, true, 60 },
                    { "dark", "Sucker Punch", 700, 8.0, false, 7 },
                    { "fighting", "Superpower", 3000, 50.0, true, 85 },
                    { "water", "Surf", 1700, 50.0, true, 65 },
                    { "normal", "Swift", 2800, 50.0, true, 60 },
                    { "psychic", "Synchronoise", 2600, 50.0, true, 80 },
                    { "normal", "Tackle", 500, 5.0, false, 5 },
                    { "normal", "Take Down", 1200, 10.0, false, 8 },
                    { "normal", "Techno Blast", 2000, 100.0, true, 120 },
                    { "electric", "Thunder", 2400, 100.0, true, 100 },
                    { "electric", "Thunder Fang", 1200, 16.0, false, 12 },
                    { "electric", "Thunder Punch", 1800, 33.0, true, 45 },
                    { "electric", "Thunder Shock", 600, 8.0, false, 5 },
                    { "electric", "Thunderbolt", 2500, 50.0, true, 80 },
                    { "normal", "Transform", 2230, 0.0, false, 0 },
                    { "normal", "Tri Attack", 2500, 50.0, true, 75 },
                    { "dragon", "Twister", 2800, 33.0, true, 45 },
                    { "fire", "V-create", 2800, 33.0, true, 95 },
                    { "grass", "Vine Whip", 600, 6.0, false, 7 },
                    { "normal", "Vise Grip", 1900, 33.0, true, 35 },
                    { "electric", "Volt Switch", 1600, 21.0, false, 14 },
                    { "water", "Water Gun", 500, 5.0, false, 5 },
                    { "water", "Water Pulse", 3200, 50.0, true, 70 },
                    { "water", "Waterfall", 1200, 8.0, false, 16 },
                    { "fire", "Weather Ball", 1600, 33.0, true, 55 },
                    { "electric", "Wild Charge", 2600, 50.0, true, 90 },
                    { "flying", "Wing Attack", 800, 9.0, false, 8 },
                    { "normal", "Wrap", 2900, 33.0, true, 60 },
                    { "bug", "X-Scissor", 1600, 33.0, true, 45 },
                    { "normal", "Yawn", 1700, 15.0, false, 0 },
                    { "electric", "Zap Cannon", 3700, 100.0, true, 140 },
                    { "psychic", "Zen Headbutt", 1100, 10.0, false, 12 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Movements_Element_element",
                table: "Movements",
                column: "element",
                principalTable: "Element",
                principalColumn: "name",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movements_Element_element",
                table: "Movements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movements",
                table: "Movements");

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "poison", "Acid" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "poison", "Acid Spray" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "flying", "Aerial Ace" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "flying", "Aeroblast" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "flying", "Air Cutter" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "flying", "Air Slash" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "rock", "Ancient Power" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "water", "Aqua Jet" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "water", "Aqua Tail" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ghost", "Astonish" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fighting", "Aura Sphere" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ice", "Aurora Beam" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ice", "Avalanche" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "dark", "Bite" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fire", "Blast Burn" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fire", "Blaze Kick" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ice", "Blizzard" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Body Slam" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ground", "Bone Club" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "flying", "Brave Bird" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fighting", "Brick Break" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "water", "Brine" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "water", "Bubble" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "water", "Bubble Beam" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "bug", "Bug Bite" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "bug", "Bug Buzz" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ground", "Bulldoze" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "steel", "Bullet Punch" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "grass", "Bullet Seed" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "electric", "Charge Beam" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fairy", "Charm" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fighting", "Close Combat" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "psychic", "Confusion" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fighting", "Counter" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "water", "Crabhammer" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fighting", "Cross Chop" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "poison", "Cross Poison" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "dark", "Crunch" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Crush Claw" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Cut" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "dark", "Dark Pulse" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fairy", "Dazzling Gleam" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ground", "Dig" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fairy", "Disarming Voice" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "electric", "Discharge" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "steel", "Doom Desire" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "dragon", "Draco Meteor" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "dragon", "Dragon Breath" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "dragon", "Dragon Claw" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "dragon", "Dragon Pulse" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "dragon", "Dragon Tail" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fighting", "Drain Punch" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fairy", "Draining Kiss" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "flying", "Drill Peck" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ground", "Drill Run" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fighting", "Dynamic Punch" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ground", "Earth Power" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ground", "Earthquake" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fire", "Ember" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "grass", "Energy Ball" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "psychic", "Extrasensory" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "flying", "Feather Dance" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "dark", "Feint Attack" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "bug", "Fell Stinger" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fire", "Fire Blast" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fire", "Fire Fang" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fire", "Fire Punch" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fire", "Fire Spin" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ground", "Fissure" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fire", "Flame Burst" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fire", "Flame Charge" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fire", "Flame Wheel" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fire", "Flamethrower" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "steel", "Flash Cannon" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "flying", "Fly" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fighting", "Flying Press" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fighting", "Focus Blast" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "dark", "Foul Play" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "grass", "Frenzy Plant" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ice", "Frost Breath" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Frustration" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "bug", "Fury Cutter" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "psychic", "Future Sight" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "grass", "Giga Drain" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Giga Impact" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "grass", "Grass Knot" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "poison", "Gunk Shot" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "flying", "Gust" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "steel", "Gyro Ball" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "psychic", "Heart Stamp" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fire", "Heat Wave" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "steel", "Heavy Slam" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ghost", "Hex" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Hidden Power" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Horn Attack" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Horn Drill" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "flying", "Hurricane" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "water", "Hydro Cannon" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "water", "Hydro Pump" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Hyper Beam" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Hyper Fang" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ice", "Ice Beam" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ice", "Ice Fang" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ice", "Ice Punch" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ice", "Ice Shard" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ice", "Icy Wind" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fire", "Incinerate" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "bug", "Infestation" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "steel", "Iron Head" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "steel", "Iron Tail" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fighting", "Karate Chop" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Last Resort" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "grass", "Leaf Blade" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "grass", "Leaf Storm" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "grass", "Leaf Tornado" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "bug", "Leech Life" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ghost", "Lick" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Lock-On" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fighting", "Low Kick" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fighting", "Low Sweep" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "bug", "Lunge" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "steel", "Magnet Bomb" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "grass", "Mega Drain" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "bug", "Megahorn" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "steel", "Metal Claw" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "steel", "Meteor Mash" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "psychic", "Mirror Coat" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "steel", "Mirror Shot" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fairy", "Moonblast" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ground", "Mud Bomb" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ground", "Mud Shot" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ground", "Mud-Slap" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "water", "Muddy Water" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ghost", "Night Shade" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "dark", "Night Slash" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "water", "Octazooka" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ghost", "Ominous Wind" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "water", "Origin Pulse" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "dragon", "Outrage" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fire", "Overheat" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "electric", "Parabolic Charge" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "dark", "Payback" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "flying", "Peck" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "grass", "Petal Blizzard" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fairy", "Play Rough" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "poison", "Poison Fang" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "poison", "Poison Jab" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "poison", "Poison Sting" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Pound" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ice", "Powder Snow" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "rock", "Power Gem" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "grass", "Power Whip" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fighting", "Power-Up Punch" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ground", "Precipice Blades" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Present" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "psychic", "Psybeam" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "psychic", "Psychic" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "psychic", "Psychic Fangs" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "psychic", "Psycho Boost" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "psychic", "Psycho Cut" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "psychic", "Psyshock" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "psychic", "Psystrike" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Quick Attack" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "grass", "Razor Leaf" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "water", "Razor Shell" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Rest" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Return" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "rock", "Rock Blast" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "rock", "Rock Slide" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fighting", "Rock Smash" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "rock", "Rock Throw" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "rock", "Rock Tomb" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "rock", "Rock Wrecker" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fighting", "Sacred Sword" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ground", "Sand Tomb" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "water", "Scald" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Scratch" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "grass", "Seed Bomb" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ghost", "Shadow Ball" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ghost", "Shadow Bone" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ghost", "Shadow Claw" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ghost", "Shadow Punch" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "ghost", "Shadow Sneak" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "bug", "Signal Beam" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "bug", "Silver Wind" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Skull Bash" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "flying", "Sky Attack" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "poison", "Sludge" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "poison", "Sludge Bomb" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "poison", "Sludge Wave" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "rock", "Smack Down" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "dark", "Snarl" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "grass", "Solar Beam" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "electric", "Spark" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "water", "Splash" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "steel", "Steel Wing" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Stomp" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "rock", "Stone Edge" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Struggle" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "bug", "Struggle Bug" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fighting", "Submission" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "dark", "Sucker Punch" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fighting", "Superpower" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "water", "Surf" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Swift" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "psychic", "Synchronoise" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Tackle" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Take Down" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Techno Blast" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "electric", "Thunder" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "electric", "Thunder Fang" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "electric", "Thunder Punch" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "electric", "Thunder Shock" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "electric", "Thunderbolt" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Transform" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Tri Attack" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "dragon", "Twister" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fire", "V-create" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "grass", "Vine Whip" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Vise Grip" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "electric", "Volt Switch" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "water", "Water Gun" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "water", "Water Pulse" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "water", "Waterfall" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "fire", "Weather Ball" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "electric", "Wild Charge" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "flying", "Wing Attack" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Wrap" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "bug", "X-Scissor" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "normal", "Yawn" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "electric", "Zap Cannon" });

            migrationBuilder.DeleteData(
                table: "Movements",
                keyColumns: new[] { "element", "name" },
                keyValues: new object[] { "psychic", "Zen Headbutt" });

            migrationBuilder.DropColumn(
                name: "isCharged",
                table: "Movements");

            migrationBuilder.RenameTable(
                name: "Movements",
                newName: "Movement");

            migrationBuilder.RenameIndex(
                name: "IX_Movements_element",
                table: "Movement",
                newName: "IX_Movement_element");

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "Movement",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movement",
                table: "Movement",
                column: "name");

            migrationBuilder.AddForeignKey(
                name: "FK_Movement_Element_element",
                table: "Movement",
                column: "element",
                principalTable: "Element",
                principalColumn: "name",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
