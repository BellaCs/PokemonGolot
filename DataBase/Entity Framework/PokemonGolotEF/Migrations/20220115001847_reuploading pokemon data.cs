using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class reuploadingpokemondata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 809);

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 54,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 148.0, 82.0, "When Mankey starts shaking and its nasal breathing turns rough, it's a sure sign that it is becoming angry. However, because it goes into a towering rage almost instantly, it is impossible for anyone to flee its wrath.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/56.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/56.png", "Mankey", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 55,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 207.0, 138.0, "When Primeape becomes furious, its blood circulation is boosted. In turn, its muscles are made even stronger. However, it also becomes much less intelligent at the same time.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/57.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/57.png", "Primeape", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 56,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 136.0, 93.0, "Growlithe has a superb sense of smell. Once it smells anything, this Pokémon won't forget the scent, no matter what. It uses its advanced olfactory sense to determine the emotions of other living things.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/58.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/58.png", 0.75f, "Growlithe", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 57,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 227.0, 166.0, "Arcanine is known for its high speed. It is said to be capable of running over 6,200 miles in a single day and night. The fire that blazes wildly within this Pokémon's body is its source of power.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/59.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/59.png", 0.75f, "Arcanine", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 58,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 101.0, 82.0, "Poliwag has a very thin skin. It is possible to see the Pokémon's spiral innards right through the skin. Despite its thinness, however, the skin is also very flexible. Even sharp fangs bounce right off it.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/60.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/60.png", 0.5f, "Poliwag", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 59,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 130.0, 123.0, "The surface of Poliwhirl's body is always wet and slick with a slimy fluid. Because of this slippery covering, it can easily slip and slide out of the clutches of any enemy in battle.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/61.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/61.png", 0.5f, "Poliwhirl", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 60,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 182.0, 184.0, "Poliwrath's highly developed, brawny muscles never grow fatigued, however much it exercises. It is so tirelessly strong, this Pokémon can swim back and forth across the ocean without effort.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/62.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/62.png", "Poliwrath", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 61,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 195.0, 82.0, "Abra sleeps for 18 hours a day. However, it can sense the presence of foes even while it is sleeping. In such a situation, this Pokémon immediately teleports to safety.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/63.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/63.png", 0.75f, "Abra", 93.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 62,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 232.0, 117.0, "Kadabra emits a peculiar alpha wave if it develops a headache. Only those people with a particularly strong psyche can hope to become a Trainer of this Pokémon.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/64.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/64.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/64.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/64.png", 0.75f, "Kadabra", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 63,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 271.0, 167.0, "Alakazam's brain continually grows, making its head far too heavy to support with its neck. This Pokémon holds its head up using its psychokinetic power instead.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/65.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/65.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/65.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/65.png", "Alakazam", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 64,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 137.0, 82.0, "Machop's muscles are special—they never get sore no matter how much they are used in exercise. This Pokémon has sufficient power to hurl a hundred adult humans.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/66.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/66.png", null, "Machop", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 65,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 177.0, 125.0, "Machoke's thoroughly toned muscles possess the hardness of steel. This Pokémon has so much strength, it can easily hold aloft a sumo wrestler on just one finger.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/67.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/67.png", null, "Machoke", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 66,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 234.0, 159.0, "Machamp has the power to hurl anything aside. However, trying to do any work requiring care and dexterity causes its arms to get tangled. This Pokémon tends to leap into action before it thinks.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/68.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/68.png", "Machamp", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 67,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 139.0, 61.0, "Bellsprout's thin and flexible body lets it bend and sway to avoid any attack, however strong it may be. From its mouth, this Pokémon spits a corrosive fluid that melts even iron.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/69.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/69.png", 0.5f, "Bellsprout", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 68,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 172.0, 92.0, "Weepinbell has a large hook on its rear end. At night, the Pokémon hooks on to a tree branch and goes to sleep. If it moves around in its sleep, it may wake up to find itself on the ground.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/70.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/70.png", 0.5f, "Weepinbell", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 69,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 207.0, 135.0, "Victreebel has a long vine that extends from its head. This vine is waved and flicked about as if it were an animal to attract prey. When an unsuspecting prey draws near, this Pokémon swallows it whole.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/71.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/71.png", "Victreebel", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 70,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 97.0, 149.0, "Tentacool's body is largely composed of water. If it is removed from the sea, it dries up like parchment. If this Pokémon happens to become dehydrated, put it back into the sea.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/72.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/72.png", "Tentacool", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 71,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name" },
                values: new object[] { 166.0, 209.0, "Tentacruel has large red orbs on its head. The orbs glow before lashing the vicinity with a harsh ultrasonic blast. This Pokémon's outburst creates rough waves around it.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/73.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/73.png", "Tentacruel" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 72,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name" },
                values: new object[] { 132.0, 132.0, "The longer a Geodude lives, the more its edges are chipped and worn away, making it more rounded in appearance. However, this Pokémon's heart will remain hard, craggy, and rough always.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/74.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/74.png", "Geodude" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 73,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 164.0, 164.0, "Graveler grows by feeding on rocks. Apparently, it prefers to eat rocks that are covered in moss. This Pokémon eats its way through a ton of rocks on a daily basis.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/75.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/75.png", "Graveler", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 74,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 211.0, 198.0, "Golem live up on mountains. If there is a large earthquake, these Pokémon will come rolling down off the mountains en masse to the foothills below.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/76.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/76.png", "Golem", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 75,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 170.0, 127.0, "Ponyta is very weak at birth. It can barely stand up. This Pokémon becomes stronger by stumbling and falling to keep up with its parent.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/77.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/77.png", "Ponyta", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 76,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 207.0, 162.0, "Rapidash usually can be seen casually cantering in the fields and plains. However, when this Pokémon turns serious, its fiery manes flare and blaze as it gallops its way up to 150 mph.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/78.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/78.png", "Rapidash", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 77,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 109.0, 98.0, "Slowpoke uses its tail to catch prey by dipping it in water at the side of a river. However, this Pokémon often forgets what it's doing and often spends entire days just loafing at water's edge.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/79.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/79.png", "Slowpoke", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 78,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 177.0, 180.0, "Slowbro's tail has a Shellder firmly attached with a bite. As a result, the tail can't be used for fishing anymore. This causes Slowbro to grudgingly swim and catch prey instead.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/80.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/80.png", "Slowbro", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 79,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 165.0, 121.0, "Magnemite attaches itself to power lines to feed on electricity. If your house has a power outage, check your circuit breakers. You may find a large number of this Pokémon clinging to the breaker box.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/81.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/81.png", 0f, "Magnemite", 93.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 80,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 223.0, 169.0, "Magneton emits a powerful magnetic force that is fatal to mechanical devices. As a result, large cities sound sirens to warn citizens of large-scale outbreaks of this Pokémon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/82.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/82.png", 0f, "Magneton", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 81,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 158.0, 83.0, "Doduo's two heads never sleep at the same time. Its two heads take turns sleeping, so one head can always keep watch for enemies while the other one sleeps.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/84.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/84.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/84.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/84.png", 0.5f, "Doduo", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 82,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 218.0, 140.0, "Watch out if Dodrio's three heads are looking in three separate directions. It's a sure sign that it is on its guard. Don't go near this Pokémon if it's being wary—it may decide to peck you.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/85.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/85.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/85.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/85.png", 0.5f, "Dodrio", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 84,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 139.0, 177.0, "Dewgong loves to snooze on bitterly cold ice. The sight of this Pokémon sleeping on a glacier was mistakenly thought to be a mermaid by a mariner long ago.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/87.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/87.png", null, "Dewgong", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 85,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 135.0, 90.0, "Grimer's sludgy and rubbery body can be forced through any opening, however small it may be. This Pokémon enters sewer pipes to drink filthy wastewater.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/88.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/88.png", null, "Grimer", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 86,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 190.0, 172.0, "From Muk's body seeps a foul fluid that gives off a nose-bendingly horrible stench. Just one drop of this Pokémon's body fluid can turn a pool stagnant and rancid.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/89.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/89.png", "Muk", 233.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 87,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 116.0, 134.0, "At night, this Pokémon uses its broad tongue to burrow a hole in the seafloor sand and then sleep in it. While it is sleeping, Shellder closes its shell, but leaves its tongue hanging out.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/90.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/90.png", "Shellder", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 88,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 186.0, 256.0, "Cloyster is capable of swimming in the sea. It does so by swallowing water, then jetting it out toward the rear. This Pokémon shoots spikes from its shell using the same system.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/91.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/91.png", "Cloyster", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 89,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 186.0, 67.0, "Gastly is largely composed of gaseous matter. When exposed to a strong wind, the gaseous body quickly dwindles away. Groups of this Pokémon cluster under the eaves of houses to escape the ravages of wind.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/92.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/92.png", "Gastly", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 90,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 223.0, 107.0, "Haunter is a dangerous Pokémon. If one beckons you while floating in darkness, you must never approach it. This Pokémon will try to lick you with its tongue and steal your life away.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/93.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/93.png", "Haunter", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 91,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 261.0, 149.0, "Sometimes, on a dark night, your shadow thrown by a streetlight will suddenly and startlingly overtake you. It is actually a Gengar running past you, pretending to be your shadow.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/94.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/94.png", "Gengar", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 92,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 85.0, 232.0, "Onix has a magnet in its brain. It acts as a compass so that this Pokémon does not lose direction while it is tunneling. As it grows older, its body becomes increasingly rounder and smoother.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/95.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/95.png", "Onix", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 93,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 89.0, 136.0, "If your nose becomes itchy while you are sleeping, it's a sure sign that one of these Pokémon is standing above your pillow and trying to eat your dream through your nostrils.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/96.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/96.png", "Drowzee", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 94,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 144.0, 193.0, "Hypno holds a pendulum in its hand. The arcing movement and glitter of the pendulum lull the foe into a deep state of hypnosis. While this Pokémon searches for prey, it polishes the pendulum.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/97.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/97.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/97.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/97.png", "Hypno", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 95,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 181.0, 124.0, "Krabby live on beaches, burrowed inside holes dug into the sand. On sandy beaches with little in the way of food, these Pokémon can be seen squabbling with each other over territory.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/98.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/98.png", "Krabby", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 96,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 240.0, 181.0, "Kingler has an enormous, oversized claw. It waves this huge claw in the air to communicate with others. However, because the claw is so heavy, the Pokémon quickly tires.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/99.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/99.png", "Kingler", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 97,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 109.0, 111.0, "Voltorb was first sighted at a company that manufactures Poké Balls. The link between that sighting and the fact that this Pokémon looks very similar to a Poké Ball remains a mystery.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/100.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/100.png", null, 0f, "Voltorb", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 98,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 173.0, 173.0, "Electrode eats electricity in the atmosphere. On days when lightning strikes, you can see this Pokémon exploding all over the place from eating too much electricity.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/101.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/101.png", 0f, "Electrode", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 99,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 107.0, 125.0, "This Pokémon consists of six eggs that form a closely knit cluster. The six eggs attract each other and spin around. When cracks increasingly appear on the eggs, Exeggcute is close to evolution.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/102.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/102.png", "Exeggcute", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 100,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 233.0, 149.0, "Exeggutor originally came from the tropics. Its heads steadily grow larger from exposure to strong sunlight. It is said that when the heads fall off, they group together to form Exeggcute.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/103.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/103.png", 0.5f, "Exeggutor", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 101,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 90.0, 144.0, "Cubone pines for the mother it will never see again. Seeing a likeness of its mother in the full moon, it cries. The stains on the skull the Pokémon wears are made by the tears it sheds.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/104.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/104.png", 0.5f, "Cubone", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 102,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name" },
                values: new object[] { 144.0, 186.0, "Marowak is the evolved form of a Cubone that has overcome its sadness at the loss of its mother and grown tough. This Pokémon's tempered and hardened spirit is not easily broken.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/105.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/105.png", "Marowak" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 103,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 224.0, 181.0, "Hitmonlee's legs freely contract and stretch. Using these springlike legs, it bowls over foes with devastating kicks. After battle, it rubs down its legs and loosens the muscles to overcome fatigue.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/106.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/106.png", 1f, "Hitmonlee", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 104,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name" },
                values: new object[] { 193.0, 197.0, "Hitmonchan is said to possess the spirit of a boxer who had been working toward a world championship. This Pokémon has an indomitable spirit and will never give up in the face of adversity.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/107.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/107.png", 1f, "Hitmonchan" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 105,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 108.0, 137.0, "Whenever Lickitung comes across something new, it will unfailingly give it a lick. It does so because it memorizes things by texture and by taste. It is somewhat put off by sour things.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/108.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/108.png", "Lickitung", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 106,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 119.0, 141.0, "If Koffing becomes agitated, it raises the toxicity of its internal gases and jets them out from all over its body. This Pokémon may also overinflate its round body, then explode.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/109.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/109.png", 0.5f, "Koffing", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 107,
                columns: new[] { "attack", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 174.0, "Weezing loves the gases given off by rotted kitchen garbage. This Pokémon will find a dirty, unkempt house and make it its home. At night, when the people in the house are asleep, it will go through the trash.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/110.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/110.png", 0.5f, "Weezing", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 108,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 140.0, 127.0, "Rhyhorn runs in a straight line, smashing everything in its path. It is not bothered even if it rushes headlong into a block of steel. This Pokémon may feel some pain from the collision the next day, however.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/111.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/111.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/111.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/111.png", "Rhyhorn", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 109,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 222.0, 171.0, "Rhydon's horn can crush even uncut diamonds. One sweeping blow of its tail can topple a building. This Pokémon's hide is extremely tough. Even direct cannon hits don't leave a scratch.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/112.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/112.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/112.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/112.png", "Rhydon", 233.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 110,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 60.0, 128.0, "Chansey lays nutritionally excellent eggs on an everyday basis. The eggs are so delicious, they are easily and eagerly devoured by even those people who have lost their appetite.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/113.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/113.png", 0f, "Chansey", 487.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 111,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 183.0, 169.0, "Tangela's vines snap off easily if they are grabbed. This happens without pain, allowing it to make a quick getaway. The lost vines are replaced by newly grown vines the very next day.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/114.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/114.png", null, "Tangela", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 112,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name" },
                values: new object[] { 181.0, 165.0, "If you come across a young Kangaskhan playing by itself, you must never disturb it or attempt to catch it. The baby Pokémon's parent is sure to be in the area, and it will become violently enraged at you.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/115.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/115.png", null, 0f, "Kangaskhan" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 113,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 129.0, 103.0, "Horsea eats small insects and moss off of rocks. If the ocean current turns fast, this Pokémon anchors itself by wrapping its tail around rocks or coral to prevent being washed away.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/116.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/116.png", 0.5f, "Horsea", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 114,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 187.0, 156.0, "Seadra sleeps after wriggling itself between the branches of coral. Those trying to harvest coral are occasionally stung by this Pokémon's poison barbs if they fail to notice it.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/117.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/117.png", "Seadra", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 115,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 123.0, 110.0, "Goldeen is a very beautiful Pokémon with fins that billow elegantly in water. However, don't let your guard down around this Pokémon—it could ram you powerfully with its horn.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/118.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/118.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/118.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/118.png", 0.5f, "Goldeen", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 116,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 175.0, 147.0, "In the autumn, Seaking males can be seen performing courtship dances in riverbeds to woo females. During this season, this Pokémon's body coloration is at its most beautiful.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/119.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/119.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/119.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/119.png", "Seaking", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 117,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 137.0, 112.0, "Staryu's center section has an organ called the core that shines bright red. If you go to a beach toward the end of summer, the glowing cores of these Pokémon look like the stars in the sky.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/120.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/120.png", 0f, "Staryu", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 118,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 210.0, 184.0, "Starmie's center section—the core—glows brightly in seven colors. Because of its luminous nature, this Pokémon has been given the nickname “the gem of the sea.”", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/121.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/121.png", null, 0f, "Starmie", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 119,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 218.0, 170.0, "Scyther is blindingly fast. Its blazing speed enhances the effectiveness of the twin scythes on its forearms. This Pokémon's scythes are so effective, they can slice through thick logs in one wicked stroke.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/123.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/123.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/123.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/123.png", "Scyther", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 120,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 223.0, 151.0, "Jynx walks rhythmically, swaying and shaking its hips as if it were dancing. Its motions are so bouncingly alluring, people seeing it are compelled to shake their hips without giving any thought to what they are doing.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/124.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/124.png", "Jynx", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 121,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 198.0, 158.0, "When a storm arrives, gangs of this Pokémon compete with each other to scale heights that are likely to be stricken by lightning bolts. Some towns use Electabuzz in place of lightning rods.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/125.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/125.png", 0.75f, "Electabuzz", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 123,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 238.0, 182.0, "Pinsir is astoundingly strong. It can grip a foe weighing twice its weight in its horns and easily lift it. This Pokémon's movements turn sluggish in cold places.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/127.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/127.png", null, "Pinsir", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 124,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 198.0, 183.0, "This Pokémon is not satisfied unless it is rampaging at all times. If there is no opponent for Tauros to battle, it will charge at thick trees and knock them down to calm itself.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/128.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/128.png", 1f, "Tauros", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 125,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 29.0, 85.0, "Magikarp is a pathetic excuse for a Pokémon that is only capable of flopping and splashing. This behavior prompted scientists to undertake research into it.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/129.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/129.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/129.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/129.png", 0.5f, "Magikarp", 85.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 126,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 237.0, 186.0, "When Magikarp evolves into Gyarados, its brain cells undergo a structural transformation. It is said that this transformation is to blame for this Pokémon's wildly violent nature.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/130.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/130.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/130.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/130.png", 0.5f, "Gyarados", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 127,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 165.0, 174.0, "People have driven Lapras almost to the point of extinction. In the evenings, this Pokémon is said to sing plaintively as it seeks what few others of its kind still remain.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/131.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/131.png", "Lapras", 277.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 128,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 91.0, 91.0, "Ditto rearranges its cell structure to transform itself into other shapes. However, if it tries to transform itself into something by relying on its memory, this Pokémon manages to get details wrong.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/132.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/132.png", 0f, "Ditto", 134.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 129,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 104.0, 114.0, "Eevee has an unstable genetic makeup that suddenly mutates due to the environment in which it lives. Radiation from various stones causes this Pokémon to evolve.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/133.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/133.png", null, 0.875f, "Eevee", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 130,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 205.0, 161.0, "Vaporeon underwent a spontaneous mutation and grew fins and gills that allow it to live underwater. This Pokémon has the ability to freely control water.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/134.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/134.png", null, 0.875f, "Vaporeon", 277.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 131,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 232.0, 182.0, "Jolteon's cells generate a low level of electricity. This power is amplified by the static electricity of its fur, enabling the Pokémon to drop thunderbolts. The bristling fur is made of electrically charged needles.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/135.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/135.png", 0.875f, "Jolteon", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 132,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 246.0, 179.0, "Flareon's fluffy fur has a functional purpose—it releases heat into the air so that its body does not get excessively hot. This Pokémon's body temperature can rise to a maximum of 1,650 degrees Fahrenheit.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/136.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/136.png", 0.875f, "Flareon", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 133,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 153.0, 136.0, "Porygon is capable of reverting itself entirely back to program data and entering cyberspace. This Pokémon is copy protected so it cannot be duplicated by copying.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/137.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/137.png", 0f, "Porygon", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 134,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 155.0, 153.0, "Omanyte is one of the ancient and long-since-extinct Pokémon that have been regenerated from fossils by people. If attacked by an enemy, it withdraws itself inside its hard shell.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/138.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/138.png", "Omanyte", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 135,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 207.0, 201.0, "Omastar uses its tentacles to capture its prey. It is believed to have become extinct because its shell grew too large and heavy, causing its movements to become too slow and ponderous.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/139.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/139.png", "Omastar", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 136,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 148.0, 140.0, "Kabuto is a Pokémon that has been regenerated from a fossil. However, in extremely rare cases, living examples have been discovered. The Pokémon has not changed at all for 300 million years.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/140.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/140.png", "Kabuto", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 137,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 220.0, 186.0, "Kabutops swam underwater to hunt for its prey in ancient times. The Pokémon was apparently evolving from being a water dweller to living on land as evident from the beginnings of change in its gills and legs.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/141.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/141.png", 0.875f, "Kabutops", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 138,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 221.0, 159.0, "Aerodactyl is a Pokémon from the age of dinosaurs. It was regenerated from genetic material extracted from amber. It is imagined to have been the king of the skies in ancient times.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/142.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/142.png", "Aerodactyl", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 139,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 190.0, 169.0, "Snorlax's typical day consists of nothing more than eating and sleeping. It is such a docile Pokémon that there are children who use its expansive belly as a place to play.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/143.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/143.png", "Snorlax", 330.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 140,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 192.0, 236.0, "Articuno is a Legendary Pokémon that can control ice. The flapping of its wings chills the air. As a result, it is said that when this Pokémon flies, snow will fall.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/144.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/144.png", 0f, "Articuno", "Legendary", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 141,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 253.0, 185.0, "Zapdos is a Legendary Pokémon that has the ability to control electricity. It usually lives in thunderclouds. The Pokémon gains power if it is stricken by lightning bolts.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/145.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/145.png", 0f, "Zapdos", "Legendary", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 142,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 251.0, 181.0, "Moltres is a Legendary Pokémon that has the ability to control fire. If this Pokémon is injured, it is said to dip its body in the molten magma of a volcano to burn and heal itself.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/146.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/146.png", 0f, "Moltres", "Legendary", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 143,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 119.0, 91.0, "Dratini continually molts and sloughs off its old skin. It does so because the life energy within its body steadily builds to reach uncontrollable levels.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/147.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/147.png", 0.5f, "Dratini", 121.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 144,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 163.0, 135.0, "Dragonair stores an enormous amount of energy inside its body. It is said to alter weather conditions in its vicinity by discharging energy from the crystals on its neck and tail.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/148.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/148.png", 0.5f, "Dragonair", "common", 156.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 145,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 263.0, 198.0, "Dragonite is capable of circling the globe in just 16 hours. It is a kindhearted Pokémon that leads lost and foundering ships in a storm to the safety of land.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/149.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/149.png", 0.5f, "Dragonite", "common", 209.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 146,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 300.0, 182.0, "Mewtwo is a Pokémon that was created by genetic manipulation. However, even though the scientific power of humans created this Pokémon's body, they failed to endow Mewtwo with a compassionate heart.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/150.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/150.png", "Mewtwo", 214.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 147,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 210.0, 210.0, "Mew is said to possess the genetic composition of all Pokémon. It is capable of making itself invisible at will, so it entirely avoids notice even if it approaches people.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/151.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/151.png", 0f, "Mew", "Mythical", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 148,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 92.0, 122.0, "In battle, Chikorita waves its leaf around to keep the foe at bay. However, a sweet fragrance also wafts from the leaf, becalming the battling Pokémon and creating a cozy, friendly atmosphere all around.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/152.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/152.png", 0.875f, "Chikorita", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 149,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 122.0, 155.0, "Bayleef's neck is ringed by curled-up leaves. Inside each tubular leaf is a small shoot of a tree. The fragrance of this shoot makes people peppy.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/153.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/153.png", 0.875f, "Bayleef", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 150,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 168.0, 202.0, "The fragrance of Meganium's flower soothes and calms emotions. In battle, this Pokémon gives off more of its becalming scent to blunt the foe's fighting spirit.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/154.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/154.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/154.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/154.png", 0.875f, "Meganium", "common", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 151,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 116.0, 93.0, "Cyndaquil protects itself by flaring up the flames on its back. The flames are vigorous if the Pokémon is angry. However, if it is tired, the flames splutter fitfully with incomplete combustion.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/155.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/155.png", 0.875f, "Cyndaquil", "common", 118.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 152,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 158.0, 126.0, "Quilava keeps its foes at bay with the intensity of its flames and gusts of superheated air. This Pokémon applies its outstanding nimbleness to dodge attacks even while scorching the foe with flames.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/156.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/156.png", "Quilava", 151.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 153,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 223.0, 173.0, "Typhlosion obscures itself behind a shimmering heat haze that it creates using its intensely hot flames. This Pokémon creates blazing explosive blasts that burn everything to cinders.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/157.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/157.png", "Typhlosion", 186.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 154,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 117.0, 109.0, "Despite the smallness of its body, Totodile's jaws are very powerful. While the Pokémon may think it is just playfully nipping, its bite has enough power to cause serious injury.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/158.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/158.png", null, "Totodile", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 155,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 150.0, 142.0, "Once Croconaw has clamped its jaws on its foe, it will absolutely not let go. Because the tips of its fangs are forked back like barbed fishhooks, they become impossible to remove when they have sunk in.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/159.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/159.png", "Croconaw", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 156,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 205.0, 188.0, "Feraligatr intimidates its foes by opening its huge mouth. In battle, it will kick the ground hard with its thick and powerful hind legs to charge at the foe at an incredible speed.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/160.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/160.png", "Feraligatr", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 157,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 79.0, 73.0, "When Sentret sleeps, it does so while another stands guard. The sentry wakes the others at the first sign of danger. When this Pokémon becomes separated from its pack, it becomes incapable of sleep due to fear.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/161.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/161.png", 0.5f, "Sentret", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 158,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 148.0, 125.0, "Furret has a very slim build. When under attack, it can slickly squirm through narrow spaces and get away. In spite of its short limbs, this Pokémon is very nimble and fleet.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/162.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/162.png", 0.5f, "Furret", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 159,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 67.0, 88.0, "Hoothoot has an internal organ that senses and tracks the earth's rotation. Using this special organ, this Pokémon begins hooting at precisely the same time every day.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/163.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/163.png", 0.5f, "Hoothoot", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 160,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 145.0, 156.0, "Noctowl never fails at catching prey in darkness. This Pokémon owes its success to its superior vision that allows it to see in minimal light, and to its soft, supple wings that make no sound in flight.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/164.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/164.png", 0.5f, "Noctowl", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 161,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 72.0, 118.0, "Ledyba secretes an aromatic fluid from where its legs join its body. This fluid is used for communicating with others. This Pokémon conveys its feelings to others by altering the fluid's scent.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/165.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/165.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/165.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/165.png", "Ledyba", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 162,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 107.0, 179.0, "It is said that in lands with clean air, where the stars fill the sky, there live Ledian in countless numbers. There is a good reason for this—the Pokémon uses the light of the stars as its energy.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/166.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/166.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/166.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/166.png", "Ledian", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 163,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 105.0, 73.0, "The web spun by Spinarak can be considered its second nervous system. It is said that this Pokémon can determine what kind of prey is touching its web just by the tiny vibrations it feels through the web's strands.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/167.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/167.png", "Spinarak", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 164,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 161.0, 124.0, "Ariados's feet are tipped with tiny hooked claws that enable it to scuttle on ceilings and vertical walls. This Pokémon constricts the foe with thin and strong silk webbing.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/168.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/168.png", "Ariados", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 165,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 194.0, 178.0, "If this Pokémon is flying by fluttering only a pair of wings on either the forelegs or hind legs, it's proof that Crobat has been flying a long distance. It switches the wings it uses if it is tired.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/169.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/169.png", null, "Crobat", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 166,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 106.0, 97.0, "Chinchou lets loose positive and negative electrical charges from its two antennas to make its prey faint. This Pokémon flashes its electric lights to exchange signals with others.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/170.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/170.png", null, "Chinchou", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 167,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 146.0, 137.0, "Lanturn is nicknamed “the deep-sea star” for its illuminated antenna. This Pokémon produces light by causing a chemical reaction between bacteria and its bodily fluids inside the antenna.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/171.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/171.png", "Lanturn", 268.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 168,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 77.0, 53.0, "Pichu charges itself with electricity more easily on days with thunderclouds or when the air is very dry. You can hear the crackling of static electricity coming off this Pokémon.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/172.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/172.png", "Pichu", 85.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 169,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 75.0, 79.0, "On nights with many shooting stars, Cleffa can be seen dancing in a ring. They dance through the night and stop only at the break of day, when these Pokémon quench their thirst with the morning dew.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/173.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/173.png", 0.25f, "Cleffa", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 170,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 69.0, 32.0, "Igglybuff's vocal cords are not sufficiently developed. It would hurt its throat if it were to sing too much. This Pokémon gargles with freshwater from a clean stream.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/174.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/174.png", 0.25f, "Igglybuff", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 171,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 67.0, 116.0, "As its energy, Togepi uses the positive emotions of compassion and pleasure exuded by people and Pokémon. This Pokémon stores up feelings of happiness inside its shell, then shares them with others.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/175.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/175.png", 0.875f, "Togepi", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 172,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 139.0, 181.0, "Togetic is said to be a Pokémon that brings good fortune. When the Pokémon spots someone who is pure of heart, it is said to appear and share its happiness with that person.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/176.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/176.png", 0.875f, "Togetic", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 173,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 134.0, 89.0, "Natu cannot fly because its wings are not yet fully grown. If your eyes meet with this Pokémon's eyes, it will stare back intently at you. But if you move even slightly, it will hop away to safety.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/177.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/177.png", 0.5f, "Natu", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 174,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 192.0, 146.0, "Xatu stands rooted and still in one spot all day long. People believe that this Pokémon does so out of fear of the terrible things it has foreseen in the future.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/178.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/178.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/178.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/178.png", 0.5f, "Xatu", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 175,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 114.0, 79.0, "Mareep's fluffy coat of wool rubs together and builds a static charge. The more static electricity is charged, the more brightly the lightbulb at the tip of its tail glows.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/179.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/179.png", 0.5f, "Mareep", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 176,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 145.0, 109.0, "Flaaffy's wool quality changes so that it can generate a high amount of static electricity with a small amount of wool. The bare and slick parts of its hide are shielded against electricity.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/180.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/180.png", 0.5f, "Flaaffy", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 177,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 211.0, 169.0, "Ampharos gives off so much light that it can be seen even from space. People in the old days used the light of this Pokémon to send signals back and forth with others far away.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/181.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/181.png", "Ampharos", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 178,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 169.0, 186.0, "When Bellossom gets exposed to plenty of sunlight, the leaves ringing its body begin to spin around. This Pokémon's dancing is renowned in the southern lands.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/182.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/182.png", null, "Bellossom", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 179,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 37.0, 93.0, "Marill's oil-filled tail acts much like a life preserver. If you see just its tail bobbing on the water's surface, it's a sure indication that this Pokémon is diving beneath the water to feed on aquatic plants.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/183.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/183.png", "Marill", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 180,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 112.0, 152.0, "Azumarill's long ears are indispensable sensors. By focusing its hearing, this Pokémon can identify what kinds of prey are around, even in rough and fast-running rivers.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/184.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/184.png", "Azumarill", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 181,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 167.0, 176.0, "Sudowoodo camouflages itself as a tree to avoid being attacked by enemies. However, because its hands remain green throughout the year, the Pokémon is easily identified as a fake during the winter.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/185.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/185.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/185.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/185.png", "Sudowoodo", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 182,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 174.0, 179.0, "The curled hair on Politoed's head is proof of its status as a king. It is said that the longer and more curled the hair, the more respect this Pokémon earns from its peers.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/186.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/186.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/186.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/186.png", "Politoed", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 183,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 67.0, 94.0, "This Pokémon drifts and floats with the wind. If it senses the approach of strong winds, Hoppip links its leaves with other Hoppip to prepare against being blown away.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/187.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/187.png", "Hoppip", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 184,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 91.0, 120.0, "Skiploom's flower blossoms when the temperature rises above 64 degrees Fahrenheit. How much the flower opens depends on the temperature. For that reason, this Pokémon is sometimes used as a thermometer.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/188.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/188.png", "Skiploom", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 185,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 118.0, 183.0, "Jumpluff rides warm southern winds to cross the sea and fly to foreign lands. The Pokémon descends to the ground when it encounters cold air while it is floating.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/189.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/189.png", null, "Jumpluff", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 186,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 136.0, 112.0, "Aipom's tail ends in a hand-like appendage that can be cleverly manipulated. However, because the Pokémon uses its tail so much, its real hands have become rather clumsy.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/190.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/190.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/190.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/190.png", "Aipom", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 187,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 55.0, 55.0, "Sunkern tries to move as little as it possibly can. It does so because it tries to conserve all the nutrients it has stored in its body for its evolution. It will not eat a thing, subsisting only on morning dew.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/191.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/191.png", "Sunkern", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 188,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 185.0, 135.0, "Sunflora converts solar energy into nutrition. It moves around actively in the daytime when it is warm. It stops moving as soon as the sun goes down for the night.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/192.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/192.png", "Sunflora", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 189,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 154.0, 94.0, "Yanma is capable of seeing 360 degrees without having to move its eyes. It is a great flier that is adept at making sudden stops and turning midair. This Pokémon uses its flying ability to quickly chase down targeted prey.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/193.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/193.png", "Yanma", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 190,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name" },
                values: new object[] { 75.0, 66.0, "Wooper usually lives in water. However, it occasionally comes out onto land in search of food. On land, it coats its body with a gooey, toxic film.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/194.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/194.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/194.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/194.png", "Wooper" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 191,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 152.0, 143.0, "Quagsire hunts for food by leaving its mouth wide open in water and waiting for its prey to blunder in unaware. Because the Pokémon does not move, it does not get very hungry.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/195.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/195.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/195.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/195.png", "Quagsire", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 192,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 261.0, 175.0, "Espeon is extremely loyal to any Trainer it considers to be worthy. It is said that this Pokémon developed its precognitive powers to protect its Trainer from harm.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/196.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/196.png", 0.875f, "Espeon", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 193,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 126.0, 240.0, "Umbreon evolved as a result of exposure to the moon's waves. It hides silently in darkness and waits for its foes to make a move. The rings on its body glow when it leaps to attack.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/197.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/197.png", 0.875f, "Umbreon", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 194,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 175.0, 87.0, "Murkrow was feared and loathed as the alleged bearer of ill fortune. This Pokémon shows strong interest in anything that sparkles or glitters. It will even try to steal rings from women.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/198.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/198.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/198.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/198.png", "Murkrow", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 195,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name" },
                values: new object[] { 177.0, 180.0, "Slowking undertakes research every day in an effort to solve the mysteries of the world. However, this Pokémon apparently forgets everything it has learned if the Shellder on its head comes off.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/199.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/199.png", null, "Slowking" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 196,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 167.0, 154.0, "Misdreavus frightens people with a creepy, sobbing cry. The Pokémon apparently uses its red spheres to absorb the fearful feelings of foes and turn them into nutrition.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/200.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/200.png", 0.5f, "Misdreavus", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 197,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 136.0, 91.0, "This Pokémon is shaped like ancient writing. It is a mystery as to which came first, the ancient writings or the various Unown. Research into this topic is ongoing but nothing is known.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/201.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/201.png", 0f, "Unown", 134.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 198,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 60.0, 106.0, "If two or more Wobbuffet meet, they will turn competitive and try to outdo each other's endurance. However, they may try to see which one can endure the longest without food. Trainers need to beware of this habit.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/202.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/202.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/202.png", "Wobbuffet", 382.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 199,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 182.0, 133.0, "Girafarig's rear head also has a brain, but it is small. The rear head attacks in response to smells and sounds. Approaching this Pokémon from behind can cause the rear head to suddenly lash out and bite.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/203.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/203.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/203.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/203.png", "Girafarig", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 200,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 108.0, 122.0, "Pineco hangs from a tree branch and patiently waits for prey to come along. If the Pokémon is disturbed while eating by someone shaking its tree, it drops down to the ground and explodes with no warning.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/204.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/204.png", "Pineco", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 201,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 161.0, 205.0, "Forretress conceals itself inside its hardened steel shell. The shell is opened when the Pokémon is catching prey, but it does so at such a quick pace that the shell's inside cannot be seen.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/205.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/205.png", 0.5f, "Forretress", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 202,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 131.0, 128.0, "Dunsparce has a drill for its tail. It uses this tail to burrow into the ground backward. This Pokémon is known to make its nest in complex shapes deep under the ground.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/206.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/206.png", null, "Dunsparce", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 203,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 143.0, 184.0, "Gligar glides through the air without a sound as if it were sliding. This Pokémon hangs on to the face of its foe using its clawed hind legs and the large pincers on its forelegs, then injects the prey with its poison barb.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/207.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/207.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/207.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/207.png", "Gligar", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 204,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 148.0, 272.0, "Steelix lives even further underground than Onix. This Pokémon is known to dig toward the earth's core. There are records of this Pokémon reaching a depth of over six-tenths of a mile underground.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/208.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/208.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/208.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/208.png", "Steelix", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 205,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 137.0, 85.0, "By baring its fangs and making a scary face, Snubbull sends smaller Pokémon scurrying away in terror. However, this Pokémon seems a little sad at making its foes flee.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/209.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/209.png", 0.25f, "Snubbull", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 206,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 212.0, 131.0, "Granbull has a particularly well-developed lower jaw. The enormous fangs are heavy, causing the Pokémon to tip its head back for balance. Unless it is startled, it will not try to bite indiscriminately.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/210.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/210.png", 0.25f, "Granbull", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 207,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name" },
                values: new object[] { 184.0, 138.0, "Qwilfish sucks in water, inflating itself. This Pokémon uses the pressure of the water it swallowed to shoot toxic quills all at once from all over its body. It finds swimming somewhat challenging.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/211.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/211.png", null, "Qwilfish" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 208,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 236.0, 181.0, "Scizor has a body with the hardness of steel. It is not easily fazed by ordinary sorts of attacks. This Pokémon flaps its wings to regulate its body temperature.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/212.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/212.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/212.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/212.png", "Scizor", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 209,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 17.0, 396.0, "Shuckle quietly hides itself under rocks, keeping its body concealed inside its hard shell while eating berries it has stored away. The berries mix with its body fluids to become a juice.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/213.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/213.png", 0.5f, "Shuckle", 85.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 210,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 234.0, 179.0, "Heracross charges in a straight line at its foe, slips beneath the foe's grasp, and then scoops up and hurls the opponent with its mighty horn. This Pokémon even has enough power to topple a massive tree.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/214.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/214.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/214.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/214.png", 0.5f, "Heracross", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 211,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 189.0, 146.0, "Sneasel scales trees by punching its hooked claws into the bark. This Pokémon seeks out unguarded nests and steals eggs for food while the parents are away.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/215.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/215.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/215.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/215.png", "Sneasel", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 212,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 142.0, 93.0, "This Pokémon likes to lick its palms that are sweetened by being soaked in honey. Teddiursa concocts its own honey by blending fruits and pollen collected by Beedrill.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/216.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/216.png", null, "Teddiursa", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 213,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 236.0, 144.0, "In the forests inhabited by Ursaring, it is said that there are many streams and towering trees where they gather food. This Pokémon walks through its forest gathering food every day.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/217.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/217.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/217.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/217.png", "Ursaring", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 214,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 118.0, 71.0, "Molten magma courses throughout Slugma's circulatory system. If this Pokémon is chilled, the magma cools and hardens. Its body turns brittle and chunks fall off, reducing its size.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/218.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/218.png", null, "Slugma", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 215,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 139.0, 191.0, "Magcargo's shell is actually its skin that hardened as a result of cooling. Its shell is very brittle and fragile—just touching it causes it to crumble apart. This Pokémon returns to its original size by dipping itself in magma.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/219.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/219.png", null, "Magcargo", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 216,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 90.0, 69.0, "Swinub roots for food by rubbing its snout against the ground. Its favorite food is a mushroom that grows under the cover of dead grass. This Pokémon occasionally roots out hot springs.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/220.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/220.png", "Swinub", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 217,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 181.0, 138.0, "Piloswine is covered by a thick coat of long hair that enables it to endure the freezing cold. This Pokémon uses its tusks to dig up food that has been buried under ice.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/221.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/221.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/221.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/221.png", "Piloswine", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 218,
                columns: new[] { "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 156.0, "Corsola's branches glitter very beautifully in seven colors when they catch sunlight. If any branch breaks off, this Pokémon grows it back in just one night.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/222.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/222.png", 0.25f, "Corsola", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 219,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 127.0, 69.0, "Remoraid sucks in water, then expels it at high velocity using its abdominal muscles to shoot down flying prey. When evolution draws near, this Pokémon travels downstream from rivers.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/223.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/223.png", "Remoraid", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 220,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 197.0, 141.0, "Octillery grabs onto its foe using its tentacles. This Pokémon tries to immobilize it before delivering the finishing blow. If the foe turns out to be too strong, Octillery spews ink to escape.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/224.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/224.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/224.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/224.png", "Octillery", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 221,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 128.0, 90.0, "Delibird carries its food bundled up in its tail. There once was a famous explorer who managed to reach the peak of the world's highest mountain, thanks to one of these Pokémon sharing its food.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/225.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/225.png", null, "Delibird", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 222,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 148.0, 226.0, "On sunny days, schools of Mantine can be seen elegantly leaping over the sea's waves. This Pokémon is not bothered by the Remoraid that hitches rides.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/226.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/226.png", 0.5f, "Mantine", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 223,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 148.0, 226.0, "Skarmory is entirely encased in hard, protective armor. This Pokémon flies at close to 190 mph. It slashes foes with its wings that possess swordlike cutting edges.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/227.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/227.png", "Skarmory", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 224,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 152.0, 83.0, "Houndour hunt as a coordinated pack. They communicate with each other using a variety of cries to corner their prey. This Pokémon's remarkable teamwork is unparalleled.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/228.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/228.png", null, "Houndour", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 225,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 224.0, 144.0, "In a Houndoom pack, the one with its horns raked sharply toward the back serves a leadership role. These Pokémon choose their leader by fighting among themselves.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/229.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/229.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/229.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/229.png", "Houndoom", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 226,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 194.0, 194.0, "Kingdra lives at extreme ocean depths that are otherwise uninhabited. It has long been believed that the yawning of this Pokémon creates spiraling ocean currents.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/230.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/230.png", "Kingdra", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 227,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 107.0, 98.0, "For its nest, Phanpy digs a vertical pit in the ground at the edge of a river. It marks the area around its nest with its trunk to let the others know that the area has been claimed.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/231.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/231.png", "Phanpy", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 228,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 214.0, 185.0, "Donphan's favorite attack is curling its body into a ball, then charging at its foe while rolling at high speed. Once it starts rolling, this Pokémon can't stop very easily.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/232.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/232.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/232.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/232.png", "Donphan", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 229,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 198.0, 180.0, "Porygon2 was created by humans using the power of science. The man-made Pokémon has been endowed with artificial intelligence that enables it to learn new gestures and emotions on its own.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/233.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/233.png", null, 0f, "Porygon2", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 230,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 192.0, 131.0, "Stantler's magnificent antlers were traded at high prices as works of art. As a result, this Pokémon was hunted close to extinction by those who were after the priceless antlers.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/234.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/234.png", "Stantler", 177.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 231,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 40.0, 83.0, "Smeargle marks the boundaries of its territory using a body fluid that leaks out from the tip of its tail. Over 5,000 different marks left by this Pokémon have been found.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/235.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/235.png", "Smeargle", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 232,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 64.0, 64.0, "Tyrogue becomes stressed out if it does not get to train every day. When raising this Pokémon, the Trainer must establish and uphold various training methods.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/236.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/236.png", null, 1f, "Tyrogue", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 233,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 173.0, 207.0, "Hitmontop spins on its head at high speed, all the while delivering kicks. This technique is a remarkable mix of both offense and defense at the same time. The Pokémon travels faster spinning than it does walking.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/237.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/237.png", 1f, "Hitmontop", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 234,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 153.0, 91.0, "Smoochum actively runs about, but also falls quite often. Whenever the chance arrives, it will look for its reflection to make sure its face hasn't become dirty.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/238.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/238.png", 0f, "Smoochum", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 235,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 135.0, 101.0, "Elekid stores electricity in its body. If it touches metal and accidentally discharges all its built-up electricity, this Pokémon begins swinging its arms in circles to recharge itself.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/239.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/239.png", 0.75f, "Elekid", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 236,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 151.0, 99.0, "Magby's state of health is determined by observing the fire it breathes. If the Pokémon is spouting yellow flames from its mouth, it is in good health. When it is fatigued, black smoke will be mixed in with the flames.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/240.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/240.png", 0.75f, "Magby", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 237,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 157.0, 193.0, "Miltank gives over five gallons of milk on a daily basis. Its sweet milk is enjoyed by children and grown-ups alike. People who can't drink milk turn it into yogurt and eat it instead.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/241.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/241.png", 0f, "Miltank", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 238,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 129.0, 169.0, "Blissey senses sadness with its fluffy coat of fur. If it does so, this Pokémon will rush over to a sad person, no matter how far away, to share a Lucky Egg that brings a smile to any face.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/242.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/242.png", "Blissey", 496.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 239,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 241.0, 195.0, "Raikou embodies the speed of lightning. The roars of this Pokémon send shock waves shuddering through the air and shake the ground as if lightning bolts had come crashing down.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/243.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/243.png", 0f, "Raikou", "Legendary", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 240,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 235.0, 171.0, "Entei embodies the passion of magma. This Pokémon is thought to have been born in the eruption of a volcano. It sends up massive bursts of fire that utterly consume all that they touch.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/244.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/244.png", 0f, "Entei", "Legendary", 251.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 241,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 180.0, 235.0, "Suicune embodies the compassion of a pure spring of water. It runs across the land with gracefulness. This Pokémon has the power to purify dirty water.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/245.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/245.png", "Suicune", "Legendary", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 242,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 115.0, 93.0, "Larvitar is born deep under the ground. To come up to the surface, this Pokémon must eat its way through the soil above. Until it does so, Larvitar cannot see its parents.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/246.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/246.png", 0.5f, "Larvitar", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 243,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 155.0, 133.0, "Pupitar creates a gas inside its body that it compresses and forcefully ejects to propel itself like a jet. The body is very durable—it avoids damage even if it hits solid steel.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/247.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/247.png", 0.5f, "Pupitar", "common", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 244,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 251.0, 207.0, "Tyranitar is so overwhelmingly powerful, it can bring down a whole mountain to make its nest. This Pokémon wanders about in mountains seeking new opponents to fight.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/248.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/248.png", 0.5f, "Tyranitar", "common", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 245,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 193.0, 310.0, "Lugia's wings pack devastating power—a light fluttering of its wings can blow apart regular houses. As a result, this Pokémon chooses to live out of sight deep under the sea.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/249.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/249.png", "Lugia", 235.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 246,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 239.0, 244.0, "Ho-Oh's feathers glow in seven colors depending on the angle at which they are struck by light. These feathers are said to bring happiness to the bearers. This Pokémon is said to live at the foot of a rainbow.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/250.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/250.png", 0f, "Ho-Oh", "Legendary", 214.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 247,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 210.0, 210.0, "This Pokémon came from the future by crossing over time. It is thought that so long as Celebi appears, a bright and shining future awaits us.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/251.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/251.png", 0f, "Celebi", "Mythical", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 248,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 124.0, 94.0, "Treecko has small hooks on the bottom of its feet that enable it to scale vertical walls. This Pokémon attacks by slamming foes with its thick tail.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/252.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/252.png", 0.875f, "Treecko", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 249,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 172.0, 120.0, "The leaves growing out of Grovyle's body are convenient for camouflaging it from enemies in the forest. This Pokémon is a master at climbing trees in jungles.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/253.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/253.png", 0.875f, "Grovyle", "common", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 250,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 223.0, 169.0, "The leaves growing on Sceptile's body are very sharp edged. This Pokémon is very agile—it leaps all over the branches of trees and jumps on its foe from above or behind.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/254.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/254.png", 0.875f, "Sceptile", "common", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 251,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 130.0, 87.0, "Torchic sticks with its Trainer, following behind with unsteady steps. This Pokémon breathes fire of over 1,800 degrees Fahrenheit, including fireballs that leave the foe scorched black.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/255.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/255.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/255.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/255.png", 0.875f, "Torchic", "common", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 252,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 163.0, 115.0, "Combusken toughens up its legs and thighs by running through fields and mountains. This Pokémon's legs possess both speed and power, enabling it to dole out 10 kicks in one second.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/256.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/256.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/256.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/256.png", "Combusken", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 253,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 240.0, 141.0, "In battle, Blaziken blows out intense flames from its wrists and attacks foes courageously. The stronger the foe, the more intensely this Pokémon's wrists burn.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/257.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/257.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/257.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/257.png", "Blaziken", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 254,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 126.0, 93.0, "The fin on Mudkip's head acts as highly sensitive radar. Using this fin to sense movements of water and air, this Pokémon can determine what is taking place around it without using its eyes.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/258.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/258.png", "Mudkip", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 255,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 156.0, 133.0, "The surface of Marshtomp's body is enveloped by a thin, sticky film that enables it to live on land. This Pokémon plays in mud on beaches when the ocean tide is low.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/259.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/259.png", null, "Marshtomp", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 256,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 208.0, 175.0, "Swampert is very strong. It has enough power to easily drag a boulder weighing more than a ton. This Pokémon also has powerful vision that lets it see even in murky water.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/260.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/260.png", null, "Swampert", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 257,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 96.0, 61.0, "At first sight, Poochyena takes a bite at anything that moves. This Pokémon chases after prey until the victim becomes exhausted. However, it may turn tail if the prey strikes back.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/261.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/261.png", null, 0.5f, "Poochyena", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 258,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 171.0, 132.0, "Mightyena gives obvious signals when it is preparing to attack. It starts to growl deeply and then flattens its body. This Pokémon will bite savagely with its sharply pointed fangs.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/262.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/262.png", 0.5f, "Mightyena", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 259,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 75.0, 59.0, "Using the spikes on its rear end, Wurmple peels the bark off trees and feeds on the sap that oozes out. This Pokémon's feet are tipped with suction pads that allow it to cling to glass without slipping.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/265.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/265.png", 0.5f, "Wurmple", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 260,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 60.0, 77.0, "Silcoon tethers itself to a tree branch using silk to keep from falling. There, this Pokémon hangs quietly while it awaits evolution. It peers out of the silk cocoon through a small hole.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/266.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/266.png", 0.5f, "Silcoon", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 261,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 189.0, 98.0, "Beautifly's favorite food is the sweet pollen of flowers. If you want to see this Pokémon, just leave a potted flower by an open window. Beautifly is sure to come looking for pollen.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/267.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/267.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/267.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/267.png", "Beautifly", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 262,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 60.0, 77.0, "Cascoon makes its protective cocoon by wrapping its body entirely with a fine silk from its mouth. Once the silk goes around its body, it hardens. This Pokémon prepares for its evolution inside the cocoon.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/268.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/268.png", "Cascoon", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 265,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 112.0, 119.0, "Lombre is nocturnal—it will get active after dusk. It is also a mischief maker. When this Pokémon spots anglers, it tugs on their fishing lines from beneath the surface and enjoys their consternation.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/271.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/271.png", "Lombre", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 266,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 173.0, 176.0, "Ludicolo begins dancing as soon as it hears cheerful, festive music. This Pokémon is said to appear when it hears the singing of children on hiking outings.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/272.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/272.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/272.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/272.png", "Ludicolo", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 267,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 71.0, 77.0, "Seedot attaches itself to a tree branch using the top of its head. It sucks moisture from the tree while hanging off the branch. The more water it drinks, the glossier this Pokémon's body becomes.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/273.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/273.png", null, "Seedot", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 268,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 134.0, 78.0, "Nuzleaf live in densely overgrown forests. They occasionally venture out of the forest to startle people. This Pokémon dislikes having its long nose pinched.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/274.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/274.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/274.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/274.png", "Nuzleaf", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 269,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 200.0, 121.0, "Shiftry is a mysterious Pokémon that is said to live atop towering trees dating back over a thousand years. It creates terrific windstorms with the fans it holds.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/275.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/275.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/275.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/275.png", "Shiftry", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 270,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name" },
                values: new object[] { 106.0, 61.0, "Taillow courageously stands its ground against foes, however strong they may be. This gutsy Pokémon will remain defiant even after a loss. On the other hand, it cries loudly if it becomes hungry.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/276.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/276.png", "Taillow" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 271,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name" },
                values: new object[] { 185.0, 124.0, "Swellow flies high above our heads, making graceful arcs in the sky. This Pokémon dives at a steep angle as soon as it spots its prey. The hapless prey is tightly grasped by Swellow's clawed feet, preventing escape.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/277.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/277.png", "Swellow" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 272,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 106.0, 61.0, "Wingull has the habit of carrying prey and valuables in its beak and hiding them in all sorts of locations. This Pokémon rides the winds and flies as if it were skating across the sky.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/278.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/278.png", null, "Wingull", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 273,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 175.0, 174.0, "Pelipper is a flying transporter that carries small Pokémon and eggs inside its massive bill. This Pokémon builds its nest on steep cliffs facing the sea.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/279.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/279.png", "Pelipper", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 274,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 79.0, 59.0, "Ralts senses the emotions of people using the horns on its head. This Pokémon rarely appears before people. But when it does, it draws closer if it senses that the person has a positive disposition.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/280.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/280.png", null, "Ralts", 99.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 275,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 117.0, 90.0, "It is said that a Kirlia that is exposed to the positive emotions of its Trainer grows beautiful. This Pokémon controls psychokinetic powers with its highly developed brain.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/281.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/281.png", null, "Kirlia", 116.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 276,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 237.0, 195.0, "Gardevoir has the ability to read the future. If it senses impending danger to its Trainer, this Pokémon is said to unleash its psychokinetic energy at full power.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/282.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/282.png", "Gardevoir", 169.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 277,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 93.0, 87.0, "From the tips of its feet, Surskit secretes an oil that enables it to walk on water as if it were skating. This Pokémon feeds on microscopic organisms in ponds and lakes.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/283.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/283.png", "Surskit", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 278,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 192.0, 150.0, "Masquerain intimidates enemies with the eyelike patterns on its antennas. This Pokémon flaps its four wings to freely fly in any direction—even sideways and backwards—as if it were a helicopter.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/284.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/284.png", "Masquerain", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 279,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name" },
                values: new object[] { 74.0, 110.0, "Shroomish live in damp soil in the dark depths of forests. They are often found keeping still under fallen leaves. This Pokémon feeds on compost that is made up of fallen, rotted leaves.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/285.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/285.png", "Shroomish" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 280,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 241.0, 144.0, "Breloom closes in on its foe with light and sprightly footwork, then throws punches with its stretchy arms. This Pokémon's fighting technique puts boxers to shame.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/286.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/286.png", "Breloom", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 281,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 104.0, 92.0, "Slakoth lolls around for over 20 hours every day. Because it moves so little, it does not need much food. This Pokémon's sole daily meal consists of just three leaves.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/287.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/287.png", "Slakoth", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 282,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 159.0, 145.0, "Vigoroth is always itching and agitated to go on a wild rampage. It simply can't tolerate sitting still for even a minute. This Pokémon's stress level rises if it can't be moving constantly.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/288.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/288.png", "Vigoroth", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 283,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 290.0, 166.0, "Slaking spends all day lying down and lolling about. It eats grass growing within its reach. If it eats all the grass it can reach, this Pokémon reluctantly moves to another spot.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/289.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/289.png", "Slaking", 284.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 284,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 80.0, 126.0, "Nincada lives underground for many years in complete darkness. This Pokémon absorbs nutrients from the roots of trees. It stays motionless as it waits for evolution.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/290.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/290.png", "Nincada", 104.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 285,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 199.0, 112.0, "Ninjask moves around at such a high speed that it cannot be seen, even while its crying can be clearly heard. For that reason, this Pokémon was long believed to be invisible.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/291.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/291.png", "Ninjask", 156.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 286,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 153.0, 73.0, "Shedinja's hard body doesn't move—not even a twitch. In fact, its body appears to be merely a hollow shell. It is believed that this Pokémon will steal the spirit of anyone peering into its hollow body from its back.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/292.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/292.png", 0f, "Shedinja", 1.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 287,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 92.0, 42.0, "Normally, Whismur's voice is very quiet—it is barely audible even if one is paying close attention. However, if this Pokémon senses danger, it starts crying at an earsplitting volume.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/293.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/293.png", "Whismur", 162.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 288,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 134.0, 81.0, "Loudred's bellowing can completely decimate a wood-frame house. It uses its voice to punish its foes. This Pokémon's round ears serve as loudspeakers.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/294.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/294.png", "Loudred", 197.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 289,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 179.0, 137.0, "Exploud triggers earthquakes with the tremors it creates by bellowing. If this Pokémon violently inhales from the ports on its body, it's a sign that it is preparing to let loose a huge bellow.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/295.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/295.png", "Exploud", 232.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 290,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 99.0, 54.0, "Makuhita is tenacious—it will keep getting up and attacking its foe however many times it is knocked down. Every time it gets back up, this Pokémon stores more energy in its body for evolving.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/296.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/296.png", 0.75f, "Makuhita", 176.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 291,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 209.0, 114.0, "Hariyama practices its straight-arm slaps in any number of locations. One hit of this Pokémon's powerful, openhanded, straight-arm punches could snap a telephone pole in two.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/297.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/297.png", 0.75f, "Hariyama", 302.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 292,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 36.0, 71.0, "Azurill spins its tail as if it were a lasso, then hurls it far. The momentum of the throw sends its body flying, too. Using this unique action, one of these Pokémon managed to hurl itself a record 33 feet.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/298.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/298.png", 0.25f, "Azurill", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 293,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 82.0, 215.0, "Nosepass's magnetic nose is always pointed to the north. If two of these Pokémon meet, they cannot turn their faces to each other when they are close because their magnetic noses repel one another.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/299.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/299.png", "Nosepass", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 294,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 84.0, 79.0, "Skitty has the habit of becoming fascinated by moving objects and chasing them around. This Pokémon is known to chase after its own tail and become dizzy.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/300.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/300.png", 0.25f, "Skitty", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 295,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 132.0, 127.0, "Delcatty prefers to live an unfettered existence in which it can do as it pleases at its own pace. Because this Pokémon eats and sleeps whenever it decides, its daily routines are completely random.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/301.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/301.png", 0.25f, "Delcatty", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 296,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 141.0, 136.0, "Sableye lead quiet lives deep inside caverns. They are feared, however, because these Pokémon are thought to steal the spirits of people when their eyes burn with a sinister glow in the darkness.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/302.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/302.png", 0.5f, "Sableye", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 297,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 155.0, 141.0, "Mawile's huge jaws are actually steel horns that have been transformed. Its docile-looking face serves to lull its foe into letting down its guard. When the foe least expects it, Mawile chomps it with its gaping jaws.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/303.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/303.png", 0.5f, "Mawile", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 298,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name" },
                values: new object[] { 121.0, 141.0, "This Pokémon has a body of steel. To make its body, Aron feeds on iron ore that it digs from mountains. Occasionally, it causes major trouble by eating bridges and rails.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/304.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/304.png", 0.5f, "Aron" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 299,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 158.0, 198.0, "Lairon tempers its steel body by drinking highly nutritious mineral springwater until it is bloated. This Pokémon makes its nest close to springs of delicious water.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/305.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/305.png", "Lairon", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 300,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 198.0, 257.0, "Aggron claims an entire mountain as its own territory. It mercilessly beats up anything that violates its environment. This Pokémon vigilantly patrols its territory at all times.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/306.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/306.png", 0.5f, "Aggron", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 301,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 78.0, 107.0, "Meditite undertakes rigorous mental training deep in the mountains. However, whenever it meditates, this Pokémon always loses its concentration and focus. As a result, its training never ends.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/307.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/307.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/307.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/307.png", 0.5f, "Meditite", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 302,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 121.0, 152.0, "It is said that through meditation, Medicham heightens energy inside its body and sharpens its sixth sense. This Pokémon hides its presence by merging itself with fields and mountains.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/308.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/308.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/308.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/308.png", "Medicham", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 303,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 123.0, 78.0, "Electrike stores electricity in its long body hair. This Pokémon stimulates its leg muscles with electric charges. These jolts of power give its legs explosive acceleration performance.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/309.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/309.png", "Electrike", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 304,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 215.0, 127.0, "Manectric is constantly discharging electricity from its mane. The sparks sometimes ignite forest fires. When it enters a battle, this Pokémon creates thunderclouds.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/310.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/310.png", "Manectric", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 305,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name" },
                values: new object[] { 167.0, 129.0, "Plusle always acts as a cheerleader for its partners. Whenever a teammate puts out a good effort in battle, this Pokémon shorts out its body to create the crackling noises of sparks to show its joy.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/311.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/311.png", "Plusle" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 306,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 147.0, 150.0, "Minun is more concerned about cheering on its partners than its own safety. It shorts out the electricity in its body to create brilliant showers of sparks to cheer on its teammates.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/312.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/312.png", "Minun", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 307,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 143.0, 166.0, "With the arrival of night, Volbeat emits light from its tail. It communicates with others by adjusting the intensity and flashing of its light. This Pokémon is attracted by the sweet aroma of Illumise.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/313.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/313.png", null, 1f, "Volbeat", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 308,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 143.0, 166.0, "Illumise attracts a swarm of Volbeat using a sweet fragrance. Once the Volbeat have gathered, this Pokémon leads the lit-up swarm in drawing geometric designs on the canvas of the night sky.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/314.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/314.png", null, 0f, "Illumise", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 309,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 186.0, 131.0, "Roselia shoots sharp thorns as projectiles at any opponent that tries to steal the flowers on its arms. The aroma of this Pokémon brings serenity to living things.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/315.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/315.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/315.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/315.png", "Roselia", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 310,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name" },
                values: new object[] { 80.0, 99.0, "Virtually all of Gulpin's body is its stomach. As a result, it can swallow something its own size. This Pokémon's stomach contains a special fluid that digests anything.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/316.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/316.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/316.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/316.png", "Gulpin" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 311,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 140.0, 159.0, "When Swalot spots prey, it spurts out a hideously toxic fluid from its pores and sprays the target. Once the prey has weakened, this Pokémon gulps it down whole with its cavernous mouth.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/317.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/317.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/317.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/317.png", "Swalot", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 312,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 171.0, 39.0, "Carvanha's strongly developed jaws and its sharply pointed fangs pack the destructive power to rip out boat hulls. Many boats have been attacked and sunk by this Pokémon.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/318.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/318.png", "Carvanha", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 313,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 243.0, 83.0, "Nicknamed “the bully of the sea,” Sharpedo is widely feared. Its cruel fangs grow back immediately if they snap off. Just one of these Pokémon can thoroughly tear apart a supertanker.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/319.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/319.png", 0.5f, "Sharpedo", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 314,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 136.0, 68.0, "Wailmer's nostrils are located above its eyes. This playful Pokémon loves to startle people by forcefully snorting out seawater it stores inside its body out of its nostrils.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/320.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/320.png", 0.5f, "Wailmer", 277.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 315,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 175.0, 87.0, "Wailord is the largest of all identified Pokémon up to now. This giant Pokémon swims languorously in the vast open sea, eating massive amounts of food at once with its enormous mouth.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/321.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/321.png", null, "Wailord", 347.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 316,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 119.0, 79.0, "Numel is extremely dull witted—it doesn't notice being hit. However, it can't stand hunger for even a second. This Pokémon's body is a seething cauldron of boiling magma.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/322.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/322.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/322.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/322.png", "Numel", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 317,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 194.0, 136.0, "Camerupt has a volcano inside its body. Magma of 18,000 degrees Fahrenheit courses through its body. Occasionally, the humps on this Pokémon's back erupt, spewing the superheated magma.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/323.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/323.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/323.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/323.png", "Camerupt", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 318,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 151.0, 203.0, "Torkoal digs through mountains in search of coal. If it finds some, it fills hollow spaces on its shell with the coal and burns it. If it is attacked, this Pokémon spouts thick black smoke to beat a retreat.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/324.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/324.png", "Torkoal", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 319,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 125.0, 122.0, "Spoink bounces around on its tail. The shock of its bouncing makes its heart pump. As a result, this Pokémon cannot afford to stop bouncing—if it stops, its heart will stop.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/325.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/325.png", "Spoink", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 320,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 171.0, 188.0, "Grumpig uses the black pearls on its body to amplify its psychic power waves for gaining total control over its foe. When this Pokémon uses its special power, its snorting breath grows labored.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/326.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/326.png", "Grumpig", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 321,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 116.0, 116.0, "All the Spinda that exist in the world are said to have utterly unique spot patterns. The shaky, tottering steps of this Pokémon give it the appearance of dancing.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/327.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/327.png", "Spinda", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 322,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 162.0, 78.0, "Trapinch's nest is a sloped, bowl-like pit dug in sand. This Pokémon patiently waits for prey to tumble down the pit. Its giant jaws have enough strength to crush even boulders.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/328.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/328.png", null, "Trapinch", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 323,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 134.0, 99.0, "To make prey faint, Vibrava generates ultrasonic waves by vigorously making its two wings vibrate. This Pokémon's ultrasonic waves are so powerful, they can bring on headaches in people.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/329.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/329.png", null, "Vibrava", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 324,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 205.0, 168.0, "Flygon is nicknamed “the elemental spirit of the desert.” Because its flapping wings whip up a cloud of sand, this Pokémon is always enveloped in a sandstorm while flying.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/330.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/330.png", "Flygon", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 325,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 156.0, 74.0, "Cacnea lives in arid locations such as deserts. It releases a strong aroma from its flower to attract prey. When prey comes near, this Pokémon shoots sharp thorns from its body to bring the victim down.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/331.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/331.png", "Cacnea", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 326,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 221.0, 115.0, "During the daytime, Cacturne remains unmoving so that it does not lose any moisture to the harsh desert sun. This Pokémon becomes active at night when the temperature drops.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/332.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/332.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/332.png", "Cacturne", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 327,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 76.0, 132.0, "Swablu has light and fluffy wings that are like cottony clouds. This Pokémon is not frightened of people. It lands on the heads of people and sits there like a cotton-fluff hat.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/333.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/333.png", "Swablu", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 328,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 141.0, 201.0, "Altaria dances and wheels through the sky among billowing, cotton-like clouds. By singing melodies in its crystal-clear voice, this Pokémon makes its listeners experience dreamy wonderment.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/334.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/334.png", "Altaria", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 329,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 222.0, 124.0, "Memories of battling its archrival Seviper are etched into every cell of Zangoose's body. This Pokémon adroitly dodges attacks with incredible agility.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/335.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/335.png", "Zangoose", 177.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 330,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 196.0, 118.0, "Seviper shares a generations-long feud with Zangoose. The scars on its body are evidence of vicious battles. This Pokémon attacks using its sword-edged tail.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/336.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/336.png", "Seviper", 177.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 331,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 178.0, 153.0, "Lunatone was discovered at a location where a meteoroid fell. As a result, some people theorize that this Pokémon came from space. However, no one has been able to prove this theory so far.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/337.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/337.png", 0f, "Lunatone", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 332,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 178.0, 153.0, "Solrock is a new species of Pokémon that is said to have fallen from space. It floats in air and moves silently. In battle, this Pokémon releases intensely bright light.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/338.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/338.png", null, 0f, "Solrock", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 333,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 93.0, 82.0, "Barboach's sensitive whiskers serve as a superb radar system. This Pokémon hides in mud, leaving only its two whiskers exposed while it waits for prey to come along.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/339.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/339.png", "Barboach", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 334,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 151.0, 141.0, "Whiscash is extremely territorial. Just one of these Pokémon will claim a large pond as its exclusive territory. If a foe approaches it, it thrashes about and triggers a massive earthquake.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/340.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/340.png", "Whiscash", 242.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 335,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 141.0, 99.0, "Corphish were originally foreign Pokémon that were imported as pets. They eventually turned up in the wild. This Pokémon is very hardy and has greatly increased its population.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/341.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/341.png", "Corphish", 125.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 336,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 224.0, 142.0, "Crawdaunt has an extremely violent nature that compels it to challenge other living things to battle. Other life-forms refuse to live in ponds inhabited by this Pokémon, making them desolate places.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/342.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/342.png", "Crawdaunt", 160.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 337,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 77.0, 124.0, "Baltoy moves while spinning around on its one foot. Primitive wall paintings depicting this Pokémon living among people were discovered in some ancient ruins.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/343.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/343.png", "Baltoy", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 338,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 140.0, 229.0, "Claydol are said to be dolls of mud made by primitive humans and brought to life by exposure to a mysterious ray. This Pokémon moves about while levitating.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/344.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/344.png", "Claydol", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 339,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 105.0, 150.0, "Lileep became extinct approximately a hundred million years ago. This ancient Pokémon attaches itself to a rock on the seafloor and catches approaching prey using tentacles shaped like flower petals.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/345.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/345.png", 0.875f, "Lileep", 165.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 340,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 152.0, 194.0, "Cradily roams around the ocean floor in search of food. This Pokémon freely extends its tree trunk-like neck and captures unwary prey using its eight tentacles.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/346.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/346.png", 0.875f, "Cradily", 200.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 341,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 176.0, 100.0, "Anorith was regenerated from a prehistoric fossil. This primitive Pokémon once lived in warm seas. It grips its prey firmly between its two large claws.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/347.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/347.png", 0.875f, "Anorith", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 342,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 222.0, 174.0, "Armaldo's tough armor makes all attacks bounce off. This Pokémon's two enormous claws can be freely extended or contracted. They have the power to punch right through a steel slab.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/348.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/348.png", 0.875f, "Armaldo", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 343,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 29.0, 85.0, "Feebas's fins are ragged and tattered from the start of its life. Because of its shoddy appearance, this Pokémon is largely ignored. It is capable of living in both the sea and in rivers.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/349.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/349.png", 0.5f, "Feebas", 85.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 344,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 192.0, 219.0, "Milotic is said to be the most beautiful of all the Pokémon. It has the power to becalm such emotions as anger and hostility to quell bitter feuding.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/350.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/350.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/350.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/350.png", 0.5f, "Milotic", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 345,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 139.0, 139.0, "Castform's appearance changes with the weather. This Pokémon gained the ability to use the vast power of nature to protect its tiny body.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/351.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/351.png", 0.5f, "Castform", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 346,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 161.0, 189.0, "Kecleon is capable of changing its body colors at will to blend in with its surroundings. There is one exception—this Pokémon can't change the zigzag pattern on its belly.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/352.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/352.png", false, 0.5f, "Kecleon", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 347,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 138.0, 65.0, "Shuppet is attracted by feelings of jealousy and vindictiveness. If someone develops strong feelings of vengeance, this Pokémon will appear in a swarm and line up beneath the eaves of that person's home.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/353.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/353.png", 0.5f, "Shuppet", 127.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 348,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 218.0, 126.0, "Banette generates energy for laying strong curses by sticking pins into its own body. This Pokémon was originally a pitiful plush doll that was thrown away.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/354.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/354.png", 0.5f, "Banette", 162.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 349,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name" },
                values: new object[] { 70.0, 162.0, "Duskull can pass through any wall no matter how thick it may be. Once this Pokémon chooses a target, it will doggedly pursue the intended victim until the break of dawn.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/355.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/355.png", "Duskull" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 350,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 124.0, 234.0, "Dusclops's body is completely hollow—there is nothing at all inside. It is said that its body is like a black hole. This Pokémon will absorb anything into its body, but nothing will ever come back out.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/356.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/356.png", null, "Dusclops", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 351,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 136.0, 163.0, "The bunches of fruit around Tropius's neck are very popular with children. This Pokémon loves fruit, and eats it continuously. Apparently, its love for fruit resulted in its own outgrowth of fruit.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/357.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/357.png", "Tropius", 223.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 352,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "isActive", "name", "stamina" },
                values: new object[] { 175.0, 170.0, "Chimecho makes its cries echo inside its hollow body. When this Pokémon becomes enraged, its cries result in ultrasonic waves that have the power to knock foes flying.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/358.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/358.png", true, "Chimecho", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 353,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 246.0, 120.0, "Every time Absol appears before people, it is followed by a disaster such as an earthquake or a tidal wave. As a result, it came to be known as the disaster Pokémon.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/359.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/359.png", "Absol", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 354,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 41.0, 86.0, "Wynaut can always be seen with a big, happy smile on its face. Look at its tail to determine if it is angry. When angered, this Pokémon will be slapping the ground with its tail.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/360.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/360.png", "Wynaut", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 355,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 95.0, 95.0, "Snorunt live in regions with heavy snowfall. In seasons without snow, such as spring and summer, this Pokémon steals away to live quietly among stalactites and stalagmites deep in caverns.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/361.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/361.png", "Snorunt", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 356,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 162.0, 162.0, "Glalie has a body made of rock, which it hardens with an armor of ice. This Pokémon has the ability to freeze moisture in the atmosphere into any shape it desires.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/362.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/362.png", "Glalie", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 357,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 95.0, 90.0, "Spheal is much faster rolling than walking to get around. When groups of this Pokémon eat, they all clap at once to show their pleasure. Because of this, their mealtimes are noisy.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/363.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/363.png", "Spheal", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 358,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 137.0, 132.0, "Sealeo has the habit of always juggling on the tip of its nose anything it sees for the first time. This Pokémon occasionally entertains itself by balancing and rolling a Spheal on its nose.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/364.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/364.png", "Sealeo", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 359,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 182.0, 176.0, "Walrein's two massively developed tusks can totally shatter blocks of ice weighing 10 tons with one blow. This Pokémon's thick coat of blubber insulates it from subzero temperatures.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/365.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/365.png", "Walrein", 242.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 360,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 133.0, 135.0, "Clamperl's sturdy shell is not only good for protection—it is also used for clamping and catching prey. A fully grown Clamperl's shell will be scored with nicks and scratches all over.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/366.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/366.png", "Clamperl", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 361,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 197.0, 179.0, "Huntail's presence went unnoticed by people for a long time because it lives at extreme depths in the sea. This Pokémon's eyes can see clearly even in the murky dark depths of the ocean.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/367.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/367.png", "Huntail", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 362,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 211.0, 179.0, "Gorebyss lives in the southern seas at extreme depths. Its body is built to withstand the enormous pressure of water at incredible depths. Because of this, this Pokémon's body is unharmed by ordinary attacks.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/368.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/368.png", "Gorebyss", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 363,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 162.0, 203.0, "Relicanth is a Pokémon species that existed for a hundred million years without ever changing its form. This ancient Pokémon feeds on microscopic organisms with its toothless mouth.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/369.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/369.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/369.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/369.png", 0.875f, "Relicanth", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 364,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 81.0, 128.0, "Luvdisc live in shallow seas in the tropics. This heart-shaped Pokémon earned its name by swimming after loving couples it spotted in the ocean's waves.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/370.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/370.png", 0.25f, "Luvdisc", 125.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 365,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 134.0, 93.0, "Bagon has a dream of one day soaring in the sky. In doomed efforts to fly, this Pokémon hurls itself off cliffs. As a result of its dives, its head has grown tough and as hard as tempered steel.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/371.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/371.png", "Bagon", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 366,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 172.0, 155.0, "Inside Shelgon's armor-like shell, cells are in the midst of transformation to create an entirely new body. This Pokémon's shell is extremely heavy, making its movements sluggish.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/372.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/372.png", "Shelgon", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 367,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 277.0, 168.0, "Salamence came about as a result of a strong, long-held dream of growing wings. It is said that this powerful desire triggered a sudden mutation in this Pokémon's cells, causing it to sprout its magnificent wings.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/373.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/373.png", "Salamence", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 368,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 96.0, 132.0, "Instead of blood, a powerful magnetic force courses throughout Beldum's body. This Pokémon communicates with others by sending controlled pulses of magnetism.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/374.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/374.png", 0f, "Beldum", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 369,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 138.0, 176.0, "When two Beldum fuse together, Metang is formed. The brains of the Beldum are joined by a magnetic nervous system. By linking its brains magnetically, this Pokémon generates strong psychokinetic power.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/375.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/375.png", null, 0f, "Metang", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 370,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 257.0, 228.0, "Metagross has four brains in total. Combined, the four brains can breeze through difficult calculations faster than a supercomputer. This Pokémon can float in the air by tucking in its four legs.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/376.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/376.png", 0f, "Metagross", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 371,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 179.0, 309.0, "Regirock was sealed away by people long ago. If this Pokémon's body is damaged in battle, it is said to seek out suitable rocks on its own to repair itself.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/377.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/377.png", 0f, "Regirock", "Legendary", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 372,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 179.0, 309.0, "Regice's body was made during an ice age. The deep-frozen body can't be melted, even by fire. This Pokémon controls frigid air of -328 degrees Fahrenheit.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/378.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/378.png", 0f, "Regice", "Legendary", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 373,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 143.0, 285.0, "Registeel has a body that is harder than any kind of metal. Its body is apparently hollow. No one has any idea what this Pokémon eats.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/379.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/379.png", 0f, "Registeel", "Legendary", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 374,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 228.0, 246.0, "Latias is highly sensitive to the emotions of people. If it senses any hostility, this Pokémon ruffles the feathers all over its body and cries shrilly to intimidate the foe.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/380.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/380.png", "Latias", "Legendary", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 375,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 268.0, 212.0, "Latios has the ability to make others see an image of what it has seen or imagines in its head. This Pokémon is intelligent and understands human speech.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/381.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/381.png", 1f, "Latios", "Legendary", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 376,
                columns: new[] { "attack", "description", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 270.0, "Through Primal Reversion and with nature's full power, it will take back its true form. It can summon storms that cause the sea levels to rise.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/382.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/382.png", "Kyogre", "Legendary", 205.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 377,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 270.0, 228.0, "Groudon is said to be the personification of the land itself. Legends tell of its many clashes against Kyogre, as each sought to gain the power of nature.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/383.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/383.png", "Groudon", 205.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 378,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 284.0, 170.0, "Rayquaza is said to have lived for hundreds of millions of years. Legends remain of how it put to rest the clash between Kyogre and Groudon.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/384.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/384.png", "Rayquaza", 213.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 379,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 210.0, 210.0, "A legend states that Jirachi will make true any wish that is written on notes attached to its head when it awakens. If this Pokémon senses danger, it will fight without awakening.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/385.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/385.png", "Jirachi", "Mythical", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 380,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 119.0, 110.0, "It undertakes photosynthesis with its body, making oxygen. The leaf on its head wilts if it is thirsty.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/387.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/387.png", 0.875f, "Turtwig", "common", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 381,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 157.0, 143.0, "It knows where pure water wells up. It carries fellow Pokémon there on its back.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/388.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/388.png", 0.875f, "Grotle", "common", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 382,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 202.0, 188.0, "Small Pokémon occasionally gather on its unmoving back to begin building their nests.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/389.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/389.png", 0.875f, "Torterra", "common", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 383,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 113.0, 86.0, "The gas made in its belly burns from its rear end. The fire burns weakly when it feels sick.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/390.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/390.png", 0.875f, "Chimchar", "common", 127.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 384,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 158.0, 105.0, "It uses ceilings and walls to launch aerial attacks. Its fiery tail is but one weapon.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/391.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/391.png", 0.875f, "Monferno", "common", 162.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 385,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 222.0, 151.0, "It tosses its enemies around with agility. It uses all its limbs to fight in its own unique style.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/392.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/392.png", 0.875f, "Infernape", "common", 183.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 387,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 150.0, 139.0, "It lives a solitary life. Its wings deliver wicked blows that can snap even the thickest of trees.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/394.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/394.png", "Prinplup", 162.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 388,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 210.0, 186.0, "The three horns that extend from its beak attest to its power. The leader has the biggest horns.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/395.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/395.png", "Empoleon", 197.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 389,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 101.0, 58.0, "They flock around mountains and fields, chasing after bug Pokémon. Their singing is noisy and annoying.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/396.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/396.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/396.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/396.png", 0.5f, "Starly", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 390,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 142.0, 94.0, "It lives in forests and fields. Squabbles over territory occur when flocks collide.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/397.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/397.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/397.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/397.png", 0.5f, "Staravia", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 391,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 234.0, 140.0, "When Staravia evolve into Staraptor, they leave the flock to live alone. They have sturdy wings.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/398.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/398.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/398.png", 0.5f, "Staraptor", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 392,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 80.0, 73.0, "It constantly gnaws on logs and rocks to whittle down its front teeth. It nests alongside water.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/399.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/399.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/399.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/399.png", 0.5f, "Bidoof", 153.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 393,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 162.0, 119.0, "It makes its nest by damming streams with bark and mud. It is known as an industrious worker.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/400.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/400.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/400.png", 0.5f, "Bibarel", 188.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 394,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 45.0, 74.0, "When its antennae hit each other, it sounds like the music of a xylophone.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/401.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/401.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/401.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/401.png", 0.5f, "Kricketot", 114.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 395,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 160.0, 100.0, "It signals its emotions with its melodies. Scientists are studying these melodic patterns.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/402.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/402.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/402.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/402.png", 0.5f, "Kricketune", 184.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 396,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 117.0, 64.0, "All of its fur dazzles if danger is sensed. It flees while the foe is momentarily blinded.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/403.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/403.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/403.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/403.png", "Shinx", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 397,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 159.0, 95.0, "Strong electricity courses through the tips of its sharp claws. A light scratch causes fainting in foes.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/404.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/404.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/404.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/404.png", "Luxio", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 398,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 232.0, 156.0, "Luxray's ability to see through objects comes in handy when it's scouting for danger.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/405.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/405.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/405.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/405.png", "Luxray", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 399,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 91.0, 109.0, "Over the winter, it closes its bud and endures the cold. In spring, the bud opens and releases pollen.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/406.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/406.png", null, "Budew", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 400,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 243.0, 185.0, "With the movements of a dancer, it strikes with whips that are densely lined with poison thorns.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/407.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/407.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/407.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/407.png", "Roserade", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 401,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 218.0, 71.0, "Its hard skull is its distinguishing feature. It snapped trees by headbutting them, and then it fed on their ripe berries.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/408.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/408.png", null, 0.875f, "Cranidos", 167.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 402,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 295.0, 109.0, "This ancient Pokémon used headbutts skillfully. Its brain was really small, so some theories suggest that its stupidity led to its extinction.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/409.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/409.png", null, 0.875f, "Rampardos", 219.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 403,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 76.0, 195.0, "Although its fossils can be found in layers of primeval rock, nothing but its face has ever been discovered.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/410.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/410.png", null, 0.875f, "Shieldon", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 404,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name" },
                values: new object[] { 94.0, 286.0, "This Pokémon is from roughly 100 million years ago. Its terrifyingly tough face is harder than steel.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/411.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/411.png", null, 0.875f, "Bastiodon" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 405,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 53.0, 83.0, "If its cloak is broken in battle, it quickly remakes the cloak with materials nearby.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/412.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/412.png", null, "Burmy", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 406,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 141.0, 180.0, "When Burmy evolved, its cloak became a part of this Pokémon's body. The cloak is never shed.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/413.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/413.png", 0f, "Wormadam", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 407,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 185.0, 98.0, "It flutters around at night and steals honey from the Combee hive.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/414.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/414.png", null, 1f, "Mothim", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 408,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 59.0, 83.0, "It collects and delivers honey to its colony. At night, they cluster to form a beehive and sleep.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/415.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/415.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/415.png", "Combee", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 409,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 149.0, 190.0, "Its abdomen is a honeycomb for grubs. It raises its grubs on honey collected by Combee.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/416.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/416.png", 0f, "Vespiquen", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 410,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 94.0, 172.0, "A pair may be seen rubbing their cheek pouches together in an effort to share stored electricity.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/417.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/417.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/417.png", 0.5f, "Pachirisu", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 411,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 132.0, 67.0, "It inflates the flotation sac around its neck and pokes its head out of the water to see what is going on.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/418.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/418.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/418.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/418.png", 0.5f, "Buizel", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 412,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 221.0, 114.0, "Its flotation sac developed as a result of pursuing aquatic prey. It can double as a rubber raft.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/419.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/419.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/419.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/419.png", "Floatzel", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 413,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 108.0, 92.0, "It evolves by sucking the energy out of the small ball where it had been storing nutrients.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/420.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/420.png", 0.5f, "Cherubi", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 414,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name" },
                values: new object[] { 170.0, 153.0, "If it senses strong sunlight, it opens its folded petals to absorb the sun's rays with its whole body.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/421.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/421.png", 0.5f, "Cherrim" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 415,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 205.0, 143.0, "It uses its tails for everything. If it wraps both of its tails around you and gives you a squeeze, that's proof it really likes you.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/424.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/424.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/424.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/424.png", 0.5f, "Ambipom", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 416,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 117.0, 80.0, "Wandering souls gathered together to form this Pokémon. When trying to make friends with children, Drifloon grabs them by the hand.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/425.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/425.png", 0.5f, "Drifloon", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 417,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 180.0, 102.0, "The raw material for the gas inside its body is souls. When its body starts to deflate, it's thought to carry away people and Pokémon.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/426.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/426.png", null, "Drifblim", 312.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 418,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name" },
                values: new object[] { 130.0, 105.0, "The reason it keeps one ear rolled up is so it can launch a swift counterattack if it's attacked by an enemy.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/427.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/427.png", null, "Buneary" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 419,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 156.0, 194.0, "It's notably wary and has a dislike of fighting, but at the same time, it can deliver powerful kicks with its lithe legs.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/428.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/428.png", null, "Lopunny", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 420,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 211.0, 187.0, "Its muttered curses can cause awful headaches or terrifying visions that torment others.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/429.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/429.png", "Mismagius", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 421,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 243.0, 103.0, "Its goons take care of most of the fighting for it. The only time it dirties its own hands is in delivering a final blow to finish off an opponent.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/430.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/430.png", "Honchkrow", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 424,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 114.0, 94.0, "There is an orb inside its mouth. When it hops, the orb bounces all over and makes a ringing sound.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/433.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/433.png", null, "Chingling", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 425,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 121.0, 90.0, "It protects itself by spraying a noxious fluid from its rear. The stench lingers for 24 hours.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/434.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/434.png", "Stunky", 160.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 426,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 184.0, 132.0, "It sprays a stinky fluid from its tail. The fluid smells worse the longer it is allowed to fester.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/435.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/435.png", "Skuntank", 230.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 427,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 43.0, 154.0, "Implements shaped like it were discovered in ancient tombs. It is unknown if they are related.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/436.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/436.png", 0f, "Bronzor", 149.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 428,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 161.0, 213.0, "Ancient people believed that petitioning Bronzong for rain was the way to make crops grow.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/437.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/437.png", 0f, "Bronzong", 167.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 429,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 124.0, 133.0, "If its body gets too damp, it will die. So, in a process reminiscent of sweating, its eyes expel moisture.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/438.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/438.png", "Bonsly", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 430,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name" },
                values: new object[] { 25.0, 77.0, "When it sees something round and white, Happiny puts it into the pouch on its stomach. It sometimes becomes overloaded and can't move.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/440.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/440.png", 0f, "Happiny" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 431,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 183.0, 91.0, "It can learn and speak human words. If they gather, they all learn the same saying.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/441.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/441.png", 0.5f, "Chatot", 183.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 432,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 169.0, 199.0, "It was bound to a fissure in an odd keystone as punishment for misdeeds 500 years ago.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/442.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/442.png", 0.5f, "Spiritomb", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 433,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 124.0, 84.0, "Its original home is an area much hotter than Alola. If you're planning to live with one, your heating bill will soar.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/443.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/443.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/443.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/443.png", "Gible", 151.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 434,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 172.0, 125.0, "It sheds its skin and gradually grows larger. Its scales can be ground into a powder and used as raw materials for traditional medicine.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/444.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/444.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/444.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/444.png", "Gabite", 169.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 435,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 261.0, 193.0, "Its fine scales don't just reduce wind resistance—their sharp edges also cause injury to any opponent who attacks it.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/445.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/445.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/445.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/445.png", "Garchomp", 239.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 436,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 137.0, 117.0, "Anything that looks edible, Munchlax will go on and swallow whole. Its stomach is tough enough to handle it even if the food has gone rotten.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/446.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/446.png", 0.875f, "Munchlax", 286.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 437,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 127.0, 78.0, "It uses waves called auras to communicate with others of its kind. It doesn't make any noise during this time, so its enemies can't detect it.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/447.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/447.png", 0.875f, "Riolu", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 438,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 236.0, 144.0, "Lucario reads its opponent's feelings with its aura waves. It finds out things it would rather not know, so it gets stressed out easily.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/448.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/448.png", 0.875f, "Lucario", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 440,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 201.0, 191.0, "It blasts internally stored sand from ports on its body to create a towering twister for attack.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/450.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/450.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/450.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/450.png", 0.5f, "Hippowdon", 239.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 441,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 93.0, 151.0, "It burrows under the sand to lie in wait for prey. Its tail claws can inject its prey with a savage poison.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/451.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/451.png", "Skorupi", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 442,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 180.0, 202.0, "It has the power in its clawed arms to make scrap of a car. The tips of its claws release poison.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/452.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/452.png", "Drapion", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 443,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 116.0, 76.0, "Inflating its poison sacs, it fills the area with an odd sound and hits flinching opponents with a poison jab.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/453.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/453.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/453.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/453.png", "Croagunk", 134.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 444,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 211.0, 133.0, "Its knuckle claws secrete a toxin so vile that even a scratch could prove fatal.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/454.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/454.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/454.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/454.png", "Toxicroak", 195.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 445,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 187.0, 136.0, "It binds itself to trees in marshes. It attracts prey with its sweet-smelling drool and gulps them down.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/455.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/455.png", null, "Carnivine", 179.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 446,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 96.0, 116.0, "It lures in prey with its shining tail fins. It stays near the surface during the day and moves to the depths when night falls.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/456.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/456.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/456.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/456.png", 0.5f, "Finneon", 135.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 447,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 142.0, 170.0, "They traverse the deep waters as if crawling over the seafloor. The fantastic lights of its fins shine like stars in the night sky.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/457.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/457.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/457.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/457.png", 0.5f, "Lumineon", 170.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 448,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 105.0, 179.0, "Mantyke are friendly toward people and will approach boats closely. The patterns on their backs differ depending on their habitat.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/458.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/458.png", 0.5f, "Mantyke", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 449,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 115.0, 105.0, "In the spring, it grows berries with the texture of frozen treats around its belly.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/459.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/459.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/459.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/459.png", "Snover", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 450,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 178.0, 158.0, "It lives a quiet life on mountains that are perpetually covered in snow. It hides itself by whipping up blizzards.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/460.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/460.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/460.png", "Abomasnow", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 451,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 243.0, 171.0, "Thanks to its increased intelligence, scrapping over food is a thing of the past. A scratch from its claws will give you a case of frostbite!", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/461.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/461.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/461.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/461.png", "Weavile", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 452,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name" },
                values: new object[] { 238.0, 205.0, "There are still people who believe that this Pokémon came from outer space. It emanates a powerful magnetic field.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/462.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/462.png", 0f, "Magnezone" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 453,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 161.0, 181.0, "It uses its tongue much more skillfully than its hands or its feet. It can deftly pick up a single small bean with its tongue.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/463.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/463.png", null, "Lickilicky", 242.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 454,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 241.0, 190.0, "It puts rocks in holes in its palms and uses its muscles to shoot them. Geodude are shot at rare times.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/464.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/464.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/464.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/464.png", "Rhyperior", 251.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 455,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 207.0, 184.0, "Its vines grow so profusely that, in the warm season, you can't even see its eyes.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/465.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/465.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/465.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/465.png", "Tangrowth", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 456,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 249.0, 163.0, "A single Electivire can provide enough electricity for all the buildings in a big city for a year.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/466.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/466.png", null, 0.75f, "Electivire", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 457,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 247.0, 172.0, "Magmortar takes down its enemies by shooting fireballs, which burn them to a blackened crisp. It avoids this method when hunting prey.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/467.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/467.png", null, 0.75f, "Magmortar", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 458,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 225.0, 217.0, "It shares many blessings with people who respect one another's rights and avoid needless strife.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/468.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/468.png", 0.875f, "Togekiss", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 459,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 231.0, 156.0, "This six-legged Pokémon is easily capable of transporting an adult in flight. The wings on its tail help it stay balanced.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/469.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/469.png", null, "Yanmega", 200.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 460,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 216.0, 219.0, "It gets its nutrition from photosynthesis. It lives a quiet life deep in forests where clean rivers flow.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/470.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/470.png", null, 0.875f, "Leafeon", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 461,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 238.0, 205.0, "It can instantaneously freeze any moisture that's around it, creating ice pellets to shoot at its prey.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/471.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/471.png", null, 0.875f, "Glaceon", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 462,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 185.0, 222.0, "Its flight is soundless. It uses its lengthy tail to carry off its prey... Then its elongated fangs do the rest.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/472.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/472.png", 0.5f, "Gliscor", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 463,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name" },
                values: new object[] { 247.0, 146.0, "Its impressive tusks are made of ice. The population thinned when it turned warm after the ice age.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/473.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/473.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/473.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/473.png", "Mamoswine" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 464,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 264.0, 150.0, "A faulty update was added to its programming. Its behavior is noticeably strange, so the experiment may have been a failure.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/474.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/474.png", null, 0f, "Porygon-Z", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 465,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 237.0, 195.0, "A master of courtesy and swordsmanship, it fights using extending swords on its elbows.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/475.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/475.png", null, 1f, "Gallade", 169.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 466,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 135.0, 275.0, "It uses three small units to catch prey and battle enemies. The main body mostly just gives orders.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/476.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/476.png", 0.5f, "Probopass", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 467,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 180.0, 254.0, "The antenna on its head captures radio waves from the world of spirits that command it to take people there.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/477.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/477.png", 0.5f, "Dusknoir", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 468,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 171.0, 150.0, "It's said that on nights of terrible blizzards, it comes down to human settlements. If you hear it knocking at your door, do not open it!", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/478.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/478.png", 0f, "Froslass", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 469,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 185.0, 159.0, "Its body is composed of plasma. It is known to infiltrate electronic devices and wreak havoc.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/479.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/479.png", false, 0f, "Rotom", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 470,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 156.0, 270.0, "It is said that its emergence gave humans the intelligence to improve their quality of life.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/480.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/480.png", 0f, "Uxie", "Legendary", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 471,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 212.0, 212.0, "It sleeps at the bottom of a lake. Its spirit is said to leave its body to fly on the lake's surface.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/481.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/481.png", 0f, "Mesprit", "Legendary", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 472,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity" },
                values: new object[] { 270.0, 151.0, "It is thought that Uxie, Mesprit, and Azelf all came from the same egg.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/482.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/482.png", 0f, "Azelf", "Legendary" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 473,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 275.0, 211.0, "It has the power to control time. It appears in Sinnoh-region myths as an ancient deity.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/483.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/483.png", null, 0f, "Dialga", "Legendary", 205.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 474,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 280.0, 215.0, "It has the ability to distort space. It is described as a deity in Sinnoh-region mythology.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/484.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/484.png", "Palkia", "Legendary", 189.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 475,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 251.0, 213.0, "Boiling blood, like magma, circulates through its body. It makes its dwelling place in volcanic caves.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/485.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/485.png", 0.5f, "Heatran", "Legendary", 209.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 476,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 287.0, 210.0, "There is an enduring legend that states this Pokémon towed continents with ropes.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/486.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/486.png", 0f, "Regigigas", "Legendary", 221.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 477,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 187.0, 225.0, "It was banished for its violence. It silently gazed upon the old world from the Distortion World.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/487.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/487.png", 0f, "Giratina", "Legendary", 284.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 478,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 152.0, 258.0, "Those who sleep holding Cresselia's feather are assured of joyful dreams. It is said to represent the crescent moon.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/488.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/488.png", "Cresselia", "Legendary", 260.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 479,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 162.0, 162.0, "It drifts in warm seas. It always returns to where it was born, no matter how far it may have drifted.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/489.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/489.png", "Phione", "Mythical", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 480,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "isActive", "name", "rarity", "stamina" },
                values: new object[] { 210.0, 210.0, "It starts its life with a wondrous power that permits it to bond with any kind of Pokémon.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/490.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/490.png", false, "Manaphy", "Mythical", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 481,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 285.0, 198.0, "It can lull people to sleep and make them dream. It is active during nights of the new moon.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/491.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/491.png", "Darkrai", "Mythical", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 482,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "isActive", "name", "rarity", "stamina" },
                values: new object[] { 210.0, 210.0, "The blooming of Gracidea flowers confers the power of flight upon it. Feelings of gratitude are the message it delivers.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/492.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/492.png", false, "Shaymin", "Mythical", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 483,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 210.0, 210.0, "When it shares the infinite energy it creates, that being's entire body will be overflowing with power.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/494.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/494.png", "Victini", "Mythical", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 484,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 88.0, 107.0, "They photosynthesize by bathing their tails in sunlight. When they are not feeling well, their tails droop.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/495.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/495.png", 0.875f, "Snivy", "common", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 485,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 122.0, 152.0, "When it gets dirty, its leaves can't be used in photosynthesis, so it always keeps itself clean.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/496.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/496.png", 0.875f, "Servine", "common", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 486,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 161.0, 204.0, "It can stop its opponents' movements with just a glare. It takes in solar energy and boosts it internally.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/497.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/497.png", 0.875f, "Serperior", "common", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 487,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 115.0, 85.0, "It loves to eat roasted berries, but sometimes it gets too excited and burns them to a crisp.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/498.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/498.png", 0.875f, "Tepig", "common", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 488,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 173.0, 106.0, "When its internal fire flares up, its movements grow sharper and faster. When in trouble, it emits smoke.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/499.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/499.png", 0.875f, "Pignite", "common", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 489,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 235.0, 127.0, "It has mastered fast and powerful fighting moves. It grows a beard of fire.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/500.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/500.png", true, 0.875f, "Emboar", "common", 242.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 490,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 117.0, 85.0, "It fights using the scalchop on its stomach. In response to an attack, it retaliates immediately by slashing.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/501.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/501.png", true, 0.875f, "Oshawott", "common", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 491,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 159.0, 116.0, "As a result of strict training, each Dewott learns different forms for using the scalchops.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/502.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/502.png", 0.875f, "Dewott", "common", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 492,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 212.0, 157.0, "One swing of the sword incorporated in its armor can fell an opponent. A simple glare from one of them quiets everybody.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/503.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/503.png", true, 0.875f, "Samurott", "common", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 494,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 165.0, 139.0, "When they see an enemy, their tails stand high, and they spit the seeds of berries stored in their cheek pouches.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/505.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/505.png", 0.5f, "Watchog", "common", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 495,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name" },
                values: new object[] { 107.0, 86.0, "This Pokémon is popular with beginners because it's intelligent, obedient to its Trainer's commands, and easy to raise.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/506.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/506.png", 0.5f, "Lillipup" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 496,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 145.0, 126.0, "It has been living with people for so long that portrayals of it can be found on the walls of caves from long, long ago.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/507.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/507.png", 0.5f, "Herdier", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 497,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 206.0, 182.0, "Its fur is long and thick. A long time ago in cold regions, every household kept a Stoutland.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/508.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/508.png", 0.5f, "Stoutland", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 498,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 98.0, 73.0, "They steal from people for fun, but their victims can't help but forgive them. Their deceptively cute act is perfect.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/509.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/509.png", 0.5f, "Purrloin", 121.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 499,
                columns: new[] { "attack", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 187.0, "Stealthily, it sneaks up on its target, striking from behind before its victim has a chance to react.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/510.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/510.png", 0.5f, "Liepard", 162.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 500,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 104.0, 94.0, "It's good at finding berries and gathers them from all over. It's kind enough to share them with friends.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/511.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/511.png", "Pansage", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 501,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 206.0, 133.0, "Ill tempered, it fights by swinging its barbed tail around wildly. The leaf growing on its head is very bitter.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/512.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/512.png", "Simisage", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 502,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 104.0, 94.0, "This Pokémon lives in caves in volcanoes. The fire within the tuft on its head can reach 600 degrees Fahrenheit.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/513.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/513.png", "Pansear", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 503,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 206.0, 133.0, "When it gets excited, embers rise from its head and tail and it gets hot. For some reason, it loves sweets.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/514.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/514.png", "Simisear", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 504,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 104.0, 94.0, "The water stored inside the tuft on its head is full of nutrients. Plants that receive its water grow large.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/515.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/515.png", 0.875f, "Panpour", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 505,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 206.0, 133.0, "It prefers places with clean water. When its tuft runs low, it replenishes it by siphoning up water with its tail.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/516.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/516.png", 0.875f, "Simipour", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 506,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 111.0, 92.0, "It eats the dreams of people and Pokémon. When it eats a pleasant dream, it expels pink-colored mist.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/517.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/517.png", "Munna", 183.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 507,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 183.0, 166.0, "The dream mist coming from its forehead changes into many different colors depending on the dream that was eaten.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/518.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/518.png", "Musharna", 253.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 508,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 98.0, 80.0, "These Pokémon live in cities. They are accustomed to people. Flocks often gather in parks and plazas.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/519.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/519.png", "Pidove", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 509,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 144.0, 107.0, "No matter where in the world it goes, it knows where its nest is, so it never gets separated from its Trainer.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/520.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/520.png", "Tranquill", 158.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 510,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 226.0, 146.0, "Males have plumage on their heads. They will never let themselves feel close to anyone other than their Trainers.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/521.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/521.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/521.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/521.png", "Unfezant", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 511,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 118.0, 64.0, "Its mane shines when it discharges electricity. They use the frequency and rhythm of these flashes to communicate.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/522.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/522.png", 0.5f, "Blitzle", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 512,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name" },
                values: new object[] { 211.0, 136.0, "They have lightning-like movements. When Zebstrika run at full speed, the sound of thunder reverberates.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/523.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/523.png", 0.5f, "Zebstrika" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 513,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 121.0, 110.0, "It was found in a fissure in a layer of exposed rock. The material that makes up its body is dirt from several hundred years ago.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/524.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/524.png", 0.5f, "Roggenrola", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 514,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 174.0, 143.0, "Its orange crystals are lumps of powerful energy. They're valuable, so Boldore is sometimes targeted for them.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/525.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/525.png", 0.5f, "Boldore", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 515,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 226.0, 201.0, "It absorbs rays of sunlight and shoots out energy. It's usually lurking deep beneath the surface.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/526.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/526.png", 0.5f, "Gigalith", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 516,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 107.0, 85.0, "The heart-shaped mark left on a body after a Woobat has been attached to it is said to bring good fortune.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/527.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/527.png", 0.5f, "Woobat", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 517,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 161.0, 119.0, "Anyone who comes into contact with the ultrasonic waves emitted by a courting male experiences a positive mood shift.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/528.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/528.png", "Swoobat", 167.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 518,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 154.0, 85.0, "By spinning its body, it can dig straight through the ground at a speed of 30 mph.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/529.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/529.png", "Drilbur", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 519,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 255.0, 129.0, "More than 300 feet below the surface, they build mazelike nests. Their activity can be destructive to subway tunnels.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/530.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/530.png", "Excadrill", 242.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 520,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 114.0, 163.0, "It touches others with the feelers on its ears, using the sound of their heartbeats to tell how they are feeling.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/531.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/531.png", "Audino", 230.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 521,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 134.0, 87.0, "Always carrying squared logs, they help out with construction. As they grow, they carry bigger logs.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/532.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/532.png", null, 0.75f, "Timburr", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 522,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 180.0, 134.0, "This Pokémon is so muscular and strongly built that even a group of wrestlers could not make it budge an inch.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/533.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/533.png", 0.75f, "Gurdurr", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 523,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 243.0, 158.0, "Rather than rely on force, they master moves that utilize the centrifugal force of spinning concrete.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/534.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/534.png", 0.75f, "Conkeldurr", 233.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 524,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 98.0, 78.0, "By vibrating its cheeks, it emits sound waves imperceptible to humans. It uses the rhythm of these sounds to talk.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/535.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/535.png", "Tympole", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 525,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 128.0, 109.0, "It lives in the water and on land. It uses its long, sticky tongue to immobilize its opponents.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/536.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/536.png", "Palpitoad", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 526,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 188.0, 150.0, "They shoot paralyzing liquid from their head bumps. They use vibration to hurt their opponents.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/537.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/537.png", "Seismitoad", 233.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 527,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 172.0, 160.0, "When it encounters a foe bigger than itself, it wants to throw it. It changes belts as it gets stronger.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/538.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/538.png", 1f, "Throh", 260.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 528,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 231.0, 153.0, "Tying their belts gets them pumped and makes their punches more destructive. Disturbing their training angers them.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/539.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/539.png", 1f, "Sawk", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 529,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 96.0, 124.0, "Since this Pokémon makes its own clothes out of leaves, it is a popular mascot for fashion designers.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/540.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/540.png", "Sewaddle", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 530,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 115.0, 162.0, "It protects itself from the cold by wrapping up in leaves. It stays on the move, eating leaves in forests.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/541.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/541.png", "Swadloon", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 531,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 205.0, 165.0, "It keeps its eggs warm with heat from fermenting leaves. It also uses leaves to make warm wrappings for Sewaddle.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/542.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/542.png", "Leavanny", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 532,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 83.0, 99.0, "Its bite injects a potent poison, enough to paralyze large bird Pokémon that try to prey on it.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/543.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/543.png", 0.5f, "Venipede", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 533,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 100.0, 173.0, "It is usually motionless, but when attacked, it rotates at high speed and then crashes into its opponent.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/544.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/544.png", 0.5f, "Whirlipede", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 534,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 203.0, 175.0, "With quick movements, it chases down its foes, attacking relentlessly with its horns until it prevails.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/545.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/545.png", 0.5f, "Scolipede", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 535,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 71.0, 111.0, "When attacked, it expels cotton from its body to create a diversion. The cotton it loses grows back in quickly.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/546.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/546.png", "Cottonee", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 536,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 164.0, 176.0, "Whimsicott doesn't live in a fixed location. It floats around on whirling winds, appearing all over the place to perform its mischief.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/547.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/547.png", "Whimsicott", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 537,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 119.0, 91.0, "They prefer clean water and soil. When the environment they live in turns bad, the whole bunch will up and move to a new area.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/548.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/548.png", 0f, "Petilil", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 538,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 214.0, 155.0, "It's well liked by other Pokémon because of its beauty. The flower on its head needs constant care, or it will soon wither and rot.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/549.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/549.png", 0f, "Lilligant", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 539,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 189.0, 129.0, "When a school of Basculin appears in a lake, everything else disappears, except for Corphish and Crawdaunt. That's how violent Basculin are.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/550.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/550.png", 0.5f, "Basculin", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 540,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 132.0, 69.0, "Sandile's still not good at hunting, so it mostly eats things that have collapsed in the desert. It's called “the cleaner of the desert.\"", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/551.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/551.png", "Sandile", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 541,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 155.0, 90.0, "It buries some of its prey in the sand to use as emergency meals when its hunts are unsuccessful.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/552.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/552.png", "Krokorok", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 542,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 229.0, 158.0, "It conceals itself in sandstorms that Flygon whip up and waits patiently for prey to appear.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/553.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/553.png", "Krookodile", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 543,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 153.0, 86.0, "When it sleeps, it pulls its limbs into its body and its internal fire goes down to 1,100 degrees Fahrenheit.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/554.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/554.png", "Darumaka", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 544,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 263.0, 114.0, "Its internal fire burns at 2,500 degrees Fahrenheit, making enough power that it can destroy a dump truck with one punch.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/555.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/555.png", "Darmanitan", 233.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 545,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 201.0, 130.0, "Arid regions are their habitat. They move rhythmically, making a sound similar to maracas.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/556.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/556.png", "Maractus", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 546,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 118.0, 128.0, "When it finds a stone of a suitable size, it secretes a liquid from its mouth to open up a hole to crawl into.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/557.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/557.png", "Dwebble", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 547,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 188.0, 200.0, "Competing for territory, Crustle fight viciously. The one whose boulder is broken is the loser of the battle.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/558.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/558.png", "Crustle", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 548,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 132.0, 132.0, "It stretches its saggy skin up to its neck to protect itself. The saggier their skin, the more respect they garner.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/559.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/559.png", 0.5f, "Scraggy", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 549,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 163.0, 222.0, "It taunts its opponents by spitting. It has a certain territory that it never leaves its whole life long.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/560.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/560.png", 0.5f, "Scrafty", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 550,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 204.0, 167.0, "The guardians of an ancient city, they always fly the same route while keeping watch for invaders.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/561.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/561.png", "Sigilyph", 176.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 551,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 134.0, 146.0, "Its hunting grounds encompassed a broad area, from the land to more than half a mile deep in the ocean.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/564.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/564.png", 0.875f, "Tirtouga", 144.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 552,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 192.0, 197.0, "Carracosta eats every last bit of the prey it catches, even the shells and bones, to further strengthen its sturdy shell.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/565.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/565.png", 0.875f, "Carracosta", 179.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 553,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 213.0, 89.0, "Restored from a fossil, this ancient bird Pokémon has wings but can't yet fly.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/566.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/566.png", 0.875f, "Archen", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 554,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 292.0, 139.0, "Said to be an ancestor of bird Pokémon, the muscles it uses to flap its wings are still weak, so it needs a long runway in order to take off.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/567.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/567.png", 0.875f, "Archeops", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 555,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 96.0, 122.0, "If a young Pokémon or child breathes in the toxic gas that Trubbish belches out, it could be a life-threatening situation.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/568.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/568.png", "Trubbish", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 556,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 181.0, 164.0, "Some say the reason Garbodor in Alola are a little stronger than their counterparts elsewhere is the presence of Muk, their natural enemy.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/569.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/569.png", "Garbodor", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 557,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 153.0, 78.0, "If a normally talkative child suddenly stops talking, it may have been replaced by Zorua.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/570.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/570.png", false, 0.875f, "Zorua", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 558,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 250.0, 127.0, "If it thinks humans are going to discover its den, Zoroark shows them visions that make them wander around in the woods.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/571.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/571.png", false, 0.875f, "Zoroark", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 559,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 98.0, 80.0, "When its tail has gotten dirty from self-cleaning or from cleaning its nest, Minccino spends a whole day washing its tail in clean spring water.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/572.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/572.png", 0.25f, "Minccino", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 560,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 198.0, 130.0, "The oil that seeps from its body is really smooth. For people troubled by bad skin, this oil is an effective treatment.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/573.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/573.png", 0.25f, "Cinccino", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 561,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 98.0, 112.0, "They intently observe both Trainers and Pokémon. Apparently, they are looking at something that only Gothita can see.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/574.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/574.png", 0.25f, "Gothita", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 564,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 170.0, 83.0, "They drive away attackers by unleashing psychic power. They can use telepathy to talk with others.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/577.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/577.png", 0.5f, "Solosis", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 565,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 208.0, 103.0, "When their two divided brains think the same thoughts, their psychic power is maximized.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/578.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/578.png", 0.5f, "Duosion", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 566,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 214.0, 148.0, "When Reuniclus shake hands, a network forms between their brains, increasing their psychic power.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/579.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/579.png", 0.5f, "Reuniclus", 242.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 567,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 84.0, 96.0, "They are better at swimming than flying, and they happily eat their favorite food, peat moss, as they dive underwater.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/580.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/580.png", 0.5f, "Ducklett", 158.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 568,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 182.0, 132.0, "Swanna start to dance at dusk. The one dancing in the middle is the leader of the flock.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/581.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/581.png", "Swanna", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 569,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 118.0, 106.0, "When the morning sun hit an icicle, it wished not to melt, and thus Vanillite was born. At night, it buries itself in snow to sleep.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/582.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/582.png", "Vanillite", 113.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 570,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 151.0, 138.0, "This hearty Pokémon survived the Ice Age. It's incredibly popular in very hot regions.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/583.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/583.png", true, 0.5f, "Vanillish", 139.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 571,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 218.0, 184.0, "Vanilluxe is born when two Vanillish, half-melted by the day's light, stick to each other and freeze together in the cold return of night.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/584.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/584.png", true, 0.5f, "Vanilluxe", 174.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 572,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 115.0, 100.0, "The turning of the seasons changes the color and scent of this Pokémon's fur. People use it to mark the seasons.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/585.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/585.png", 0.5f, "Deerling", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 573,
                columns: new[] { "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 146.0, "They migrate according to the seasons, so some people call Sawsbuck the harbingers of spring.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/586.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/586.png", 0.5f, "Sawsbuck", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 574,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 158.0, 127.0, "As it flies, it scatters electricity around, so bird Pokémon keep their distance. That's why Emolga can keep all its food to itself.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/587.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/587.png", 0.5f, "Emolga", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 575,
                columns: new[] { "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 87.0, "For some reason they evolve when they receive electrical energy while they are attacking Shelmet.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/588.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/588.png", 0.5f, "Karrablast", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 576,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name" },
                values: new object[] { 223.0, 187.0, "These Pokémon evolve by wearing the shell covering of a Shelmet. The steel armor protects their whole body.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/589.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/589.png", 0.5f, "Escavalier" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 577,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 97.0, 91.0, "It lures Pokémon with its pattern that looks just like a Poké Ball, then releases poison spores.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/590.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/590.png", "Foongus", 170.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 578,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 155.0, 139.0, "It lures prey close by dancing and waving its arm caps, which resemble Poké Balls, in a swaying motion.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/591.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/591.png", "Amoonguss", 249.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 579,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 115.0, 134.0, "Using the invisible poison spikes on its veillike arms and legs, it paralyzes its enemies and causes them to drown.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/592.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/592.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/592.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/592.png", 0f, "Frillish", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 580,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 159.0, 178.0, "Fishermen are terrified of Jellicent. It's rumored to drag them into the sea and steal their lives away.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/593.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/593.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/593.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/593.png", 0f, "Jellicent", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 581,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 138.0, 131.0, "The reason it helps Pokémon in a weakened condition is that any Pokémon coming after them may also attack Alomomola.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/594.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/594.png", "Alomomola", 338.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 582,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 110.0, 98.0, "They attach themselves to large-bodied Pokémon and absorb static electricity, which they store in an electric pouch.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/595.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/595.png", "Joltik", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 583,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 201.0, 128.0, "When attacked, they create an electric barrier by spitting out many electrically charged threads.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/596.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/596.png", "Galvantula", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 584,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 82.0, 155.0, "It absorbs the iron it finds in the rock while clinging to the ceiling. It shoots spikes when in danger.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/597.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/597.png", "Ferroseed", 127.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 585,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 158.0, 223.0, "They attach themselves to cave ceilings, firing steel spikes at targets passing beneath them.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/598.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/598.png", "Ferrothorn", 179.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 586,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 98.0, 121.0, "The two minigears that mesh together are predetermined. Each will rebound from other minigears without meshing.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/599.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/599.png", 0f, "Klink", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 587,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 150.0, 174.0, "A minigear and big gear comprise its body. If the minigear it launches at a foe doesn't return, it will die.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/600.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/600.png", 0f, "Klang", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 588,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 199.0, 214.0, "Its red core functions as an energy tank. It fires the charged energy through its spikes into an area.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/601.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/601.png", 0f, "Klinklang", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 589,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 105.0, 78.0, "One alone can emit only a trickle of electricity, so a group of them gathers to unleash a powerful electric shock.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/602.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/602.png", "Tynamo", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 590,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 156.0, 130.0, "These Pokémon have a big appetite. When they spot their prey, they attack it and paralyze it with electricity.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/603.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/603.png", "Eelektrik", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 591,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 217.0, 152.0, "They crawl out of the ocean using their arms. They will attack prey on shore and immediately drag it into the ocean.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/604.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/604.png", "Eelektross", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 592,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name" },
                values: new object[] { 148.0, 100.0, "This Pokémon is shrouded in mystery. It's said to have appeared from a UFO that fell from the sky about 50 years ago.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/605.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/605.png", null, 0.5f, "Elgyem" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 593,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 221.0, 163.0, "It has strong psychic powers. Using its fingers that flash three different colors, it controls its opponents and rewrites their memories.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/606.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/606.png", null, 0.5f, "Beheeyem", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 594,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 108.0, 98.0, "Litwick shines a light that absorbs the life energy of people and Pokémon, which becomes the fuel that it burns.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/607.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/607.png", "Litwick", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 595,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 169.0, 115.0, "It arrives near the moment of death and steals spirit from the body.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/608.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/608.png", "Lampent", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 596,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 271.0, 182.0, "The spirits burned up in its ominous flame lose their way and wander this world forever.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/609.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/609.png", "Chandelure", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 597,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 154.0, 101.0, "They mark their territory by leaving gashes in trees with their tusks. If a tusk breaks, a new one grows in quickly.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/610.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/610.png", "Axew", 130.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 598,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 212.0, 123.0, "A broken tusk will not grow back, so it diligently sharpens its tusks on river rocks after the end of a battle.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/611.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/611.png", "Fraxure", 165.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 599,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 284.0, 172.0, "Their sturdy tusks will stay sharp even if used to cut steel beams. These Pokémon are covered in hard armor.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/612.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/612.png", 0.5f, "Haxorus", 183.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 600,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 128.0, 74.0, "Their snot is a barometer of health. When healthy, their snot is sticky and the power of their ice moves increases.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/613.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/613.png", 0.5f, "Cubchoo", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 601,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 233.0, 152.0, "It freezes its breath to create fangs and claws of ice to fight with. Cold northern areas are its habitat.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/614.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/614.png", 0.5f, "Beartic", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 602,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 190.0, 218.0, "They are composed of ice crystals. They capture prey with chains of ice, freezing the prey at -148 degrees Fahrenheit.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/615.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/615.png", 0f, "Cryogonal", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 603,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 72.0, 140.0, "It evolves when bathed in an electric-like energy along with Karrablast. The reason is still unknown.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/616.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/616.png", "Shelmet", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 604,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 220.0, 120.0, "When its body dries out, it weakens. So, to prevent dehydration, it wraps itself in many layers of thin membrane.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/617.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/617.png", "Accelgor", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 605,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 144.0, 171.0, "It conceals itself in the mud of the seashore. Then it waits. When prey touch it, it delivers a jolt of electricity.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/618.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/618.png", "Stunfisk", 240.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 606,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 160.0, 98.0, "They seclude themselves in the mountains and devote themselves to training. The form of their kicks and chops differs from pack to pack.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/619.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/619.png", "Mienfoo", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 607,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 258.0, 127.0, "When Mienshao lets out a bizarre wail, you're in danger. A flurry of kicks and chops too fast to see is about to be unleashed!", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/620.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/620.png", "Mienshao", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 608,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 213.0, 170.0, "It infiltrates tunnels that Pokémon like Diglett and Dugtrio have dug and quietly waits for prey to pass through.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/621.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/621.png", "Druddigon", 184.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 609,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 127.0, 92.0, "Although ancient people apparently built it by working with clay, the source of its energy is unclear.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/622.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/622.png", 0f, "Golett", 153.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 610,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 222.0, 154.0, "When the seal on its chest is removed, it rages indiscriminately, turning the whole town around it into a mountain of rubble.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/623.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/623.png", 0f, "Golurk", 205.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 611,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 154.0, 114.0, "It follows Bisharp's orders to a tee when it attacks enemies. After slashing an opponent, Pawniard clangs both of its blades together.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/624.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/624.png", "Pawniard", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 612,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 232.0, 176.0, "It leads a group of Pawniard. Bisharp doesn't even change its expression when it deals the finishing blow to an opponent.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/625.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/625.png", "Bisharp", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 613,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 195.0, 182.0, "Their fluffy fur absorbs damage, even if they strike foes with a fierce headbutt.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/626.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/626.png", "Bouffalant", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 614,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 150.0, 97.0, "Known as a natural-born warrior, soon after its hatching, it will challenge its parent to a fight in order to gain their acceptance.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/627.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/627.png", 1f, "Rufflet", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 615,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 232.0, 152.0, "Known as “the hero of the skies,\" this Pokémon is so proud and so brave that it will never retreat, even when it's injured.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/628.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/628.png", 1f, "Braviary", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 616,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 105.0, 139.0, "Its healthy appetite leads to visible growth spurts. It often has to replace the bones it wears as its size increases.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/629.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/629.png", 0f, "Vullaby", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 617,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 129.0, 205.0, "It's always searching for food for Vullaby. When it finds a weak Pokémon, Mandibuzz swoops it right off to its nest.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/630.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/630.png", 0f, "Mandibuzz", 242.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 618,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 204.0, 129.0, "It draws in air through its tail, transforms it into fire, and uses it like a tongue. It melts Durant and eats them.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/631.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/631.png", "Heatmor", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 619,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 217.0, 188.0, "They attack in groups, covering themselves in steel armor to protect themselves from Heatmor.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/632.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/632.png", "Durant", 151.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 620,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 116.0, 93.0, "Lacking sight, it's unaware of its surroundings, so it bumps into things and eats anything that moves.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/633.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/633.png", "Deino", 141.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 621,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 159.0, 135.0, "After it has eaten up all the food in its territory, it moves to another area. Its two heads do not get along.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/634.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/634.png", "Zweilous", 176.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 622,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 256.0, 188.0, "It responds to movement by attacking. This scary, three-headed Pokémon devours everything in its path!", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/635.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/635.png", 0.5f, "Hydreigon", 211.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 623,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 156.0, 107.0, "It protects itself with flame. Long years ago, people believed Larvesta had a nest on the sun.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/636.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/636.png", false, 0.5f, "Larvesta", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 624,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "isActive", "name", "stamina" },
                values: new object[] { 264.0, 189.0, "According to legends, it was hatched from a flaming cocoon to save people and Pokémon that were suffering from the cold.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/637.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/637.png", false, "Volcarona", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 625,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 192.0, 229.0, "It has a body and heart of steel. It worked with its allies to punish people when they hurt Pokémon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/638.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/638.png", 0f, "Cobalion", "Legendary", 209.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 626,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 260.0, 192.0, "Spoken of in legend, this Pokémon used its phenomenal power to destroy a castle in its effort to protect Pokémon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/639.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/639.png", 0f, "Terrakion", "Legendary", 209.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 627,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 192.0, 229.0, "Legends say this Pokémon confounded opponents with its swift movements.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/640.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/640.png", 0f, "Virizion", "Legendary", 209.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 628,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 266.0, 164.0, "Tornadus expels massive energy from its tail, causing severe storms. Its power is great enough to blow houses away.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/641.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/641.png", "Tornadus", "Legendary", 188.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 629,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 266.0, 164.0, "As it flies around, it shoots lightning all over the place and causes forest fires. It is therefore disliked.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/642.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/642.png", 1f, "Thundurus", "Legendary", 188.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 630,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 275.0, 211.0, "When Reshiram's tail flares, the heat energy moves the atmosphere and changes the world's weather.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/643.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/643.png", "Reshiram", "Legendary", 205.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 631,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 275.0, 211.0, "Concealing itself in lightning clouds, it flies throughout the Unova region. It creates electricity in its tail.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/644.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/644.png", 0f, "Zekrom", "Legendary", 205.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 632,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 261.0, 182.0, "From the forces of lightning and wind, it creates energy to give nutrients to the soil and make the land abundant.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/645.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/645.png", 1f, "Landorus", "Legendary", 205.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 633,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 246.0, 170.0, "It generates a powerful, freezing energy inside itself, but its body became frozen when the energy leaked out.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/646.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/646.png", 0f, "Kyurem", "Legendary", 245.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 634,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 260.0, 192.0, "When it is resolute, its body fills with power and it becomes swifter. Its jumps are then too fast to follow.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/647.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/647.png", false, 0f, "Keldeo", "Mythical", 209.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 635,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 250.0, 225.0, "Its melodies are sung with a special vocalization method that can control the feelings of those who hear it.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/648.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/648.png", 0f, "Meloetta", "Mythical", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 636,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 110.0, 106.0, "The quills on its head are usually soft. When it flexes them, the points become so hard and sharp that they can pierce rock.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/650.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/650.png", true, 0.875f, "Chespin", 148.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 637,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 146.0, 156.0, "It relies on its sturdy shell to deflect predators' attacks. It counterattacks with its sharp quills.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/651.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/651.png", true, 0.875f, "Quilladin", 156.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 638,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 116.0, 102.0, "Eating a twig fills it with energy, and its roomy ears give vent to air hotter than 390 degrees Fahrenheit.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/653.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/653.png", 0.875f, "Fennekin", "common", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 639,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 122.0, 84.0, "It secretes flexible bubbles from its chest and back. The bubbles reduce the damage it would otherwise take when attacked.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/656.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/656.png", 0.875f, "Froakie", "common", 121.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 640,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 223.0, 152.0, "It creates throwing stars out of compressed water. When it spins them and throws them at high speed, these stars can split metal in two.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/658.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/658.png", 0.875f, "Greninja", "common", 176.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 641,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 68.0, 72.0, "They use their large ears to dig burrows. They will dig the whole night through.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/659.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/659.png", 0.5f, "Bunnelby", "common", 116.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 642,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 176.0, 155.0, "In the fever of an exciting battle, it showers embers from the gaps between its feathers and takes to the air.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/663.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/663.png", 0.5f, "Talonflame", "common", 186.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 643,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 48.0, 89.0, "It lives hidden within thicket shadows. When predators attack, it quickly bristles the fur covering its body in an effort to threaten them.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/665.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/665.png", false, 0.5f, "Spewpa", "common", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 644,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 139.0, 112.0, "The stronger the opponent it faces, the more heat surges from its mane and the more power flows through its body.", 0.875f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/667.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/667.png", 0.125f, "Litleo", "common", 158.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 645,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 123.0, 102.0, "Thought to be one of the first Pokémon to live in harmony with humans, it has a placid disposition.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/672.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/672.png", false, 0.5f, "Skiddo", "common", 165.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 646,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 145.0, 107.0, "It does its best to be taken seriously by its enemies, but its glare is not sufficiently intimidating. Chewing on a leaf is its trademark.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/674.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/674.png", 0.5f, "Pancham", "common", 167.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 647,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 120.0, 114.0, "The organ that emits its intense psychic power is sheltered by its ears to keep power from leaking out.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/677.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/677.png", true, 0.5f, "Espurr", "common", 158.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 648,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 110.0, 113.0, "It emits a scent that enraptures those who smell it. This fragrance changes depending on what it has eaten.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/682.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/682.png", 0.5f, "Spritzee", "common", 186.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 650,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 109.0, 119.0, "To entangle its opponents in battle, it extrudes white threads as sweet and sticky as cotton candy.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/684.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/684.png", 0.5f, "Swirlix", 158.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 651,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 168.0, 163.0, "It can distinguish the faintest of scents. It puts its sensitive sense of smell to use by helping pastry chefs in their work.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/685.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/685.png", 0.5f, "Slurpuff", 193.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 653,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 109.0, 109.0, "Camouflaged as rotten kelp, they spray liquid poison on prey that approaches unawares and then finish it off.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/690.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/690.png", 0.5f, "Skrelp", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 656,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 227.0, 191.0, "Thanks to its gargantuan jaws, which could shred thick metal plates as if they were paper, it was invincible in the ancient world it once inhabited.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/697.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/697.png", false, 0.5f, "Tyrantrum", 193.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 658,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 164.0, 134.0, "Its whiskers serve as antennas. By sending and receiving electrical waves, it can communicate with others over vast distances.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/702.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/702.png", false, 0.5f, "Dedenne", 167.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 659,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 95.0, 285.0, "Born from the temperatures and pressures deep underground, it fires beams from the stone in its head.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/703.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/703.png", false, 0f, "Carbink", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 663,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 122.0, 124.0, "The pumpkin body is inhabited by a spirit trapped in this world. As the sun sets, it becomes restless and active.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/710.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/710.png", "Pumpkaboo", 127.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 665,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 261.0, 187.0, "In its true form, it possess a huge amount of power. Legends of its avarice tell how it once carried off an entire castle to gain the treasure hidden within.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/720.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/720.png", true, 0f, "Hoopa", "Mythical", 173.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 667,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 1.0, 1.0, "An Ultra Beast that lives in a different world, it cackles wildly as it sprays its opponents with poison from the needles on its head.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/803.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/803.png", false, 0f, "Poipole", 1.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 672,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 118.0, 99.0, "It melts particles of iron and other metals found in the subsoil, so it can absorb them into its body of molten steel.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/808.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/808.png", true, 0f, "Meltan", "Mythical", 130.0 });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "num_pokedex", "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[,]
                {
                    { 52, 122.0, 95.0, "Psyduck uses a mysterious power. When it does so, this Pokémon generates brain waves that are supposedly only seen in sleepers. This discovery spurred controversy among scholars.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/54.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/54.png", null, true, 0.5f, "Psyduck", "common", 137.0 },
                    { 53, 191.0, 162.0, "The webbed flippers on its forelegs and hind legs and the streamlined body of Golduck give it frightening speed. This Pokémon is definitely much faster than even the most athletic swimmer.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/55.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/55.png", null, true, 0.5f, "Golduck", "common", 190.0 },
                    { 83, 85.0, 121.0, "Seel hunts for prey in the frigid sea underneath sheets of ice. When it needs to breathe, it punches a hole through the ice with the sharply protruding section of its head.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/86.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/86.png", null, true, 0.5f, "Seel", "common", 163.0 },
                    { 122, 206.0, 154.0, "In battle, Magmar blows out intensely hot flames from all over its body to intimidate its opponent. This Pokémon's fiery bursts create heat waves that ignite grass and trees in its surroundings.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/126.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/126.png", null, true, 0.75f, "Magmar", "common", 163.0 },
                    { 263, 98.0, 162.0, "Dustox is instinctively drawn to light. Swarms of this Pokémon are attracted by the bright lights of cities, where they wreak havoc by stripping the leaves off roadside trees for food.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/269.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/269.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/269.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/269.png", true, 0.5f, "Dustox", "common", 155.0 },
                    { 264, 71.0, 77.0, "Lotad live in ponds and lakes, where they float on the surface. It grows weak if its broad leaf dies. On rare occasions, this Pokémon travels on land in search of clean water.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/270.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/270.png", null, true, 0.5f, "Lotad", "common", 120.0 },
                    { 386, 112.0, 102.0, "Because it is very proud, it hates accepting food from people. Its thick down guards it from cold.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/393.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/393.png", null, true, 0.875f, "Piplup", "common", 142.0 },
                    { 422, 109.0, 82.0, "When it's happy, Glameow demonstrates beautiful movements of its tail, like a dancing ribbon.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/431.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/431.png", null, true, 0.25f, "Glameow", "common", 135.0 },
                    { 423, 172.0, 133.0, "To make itself appear intimidatingly beefy, it tightly cinches its waist with its twin tails.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/432.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/432.png", null, true, 0.25f, "Purugly", "common", 174.0 },
                    { 439, 124.0, 118.0, "It enshrouds itself with sand to protect itself from germs. It does not enjoy getting wet.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/449.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/449.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/449.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/449.png", true, 0.5f, "Hippopotas", "common", 169.0 },
                    { 493, 98.0, 73.0, "Extremely cautious, one of them will always be on the lookout, but it won't notice a foe coming from behind.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/504.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/504.png", null, true, 0.5f, "Patrat", "common", 128.0 },
                    { 562, 137.0, 153.0, "According to many old tales, it creates friends for itself by controlling sleeping children on starry nights.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/575.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/575.png", null, true, 0.25f, "Gothorita", "common", 155.0 },
                    { 563, 176.0, 205.0, "They can predict the future from the placement and movement of the stars. They can see Trainers' life spans.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/576.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/576.png", null, true, 0.25f, "Gothitelle", "common", 172.0 },
                    { 649, 173.0, 150.0, "It devises various scents, pleasant and unpleasant, and emits scents that its enemies dislike in order to gain an edge in battle.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/683.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/683.png", null, true, 0.5f, "Aromatisse", "common", 226.0 },
                    { 652, 96.0, 120.0, "Two Binacle live together on one rock. When they fight, one of them will move to a different rock.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/688.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/688.png", null, true, 0.5f, "Binacle", "common", 123.0 },
                    { 654, 108.0, 117.0, "They knock down flying prey by firing compressed water from their massive claws like shooting a pistol.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/692.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/692.png", null, true, 0.5f, "Clauncher", "common", 137.0 },
                    { 655, 115.0, 78.0, "They make their home in deserts. They can generate their energy from basking in the sun, so eating food is not a requirement.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/694.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/694.png", null, false, 0.5f, "Helioptile", "common", 127.0 },
                    { 657, 195.0, 153.0, "Although its body is small, its proficient fighting skills enable it to keep up with big bruisers like Machamp and Hariyama.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/701.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/701.png", null, false, 0.5f, "Hawlucha", "common", 186.0 },
                    { 660, 101.0, 112.0, "The weakest Dragon-type Pokémon, it lives in damp, shady places, so its body doesn't dry out.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/704.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/704.png", null, true, 0.5f, "Goomy", "common", 128.0 },
                    { 661, 160.0, 179.0, "These key collectors threaten any attackers by fiercely jingling their keys at them.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/707.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/707.png", null, true, 0.5f, "Klefki", "common", 149.0 },
                    { 662, 125.0, 103.0, "These Pokémon are created when spirits possess rotten tree stumps. They prefer to live in abandoned forests.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/708.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/708.png", null, true, 0.5f, "Phantump", "common", 125.0 },
                    { 664, 117.0, 120.0, "It blocks opponents' attacks with the ice that shields its body. It uses cold air to repair any cracks with new ice.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/712.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/712.png", null, true, 0.5f, "Bergmite", "common", 146.0 },
                    { 666, 265.0, 190.0, "It sinks into the shadows of people and Pokémon, where it can understand their feelings and copy their capabilities.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/802.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/802.png", null, false, 0f, "Marshadow", "Mythical", 207.0 },
                    { 668, 1.0, 1.0, "One kind of Ultra Beast, it fires a glowing, venomous liquid from its needles. This liquid is also immensely adhesive.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/804.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/804.png", null, false, 0f, "Naganadel", "common", 1.0 },
                    { 669, 1.0, 1.0, "When stone walls started moving and attacking, the brute's true identity was this mysterious life-form, which brings to mind an Ultra Beast.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/805.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/805.png", null, false, 0f, "Stakataka", "common", 1.0 },
                    { 670, 1.0, 1.0, "A UB that appeared from an Ultra Wormhole, it causes explosions, then takes advantage of opponents' surprise to rob them of their vitality.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/806.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/806.png", null, false, 0f, "Blacephalon", "common", 1.0 },
                    { 671, 1.0, 1.0, "It approaches its enemies at the speed of lightning, then tears them limb from limb with its sharp claws.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/807.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/807.png", null, false, 0f, "Zeraora", "Mythical", 1.0 },
                    { 673, 226.0, 190.0, "Revered long ago for its capacity to create iron from nothing, for some reason it has come back to life after 3,000 years.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/809.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/809.png", null, true, 0f, "Melmetal", "Mythical", 264.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 673);

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 54,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 122.0, 95.0, "Psyduck uses a mysterious power. When it does so, this Pokémon generates brain waves that are supposedly only seen in sleepers. This discovery spurred controversy among scholars.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/54.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/54.png", "Psyduck", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 55,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 191.0, 162.0, "The webbed flippers on its forelegs and hind legs and the streamlined body of Golduck give it frightening speed. This Pokémon is definitely much faster than even the most athletic swimmer.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/55.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/55.png", "Golduck", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 56,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 148.0, 82.0, "When Mankey starts shaking and its nasal breathing turns rough, it's a sure sign that it is becoming angry. However, because it goes into a towering rage almost instantly, it is impossible for anyone to flee its wrath.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/56.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/56.png", 0.5f, "Mankey", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 57,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 207.0, 138.0, "When Primeape becomes furious, its blood circulation is boosted. In turn, its muscles are made even stronger. However, it also becomes much less intelligent at the same time.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/57.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/57.png", 0.5f, "Primeape", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 58,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 136.0, 93.0, "Growlithe has a superb sense of smell. Once it smells anything, this Pokémon won't forget the scent, no matter what. It uses its advanced olfactory sense to determine the emotions of other living things.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/58.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/58.png", 0.75f, "Growlithe", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 59,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 227.0, 166.0, "Arcanine is known for its high speed. It is said to be capable of running over 6,200 miles in a single day and night. The fire that blazes wildly within this Pokémon's body is its source of power.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/59.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/59.png", 0.75f, "Arcanine", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 60,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 101.0, 82.0, "Poliwag has a very thin skin. It is possible to see the Pokémon's spiral innards right through the skin. Despite its thinness, however, the skin is also very flexible. Even sharp fangs bounce right off it.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/60.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/60.png", "Poliwag", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 61,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 130.0, 123.0, "The surface of Poliwhirl's body is always wet and slick with a slimy fluid. Because of this slippery covering, it can easily slip and slide out of the clutches of any enemy in battle.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/61.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/61.png", 0.5f, "Poliwhirl", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 62,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 182.0, 184.0, "Poliwrath's highly developed, brawny muscles never grow fatigued, however much it exercises. It is so tirelessly strong, this Pokémon can swim back and forth across the ocean without effort.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/62.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/62.png", null, 0.5f, "Poliwrath", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 63,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 195.0, 82.0, "Abra sleeps for 18 hours a day. However, it can sense the presence of foes even while it is sleeping. In such a situation, this Pokémon immediately teleports to safety.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/63.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/63.png", null, "Abra", 93.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 64,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 232.0, 117.0, "Kadabra emits a peculiar alpha wave if it develops a headache. Only those people with a particularly strong psyche can hope to become a Trainer of this Pokémon.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/64.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/64.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/64.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/64.png", "Kadabra", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 65,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 271.0, 167.0, "Alakazam's brain continually grows, making its head far too heavy to support with its neck. This Pokémon holds its head up using its psychokinetic power instead.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/65.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/65.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/65.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/65.png", "Alakazam", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 66,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 137.0, 82.0, "Machop's muscles are special—they never get sore no matter how much they are used in exercise. This Pokémon has sufficient power to hurl a hundred adult humans.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/66.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/66.png", "Machop", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 67,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 177.0, 125.0, "Machoke's thoroughly toned muscles possess the hardness of steel. This Pokémon has so much strength, it can easily hold aloft a sumo wrestler on just one finger.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/67.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/67.png", 0.75f, "Machoke", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 68,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 234.0, 159.0, "Machamp has the power to hurl anything aside. However, trying to do any work requiring care and dexterity causes its arms to get tangled. This Pokémon tends to leap into action before it thinks.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/68.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/68.png", 0.75f, "Machamp", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 69,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 139.0, 61.0, "Bellsprout's thin and flexible body lets it bend and sway to avoid any attack, however strong it may be. From its mouth, this Pokémon spits a corrosive fluid that melts even iron.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/69.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/69.png", "Bellsprout", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 70,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 172.0, 92.0, "Weepinbell has a large hook on its rear end. At night, the Pokémon hooks on to a tree branch and goes to sleep. If it moves around in its sleep, it may wake up to find itself on the ground.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/70.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/70.png", "Weepinbell", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 71,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name" },
                values: new object[] { 207.0, 135.0, "Victreebel has a long vine that extends from its head. This vine is waved and flicked about as if it were an animal to attract prey. When an unsuspecting prey draws near, this Pokémon swallows it whole.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/71.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/71.png", "Victreebel" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 72,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name" },
                values: new object[] { 97.0, 149.0, "Tentacool's body is largely composed of water. If it is removed from the sea, it dries up like parchment. If this Pokémon happens to become dehydrated, put it back into the sea.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/72.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/72.png", "Tentacool" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 73,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 166.0, 209.0, "Tentacruel has large red orbs on its head. The orbs glow before lashing the vicinity with a harsh ultrasonic blast. This Pokémon's outburst creates rough waves around it.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/73.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/73.png", "Tentacruel", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 74,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 132.0, 132.0, "The longer a Geodude lives, the more its edges are chipped and worn away, making it more rounded in appearance. However, this Pokémon's heart will remain hard, craggy, and rough always.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/74.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/74.png", "Geodude", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 75,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 164.0, 164.0, "Graveler grows by feeding on rocks. Apparently, it prefers to eat rocks that are covered in moss. This Pokémon eats its way through a ton of rocks on a daily basis.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/75.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/75.png", "Graveler", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 76,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 211.0, 198.0, "Golem live up on mountains. If there is a large earthquake, these Pokémon will come rolling down off the mountains en masse to the foothills below.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/76.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/76.png", "Golem", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 77,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 170.0, 127.0, "Ponyta is very weak at birth. It can barely stand up. This Pokémon becomes stronger by stumbling and falling to keep up with its parent.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/77.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/77.png", "Ponyta", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 78,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 207.0, 162.0, "Rapidash usually can be seen casually cantering in the fields and plains. However, when this Pokémon turns serious, its fiery manes flare and blaze as it gallops its way up to 150 mph.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/78.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/78.png", "Rapidash", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 79,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 109.0, 98.0, "Slowpoke uses its tail to catch prey by dipping it in water at the side of a river. However, this Pokémon often forgets what it's doing and often spends entire days just loafing at water's edge.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/79.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/79.png", 0.5f, "Slowpoke", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 80,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 177.0, 180.0, "Slowbro's tail has a Shellder firmly attached with a bite. As a result, the tail can't be used for fishing anymore. This causes Slowbro to grudgingly swim and catch prey instead.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/80.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/80.png", 0.5f, "Slowbro", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 81,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 165.0, 121.0, "Magnemite attaches itself to power lines to feed on electricity. If your house has a power outage, check your circuit breakers. You may find a large number of this Pokémon clinging to the breaker box.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/81.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/81.png", null, 0f, "Magnemite", 93.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 82,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 223.0, 169.0, "Magneton emits a powerful magnetic force that is fatal to mechanical devices. As a result, large cities sound sirens to warn citizens of large-scale outbreaks of this Pokémon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/82.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/82.png", null, 0f, "Magneton", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 84,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 158.0, 83.0, "Doduo's two heads never sleep at the same time. Its two heads take turns sleeping, so one head can always keep watch for enemies while the other one sleeps.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/84.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/84.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/84.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/84.png", "Doduo", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 85,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 218.0, 140.0, "Watch out if Dodrio's three heads are looking in three separate directions. It's a sure sign that it is on its guard. Don't go near this Pokémon if it's being wary—it may decide to peck you.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/85.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/85.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/85.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/85.png", "Dodrio", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 86,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 85.0, 121.0, "Seel hunts for prey in the frigid sea underneath sheets of ice. When it needs to breathe, it punches a hole through the ice with the sharply protruding section of its head.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/86.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/86.png", "Seel", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 87,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 139.0, 177.0, "Dewgong loves to snooze on bitterly cold ice. The sight of this Pokémon sleeping on a glacier was mistakenly thought to be a mermaid by a mariner long ago.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/87.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/87.png", "Dewgong", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 88,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 135.0, 90.0, "Grimer's sludgy and rubbery body can be forced through any opening, however small it may be. This Pokémon enters sewer pipes to drink filthy wastewater.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/88.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/88.png", "Grimer", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 89,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 190.0, 172.0, "From Muk's body seeps a foul fluid that gives off a nose-bendingly horrible stench. Just one drop of this Pokémon's body fluid can turn a pool stagnant and rancid.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/89.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/89.png", "Muk", 233.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 90,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 116.0, 134.0, "At night, this Pokémon uses its broad tongue to burrow a hole in the seafloor sand and then sleep in it. While it is sleeping, Shellder closes its shell, but leaves its tongue hanging out.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/90.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/90.png", "Shellder", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 91,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 186.0, 256.0, "Cloyster is capable of swimming in the sea. It does so by swallowing water, then jetting it out toward the rear. This Pokémon shoots spikes from its shell using the same system.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/91.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/91.png", "Cloyster", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 92,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 186.0, 67.0, "Gastly is largely composed of gaseous matter. When exposed to a strong wind, the gaseous body quickly dwindles away. Groups of this Pokémon cluster under the eaves of houses to escape the ravages of wind.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/92.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/92.png", "Gastly", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 93,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 223.0, 107.0, "Haunter is a dangerous Pokémon. If one beckons you while floating in darkness, you must never approach it. This Pokémon will try to lick you with its tongue and steal your life away.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/93.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/93.png", "Haunter", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 94,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 261.0, 149.0, "Sometimes, on a dark night, your shadow thrown by a streetlight will suddenly and startlingly overtake you. It is actually a Gengar running past you, pretending to be your shadow.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/94.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/94.png", null, "Gengar", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 95,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 85.0, 232.0, "Onix has a magnet in its brain. It acts as a compass so that this Pokémon does not lose direction while it is tunneling. As it grows older, its body becomes increasingly rounder and smoother.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/95.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/95.png", "Onix", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 96,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 89.0, 136.0, "If your nose becomes itchy while you are sleeping, it's a sure sign that one of these Pokémon is standing above your pillow and trying to eat your dream through your nostrils.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/96.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/96.png", "Drowzee", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 97,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 144.0, 193.0, "Hypno holds a pendulum in its hand. The arcing movement and glitter of the pendulum lull the foe into a deep state of hypnosis. While this Pokémon searches for prey, it polishes the pendulum.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/97.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/97.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/97.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/97.png", 0.5f, "Hypno", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 98,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 181.0, 124.0, "Krabby live on beaches, burrowed inside holes dug into the sand. On sandy beaches with little in the way of food, these Pokémon can be seen squabbling with each other over territory.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/98.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/98.png", 0.5f, "Krabby", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 99,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 240.0, 181.0, "Kingler has an enormous, oversized claw. It waves this huge claw in the air to communicate with others. However, because the claw is so heavy, the Pokémon quickly tires.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/99.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/99.png", "Kingler", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 100,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 109.0, 111.0, "Voltorb was first sighted at a company that manufactures Poké Balls. The link between that sighting and the fact that this Pokémon looks very similar to a Poké Ball remains a mystery.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/100.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/100.png", 0f, "Voltorb", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 101,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 173.0, 173.0, "Electrode eats electricity in the atmosphere. On days when lightning strikes, you can see this Pokémon exploding all over the place from eating too much electricity.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/101.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/101.png", 0f, "Electrode", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 102,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name" },
                values: new object[] { 107.0, 125.0, "This Pokémon consists of six eggs that form a closely knit cluster. The six eggs attract each other and spin around. When cracks increasingly appear on the eggs, Exeggcute is close to evolution.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/102.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/102.png", "Exeggcute" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 103,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 233.0, 149.0, "Exeggutor originally came from the tropics. Its heads steadily grow larger from exposure to strong sunlight. It is said that when the heads fall off, they group together to form Exeggcute.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/103.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/103.png", 0.5f, "Exeggutor", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 104,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name" },
                values: new object[] { 90.0, 144.0, "Cubone pines for the mother it will never see again. Seeing a likeness of its mother in the full moon, it cries. The stains on the skull the Pokémon wears are made by the tears it sheds.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/104.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/104.png", 0.5f, "Cubone" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 105,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 144.0, 186.0, "Marowak is the evolved form of a Cubone that has overcome its sadness at the loss of its mother and grown tough. This Pokémon's tempered and hardened spirit is not easily broken.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/105.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/105.png", "Marowak", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 106,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 224.0, 181.0, "Hitmonlee's legs freely contract and stretch. Using these springlike legs, it bowls over foes with devastating kicks. After battle, it rubs down its legs and loosens the muscles to overcome fatigue.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/106.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/106.png", 1f, "Hitmonlee", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 107,
                columns: new[] { "attack", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 193.0, "Hitmonchan is said to possess the spirit of a boxer who had been working toward a world championship. This Pokémon has an indomitable spirit and will never give up in the face of adversity.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/107.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/107.png", 1f, "Hitmonchan", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 108,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 108.0, 137.0, "Whenever Lickitung comes across something new, it will unfailingly give it a lick. It does so because it memorizes things by texture and by taste. It is somewhat put off by sour things.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/108.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/108.png", null, "Lickitung", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 109,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 119.0, 141.0, "If Koffing becomes agitated, it raises the toxicity of its internal gases and jets them out from all over its body. This Pokémon may also overinflate its round body, then explode.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/109.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/109.png", null, "Koffing", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 110,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 174.0, 197.0, "Weezing loves the gases given off by rotted kitchen garbage. This Pokémon will find a dirty, unkempt house and make it its home. At night, when the people in the house are asleep, it will go through the trash.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/110.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/110.png", 0.5f, "Weezing", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 111,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 140.0, 127.0, "Rhyhorn runs in a straight line, smashing everything in its path. It is not bothered even if it rushes headlong into a block of steel. This Pokémon may feel some pain from the collision the next day, however.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/111.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/111.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/111.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/111.png", "Rhyhorn", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 112,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name" },
                values: new object[] { 222.0, 171.0, "Rhydon's horn can crush even uncut diamonds. One sweeping blow of its tail can topple a building. This Pokémon's hide is extremely tough. Even direct cannon hits don't leave a scratch.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/112.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/112.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/112.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/112.png", 0.5f, "Rhydon" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 113,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 60.0, 128.0, "Chansey lays nutritionally excellent eggs on an everyday basis. The eggs are so delicious, they are easily and eagerly devoured by even those people who have lost their appetite.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/113.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/113.png", 0f, "Chansey", 487.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 114,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 183.0, 169.0, "Tangela's vines snap off easily if they are grabbed. This happens without pain, allowing it to make a quick getaway. The lost vines are replaced by newly grown vines the very next day.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/114.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/114.png", "Tangela", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 115,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 181.0, 165.0, "If you come across a young Kangaskhan playing by itself, you must never disturb it or attempt to catch it. The baby Pokémon's parent is sure to be in the area, and it will become violently enraged at you.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/115.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/115.png", null, 0f, "Kangaskhan", 233.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 116,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 129.0, 103.0, "Horsea eats small insects and moss off of rocks. If the ocean current turns fast, this Pokémon anchors itself by wrapping its tail around rocks or coral to prevent being washed away.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/116.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/116.png", null, "Horsea", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 117,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 187.0, 156.0, "Seadra sleeps after wriggling itself between the branches of coral. Those trying to harvest coral are occasionally stung by this Pokémon's poison barbs if they fail to notice it.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/117.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/117.png", 0.5f, "Seadra", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 118,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 123.0, 110.0, "Goldeen is a very beautiful Pokémon with fins that billow elegantly in water. However, don't let your guard down around this Pokémon—it could ram you powerfully with its horn.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/118.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/118.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/118.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/118.png", 0.5f, "Goldeen", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 119,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 175.0, 147.0, "In the autumn, Seaking males can be seen performing courtship dances in riverbeds to woo females. During this season, this Pokémon's body coloration is at its most beautiful.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/119.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/119.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/119.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/119.png", "Seaking", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 120,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 137.0, 112.0, "Staryu's center section has an organ called the core that shines bright red. If you go to a beach toward the end of summer, the glowing cores of these Pokémon look like the stars in the sky.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/120.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/120.png", "Staryu", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 121,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 210.0, 184.0, "Starmie's center section—the core—glows brightly in seven colors. Because of its luminous nature, this Pokémon has been given the nickname “the gem of the sea.”", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/121.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/121.png", 0f, "Starmie", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 123,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 218.0, 170.0, "Scyther is blindingly fast. Its blazing speed enhances the effectiveness of the twin scythes on its forearms. This Pokémon's scythes are so effective, they can slice through thick logs in one wicked stroke.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/123.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/123.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/123.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/123.png", "Scyther", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 124,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 223.0, 151.0, "Jynx walks rhythmically, swaying and shaking its hips as if it were dancing. Its motions are so bouncingly alluring, people seeing it are compelled to shake their hips without giving any thought to what they are doing.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/124.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/124.png", 0f, "Jynx", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 125,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 198.0, 158.0, "When a storm arrives, gangs of this Pokémon compete with each other to scale heights that are likely to be stricken by lightning bolts. Some towns use Electabuzz in place of lightning rods.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/125.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/125.png", null, 0.75f, "Electabuzz", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 126,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 206.0, 154.0, "In battle, Magmar blows out intensely hot flames from all over its body to intimidate its opponent. This Pokémon's fiery bursts create heat waves that ignite grass and trees in its surroundings.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/126.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/126.png", null, 0.75f, "Magmar", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 127,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 238.0, 182.0, "Pinsir is astoundingly strong. It can grip a foe weighing twice its weight in its horns and easily lift it. This Pokémon's movements turn sluggish in cold places.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/127.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/127.png", "Pinsir", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 128,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 198.0, 183.0, "This Pokémon is not satisfied unless it is rampaging at all times. If there is no opponent for Tauros to battle, it will charge at thick trees and knock them down to calm itself.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/128.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/128.png", 1f, "Tauros", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 129,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 29.0, 85.0, "Magikarp is a pathetic excuse for a Pokémon that is only capable of flopping and splashing. This behavior prompted scientists to undertake research into it.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/129.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/129.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/129.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/129.png", 0.5f, "Magikarp", 85.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 130,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 237.0, 186.0, "When Magikarp evolves into Gyarados, its brain cells undergo a structural transformation. It is said that this transformation is to blame for this Pokémon's wildly violent nature.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/130.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/130.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/130.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/130.png", 0.5f, "Gyarados", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 131,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 165.0, 174.0, "People have driven Lapras almost to the point of extinction. In the evenings, this Pokémon is said to sing plaintively as it seeks what few others of its kind still remain.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/131.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/131.png", 0.5f, "Lapras", 277.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 132,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 91.0, 91.0, "Ditto rearranges its cell structure to transform itself into other shapes. However, if it tries to transform itself into something by relying on its memory, this Pokémon manages to get details wrong.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/132.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/132.png", 0f, "Ditto", 134.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 133,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 104.0, 114.0, "Eevee has an unstable genetic makeup that suddenly mutates due to the environment in which it lives. Radiation from various stones causes this Pokémon to evolve.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/133.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/133.png", 0.875f, "Eevee", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 134,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 205.0, 161.0, "Vaporeon underwent a spontaneous mutation and grew fins and gills that allow it to live underwater. This Pokémon has the ability to freely control water.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/134.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/134.png", "Vaporeon", 277.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 135,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 232.0, 182.0, "Jolteon's cells generate a low level of electricity. This power is amplified by the static electricity of its fur, enabling the Pokémon to drop thunderbolts. The bristling fur is made of electrically charged needles.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/135.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/135.png", "Jolteon", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 136,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 246.0, 179.0, "Flareon's fluffy fur has a functional purpose—it releases heat into the air so that its body does not get excessively hot. This Pokémon's body temperature can rise to a maximum of 1,650 degrees Fahrenheit.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/136.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/136.png", "Flareon", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 137,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 153.0, 136.0, "Porygon is capable of reverting itself entirely back to program data and entering cyberspace. This Pokémon is copy protected so it cannot be duplicated by copying.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/137.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/137.png", 0f, "Porygon", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 138,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 155.0, 153.0, "Omanyte is one of the ancient and long-since-extinct Pokémon that have been regenerated from fossils by people. If attacked by an enemy, it withdraws itself inside its hard shell.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/138.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/138.png", "Omanyte", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 139,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 207.0, 201.0, "Omastar uses its tentacles to capture its prey. It is believed to have become extinct because its shell grew too large and heavy, causing its movements to become too slow and ponderous.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/139.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/139.png", "Omastar", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 140,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 148.0, 140.0, "Kabuto is a Pokémon that has been regenerated from a fossil. However, in extremely rare cases, living examples have been discovered. The Pokémon has not changed at all for 300 million years.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/140.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/140.png", 0.875f, "Kabuto", "common", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 141,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 220.0, 186.0, "Kabutops swam underwater to hunt for its prey in ancient times. The Pokémon was apparently evolving from being a water dweller to living on land as evident from the beginnings of change in its gills and legs.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/141.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/141.png", 0.875f, "Kabutops", "common", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 142,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 221.0, 159.0, "Aerodactyl is a Pokémon from the age of dinosaurs. It was regenerated from genetic material extracted from amber. It is imagined to have been the king of the skies in ancient times.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/142.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/142.png", 0.875f, "Aerodactyl", "common", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 143,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 190.0, 169.0, "Snorlax's typical day consists of nothing more than eating and sleeping. It is such a docile Pokémon that there are children who use its expansive belly as a place to play.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/143.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/143.png", 0.875f, "Snorlax", 330.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 144,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 192.0, 236.0, "Articuno is a Legendary Pokémon that can control ice. The flapping of its wings chills the air. As a result, it is said that when this Pokémon flies, snow will fall.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/144.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/144.png", 0f, "Articuno", "Legendary", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 145,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 253.0, 185.0, "Zapdos is a Legendary Pokémon that has the ability to control electricity. It usually lives in thunderclouds. The Pokémon gains power if it is stricken by lightning bolts.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/145.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/145.png", 0f, "Zapdos", "Legendary", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 146,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 251.0, 181.0, "Moltres is a Legendary Pokémon that has the ability to control fire. If this Pokémon is injured, it is said to dip its body in the molten magma of a volcano to burn and heal itself.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/146.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/146.png", "Moltres", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 147,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 119.0, 91.0, "Dratini continually molts and sloughs off its old skin. It does so because the life energy within its body steadily builds to reach uncontrollable levels.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/147.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/147.png", 0.5f, "Dratini", "common", 121.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 148,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 163.0, 135.0, "Dragonair stores an enormous amount of energy inside its body. It is said to alter weather conditions in its vicinity by discharging energy from the crystals on its neck and tail.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/148.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/148.png", 0.5f, "Dragonair", 156.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 149,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 263.0, 198.0, "Dragonite is capable of circling the globe in just 16 hours. It is a kindhearted Pokémon that leads lost and foundering ships in a storm to the safety of land.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/149.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/149.png", 0.5f, "Dragonite", 209.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 150,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 300.0, 182.0, "Mewtwo is a Pokémon that was created by genetic manipulation. However, even though the scientific power of humans created this Pokémon's body, they failed to endow Mewtwo with a compassionate heart.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/150.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/150.png", null, 0f, "Mewtwo", "Legendary", 214.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 151,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 210.0, 210.0, "Mew is said to possess the genetic composition of all Pokémon. It is capable of making itself invisible at will, so it entirely avoids notice even if it approaches people.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/151.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/151.png", 0f, "Mew", "Mythical", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 152,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 92.0, 122.0, "In battle, Chikorita waves its leaf around to keep the foe at bay. However, a sweet fragrance also wafts from the leaf, becalming the battling Pokémon and creating a cozy, friendly atmosphere all around.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/152.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/152.png", "Chikorita", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 153,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 122.0, 155.0, "Bayleef's neck is ringed by curled-up leaves. Inside each tubular leaf is a small shoot of a tree. The fragrance of this shoot makes people peppy.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/153.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/153.png", "Bayleef", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 154,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 168.0, 202.0, "The fragrance of Meganium's flower soothes and calms emotions. In battle, this Pokémon gives off more of its becalming scent to blunt the foe's fighting spirit.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/154.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/154.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/154.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/154.png", "Meganium", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 155,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 116.0, 93.0, "Cyndaquil protects itself by flaring up the flames on its back. The flames are vigorous if the Pokémon is angry. However, if it is tired, the flames splutter fitfully with incomplete combustion.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/155.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/155.png", "Cyndaquil", 118.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 156,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 158.0, 126.0, "Quilava keeps its foes at bay with the intensity of its flames and gusts of superheated air. This Pokémon applies its outstanding nimbleness to dodge attacks even while scorching the foe with flames.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/156.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/156.png", "Quilava", 151.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 157,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 223.0, 173.0, "Typhlosion obscures itself behind a shimmering heat haze that it creates using its intensely hot flames. This Pokémon creates blazing explosive blasts that burn everything to cinders.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/157.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/157.png", 0.875f, "Typhlosion", 186.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 158,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 117.0, 109.0, "Despite the smallness of its body, Totodile's jaws are very powerful. While the Pokémon may think it is just playfully nipping, its bite has enough power to cause serious injury.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/158.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/158.png", 0.875f, "Totodile", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 159,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 150.0, 142.0, "Once Croconaw has clamped its jaws on its foe, it will absolutely not let go. Because the tips of its fangs are forked back like barbed fishhooks, they become impossible to remove when they have sunk in.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/159.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/159.png", 0.875f, "Croconaw", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 160,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 205.0, 188.0, "Feraligatr intimidates its foes by opening its huge mouth. In battle, it will kick the ground hard with its thick and powerful hind legs to charge at the foe at an incredible speed.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/160.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/160.png", 0.875f, "Feraligatr", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 161,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 79.0, 73.0, "When Sentret sleeps, it does so while another stands guard. The sentry wakes the others at the first sign of danger. When this Pokémon becomes separated from its pack, it becomes incapable of sleep due to fear.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/161.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/161.png", null, "Sentret", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 162,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 148.0, 125.0, "Furret has a very slim build. When under attack, it can slickly squirm through narrow spaces and get away. In spite of its short limbs, this Pokémon is very nimble and fleet.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/162.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/162.png", null, "Furret", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 163,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 67.0, 88.0, "Hoothoot has an internal organ that senses and tracks the earth's rotation. Using this special organ, this Pokémon begins hooting at precisely the same time every day.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/163.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/163.png", "Hoothoot", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 164,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 145.0, 156.0, "Noctowl never fails at catching prey in darkness. This Pokémon owes its success to its superior vision that allows it to see in minimal light, and to its soft, supple wings that make no sound in flight.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/164.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/164.png", "Noctowl", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 165,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 72.0, 118.0, "Ledyba secretes an aromatic fluid from where its legs join its body. This fluid is used for communicating with others. This Pokémon conveys its feelings to others by altering the fluid's scent.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/165.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/165.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/165.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/165.png", "Ledyba", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 166,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 107.0, 179.0, "It is said that in lands with clean air, where the stars fill the sky, there live Ledian in countless numbers. There is a good reason for this—the Pokémon uses the light of the stars as its energy.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/166.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/166.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/166.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/166.png", "Ledian", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 167,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 105.0, 73.0, "The web spun by Spinarak can be considered its second nervous system. It is said that this Pokémon can determine what kind of prey is touching its web just by the tiny vibrations it feels through the web's strands.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/167.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/167.png", "Spinarak", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 168,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 161.0, 124.0, "Ariados's feet are tipped with tiny hooked claws that enable it to scuttle on ceilings and vertical walls. This Pokémon constricts the foe with thin and strong silk webbing.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/168.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/168.png", "Ariados", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 169,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 194.0, 178.0, "If this Pokémon is flying by fluttering only a pair of wings on either the forelegs or hind legs, it's proof that Crobat has been flying a long distance. It switches the wings it uses if it is tired.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/169.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/169.png", 0.5f, "Crobat", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 170,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 106.0, 97.0, "Chinchou lets loose positive and negative electrical charges from its two antennas to make its prey faint. This Pokémon flashes its electric lights to exchange signals with others.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/170.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/170.png", 0.5f, "Chinchou", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 171,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 146.0, 137.0, "Lanturn is nicknamed “the deep-sea star” for its illuminated antenna. This Pokémon produces light by causing a chemical reaction between bacteria and its bodily fluids inside the antenna.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/171.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/171.png", 0.5f, "Lanturn", 268.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 172,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 77.0, 53.0, "Pichu charges itself with electricity more easily on days with thunderclouds or when the air is very dry. You can hear the crackling of static electricity coming off this Pokémon.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/172.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/172.png", 0.5f, "Pichu", 85.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 173,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 75.0, 79.0, "On nights with many shooting stars, Cleffa can be seen dancing in a ring. They dance through the night and stop only at the break of day, when these Pokémon quench their thirst with the morning dew.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/173.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/173.png", 0.25f, "Cleffa", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 174,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 69.0, 32.0, "Igglybuff's vocal cords are not sufficiently developed. It would hurt its throat if it were to sing too much. This Pokémon gargles with freshwater from a clean stream.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/174.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/174.png", null, 0.25f, "Igglybuff", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 175,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 67.0, 116.0, "As its energy, Togepi uses the positive emotions of compassion and pleasure exuded by people and Pokémon. This Pokémon stores up feelings of happiness inside its shell, then shares them with others.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/175.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/175.png", 0.875f, "Togepi", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 176,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 139.0, 181.0, "Togetic is said to be a Pokémon that brings good fortune. When the Pokémon spots someone who is pure of heart, it is said to appear and share its happiness with that person.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/176.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/176.png", 0.875f, "Togetic", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 177,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 134.0, 89.0, "Natu cannot fly because its wings are not yet fully grown. If your eyes meet with this Pokémon's eyes, it will stare back intently at you. But if you move even slightly, it will hop away to safety.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/177.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/177.png", "Natu", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 178,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 192.0, 146.0, "Xatu stands rooted and still in one spot all day long. People believe that this Pokémon does so out of fear of the terrible things it has foreseen in the future.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/178.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/178.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/178.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/178.png", "Xatu", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 179,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 114.0, 79.0, "Mareep's fluffy coat of wool rubs together and builds a static charge. The more static electricity is charged, the more brightly the lightbulb at the tip of its tail glows.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/179.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/179.png", "Mareep", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 180,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 145.0, 109.0, "Flaaffy's wool quality changes so that it can generate a high amount of static electricity with a small amount of wool. The bare and slick parts of its hide are shielded against electricity.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/180.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/180.png", "Flaaffy", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 181,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 211.0, 169.0, "Ampharos gives off so much light that it can be seen even from space. People in the old days used the light of this Pokémon to send signals back and forth with others far away.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/181.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/181.png", null, "Ampharos", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 182,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 169.0, 186.0, "When Bellossom gets exposed to plenty of sunlight, the leaves ringing its body begin to spin around. This Pokémon's dancing is renowned in the southern lands.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/182.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/182.png", null, "Bellossom", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 183,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 37.0, 93.0, "Marill's oil-filled tail acts much like a life preserver. If you see just its tail bobbing on the water's surface, it's a sure indication that this Pokémon is diving beneath the water to feed on aquatic plants.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/183.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/183.png", "Marill", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 184,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 112.0, 152.0, "Azumarill's long ears are indispensable sensors. By focusing its hearing, this Pokémon can identify what kinds of prey are around, even in rough and fast-running rivers.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/184.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/184.png", "Azumarill", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 185,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 167.0, 176.0, "Sudowoodo camouflages itself as a tree to avoid being attacked by enemies. However, because its hands remain green throughout the year, the Pokémon is easily identified as a fake during the winter.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/185.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/185.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/185.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/185.png", "Sudowoodo", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 186,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 174.0, 179.0, "The curled hair on Politoed's head is proof of its status as a king. It is said that the longer and more curled the hair, the more respect this Pokémon earns from its peers.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/186.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/186.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/186.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/186.png", "Politoed", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 187,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 67.0, 94.0, "This Pokémon drifts and floats with the wind. If it senses the approach of strong winds, Hoppip links its leaves with other Hoppip to prepare against being blown away.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/187.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/187.png", "Hoppip", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 188,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 91.0, 120.0, "Skiploom's flower blossoms when the temperature rises above 64 degrees Fahrenheit. How much the flower opens depends on the temperature. For that reason, this Pokémon is sometimes used as a thermometer.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/188.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/188.png", "Skiploom", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 189,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 118.0, 183.0, "Jumpluff rides warm southern winds to cross the sea and fly to foreign lands. The Pokémon descends to the ground when it encounters cold air while it is floating.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/189.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/189.png", "Jumpluff", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 190,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name" },
                values: new object[] { 136.0, 112.0, "Aipom's tail ends in a hand-like appendage that can be cleverly manipulated. However, because the Pokémon uses its tail so much, its real hands have become rather clumsy.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/190.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/190.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/190.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/190.png", "Aipom" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 191,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 55.0, 55.0, "Sunkern tries to move as little as it possibly can. It does so because it tries to conserve all the nutrients it has stored in its body for its evolution. It will not eat a thing, subsisting only on morning dew.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/191.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/191.png", null, "Sunkern", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 192,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 185.0, 135.0, "Sunflora converts solar energy into nutrition. It moves around actively in the daytime when it is warm. It stops moving as soon as the sun goes down for the night.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/192.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/192.png", 0.5f, "Sunflora", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 193,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 154.0, 94.0, "Yanma is capable of seeing 360 degrees without having to move its eyes. It is a great flier that is adept at making sudden stops and turning midair. This Pokémon uses its flying ability to quickly chase down targeted prey.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/193.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/193.png", 0.5f, "Yanma", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 194,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 75.0, 66.0, "Wooper usually lives in water. However, it occasionally comes out onto land in search of food. On land, it coats its body with a gooey, toxic film.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/194.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/194.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/194.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/194.png", "Wooper", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 195,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name" },
                values: new object[] { 152.0, 143.0, "Quagsire hunts for food by leaving its mouth wide open in water and waiting for its prey to blunder in unaware. Because the Pokémon does not move, it does not get very hungry.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/195.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/195.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/195.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/195.png", "Quagsire" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 196,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 261.0, 175.0, "Espeon is extremely loyal to any Trainer it considers to be worthy. It is said that this Pokémon developed its precognitive powers to protect its Trainer from harm.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/196.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/196.png", 0.875f, "Espeon", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 197,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 126.0, 240.0, "Umbreon evolved as a result of exposure to the moon's waves. It hides silently in darkness and waits for its foes to make a move. The rings on its body glow when it leaps to attack.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/197.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/197.png", 0.875f, "Umbreon", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 198,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 175.0, 87.0, "Murkrow was feared and loathed as the alleged bearer of ill fortune. This Pokémon shows strong interest in anything that sparkles or glitters. It will even try to steal rings from women.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/198.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/198.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/198.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/198.png", "Murkrow", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 199,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 177.0, 180.0, "Slowking undertakes research every day in an effort to solve the mysteries of the world. However, this Pokémon apparently forgets everything it has learned if the Shellder on its head comes off.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/199.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/199.png", null, "Slowking", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 200,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 167.0, 154.0, "Misdreavus frightens people with a creepy, sobbing cry. The Pokémon apparently uses its red spheres to absorb the fearful feelings of foes and turn them into nutrition.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/200.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/200.png", "Misdreavus", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 201,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 136.0, 91.0, "This Pokémon is shaped like ancient writing. It is a mystery as to which came first, the ancient writings or the various Unown. Research into this topic is ongoing but nothing is known.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/201.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/201.png", 0f, "Unown", 134.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 202,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 60.0, 106.0, "If two or more Wobbuffet meet, they will turn competitive and try to outdo each other's endurance. However, they may try to see which one can endure the longest without food. Trainers need to beware of this habit.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/202.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/202.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/202.png", "Wobbuffet", 382.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 203,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 182.0, 133.0, "Girafarig's rear head also has a brain, but it is small. The rear head attacks in response to smells and sounds. Approaching this Pokémon from behind can cause the rear head to suddenly lash out and bite.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/203.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/203.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/203.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/203.png", "Girafarig", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 204,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 108.0, 122.0, "Pineco hangs from a tree branch and patiently waits for prey to come along. If the Pokémon is disturbed while eating by someone shaking its tree, it drops down to the ground and explodes with no warning.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/204.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/204.png", null, "Pineco", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 205,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 161.0, 205.0, "Forretress conceals itself inside its hardened steel shell. The shell is opened when the Pokémon is catching prey, but it does so at such a quick pace that the shell's inside cannot be seen.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/205.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/205.png", 0.5f, "Forretress", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 206,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 131.0, 128.0, "Dunsparce has a drill for its tail. It uses this tail to burrow into the ground backward. This Pokémon is known to make its nest in complex shapes deep under the ground.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/206.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/206.png", 0.5f, "Dunsparce", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 207,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name" },
                values: new object[] { 143.0, 184.0, "Gligar glides through the air without a sound as if it were sliding. This Pokémon hangs on to the face of its foe using its clawed hind legs and the large pincers on its forelegs, then injects the prey with its poison barb.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/207.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/207.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/207.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/207.png", "Gligar" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 208,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 148.0, 272.0, "Steelix lives even further underground than Onix. This Pokémon is known to dig toward the earth's core. There are records of this Pokémon reaching a depth of over six-tenths of a mile underground.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/208.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/208.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/208.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/208.png", "Steelix", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 209,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 137.0, 85.0, "By baring its fangs and making a scary face, Snubbull sends smaller Pokémon scurrying away in terror. However, this Pokémon seems a little sad at making its foes flee.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/209.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/209.png", 0.25f, "Snubbull", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 210,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 212.0, 131.0, "Granbull has a particularly well-developed lower jaw. The enormous fangs are heavy, causing the Pokémon to tip its head back for balance. Unless it is startled, it will not try to bite indiscriminately.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/210.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/210.png", null, 0.25f, "Granbull", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 211,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 184.0, 138.0, "Qwilfish sucks in water, inflating itself. This Pokémon uses the pressure of the water it swallowed to shoot toxic quills all at once from all over its body. It finds swimming somewhat challenging.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/211.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/211.png", null, "Qwilfish", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 212,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 236.0, 181.0, "Scizor has a body with the hardness of steel. It is not easily fazed by ordinary sorts of attacks. This Pokémon flaps its wings to regulate its body temperature.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/212.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/212.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/212.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/212.png", "Scizor", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 213,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 17.0, 396.0, "Shuckle quietly hides itself under rocks, keeping its body concealed inside its hard shell while eating berries it has stored away. The berries mix with its body fluids to become a juice.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/213.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/213.png", null, "Shuckle", 85.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 214,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 234.0, 179.0, "Heracross charges in a straight line at its foe, slips beneath the foe's grasp, and then scoops up and hurls the opponent with its mighty horn. This Pokémon even has enough power to topple a massive tree.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/214.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/214.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/214.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/214.png", "Heracross", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 215,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 189.0, 146.0, "Sneasel scales trees by punching its hooked claws into the bark. This Pokémon seeks out unguarded nests and steals eggs for food while the parents are away.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/215.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/215.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/215.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/215.png", "Sneasel", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 216,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 142.0, 93.0, "This Pokémon likes to lick its palms that are sweetened by being soaked in honey. Teddiursa concocts its own honey by blending fruits and pollen collected by Beedrill.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/216.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/216.png", "Teddiursa", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 217,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 236.0, 144.0, "In the forests inhabited by Ursaring, it is said that there are many streams and towering trees where they gather food. This Pokémon walks through its forest gathering food every day.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/217.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/217.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/217.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/217.png", "Ursaring", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 218,
                columns: new[] { "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 71.0, "Molten magma courses throughout Slugma's circulatory system. If this Pokémon is chilled, the magma cools and hardens. Its body turns brittle and chunks fall off, reducing its size.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/218.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/218.png", 0.5f, "Slugma", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 219,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 139.0, 191.0, "Magcargo's shell is actually its skin that hardened as a result of cooling. Its shell is very brittle and fragile—just touching it causes it to crumble apart. This Pokémon returns to its original size by dipping itself in magma.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/219.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/219.png", "Magcargo", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 220,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 90.0, 69.0, "Swinub roots for food by rubbing its snout against the ground. Its favorite food is a mushroom that grows under the cover of dead grass. This Pokémon occasionally roots out hot springs.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/220.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/220.png", null, "Swinub", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 221,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 181.0, 138.0, "Piloswine is covered by a thick coat of long hair that enables it to endure the freezing cold. This Pokémon uses its tusks to dig up food that has been buried under ice.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/221.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/221.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/221.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/221.png", "Piloswine", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 222,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 118.0, 156.0, "Corsola's branches glitter very beautifully in seven colors when they catch sunlight. If any branch breaks off, this Pokémon grows it back in just one night.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/222.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/222.png", 0.25f, "Corsola", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 223,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 127.0, 69.0, "Remoraid sucks in water, then expels it at high velocity using its abdominal muscles to shoot down flying prey. When evolution draws near, this Pokémon travels downstream from rivers.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/223.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/223.png", "Remoraid", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 224,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 197.0, 141.0, "Octillery grabs onto its foe using its tentacles. This Pokémon tries to immobilize it before delivering the finishing blow. If the foe turns out to be too strong, Octillery spews ink to escape.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/224.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/224.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/224.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/224.png", "Octillery", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 225,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 128.0, 90.0, "Delibird carries its food bundled up in its tail. There once was a famous explorer who managed to reach the peak of the world's highest mountain, thanks to one of these Pokémon sharing its food.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/225.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/225.png", null, "Delibird", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 226,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 148.0, 226.0, "On sunny days, schools of Mantine can be seen elegantly leaping over the sea's waves. This Pokémon is not bothered by the Remoraid that hitches rides.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/226.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/226.png", "Mantine", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 227,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 148.0, 226.0, "Skarmory is entirely encased in hard, protective armor. This Pokémon flies at close to 190 mph. It slashes foes with its wings that possess swordlike cutting edges.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/227.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/227.png", "Skarmory", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 228,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 152.0, 83.0, "Houndour hunt as a coordinated pack. They communicate with each other using a variety of cries to corner their prey. This Pokémon's remarkable teamwork is unparalleled.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/228.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/228.png", null, "Houndour", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 229,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 224.0, 144.0, "In a Houndoom pack, the one with its horns raked sharply toward the back serves a leadership role. These Pokémon choose their leader by fighting among themselves.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/229.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/229.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/229.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/229.png", 0.5f, "Houndoom", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 230,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 194.0, 194.0, "Kingdra lives at extreme ocean depths that are otherwise uninhabited. It has long been believed that the yawning of this Pokémon creates spiraling ocean currents.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/230.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/230.png", "Kingdra", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 231,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 107.0, 98.0, "For its nest, Phanpy digs a vertical pit in the ground at the edge of a river. It marks the area around its nest with its trunk to let the others know that the area has been claimed.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/231.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/231.png", "Phanpy", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 232,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 214.0, 185.0, "Donphan's favorite attack is curling its body into a ball, then charging at its foe while rolling at high speed. Once it starts rolling, this Pokémon can't stop very easily.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/232.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/232.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/232.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/232.png", 0.5f, "Donphan", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 233,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 198.0, 180.0, "Porygon2 was created by humans using the power of science. The man-made Pokémon has been endowed with artificial intelligence that enables it to learn new gestures and emotions on its own.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/233.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/233.png", 0f, "Porygon2", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 234,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 192.0, 131.0, "Stantler's magnificent antlers were traded at high prices as works of art. As a result, this Pokémon was hunted close to extinction by those who were after the priceless antlers.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/234.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/234.png", 0.5f, "Stantler", 177.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 235,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 40.0, 83.0, "Smeargle marks the boundaries of its territory using a body fluid that leaks out from the tip of its tail. Over 5,000 different marks left by this Pokémon have been found.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/235.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/235.png", 0.5f, "Smeargle", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 236,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 64.0, 64.0, "Tyrogue becomes stressed out if it does not get to train every day. When raising this Pokémon, the Trainer must establish and uphold various training methods.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/236.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/236.png", 1f, "Tyrogue", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 237,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 173.0, 207.0, "Hitmontop spins on its head at high speed, all the while delivering kicks. This technique is a remarkable mix of both offense and defense at the same time. The Pokémon travels faster spinning than it does walking.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/237.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/237.png", 1f, "Hitmontop", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 238,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 153.0, 91.0, "Smoochum actively runs about, but also falls quite often. Whenever the chance arrives, it will look for its reflection to make sure its face hasn't become dirty.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/238.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/238.png", "Smoochum", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 239,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 135.0, 101.0, "Elekid stores electricity in its body. If it touches metal and accidentally discharges all its built-up electricity, this Pokémon begins swinging its arms in circles to recharge itself.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/239.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/239.png", 0.75f, "Elekid", "common", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 240,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 151.0, 99.0, "Magby's state of health is determined by observing the fire it breathes. If the Pokémon is spouting yellow flames from its mouth, it is in good health. When it is fatigued, black smoke will be mixed in with the flames.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/240.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/240.png", 0.75f, "Magby", "common", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 241,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 157.0, 193.0, "Miltank gives over five gallons of milk on a daily basis. Its sweet milk is enjoyed by children and grown-ups alike. People who can't drink milk turn it into yogurt and eat it instead.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/241.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/241.png", "Miltank", "common", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 242,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 129.0, 169.0, "Blissey senses sadness with its fluffy coat of fur. If it does so, this Pokémon will rush over to a sad person, no matter how far away, to share a Lucky Egg that brings a smile to any face.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/242.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/242.png", 0f, "Blissey", 496.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 243,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 241.0, 195.0, "Raikou embodies the speed of lightning. The roars of this Pokémon send shock waves shuddering through the air and shake the ground as if lightning bolts had come crashing down.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/243.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/243.png", 0f, "Raikou", "Legendary", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 244,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 235.0, 171.0, "Entei embodies the passion of magma. This Pokémon is thought to have been born in the eruption of a volcano. It sends up massive bursts of fire that utterly consume all that they touch.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/244.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/244.png", 0f, "Entei", "Legendary", 251.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 245,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 180.0, 235.0, "Suicune embodies the compassion of a pure spring of water. It runs across the land with gracefulness. This Pokémon has the power to purify dirty water.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/245.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/245.png", "Suicune", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 246,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 115.0, 93.0, "Larvitar is born deep under the ground. To come up to the surface, this Pokémon must eat its way through the soil above. Until it does so, Larvitar cannot see its parents.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/246.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/246.png", 0.5f, "Larvitar", "common", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 247,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 155.0, 133.0, "Pupitar creates a gas inside its body that it compresses and forcefully ejects to propel itself like a jet. The body is very durable—it avoids damage even if it hits solid steel.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/247.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/247.png", 0.5f, "Pupitar", "common", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 248,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 251.0, 207.0, "Tyranitar is so overwhelmingly powerful, it can bring down a whole mountain to make its nest. This Pokémon wanders about in mountains seeking new opponents to fight.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/248.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/248.png", 0.5f, "Tyranitar", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 249,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 193.0, 310.0, "Lugia's wings pack devastating power—a light fluttering of its wings can blow apart regular houses. As a result, this Pokémon chooses to live out of sight deep under the sea.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/249.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/249.png", 0f, "Lugia", "Legendary", 235.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 250,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 239.0, 244.0, "Ho-Oh's feathers glow in seven colors depending on the angle at which they are struck by light. These feathers are said to bring happiness to the bearers. This Pokémon is said to live at the foot of a rainbow.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/250.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/250.png", 0f, "Ho-Oh", "Legendary", 214.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 251,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 210.0, 210.0, "This Pokémon came from the future by crossing over time. It is thought that so long as Celebi appears, a bright and shining future awaits us.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/251.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/251.png", null, 0f, "Celebi", "Mythical", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 252,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 124.0, 94.0, "Treecko has small hooks on the bottom of its feet that enable it to scale vertical walls. This Pokémon attacks by slamming foes with its thick tail.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/252.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/252.png", null, "Treecko", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 253,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 172.0, 120.0, "The leaves growing out of Grovyle's body are convenient for camouflaging it from enemies in the forest. This Pokémon is a master at climbing trees in jungles.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/253.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/253.png", null, "Grovyle", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 254,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 223.0, 169.0, "The leaves growing on Sceptile's body are very sharp edged. This Pokémon is very agile—it leaps all over the branches of trees and jumps on its foe from above or behind.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/254.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/254.png", "Sceptile", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 255,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 130.0, 87.0, "Torchic sticks with its Trainer, following behind with unsteady steps. This Pokémon breathes fire of over 1,800 degrees Fahrenheit, including fireballs that leave the foe scorched black.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/255.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/255.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/255.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/255.png", "Torchic", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 256,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 163.0, 115.0, "Combusken toughens up its legs and thighs by running through fields and mountains. This Pokémon's legs possess both speed and power, enabling it to dole out 10 kicks in one second.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/256.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/256.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/256.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/256.png", "Combusken", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 257,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 240.0, 141.0, "In battle, Blaziken blows out intense flames from its wrists and attacks foes courageously. The stronger the foe, the more intensely this Pokémon's wrists burn.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/257.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/257.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/257.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/257.png", 0.875f, "Blaziken", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 258,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 126.0, 93.0, "The fin on Mudkip's head acts as highly sensitive radar. Using this fin to sense movements of water and air, this Pokémon can determine what is taking place around it without using its eyes.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/258.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/258.png", 0.875f, "Mudkip", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 259,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 156.0, 133.0, "The surface of Marshtomp's body is enveloped by a thin, sticky film that enables it to live on land. This Pokémon plays in mud on beaches when the ocean tide is low.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/259.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/259.png", 0.875f, "Marshtomp", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 260,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 208.0, 175.0, "Swampert is very strong. It has enough power to easily drag a boulder weighing more than a ton. This Pokémon also has powerful vision that lets it see even in murky water.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/260.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/260.png", 0.875f, "Swampert", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 261,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 96.0, 61.0, "At first sight, Poochyena takes a bite at anything that moves. This Pokémon chases after prey until the victim becomes exhausted. However, it may turn tail if the prey strikes back.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/261.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/261.png", null, "Poochyena", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 262,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 171.0, 132.0, "Mightyena gives obvious signals when it is preparing to attack. It starts to growl deeply and then flattens its body. This Pokémon will bite savagely with its sharply pointed fangs.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/262.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/262.png", "Mightyena", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 265,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 75.0, 59.0, "Using the spikes on its rear end, Wurmple peels the bark off trees and feeds on the sap that oozes out. This Pokémon's feet are tipped with suction pads that allow it to cling to glass without slipping.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/265.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/265.png", "Wurmple", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 266,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 60.0, 77.0, "Silcoon tethers itself to a tree branch using silk to keep from falling. There, this Pokémon hangs quietly while it awaits evolution. It peers out of the silk cocoon through a small hole.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/266.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/266.png", null, "Silcoon", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 267,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 189.0, 98.0, "Beautifly's favorite food is the sweet pollen of flowers. If you want to see this Pokémon, just leave a potted flower by an open window. Beautifly is sure to come looking for pollen.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/267.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/267.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/267.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/267.png", "Beautifly", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 268,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 60.0, 77.0, "Cascoon makes its protective cocoon by wrapping its body entirely with a fine silk from its mouth. Once the silk goes around its body, it hardens. This Pokémon prepares for its evolution inside the cocoon.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/268.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/268.png", null, "Cascoon", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 269,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 98.0, 162.0, "Dustox is instinctively drawn to light. Swarms of this Pokémon are attracted by the bright lights of cities, where they wreak havoc by stripping the leaves off roadside trees for food.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/269.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/269.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/269.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/269.png", "Dustox", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 270,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name" },
                values: new object[] { 71.0, 77.0, "Lotad live in ponds and lakes, where they float on the surface. It grows weak if its broad leaf dies. On rare occasions, this Pokémon travels on land in search of clean water.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/270.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/270.png", "Lotad" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 271,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name" },
                values: new object[] { 112.0, 119.0, "Lombre is nocturnal—it will get active after dusk. It is also a mischief maker. When this Pokémon spots anglers, it tugs on their fishing lines from beneath the surface and enjoys their consternation.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/271.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/271.png", "Lombre" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 272,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 173.0, 176.0, "Ludicolo begins dancing as soon as it hears cheerful, festive music. This Pokémon is said to appear when it hears the singing of children on hiking outings.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/272.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/272.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/272.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/272.png", "Ludicolo", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 273,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 71.0, 77.0, "Seedot attaches itself to a tree branch using the top of its head. It sucks moisture from the tree while hanging off the branch. The more water it drinks, the glossier this Pokémon's body becomes.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/273.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/273.png", "Seedot", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 274,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 134.0, 78.0, "Nuzleaf live in densely overgrown forests. They occasionally venture out of the forest to startle people. This Pokémon dislikes having its long nose pinched.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/274.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/274.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/274.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/274.png", "Nuzleaf", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 275,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 200.0, 121.0, "Shiftry is a mysterious Pokémon that is said to live atop towering trees dating back over a thousand years. It creates terrific windstorms with the fans it holds.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/275.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/275.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/275.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/275.png", "Shiftry", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 276,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 106.0, 61.0, "Taillow courageously stands its ground against foes, however strong they may be. This gutsy Pokémon will remain defiant even after a loss. On the other hand, it cries loudly if it becomes hungry.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/276.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/276.png", "Taillow", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 277,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 185.0, 124.0, "Swellow flies high above our heads, making graceful arcs in the sky. This Pokémon dives at a steep angle as soon as it spots its prey. The hapless prey is tightly grasped by Swellow's clawed feet, preventing escape.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/277.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/277.png", "Swellow", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 278,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 106.0, 61.0, "Wingull has the habit of carrying prey and valuables in its beak and hiding them in all sorts of locations. This Pokémon rides the winds and flies as if it were skating across the sky.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/278.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/278.png", "Wingull", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 279,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name" },
                values: new object[] { 175.0, 174.0, "Pelipper is a flying transporter that carries small Pokémon and eggs inside its massive bill. This Pokémon builds its nest on steep cliffs facing the sea.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/279.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/279.png", "Pelipper" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 280,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 79.0, 59.0, "Ralts senses the emotions of people using the horns on its head. This Pokémon rarely appears before people. But when it does, it draws closer if it senses that the person has a positive disposition.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/280.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/280.png", "Ralts", 99.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 281,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 117.0, 90.0, "It is said that a Kirlia that is exposed to the positive emotions of its Trainer grows beautiful. This Pokémon controls psychokinetic powers with its highly developed brain.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/281.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/281.png", "Kirlia", 116.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 282,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 237.0, 195.0, "Gardevoir has the ability to read the future. If it senses impending danger to its Trainer, this Pokémon is said to unleash its psychokinetic energy at full power.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/282.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/282.png", "Gardevoir", 169.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 283,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 93.0, 87.0, "From the tips of its feet, Surskit secretes an oil that enables it to walk on water as if it were skating. This Pokémon feeds on microscopic organisms in ponds and lakes.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/283.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/283.png", "Surskit", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 284,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 192.0, 150.0, "Masquerain intimidates enemies with the eyelike patterns on its antennas. This Pokémon flaps its four wings to freely fly in any direction—even sideways and backwards—as if it were a helicopter.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/284.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/284.png", "Masquerain", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 285,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 74.0, 110.0, "Shroomish live in damp soil in the dark depths of forests. They are often found keeping still under fallen leaves. This Pokémon feeds on compost that is made up of fallen, rotted leaves.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/285.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/285.png", "Shroomish", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 286,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 241.0, 144.0, "Breloom closes in on its foe with light and sprightly footwork, then throws punches with its stretchy arms. This Pokémon's fighting technique puts boxers to shame.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/286.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/286.png", 0.5f, "Breloom", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 287,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 104.0, 92.0, "Slakoth lolls around for over 20 hours every day. Because it moves so little, it does not need much food. This Pokémon's sole daily meal consists of just three leaves.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/287.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/287.png", "Slakoth", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 288,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 159.0, 145.0, "Vigoroth is always itching and agitated to go on a wild rampage. It simply can't tolerate sitting still for even a minute. This Pokémon's stress level rises if it can't be moving constantly.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/288.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/288.png", "Vigoroth", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 289,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 290.0, 166.0, "Slaking spends all day lying down and lolling about. It eats grass growing within its reach. If it eats all the grass it can reach, this Pokémon reluctantly moves to another spot.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/289.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/289.png", "Slaking", 284.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 290,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 80.0, 126.0, "Nincada lives underground for many years in complete darkness. This Pokémon absorbs nutrients from the roots of trees. It stays motionless as it waits for evolution.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/290.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/290.png", 0.5f, "Nincada", 104.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 291,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 199.0, 112.0, "Ninjask moves around at such a high speed that it cannot be seen, even while its crying can be clearly heard. For that reason, this Pokémon was long believed to be invisible.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/291.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/291.png", 0.5f, "Ninjask", 156.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 292,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 153.0, 73.0, "Shedinja's hard body doesn't move—not even a twitch. In fact, its body appears to be merely a hollow shell. It is believed that this Pokémon will steal the spirit of anyone peering into its hollow body from its back.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/292.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/292.png", 0f, "Shedinja", 1.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 293,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 92.0, 42.0, "Normally, Whismur's voice is very quiet—it is barely audible even if one is paying close attention. However, if this Pokémon senses danger, it starts crying at an earsplitting volume.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/293.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/293.png", "Whismur", 162.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 294,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 134.0, 81.0, "Loudred's bellowing can completely decimate a wood-frame house. It uses its voice to punish its foes. This Pokémon's round ears serve as loudspeakers.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/294.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/294.png", 0.5f, "Loudred", 197.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 295,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 179.0, 137.0, "Exploud triggers earthquakes with the tremors it creates by bellowing. If this Pokémon violently inhales from the ports on its body, it's a sign that it is preparing to let loose a huge bellow.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/295.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/295.png", 0.5f, "Exploud", 232.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 296,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 99.0, 54.0, "Makuhita is tenacious—it will keep getting up and attacking its foe however many times it is knocked down. Every time it gets back up, this Pokémon stores more energy in its body for evolving.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/296.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/296.png", 0.75f, "Makuhita", 176.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 297,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 209.0, 114.0, "Hariyama practices its straight-arm slaps in any number of locations. One hit of this Pokémon's powerful, openhanded, straight-arm punches could snap a telephone pole in two.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/297.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/297.png", 0.75f, "Hariyama", 302.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 298,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name" },
                values: new object[] { 36.0, 71.0, "Azurill spins its tail as if it were a lasso, then hurls it far. The momentum of the throw sends its body flying, too. Using this unique action, one of these Pokémon managed to hurl itself a record 33 feet.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/298.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/298.png", 0.25f, "Azurill" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 299,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 82.0, 215.0, "Nosepass's magnetic nose is always pointed to the north. If two of these Pokémon meet, they cannot turn their faces to each other when they are close because their magnetic noses repel one another.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/299.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/299.png", "Nosepass", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 300,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 84.0, 79.0, "Skitty has the habit of becoming fascinated by moving objects and chasing them around. This Pokémon is known to chase after its own tail and become dizzy.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/300.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/300.png", 0.25f, "Skitty", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 301,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 132.0, 127.0, "Delcatty prefers to live an unfettered existence in which it can do as it pleases at its own pace. Because this Pokémon eats and sleeps whenever it decides, its daily routines are completely random.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/301.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/301.png", null, 0.25f, "Delcatty", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 302,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 141.0, 136.0, "Sableye lead quiet lives deep inside caverns. They are feared, however, because these Pokémon are thought to steal the spirits of people when their eyes burn with a sinister glow in the darkness.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/302.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/302.png", null, "Sableye", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 303,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 155.0, 141.0, "Mawile's huge jaws are actually steel horns that have been transformed. Its docile-looking face serves to lull its foe into letting down its guard. When the foe least expects it, Mawile chomps it with its gaping jaws.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/303.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/303.png", "Mawile", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 304,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 121.0, 141.0, "This Pokémon has a body of steel. To make its body, Aron feeds on iron ore that it digs from mountains. Occasionally, it causes major trouble by eating bridges and rails.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/304.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/304.png", "Aron", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 305,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name" },
                values: new object[] { 158.0, 198.0, "Lairon tempers its steel body by drinking highly nutritious mineral springwater until it is bloated. This Pokémon makes its nest close to springs of delicious water.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/305.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/305.png", "Lairon" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 306,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 198.0, 257.0, "Aggron claims an entire mountain as its own territory. It mercilessly beats up anything that violates its environment. This Pokémon vigilantly patrols its territory at all times.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/306.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/306.png", "Aggron", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 307,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 78.0, 107.0, "Meditite undertakes rigorous mental training deep in the mountains. However, whenever it meditates, this Pokémon always loses its concentration and focus. As a result, its training never ends.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/307.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/307.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/307.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/307.png", 0.5f, "Meditite", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 308,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 121.0, 152.0, "It is said that through meditation, Medicham heightens energy inside its body and sharpens its sixth sense. This Pokémon hides its presence by merging itself with fields and mountains.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/308.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/308.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/308.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/308.png", 0.5f, "Medicham", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 309,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 123.0, 78.0, "Electrike stores electricity in its long body hair. This Pokémon stimulates its leg muscles with electric charges. These jolts of power give its legs explosive acceleration performance.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/309.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/309.png", null, "Electrike", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 310,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name" },
                values: new object[] { 215.0, 127.0, "Manectric is constantly discharging electricity from its mane. The sparks sometimes ignite forest fires. When it enters a battle, this Pokémon creates thunderclouds.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/310.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/310.png", null, "Manectric" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 311,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 167.0, 129.0, "Plusle always acts as a cheerleader for its partners. Whenever a teammate puts out a good effort in battle, this Pokémon shorts out its body to create the crackling noises of sparks to show its joy.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/311.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/311.png", null, "Plusle", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 312,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 147.0, 150.0, "Minun is more concerned about cheering on its partners than its own safety. It shorts out the electricity in its body to create brilliant showers of sparks to cheer on its teammates.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/312.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/312.png", "Minun", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 313,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 143.0, 166.0, "With the arrival of night, Volbeat emits light from its tail. It communicates with others by adjusting the intensity and flashing of its light. This Pokémon is attracted by the sweet aroma of Illumise.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/313.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/313.png", 1f, "Volbeat", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 314,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 143.0, 166.0, "Illumise attracts a swarm of Volbeat using a sweet fragrance. Once the Volbeat have gathered, this Pokémon leads the lit-up swarm in drawing geometric designs on the canvas of the night sky.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/314.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/314.png", 0f, "Illumise", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 315,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 186.0, 131.0, "Roselia shoots sharp thorns as projectiles at any opponent that tries to steal the flowers on its arms. The aroma of this Pokémon brings serenity to living things.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/315.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/315.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/315.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/315.png", "Roselia", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 316,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 80.0, 99.0, "Virtually all of Gulpin's body is its stomach. As a result, it can swallow something its own size. This Pokémon's stomach contains a special fluid that digests anything.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/316.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/316.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/316.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/316.png", "Gulpin", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 317,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 140.0, 159.0, "When Swalot spots prey, it spurts out a hideously toxic fluid from its pores and sprays the target. Once the prey has weakened, this Pokémon gulps it down whole with its cavernous mouth.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/317.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/317.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/317.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/317.png", "Swalot", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 318,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 171.0, 39.0, "Carvanha's strongly developed jaws and its sharply pointed fangs pack the destructive power to rip out boat hulls. Many boats have been attacked and sunk by this Pokémon.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/318.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/318.png", "Carvanha", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 319,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 243.0, 83.0, "Nicknamed “the bully of the sea,” Sharpedo is widely feared. Its cruel fangs grow back immediately if they snap off. Just one of these Pokémon can thoroughly tear apart a supertanker.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/319.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/319.png", "Sharpedo", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 320,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 136.0, 68.0, "Wailmer's nostrils are located above its eyes. This playful Pokémon loves to startle people by forcefully snorting out seawater it stores inside its body out of its nostrils.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/320.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/320.png", "Wailmer", 277.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 321,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 175.0, 87.0, "Wailord is the largest of all identified Pokémon up to now. This giant Pokémon swims languorously in the vast open sea, eating massive amounts of food at once with its enormous mouth.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/321.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/321.png", "Wailord", 347.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 322,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 119.0, 79.0, "Numel is extremely dull witted—it doesn't notice being hit. However, it can't stand hunger for even a second. This Pokémon's body is a seething cauldron of boiling magma.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/322.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/322.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/322.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/322.png", "Numel", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 323,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 194.0, 136.0, "Camerupt has a volcano inside its body. Magma of 18,000 degrees Fahrenheit courses through its body. Occasionally, the humps on this Pokémon's back erupt, spewing the superheated magma.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/323.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/323.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/323.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/323.png", "Camerupt", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 324,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 151.0, 203.0, "Torkoal digs through mountains in search of coal. If it finds some, it fills hollow spaces on its shell with the coal and burns it. If it is attacked, this Pokémon spouts thick black smoke to beat a retreat.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/324.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/324.png", "Torkoal", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 325,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 125.0, 122.0, "Spoink bounces around on its tail. The shock of its bouncing makes its heart pump. As a result, this Pokémon cannot afford to stop bouncing—if it stops, its heart will stop.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/325.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/325.png", "Spoink", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 326,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 171.0, 188.0, "Grumpig uses the black pearls on its body to amplify its psychic power waves for gaining total control over its foe. When this Pokémon uses its special power, its snorting breath grows labored.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/326.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/326.png", null, "Grumpig", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 327,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 116.0, 116.0, "All the Spinda that exist in the world are said to have utterly unique spot patterns. The shaky, tottering steps of this Pokémon give it the appearance of dancing.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/327.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/327.png", "Spinda", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 328,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 162.0, 78.0, "Trapinch's nest is a sloped, bowl-like pit dug in sand. This Pokémon patiently waits for prey to tumble down the pit. Its giant jaws have enough strength to crush even boulders.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/328.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/328.png", "Trapinch", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 329,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 134.0, 99.0, "To make prey faint, Vibrava generates ultrasonic waves by vigorously making its two wings vibrate. This Pokémon's ultrasonic waves are so powerful, they can bring on headaches in people.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/329.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/329.png", "Vibrava", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 330,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 205.0, 168.0, "Flygon is nicknamed “the elemental spirit of the desert.” Because its flapping wings whip up a cloud of sand, this Pokémon is always enveloped in a sandstorm while flying.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/330.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/330.png", "Flygon", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 331,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 156.0, 74.0, "Cacnea lives in arid locations such as deserts. It releases a strong aroma from its flower to attract prey. When prey comes near, this Pokémon shoots sharp thorns from its body to bring the victim down.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/331.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/331.png", 0.5f, "Cacnea", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 332,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 221.0, 115.0, "During the daytime, Cacturne remains unmoving so that it does not lose any moisture to the harsh desert sun. This Pokémon becomes active at night when the temperature drops.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/332.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/332.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/332.png", 0.5f, "Cacturne", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 333,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 76.0, 132.0, "Swablu has light and fluffy wings that are like cottony clouds. This Pokémon is not frightened of people. It lands on the heads of people and sits there like a cotton-fluff hat.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/333.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/333.png", "Swablu", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 334,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 141.0, 201.0, "Altaria dances and wheels through the sky among billowing, cotton-like clouds. By singing melodies in its crystal-clear voice, this Pokémon makes its listeners experience dreamy wonderment.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/334.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/334.png", "Altaria", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 335,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 222.0, 124.0, "Memories of battling its archrival Seviper are etched into every cell of Zangoose's body. This Pokémon adroitly dodges attacks with incredible agility.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/335.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/335.png", "Zangoose", 177.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 336,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 196.0, 118.0, "Seviper shares a generations-long feud with Zangoose. The scars on its body are evidence of vicious battles. This Pokémon attacks using its sword-edged tail.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/336.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/336.png", "Seviper", 177.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 337,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 178.0, 153.0, "Lunatone was discovered at a location where a meteoroid fell. As a result, some people theorize that this Pokémon came from space. However, no one has been able to prove this theory so far.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/337.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/337.png", "Lunatone", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 338,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 178.0, 153.0, "Solrock is a new species of Pokémon that is said to have fallen from space. It floats in air and moves silently. In battle, this Pokémon releases intensely bright light.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/338.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/338.png", "Solrock", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 339,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 93.0, 82.0, "Barboach's sensitive whiskers serve as a superb radar system. This Pokémon hides in mud, leaving only its two whiskers exposed while it waits for prey to come along.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/339.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/339.png", 0.5f, "Barboach", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 340,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 151.0, 141.0, "Whiscash is extremely territorial. Just one of these Pokémon will claim a large pond as its exclusive territory. If a foe approaches it, it thrashes about and triggers a massive earthquake.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/340.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/340.png", 0.5f, "Whiscash", 242.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 341,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 141.0, 99.0, "Corphish were originally foreign Pokémon that were imported as pets. They eventually turned up in the wild. This Pokémon is very hardy and has greatly increased its population.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/341.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/341.png", 0.5f, "Corphish", 125.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 342,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 224.0, 142.0, "Crawdaunt has an extremely violent nature that compels it to challenge other living things to battle. Other life-forms refuse to live in ponds inhabited by this Pokémon, making them desolate places.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/342.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/342.png", 0.5f, "Crawdaunt", 160.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 343,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 77.0, 124.0, "Baltoy moves while spinning around on its one foot. Primitive wall paintings depicting this Pokémon living among people were discovered in some ancient ruins.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/343.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/343.png", 0f, "Baltoy", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 344,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 140.0, 229.0, "Claydol are said to be dolls of mud made by primitive humans and brought to life by exposure to a mysterious ray. This Pokémon moves about while levitating.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/344.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/344.png", null, 0f, "Claydol", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 345,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 105.0, 150.0, "Lileep became extinct approximately a hundred million years ago. This ancient Pokémon attaches itself to a rock on the seafloor and catches approaching prey using tentacles shaped like flower petals.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/345.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/345.png", 0.875f, "Lileep", 165.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 346,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 152.0, 194.0, "Cradily roams around the ocean floor in search of food. This Pokémon freely extends its tree trunk-like neck and captures unwary prey using its eight tentacles.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/346.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/346.png", true, 0.875f, "Cradily", 200.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 347,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 176.0, 100.0, "Anorith was regenerated from a prehistoric fossil. This primitive Pokémon once lived in warm seas. It grips its prey firmly between its two large claws.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/347.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/347.png", 0.875f, "Anorith", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 348,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 222.0, 174.0, "Armaldo's tough armor makes all attacks bounce off. This Pokémon's two enormous claws can be freely extended or contracted. They have the power to punch right through a steel slab.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/348.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/348.png", 0.875f, "Armaldo", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 349,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name" },
                values: new object[] { 29.0, 85.0, "Feebas's fins are ragged and tattered from the start of its life. Because of its shoddy appearance, this Pokémon is largely ignored. It is capable of living in both the sea and in rivers.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/349.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/349.png", "Feebas" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 350,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 192.0, 219.0, "Milotic is said to be the most beautiful of all the Pokémon. It has the power to becalm such emotions as anger and hostility to quell bitter feuding.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/350.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/350.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/350.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/350.png", "Milotic", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 351,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 139.0, 139.0, "Castform's appearance changes with the weather. This Pokémon gained the ability to use the vast power of nature to protect its tiny body.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/351.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/351.png", "Castform", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 352,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "isActive", "name", "stamina" },
                values: new object[] { 161.0, 189.0, "Kecleon is capable of changing its body colors at will to blend in with its surroundings. There is one exception—this Pokémon can't change the zigzag pattern on its belly.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/352.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/352.png", false, "Kecleon", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 353,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 138.0, 65.0, "Shuppet is attracted by feelings of jealousy and vindictiveness. If someone develops strong feelings of vengeance, this Pokémon will appear in a swarm and line up beneath the eaves of that person's home.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/353.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/353.png", "Shuppet", 127.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 354,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 218.0, 126.0, "Banette generates energy for laying strong curses by sticking pins into its own body. This Pokémon was originally a pitiful plush doll that was thrown away.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/354.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/354.png", "Banette", 162.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 355,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 70.0, 162.0, "Duskull can pass through any wall no matter how thick it may be. Once this Pokémon chooses a target, it will doggedly pursue the intended victim until the break of dawn.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/355.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/355.png", "Duskull", 85.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 356,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 124.0, 234.0, "Dusclops's body is completely hollow—there is nothing at all inside. It is said that its body is like a black hole. This Pokémon will absorb anything into its body, but nothing will ever come back out.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/356.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/356.png", "Dusclops", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 357,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 136.0, 163.0, "The bunches of fruit around Tropius's neck are very popular with children. This Pokémon loves fruit, and eats it continuously. Apparently, its love for fruit resulted in its own outgrowth of fruit.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/357.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/357.png", "Tropius", 223.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 358,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 175.0, 170.0, "Chimecho makes its cries echo inside its hollow body. When this Pokémon becomes enraged, its cries result in ultrasonic waves that have the power to knock foes flying.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/358.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/358.png", "Chimecho", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 359,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 246.0, 120.0, "Every time Absol appears before people, it is followed by a disaster such as an earthquake or a tidal wave. As a result, it came to be known as the disaster Pokémon.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/359.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/359.png", "Absol", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 360,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 41.0, 86.0, "Wynaut can always be seen with a big, happy smile on its face. Look at its tail to determine if it is angry. When angered, this Pokémon will be slapping the ground with its tail.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/360.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/360.png", "Wynaut", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 361,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 95.0, 95.0, "Snorunt live in regions with heavy snowfall. In seasons without snow, such as spring and summer, this Pokémon steals away to live quietly among stalactites and stalagmites deep in caverns.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/361.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/361.png", "Snorunt", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 362,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 162.0, 162.0, "Glalie has a body made of rock, which it hardens with an armor of ice. This Pokémon has the ability to freeze moisture in the atmosphere into any shape it desires.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/362.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/362.png", "Glalie", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 363,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 95.0, 90.0, "Spheal is much faster rolling than walking to get around. When groups of this Pokémon eat, they all clap at once to show their pleasure. Because of this, their mealtimes are noisy.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/363.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/363.png", null, 0.5f, "Spheal", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 364,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 137.0, 132.0, "Sealeo has the habit of always juggling on the tip of its nose anything it sees for the first time. This Pokémon occasionally entertains itself by balancing and rolling a Spheal on its nose.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/364.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/364.png", 0.5f, "Sealeo", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 365,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 182.0, 176.0, "Walrein's two massively developed tusks can totally shatter blocks of ice weighing 10 tons with one blow. This Pokémon's thick coat of blubber insulates it from subzero temperatures.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/365.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/365.png", "Walrein", 242.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 366,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 133.0, 135.0, "Clamperl's sturdy shell is not only good for protection—it is also used for clamping and catching prey. A fully grown Clamperl's shell will be scored with nicks and scratches all over.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/366.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/366.png", "Clamperl", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 367,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 197.0, 179.0, "Huntail's presence went unnoticed by people for a long time because it lives at extreme depths in the sea. This Pokémon's eyes can see clearly even in the murky dark depths of the ocean.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/367.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/367.png", "Huntail", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 368,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 211.0, 179.0, "Gorebyss lives in the southern seas at extreme depths. Its body is built to withstand the enormous pressure of water at incredible depths. Because of this, this Pokémon's body is unharmed by ordinary attacks.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/368.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/368.png", 0.5f, "Gorebyss", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 369,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 162.0, 203.0, "Relicanth is a Pokémon species that existed for a hundred million years without ever changing its form. This ancient Pokémon feeds on microscopic organisms with its toothless mouth.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/369.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/369.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/369.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/369.png", 0.875f, "Relicanth", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 370,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 81.0, 128.0, "Luvdisc live in shallow seas in the tropics. This heart-shaped Pokémon earned its name by swimming after loving couples it spotted in the ocean's waves.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/370.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/370.png", 0.25f, "Luvdisc", 125.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 371,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 134.0, 93.0, "Bagon has a dream of one day soaring in the sky. In doomed efforts to fly, this Pokémon hurls itself off cliffs. As a result of its dives, its head has grown tough and as hard as tempered steel.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/371.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/371.png", 0.5f, "Bagon", "common", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 372,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 172.0, 155.0, "Inside Shelgon's armor-like shell, cells are in the midst of transformation to create an entirely new body. This Pokémon's shell is extremely heavy, making its movements sluggish.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/372.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/372.png", 0.5f, "Shelgon", "common", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 373,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 277.0, 168.0, "Salamence came about as a result of a strong, long-held dream of growing wings. It is said that this powerful desire triggered a sudden mutation in this Pokémon's cells, causing it to sprout its magnificent wings.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/373.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/373.png", 0.5f, "Salamence", "common", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 374,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 96.0, 132.0, "Instead of blood, a powerful magnetic force courses throughout Beldum's body. This Pokémon communicates with others by sending controlled pulses of magnetism.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/374.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/374.png", "Beldum", "common", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 375,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 138.0, 176.0, "When two Beldum fuse together, Metang is formed. The brains of the Beldum are joined by a magnetic nervous system. By linking its brains magnetically, this Pokémon generates strong psychokinetic power.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/375.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/375.png", 0f, "Metang", "common", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 376,
                columns: new[] { "attack", "description", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 257.0, "Metagross has four brains in total. Combined, the four brains can breeze through difficult calculations faster than a supercomputer. This Pokémon can float in the air by tucking in its four legs.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/376.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/376.png", "Metagross", "common", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 377,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 179.0, 309.0, "Regirock was sealed away by people long ago. If this Pokémon's body is damaged in battle, it is said to seek out suitable rocks on its own to repair itself.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/377.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/377.png", "Regirock", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 378,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 179.0, 309.0, "Regice's body was made during an ice age. The deep-frozen body can't be melted, even by fire. This Pokémon controls frigid air of -328 degrees Fahrenheit.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/378.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/378.png", "Regice", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 379,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 143.0, 285.0, "Registeel has a body that is harder than any kind of metal. Its body is apparently hollow. No one has any idea what this Pokémon eats.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/379.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/379.png", "Registeel", "Legendary", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 380,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 228.0, 246.0, "Latias is highly sensitive to the emotions of people. If it senses any hostility, this Pokémon ruffles the feathers all over its body and cries shrilly to intimidate the foe.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/380.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/380.png", 0f, "Latias", "Legendary", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 381,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 268.0, 212.0, "Latios has the ability to make others see an image of what it has seen or imagines in its head. This Pokémon is intelligent and understands human speech.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/381.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/381.png", 1f, "Latios", "Legendary", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 382,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 270.0, 228.0, "Through Primal Reversion and with nature's full power, it will take back its true form. It can summon storms that cause the sea levels to rise.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/382.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/382.png", 0f, "Kyogre", "Legendary", 205.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 383,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 270.0, 228.0, "Groudon is said to be the personification of the land itself. Legends tell of its many clashes against Kyogre, as each sought to gain the power of nature.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/383.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/383.png", 0f, "Groudon", "Legendary", 205.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 384,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 284.0, 170.0, "Rayquaza is said to have lived for hundreds of millions of years. Legends remain of how it put to rest the clash between Kyogre and Groudon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/384.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/384.png", 0f, "Rayquaza", "Legendary", 213.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 385,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 210.0, 210.0, "A legend states that Jirachi will make true any wish that is written on notes attached to its head when it awakens. If this Pokémon senses danger, it will fight without awakening.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/385.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/385.png", 0f, "Jirachi", "Mythical", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 387,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 119.0, 110.0, "It undertakes photosynthesis with its body, making oxygen. The leaf on its head wilts if it is thirsty.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/387.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/387.png", "Turtwig", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 388,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 157.0, 143.0, "It knows where pure water wells up. It carries fellow Pokémon there on its back.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/388.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/388.png", "Grotle", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 389,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 202.0, 188.0, "Small Pokémon occasionally gather on its unmoving back to begin building their nests.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/389.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/389.png", null, 0.875f, "Torterra", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 390,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 113.0, 86.0, "The gas made in its belly burns from its rear end. The fire burns weakly when it feels sick.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/390.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/390.png", null, 0.875f, "Chimchar", 127.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 391,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 158.0, 105.0, "It uses ceilings and walls to launch aerial attacks. Its fiery tail is but one weapon.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/391.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/391.png", null, 0.875f, "Monferno", 162.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 392,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 222.0, 151.0, "It tosses its enemies around with agility. It uses all its limbs to fight in its own unique style.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/392.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/392.png", null, 0.875f, "Infernape", 183.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 393,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 112.0, 102.0, "Because it is very proud, it hates accepting food from people. Its thick down guards it from cold.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/393.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/393.png", null, 0.875f, "Piplup", 142.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 394,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 150.0, 139.0, "It lives a solitary life. Its wings deliver wicked blows that can snap even the thickest of trees.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/394.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/394.png", null, 0.875f, "Prinplup", 162.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 395,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 210.0, 186.0, "The three horns that extend from its beak attest to its power. The leader has the biggest horns.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/395.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/395.png", null, 0.875f, "Empoleon", 197.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 396,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 101.0, 58.0, "They flock around mountains and fields, chasing after bug Pokémon. Their singing is noisy and annoying.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/396.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/396.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/396.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/396.png", "Starly", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 397,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 142.0, 94.0, "It lives in forests and fields. Squabbles over territory occur when flocks collide.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/397.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/397.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/397.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/397.png", "Staravia", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 398,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 234.0, 140.0, "When Staravia evolve into Staraptor, they leave the flock to live alone. They have sturdy wings.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/398.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/398.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/398.png", "Staraptor", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 399,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 80.0, 73.0, "It constantly gnaws on logs and rocks to whittle down its front teeth. It nests alongside water.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/399.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/399.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/399.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/399.png", "Bidoof", 153.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 400,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 162.0, 119.0, "It makes its nest by damming streams with bark and mud. It is known as an industrious worker.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/400.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/400.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/400.png", "Bibarel", 188.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 401,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 45.0, 74.0, "When its antennae hit each other, it sounds like the music of a xylophone.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/401.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/401.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/401.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/401.png", 0.5f, "Kricketot", 114.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 402,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 160.0, 100.0, "It signals its emotions with its melodies. Scientists are studying these melodic patterns.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/402.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/402.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/402.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/402.png", 0.5f, "Kricketune", 184.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 403,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 117.0, 64.0, "All of its fur dazzles if danger is sensed. It flees while the foe is momentarily blinded.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/403.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/403.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/403.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/403.png", 0.5f, "Shinx", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 404,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name" },
                values: new object[] { 159.0, 95.0, "Strong electricity courses through the tips of its sharp claws. A light scratch causes fainting in foes.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/404.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/404.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/404.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/404.png", 0.5f, "Luxio" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 405,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 232.0, 156.0, "Luxray's ability to see through objects comes in handy when it's scouting for danger.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/405.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/405.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/405.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/405.png", "Luxray", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 406,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 91.0, 109.0, "Over the winter, it closes its bud and endures the cold. In spring, the bud opens and releases pollen.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/406.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/406.png", 0.5f, "Budew", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 407,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 243.0, 185.0, "With the movements of a dancer, it strikes with whips that are densely lined with poison thorns.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/407.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/407.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/407.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/407.png", 0.5f, "Roserade", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 408,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 218.0, 71.0, "Its hard skull is its distinguishing feature. It snapped trees by headbutting them, and then it fed on their ripe berries.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/408.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/408.png", null, "Cranidos", 167.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 409,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 295.0, 109.0, "This ancient Pokémon used headbutts skillfully. Its brain was really small, so some theories suggest that its stupidity led to its extinction.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/409.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/409.png", 0.875f, "Rampardos", 219.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 410,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 76.0, 195.0, "Although its fossils can be found in layers of primeval rock, nothing but its face has ever been discovered.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/410.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/410.png", null, 0.875f, "Shieldon", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 411,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 94.0, 286.0, "This Pokémon is from roughly 100 million years ago. Its terrifyingly tough face is harder than steel.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/411.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/411.png", null, 0.875f, "Bastiodon", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 412,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 53.0, 83.0, "If its cloak is broken in battle, it quickly remakes the cloak with materials nearby.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/412.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/412.png", null, "Burmy", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 413,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 141.0, 180.0, "When Burmy evolved, its cloak became a part of this Pokémon's body. The cloak is never shed.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/413.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/413.png", 0f, "Wormadam", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 414,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name" },
                values: new object[] { 185.0, 98.0, "It flutters around at night and steals honey from the Combee hive.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/414.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/414.png", 1f, "Mothim" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 415,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 59.0, 83.0, "It collects and delivers honey to its colony. At night, they cluster to form a beehive and sleep.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/415.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/415.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/415.png", 0.875f, "Combee", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 416,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 149.0, 190.0, "Its abdomen is a honeycomb for grubs. It raises its grubs on honey collected by Combee.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/416.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/416.png", 0f, "Vespiquen", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 417,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 94.0, 172.0, "A pair may be seen rubbing their cheek pouches together in an effort to share stored electricity.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/417.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/417.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/417.png", "Pachirisu", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 418,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name" },
                values: new object[] { 132.0, 67.0, "It inflates the flotation sac around its neck and pokes its head out of the water to see what is going on.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/418.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/418.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/418.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/418.png", "Buizel" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 419,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 221.0, 114.0, "Its flotation sac developed as a result of pursuing aquatic prey. It can double as a rubber raft.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/419.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/419.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/419.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/419.png", "Floatzel", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 420,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 108.0, 92.0, "It evolves by sucking the energy out of the small ball where it had been storing nutrients.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/420.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/420.png", "Cherubi", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 421,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 170.0, 153.0, "If it senses strong sunlight, it opens its folded petals to absorb the sun's rays with its whole body.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/421.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/421.png", "Cherrim", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 424,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 205.0, 143.0, "It uses its tails for everything. If it wraps both of its tails around you and gives you a squeeze, that's proof it really likes you.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/424.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/424.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/424.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/424.png", "Ambipom", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 425,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 117.0, 80.0, "Wandering souls gathered together to form this Pokémon. When trying to make friends with children, Drifloon grabs them by the hand.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/425.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/425.png", "Drifloon", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 426,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 180.0, 102.0, "The raw material for the gas inside its body is souls. When its body starts to deflate, it's thought to carry away people and Pokémon.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/426.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/426.png", "Drifblim", 312.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 427,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 130.0, 105.0, "The reason it keeps one ear rolled up is so it can launch a swift counterattack if it's attacked by an enemy.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/427.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/427.png", 0.5f, "Buneary", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 428,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 156.0, 194.0, "It's notably wary and has a dislike of fighting, but at the same time, it can deliver powerful kicks with its lithe legs.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/428.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/428.png", 0.5f, "Lopunny", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 429,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 211.0, 187.0, "Its muttered curses can cause awful headaches or terrifying visions that torment others.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/429.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/429.png", "Mismagius", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 430,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name" },
                values: new object[] { 243.0, 103.0, "Its goons take care of most of the fighting for it. The only time it dirties its own hands is in delivering a final blow to finish off an opponent.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/430.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/430.png", 0.5f, "Honchkrow" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 431,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 109.0, 82.0, "When it's happy, Glameow demonstrates beautiful movements of its tail, like a dancing ribbon.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/431.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/431.png", 0.25f, "Glameow", 135.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 432,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 172.0, 133.0, "To make itself appear intimidatingly beefy, it tightly cinches its waist with its twin tails.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/432.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/432.png", 0.25f, "Purugly", 174.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 433,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 114.0, 94.0, "There is an orb inside its mouth. When it hops, the orb bounces all over and makes a ringing sound.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/433.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/433.png", null, "Chingling", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 434,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 121.0, 90.0, "It protects itself by spraying a noxious fluid from its rear. The stench lingers for 24 hours.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/434.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/434.png", null, "Stunky", 160.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 435,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 184.0, 132.0, "It sprays a stinky fluid from its tail. The fluid smells worse the longer it is allowed to fester.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/435.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/435.png", null, "Skuntank", 230.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 436,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 43.0, 154.0, "Implements shaped like it were discovered in ancient tombs. It is unknown if they are related.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/436.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/436.png", 0f, "Bronzor", 149.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 437,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 161.0, 213.0, "Ancient people believed that petitioning Bronzong for rain was the way to make crops grow.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/437.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/437.png", 0f, "Bronzong", 167.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 438,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 124.0, 133.0, "If its body gets too damp, it will die. So, in a process reminiscent of sweating, its eyes expel moisture.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/438.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/438.png", 0.5f, "Bonsly", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 440,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 25.0, 77.0, "When it sees something round and white, Happiny puts it into the pouch on its stomach. It sometimes becomes overloaded and can't move.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/440.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/440.png", null, 0f, "Happiny", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 441,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 183.0, 91.0, "It can learn and speak human words. If they gather, they all learn the same saying.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/441.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/441.png", "Chatot", 183.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 442,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 169.0, 199.0, "It was bound to a fissure in an odd keystone as punishment for misdeeds 500 years ago.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/442.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/442.png", "Spiritomb", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 443,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 124.0, 84.0, "Its original home is an area much hotter than Alola. If you're planning to live with one, your heating bill will soar.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/443.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/443.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/443.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/443.png", "Gible", 151.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 444,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 172.0, 125.0, "It sheds its skin and gradually grows larger. Its scales can be ground into a powder and used as raw materials for traditional medicine.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/444.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/444.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/444.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/444.png", "Gabite", 169.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 445,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 261.0, 193.0, "Its fine scales don't just reduce wind resistance—their sharp edges also cause injury to any opponent who attacks it.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/445.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/445.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/445.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/445.png", "Garchomp", 239.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 446,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 137.0, 117.0, "Anything that looks edible, Munchlax will go on and swallow whole. Its stomach is tough enough to handle it even if the food has gone rotten.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/446.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/446.png", null, 0.875f, "Munchlax", 286.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 447,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 127.0, 78.0, "It uses waves called auras to communicate with others of its kind. It doesn't make any noise during this time, so its enemies can't detect it.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/447.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/447.png", null, 0.875f, "Riolu", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 448,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 236.0, 144.0, "Lucario reads its opponent's feelings with its aura waves. It finds out things it would rather not know, so it gets stressed out easily.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/448.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/448.png", 0.875f, "Lucario", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 449,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 124.0, 118.0, "It enshrouds itself with sand to protect itself from germs. It does not enjoy getting wet.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/449.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/449.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/449.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/449.png", "Hippopotas", 169.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 450,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 201.0, 191.0, "It blasts internally stored sand from ports on its body to create a towering twister for attack.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/450.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/450.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/450.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/450.png", "Hippowdon", 239.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 451,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 93.0, 151.0, "It burrows under the sand to lie in wait for prey. Its tail claws can inject its prey with a savage poison.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/451.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/451.png", null, "Skorupi", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 452,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name" },
                values: new object[] { 180.0, 202.0, "It has the power in its clawed arms to make scrap of a car. The tips of its claws release poison.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/452.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/452.png", 0.5f, "Drapion" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 453,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 116.0, 76.0, "Inflating its poison sacs, it fills the area with an odd sound and hits flinching opponents with a poison jab.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/453.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/453.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/453.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/453.png", "Croagunk", 134.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 454,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 211.0, 133.0, "Its knuckle claws secrete a toxin so vile that even a scratch could prove fatal.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/454.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/454.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/454.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/454.png", "Toxicroak", 195.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 455,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 187.0, 136.0, "It binds itself to trees in marshes. It attracts prey with its sweet-smelling drool and gulps them down.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/455.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/455.png", null, "Carnivine", 179.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 456,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 96.0, 116.0, "It lures in prey with its shining tail fins. It stays near the surface during the day and moves to the depths when night falls.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/456.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/456.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/456.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/456.png", 0.5f, "Finneon", 135.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 457,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 142.0, 170.0, "They traverse the deep waters as if crawling over the seafloor. The fantastic lights of its fins shine like stars in the night sky.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/457.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/457.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/457.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/457.png", 0.5f, "Lumineon", 170.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 458,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 105.0, 179.0, "Mantyke are friendly toward people and will approach boats closely. The patterns on their backs differ depending on their habitat.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/458.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/458.png", 0.5f, "Mantyke", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 459,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 115.0, 105.0, "In the spring, it grows berries with the texture of frozen treats around its belly.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/459.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/459.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/459.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/459.png", "Snover", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 460,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 178.0, 158.0, "It lives a quiet life on mountains that are perpetually covered in snow. It hides itself by whipping up blizzards.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/460.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/460.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/460.png", 0.5f, "Abomasnow", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 461,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 243.0, 171.0, "Thanks to its increased intelligence, scrapping over food is a thing of the past. A scratch from its claws will give you a case of frostbite!", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/461.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/461.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/461.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/461.png", 0.5f, "Weavile", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 462,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 238.0, 205.0, "There are still people who believe that this Pokémon came from outer space. It emanates a powerful magnetic field.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/462.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/462.png", 0f, "Magnezone", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 463,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name" },
                values: new object[] { 161.0, 181.0, "It uses its tongue much more skillfully than its hands or its feet. It can deftly pick up a single small bean with its tongue.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/463.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/463.png", null, "Lickilicky" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 464,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 241.0, 190.0, "It puts rocks in holes in its palms and uses its muscles to shoot them. Geodude are shot at rare times.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/464.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/464.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/464.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/464.png", 0.5f, "Rhyperior", 251.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 465,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 207.0, 184.0, "Its vines grow so profusely that, in the warm season, you can't even see its eyes.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/465.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/465.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/465.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/465.png", 0.5f, "Tangrowth", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 466,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 249.0, 163.0, "A single Electivire can provide enough electricity for all the buildings in a big city for a year.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/466.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/466.png", 0.75f, "Electivire", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 467,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 247.0, 172.0, "Magmortar takes down its enemies by shooting fireballs, which burn them to a blackened crisp. It avoids this method when hunting prey.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/467.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/467.png", 0.75f, "Magmortar", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 468,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 225.0, 217.0, "It shares many blessings with people who respect one another's rights and avoid needless strife.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/468.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/468.png", 0.875f, "Togekiss", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 469,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 231.0, 156.0, "This six-legged Pokémon is easily capable of transporting an adult in flight. The wings on its tail help it stay balanced.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/469.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/469.png", true, 0.5f, "Yanmega", 200.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 470,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 216.0, 219.0, "It gets its nutrition from photosynthesis. It lives a quiet life deep in forests where clean rivers flow.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/470.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/470.png", 0.875f, "Leafeon", "common", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 471,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 238.0, 205.0, "It can instantaneously freeze any moisture that's around it, creating ice pellets to shoot at its prey.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/471.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/471.png", 0.875f, "Glaceon", "common", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 472,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity" },
                values: new object[] { 185.0, 222.0, "Its flight is soundless. It uses its lengthy tail to carry off its prey... Then its elongated fangs do the rest.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/472.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/472.png", 0.5f, "Gliscor", "common" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 473,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 247.0, 146.0, "Its impressive tusks are made of ice. The population thinned when it turned warm after the ice age.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/473.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/473.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/473.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/473.png", 0.5f, "Mamoswine", "common", 242.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 474,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 264.0, 150.0, "A faulty update was added to its programming. Its behavior is noticeably strange, so the experiment may have been a failure.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/474.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/474.png", "Porygon-Z", "common", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 475,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 237.0, 195.0, "A master of courtesy and swordsmanship, it fights using extending swords on its elbows.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/475.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/475.png", 1f, "Gallade", "common", 169.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 476,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 135.0, 275.0, "It uses three small units to catch prey and battle enemies. The main body mostly just gives orders.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/476.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/476.png", 0.5f, "Probopass", "common", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 477,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 180.0, 254.0, "The antenna on its head captures radio waves from the world of spirits that command it to take people there.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/477.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/477.png", 0.5f, "Dusknoir", "common", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 478,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 171.0, 150.0, "It's said that on nights of terrible blizzards, it comes down to human settlements. If you hear it knocking at your door, do not open it!", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/478.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/478.png", "Froslass", "common", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 479,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 185.0, 159.0, "Its body is composed of plasma. It is known to infiltrate electronic devices and wreak havoc.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/479.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/479.png", "Rotom", "common", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 480,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "isActive", "name", "rarity", "stamina" },
                values: new object[] { 156.0, 270.0, "It is said that its emergence gave humans the intelligence to improve their quality of life.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/480.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/480.png", true, "Uxie", "Legendary", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 481,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 212.0, 212.0, "It sleeps at the bottom of a lake. Its spirit is said to leave its body to fly on the lake's surface.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/481.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/481.png", "Mesprit", "Legendary", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 482,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "isActive", "name", "rarity", "stamina" },
                values: new object[] { 270.0, 151.0, "It is thought that Uxie, Mesprit, and Azelf all came from the same egg.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/482.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/482.png", true, "Azelf", "Legendary", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 483,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 275.0, 211.0, "It has the power to control time. It appears in Sinnoh-region myths as an ancient deity.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/483.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/483.png", "Dialga", "Legendary", 205.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 484,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 280.0, 215.0, "It has the ability to distort space. It is described as a deity in Sinnoh-region mythology.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/484.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/484.png", 0f, "Palkia", "Legendary", 189.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 485,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 251.0, 213.0, "Boiling blood, like magma, circulates through its body. It makes its dwelling place in volcanic caves.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/485.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/485.png", 0.5f, "Heatran", "Legendary", 209.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 486,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 287.0, 210.0, "There is an enduring legend that states this Pokémon towed continents with ropes.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/486.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/486.png", 0f, "Regigigas", "Legendary", 221.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 487,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 187.0, 225.0, "It was banished for its violence. It silently gazed upon the old world from the Distortion World.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/487.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/487.png", 0f, "Giratina", "Legendary", 284.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 488,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 152.0, 258.0, "Those who sleep holding Cresselia's feather are assured of joyful dreams. It is said to represent the crescent moon.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/488.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/488.png", 0f, "Cresselia", "Legendary", 260.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 489,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 162.0, 162.0, "It drifts in warm seas. It always returns to where it was born, no matter how far it may have drifted.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/489.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/489.png", false, 0f, "Phione", "Mythical", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 490,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 210.0, 210.0, "It starts its life with a wondrous power that permits it to bond with any kind of Pokémon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/490.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/490.png", false, 0f, "Manaphy", "Mythical", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 491,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 285.0, 198.0, "It can lull people to sleep and make them dream. It is active during nights of the new moon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/491.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/491.png", 0f, "Darkrai", "Mythical", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 492,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 210.0, 210.0, "The blooming of Gracidea flowers confers the power of flight upon it. Feelings of gratitude are the message it delivers.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/492.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/492.png", false, 0f, "Shaymin", "Mythical", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 494,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 210.0, 210.0, "When it shares the infinite energy it creates, that being's entire body will be overflowing with power.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/494.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/494.png", 0f, "Victini", "Mythical", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 495,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name" },
                values: new object[] { 88.0, 107.0, "They photosynthesize by bathing their tails in sunlight. When they are not feeling well, their tails droop.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/495.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/495.png", 0.875f, "Snivy" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 496,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 122.0, 152.0, "When it gets dirty, its leaves can't be used in photosynthesis, so it always keeps itself clean.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/496.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/496.png", 0.875f, "Servine", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 497,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 161.0, 204.0, "It can stop its opponents' movements with just a glare. It takes in solar energy and boosts it internally.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/497.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/497.png", 0.875f, "Serperior", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 498,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 115.0, 85.0, "It loves to eat roasted berries, but sometimes it gets too excited and burns them to a crisp.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/498.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/498.png", 0.875f, "Tepig", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 499,
                columns: new[] { "attack", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 173.0, "When its internal fire flares up, its movements grow sharper and faster. When in trouble, it emits smoke.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/499.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/499.png", 0.875f, "Pignite", 207.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 500,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 235.0, 127.0, "It has mastered fast and powerful fighting moves. It grows a beard of fire.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/500.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/500.png", "Emboar", 242.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 501,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 117.0, 85.0, "It fights using the scalchop on its stomach. In response to an attack, it retaliates immediately by slashing.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/501.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/501.png", "Oshawott", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 502,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 159.0, 116.0, "As a result of strict training, each Dewott learns different forms for using the scalchops.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/502.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/502.png", "Dewott", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 503,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 212.0, 157.0, "One swing of the sword incorporated in its armor can fell an opponent. A simple glare from one of them quiets everybody.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/503.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/503.png", "Samurott", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 504,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 98.0, 73.0, "Extremely cautious, one of them will always be on the lookout, but it won't notice a foe coming from behind.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/504.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/504.png", 0.5f, "Patrat", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 505,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 165.0, 139.0, "When they see an enemy, their tails stand high, and they spit the seeds of berries stored in their cheek pouches.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/505.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/505.png", 0.5f, "Watchog", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 506,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 107.0, 86.0, "This Pokémon is popular with beginners because it's intelligent, obedient to its Trainer's commands, and easy to raise.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/506.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/506.png", "Lillipup", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 507,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 145.0, 126.0, "It has been living with people for so long that portrayals of it can be found on the walls of caves from long, long ago.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/507.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/507.png", "Herdier", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 508,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 206.0, 182.0, "Its fur is long and thick. A long time ago in cold regions, every household kept a Stoutland.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/508.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/508.png", "Stoutland", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 509,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 98.0, 73.0, "They steal from people for fun, but their victims can't help but forgive them. Their deceptively cute act is perfect.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/509.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/509.png", "Purrloin", 121.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 510,
                columns: new[] { "attack", "defense", "description", "img_back", "img_back_female", "img_front", "img_front_female", "name", "stamina" },
                values: new object[] { 187.0, 106.0, "Stealthily, it sneaks up on its target, striking from behind before its victim has a chance to react.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/510.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/510.png", null, "Liepard", 162.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 511,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 104.0, 94.0, "It's good at finding berries and gathers them from all over. It's kind enough to share them with friends.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/511.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/511.png", 0.875f, "Pansage", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 512,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name" },
                values: new object[] { 206.0, 133.0, "Ill tempered, it fights by swinging its barbed tail around wildly. The leaf growing on its head is very bitter.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/512.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/512.png", 0.875f, "Simisage" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 513,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 104.0, 94.0, "This Pokémon lives in caves in volcanoes. The fire within the tuft on its head can reach 600 degrees Fahrenheit.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/513.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/513.png", 0.875f, "Pansear", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 514,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 206.0, 133.0, "When it gets excited, embers rise from its head and tail and it gets hot. For some reason, it loves sweets.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/514.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/514.png", 0.875f, "Simisear", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 515,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 104.0, 94.0, "The water stored inside the tuft on its head is full of nutrients. Plants that receive its water grow large.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/515.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/515.png", 0.875f, "Panpour", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 516,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 206.0, 133.0, "It prefers places with clean water. When its tuft runs low, it replenishes it by siphoning up water with its tail.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/516.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/516.png", 0.875f, "Simipour", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 517,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 111.0, 92.0, "It eats the dreams of people and Pokémon. When it eats a pleasant dream, it expels pink-colored mist.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/517.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/517.png", "Munna", 183.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 518,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 183.0, 166.0, "The dream mist coming from its forehead changes into many different colors depending on the dream that was eaten.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/518.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/518.png", "Musharna", 253.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 519,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 98.0, 80.0, "These Pokémon live in cities. They are accustomed to people. Flocks often gather in parks and plazas.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/519.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/519.png", "Pidove", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 520,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 144.0, 107.0, "No matter where in the world it goes, it knows where its nest is, so it never gets separated from its Trainer.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/520.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/520.png", "Tranquill", 158.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 521,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 226.0, 146.0, "Males have plumage on their heads. They will never let themselves feel close to anyone other than their Trainers.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/521.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/521.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/521.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/521.png", 0.5f, "Unfezant", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 522,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 118.0, 64.0, "Its mane shines when it discharges electricity. They use the frequency and rhythm of these flashes to communicate.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/522.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/522.png", 0.5f, "Blitzle", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 523,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 211.0, 136.0, "They have lightning-like movements. When Zebstrika run at full speed, the sound of thunder reverberates.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/523.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/523.png", 0.5f, "Zebstrika", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 524,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 121.0, 110.0, "It was found in a fissure in a layer of exposed rock. The material that makes up its body is dirt from several hundred years ago.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/524.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/524.png", "Roggenrola", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 525,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 174.0, 143.0, "Its orange crystals are lumps of powerful energy. They're valuable, so Boldore is sometimes targeted for them.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/525.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/525.png", "Boldore", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 526,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 226.0, 201.0, "It absorbs rays of sunlight and shoots out energy. It's usually lurking deep beneath the surface.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/526.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/526.png", "Gigalith", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 527,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 107.0, 85.0, "The heart-shaped mark left on a body after a Woobat has been attached to it is said to bring good fortune.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/527.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/527.png", 0.5f, "Woobat", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 528,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 161.0, 119.0, "Anyone who comes into contact with the ultrasonic waves emitted by a courting male experiences a positive mood shift.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/528.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/528.png", 0.5f, "Swoobat", 167.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 529,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 154.0, 85.0, "By spinning its body, it can dig straight through the ground at a speed of 30 mph.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/529.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/529.png", "Drilbur", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 530,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 255.0, 129.0, "More than 300 feet below the surface, they build mazelike nests. Their activity can be destructive to subway tunnels.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/530.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/530.png", "Excadrill", 242.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 531,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 114.0, 163.0, "It touches others with the feelers on its ears, using the sound of their heartbeats to tell how they are feeling.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/531.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/531.png", "Audino", 230.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 532,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 134.0, 87.0, "Always carrying squared logs, they help out with construction. As they grow, they carry bigger logs.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/532.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/532.png", 0.75f, "Timburr", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 533,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 180.0, 134.0, "This Pokémon is so muscular and strongly built that even a group of wrestlers could not make it budge an inch.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/533.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/533.png", 0.75f, "Gurdurr", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 534,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 243.0, 158.0, "Rather than rely on force, they master moves that utilize the centrifugal force of spinning concrete.", 0.25f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/534.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/534.png", 0.75f, "Conkeldurr", 233.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 535,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 98.0, 78.0, "By vibrating its cheeks, it emits sound waves imperceptible to humans. It uses the rhythm of these sounds to talk.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/535.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/535.png", "Tympole", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 536,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 128.0, 109.0, "It lives in the water and on land. It uses its long, sticky tongue to immobilize its opponents.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/536.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/536.png", "Palpitoad", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 537,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 188.0, 150.0, "They shoot paralyzing liquid from their head bumps. They use vibration to hurt their opponents.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/537.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/537.png", 0.5f, "Seismitoad", 233.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 538,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 172.0, 160.0, "When it encounters a foe bigger than itself, it wants to throw it. It changes belts as it gets stronger.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/538.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/538.png", 1f, "Throh", 260.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 539,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 231.0, 153.0, "Tying their belts gets them pumped and makes their punches more destructive. Disturbing their training angers them.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/539.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/539.png", 1f, "Sawk", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 540,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 96.0, 124.0, "Since this Pokémon makes its own clothes out of leaves, it is a popular mascot for fashion designers.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/540.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/540.png", "Sewaddle", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 541,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 115.0, 162.0, "It protects itself from the cold by wrapping up in leaves. It stays on the move, eating leaves in forests.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/541.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/541.png", "Swadloon", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 542,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 205.0, 165.0, "It keeps its eggs warm with heat from fermenting leaves. It also uses leaves to make warm wrappings for Sewaddle.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/542.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/542.png", "Leavanny", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 543,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 83.0, 99.0, "Its bite injects a potent poison, enough to paralyze large bird Pokémon that try to prey on it.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/543.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/543.png", "Venipede", 102.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 544,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 100.0, 173.0, "It is usually motionless, but when attacked, it rotates at high speed and then crashes into its opponent.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/544.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/544.png", "Whirlipede", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 545,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 203.0, 175.0, "With quick movements, it chases down its foes, attacking relentlessly with its horns until it prevails.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/545.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/545.png", "Scolipede", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 546,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 71.0, 111.0, "When attacked, it expels cotton from its body to create a diversion. The cotton it loses grows back in quickly.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/546.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/546.png", "Cottonee", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 547,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 164.0, 176.0, "Whimsicott doesn't live in a fixed location. It floats around on whirling winds, appearing all over the place to perform its mischief.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/547.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/547.png", "Whimsicott", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 548,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 119.0, 91.0, "They prefer clean water and soil. When the environment they live in turns bad, the whole bunch will up and move to a new area.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/548.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/548.png", 0f, "Petilil", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 549,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 214.0, 155.0, "It's well liked by other Pokémon because of its beauty. The flower on its head needs constant care, or it will soon wither and rot.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/549.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/549.png", 0f, "Lilligant", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 550,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 189.0, 129.0, "When a school of Basculin appears in a lake, everything else disappears, except for Corphish and Crawdaunt. That's how violent Basculin are.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/550.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/550.png", "Basculin", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 551,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 132.0, 69.0, "Sandile's still not good at hunting, so it mostly eats things that have collapsed in the desert. It's called “the cleaner of the desert.\"", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/551.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/551.png", 0.5f, "Sandile", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 552,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 155.0, 90.0, "It buries some of its prey in the sand to use as emergency meals when its hunts are unsuccessful.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/552.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/552.png", 0.5f, "Krokorok", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 553,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 229.0, 158.0, "It conceals itself in sandstorms that Flygon whip up and waits patiently for prey to appear.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/553.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/553.png", 0.5f, "Krookodile", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 554,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 153.0, 86.0, "When it sleeps, it pulls its limbs into its body and its internal fire goes down to 1,100 degrees Fahrenheit.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/554.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/554.png", 0.5f, "Darumaka", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 555,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 263.0, 114.0, "Its internal fire burns at 2,500 degrees Fahrenheit, making enough power that it can destroy a dump truck with one punch.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/555.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/555.png", "Darmanitan", 233.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 556,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 201.0, 130.0, "Arid regions are their habitat. They move rhythmically, making a sound similar to maracas.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/556.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/556.png", "Maractus", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 557,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 118.0, 128.0, "When it finds a stone of a suitable size, it secretes a liquid from its mouth to open up a hole to crawl into.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/557.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/557.png", true, 0.5f, "Dwebble", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 558,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 188.0, 200.0, "Competing for territory, Crustle fight viciously. The one whose boulder is broken is the loser of the battle.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/558.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/558.png", true, 0.5f, "Crustle", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 559,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 132.0, 132.0, "It stretches its saggy skin up to its neck to protect itself. The saggier their skin, the more respect they garner.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/559.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/559.png", 0.5f, "Scraggy", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 560,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 163.0, 222.0, "It taunts its opponents by spitting. It has a certain territory that it never leaves its whole life long.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/560.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/560.png", 0.5f, "Scrafty", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 561,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 204.0, 167.0, "The guardians of an ancient city, they always fly the same route while keeping watch for invaders.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/561.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/561.png", 0.5f, "Sigilyph", 176.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 564,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 134.0, 146.0, "Its hunting grounds encompassed a broad area, from the land to more than half a mile deep in the ocean.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/564.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/564.png", 0.875f, "Tirtouga", 144.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 565,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 192.0, 197.0, "Carracosta eats every last bit of the prey it catches, even the shells and bones, to further strengthen its sturdy shell.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/565.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/565.png", 0.875f, "Carracosta", 179.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 566,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 213.0, 89.0, "Restored from a fossil, this ancient bird Pokémon has wings but can't yet fly.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/566.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/566.png", 0.875f, "Archen", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 567,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 292.0, 139.0, "Said to be an ancestor of bird Pokémon, the muscles it uses to flap its wings are still weak, so it needs a long runway in order to take off.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/567.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/567.png", 0.875f, "Archeops", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 568,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 96.0, 122.0, "If a young Pokémon or child breathes in the toxic gas that Trubbish belches out, it could be a life-threatening situation.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/568.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/568.png", "Trubbish", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 569,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 181.0, 164.0, "Some say the reason Garbodor in Alola are a little stronger than their counterparts elsewhere is the presence of Muk, their natural enemy.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/569.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/569.png", "Garbodor", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 570,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 153.0, 78.0, "If a normally talkative child suddenly stops talking, it may have been replaced by Zorua.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/570.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/570.png", false, 0.875f, "Zorua", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 571,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 250.0, 127.0, "If it thinks humans are going to discover its den, Zoroark shows them visions that make them wander around in the woods.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/571.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/571.png", false, 0.875f, "Zoroark", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 572,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 98.0, 80.0, "When its tail has gotten dirty from self-cleaning or from cleaning its nest, Minccino spends a whole day washing its tail in clean spring water.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/572.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/572.png", 0.25f, "Minccino", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 573,
                columns: new[] { "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 130.0, "The oil that seeps from its body is really smooth. For people troubled by bad skin, this oil is an effective treatment.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/573.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/573.png", 0.25f, "Cinccino", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 574,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 98.0, 112.0, "They intently observe both Trainers and Pokémon. Apparently, they are looking at something that only Gothita can see.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/574.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/574.png", 0.25f, "Gothita", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 575,
                columns: new[] { "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 153.0, "According to many old tales, it creates friends for itself by controlling sleeping children on starry nights.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/575.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/575.png", 0.25f, "Gothorita", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 576,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name" },
                values: new object[] { 176.0, 205.0, "They can predict the future from the placement and movement of the stars. They can see Trainers' life spans.", 0.75f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/576.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/576.png", 0.25f, "Gothitelle" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 577,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 170.0, 83.0, "They drive away attackers by unleashing psychic power. They can use telepathy to talk with others.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/577.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/577.png", "Solosis", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 578,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 208.0, 103.0, "When their two divided brains think the same thoughts, their psychic power is maximized.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/578.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/578.png", "Duosion", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 579,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 214.0, 148.0, "When Reuniclus shake hands, a network forms between their brains, increasing their psychic power.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/579.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/579.png", null, 0.5f, "Reuniclus", 242.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 580,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 84.0, 96.0, "They are better at swimming than flying, and they happily eat their favorite food, peat moss, as they dive underwater.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/580.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/580.png", null, 0.5f, "Ducklett", 158.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 581,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 182.0, 132.0, "Swanna start to dance at dusk. The one dancing in the middle is the leader of the flock.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/581.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/581.png", "Swanna", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 582,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 118.0, 106.0, "When the morning sun hit an icicle, it wished not to melt, and thus Vanillite was born. At night, it buries itself in snow to sleep.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/582.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/582.png", "Vanillite", 113.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 583,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 151.0, 138.0, "This hearty Pokémon survived the Ice Age. It's incredibly popular in very hot regions.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/583.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/583.png", "Vanillish", 139.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 584,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 218.0, 184.0, "Vanilluxe is born when two Vanillish, half-melted by the day's light, stick to each other and freeze together in the cold return of night.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/584.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/584.png", "Vanilluxe", 174.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 585,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 115.0, 100.0, "The turning of the seasons changes the color and scent of this Pokémon's fur. People use it to mark the seasons.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/585.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/585.png", "Deerling", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 586,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 198.0, 146.0, "They migrate according to the seasons, so some people call Sawsbuck the harbingers of spring.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/586.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/586.png", 0.5f, "Sawsbuck", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 587,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 158.0, 127.0, "As it flies, it scatters electricity around, so bird Pokémon keep their distance. That's why Emolga can keep all its food to itself.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/587.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/587.png", 0.5f, "Emolga", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 588,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 137.0, 87.0, "For some reason they evolve when they receive electrical energy while they are attacking Shelmet.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/588.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/588.png", 0.5f, "Karrablast", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 589,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 223.0, 187.0, "These Pokémon evolve by wearing the shell covering of a Shelmet. The steel armor protects their whole body.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/589.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/589.png", "Escavalier", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 590,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 97.0, 91.0, "It lures Pokémon with its pattern that looks just like a Poké Ball, then releases poison spores.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/590.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/590.png", "Foongus", 170.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 591,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 155.0, 139.0, "It lures prey close by dancing and waving its arm caps, which resemble Poké Balls, in a swaying motion.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/591.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/591.png", "Amoonguss", 249.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 592,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name" },
                values: new object[] { 115.0, 134.0, "Using the invisible poison spikes on its veillike arms and legs, it paralyzes its enemies and causes them to drown.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/592.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/592.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/592.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/592.png", 0f, "Frillish" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 593,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "stamina" },
                values: new object[] { 159.0, 178.0, "Fishermen are terrified of Jellicent. It's rumored to drag them into the sea and steal their lives away.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/593.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/593.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/593.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/593.png", 0f, "Jellicent", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 594,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 138.0, 131.0, "The reason it helps Pokémon in a weakened condition is that any Pokémon coming after them may also attack Alomomola.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/594.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/594.png", "Alomomola", 338.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 595,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 110.0, 98.0, "They attach themselves to large-bodied Pokémon and absorb static electricity, which they store in an electric pouch.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/595.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/595.png", "Joltik", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 596,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 201.0, 128.0, "When attacked, they create an electric barrier by spitting out many electrically charged threads.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/596.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/596.png", "Galvantula", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 597,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 82.0, 155.0, "It absorbs the iron it finds in the rock while clinging to the ceiling. It shoots spikes when in danger.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/597.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/597.png", "Ferroseed", 127.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 598,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 158.0, 223.0, "They attach themselves to cave ceilings, firing steel spikes at targets passing beneath them.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/598.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/598.png", "Ferrothorn", 179.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 599,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 98.0, 121.0, "The two minigears that mesh together are predetermined. Each will rebound from other minigears without meshing.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/599.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/599.png", 0f, "Klink", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 600,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 150.0, 174.0, "A minigear and big gear comprise its body. If the minigear it launches at a foe doesn't return, it will die.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/600.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/600.png", 0f, "Klang", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 601,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 199.0, 214.0, "Its red core functions as an energy tank. It fires the charged energy through its spikes into an area.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/601.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/601.png", 0f, "Klinklang", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 602,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 105.0, 78.0, "One alone can emit only a trickle of electricity, so a group of them gathers to unleash a powerful electric shock.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/602.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/602.png", 0.5f, "Tynamo", 111.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 603,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 156.0, 130.0, "These Pokémon have a big appetite. When they spot their prey, they attack it and paralyze it with electricity.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/603.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/603.png", "Eelektrik", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 604,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 217.0, 152.0, "They crawl out of the ocean using their arms. They will attack prey on shore and immediately drag it into the ocean.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/604.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/604.png", "Eelektross", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 605,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 148.0, 100.0, "This Pokémon is shrouded in mystery. It's said to have appeared from a UFO that fell from the sky about 50 years ago.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/605.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/605.png", "Elgyem", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 606,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 221.0, 163.0, "It has strong psychic powers. Using its fingers that flash three different colors, it controls its opponents and rewrites their memories.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/606.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/606.png", "Beheeyem", 181.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 607,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 108.0, 98.0, "Litwick shines a light that absorbs the life energy of people and Pokémon, which becomes the fuel that it burns.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/607.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/607.png", "Litwick", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 608,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 169.0, 115.0, "It arrives near the moment of death and steals spirit from the body.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/608.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/608.png", "Lampent", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 609,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 271.0, 182.0, "The spirits burned up in its ominous flame lose their way and wander this world forever.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/609.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/609.png", 0.5f, "Chandelure", 155.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 610,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 154.0, 101.0, "They mark their territory by leaving gashes in trees with their tusks. If a tusk breaks, a new one grows in quickly.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/610.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/610.png", 0.5f, "Axew", 130.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 611,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 212.0, 123.0, "A broken tusk will not grow back, so it diligently sharpens its tusks on river rocks after the end of a battle.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/611.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/611.png", "Fraxure", 165.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 612,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 284.0, 172.0, "Their sturdy tusks will stay sharp even if used to cut steel beams. These Pokémon are covered in hard armor.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/612.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/612.png", "Haxorus", 183.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 613,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 128.0, 74.0, "Their snot is a barometer of health. When healthy, their snot is sticky and the power of their ice moves increases.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/613.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/613.png", "Cubchoo", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 614,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 233.0, 152.0, "It freezes its breath to create fangs and claws of ice to fight with. Cold northern areas are its habitat.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/614.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/614.png", 0.5f, "Beartic", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 615,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 190.0, 218.0, "They are composed of ice crystals. They capture prey with chains of ice, freezing the prey at -148 degrees Fahrenheit.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/615.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/615.png", 0f, "Cryogonal", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 616,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 72.0, 140.0, "It evolves when bathed in an electric-like energy along with Karrablast. The reason is still unknown.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/616.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/616.png", 0.5f, "Shelmet", 137.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 617,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 220.0, 120.0, "When its body dries out, it weakens. So, to prevent dehydration, it wraps itself in many layers of thin membrane.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/617.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/617.png", 0.5f, "Accelgor", 190.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 618,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 144.0, 171.0, "It conceals itself in the mud of the seashore. Then it waits. When prey touch it, it delivers a jolt of electricity.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/618.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/618.png", "Stunfisk", 240.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 619,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 160.0, 98.0, "They seclude themselves in the mountains and devote themselves to training. The form of their kicks and chops differs from pack to pack.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/619.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/619.png", "Mienfoo", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 620,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 258.0, 127.0, "When Mienshao lets out a bizarre wail, you're in danger. A flurry of kicks and chops too fast to see is about to be unleashed!", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/620.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/620.png", "Mienshao", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 621,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 213.0, 170.0, "It infiltrates tunnels that Pokémon like Diglett and Dugtrio have dug and quietly waits for prey to pass through.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/621.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/621.png", "Druddigon", 184.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 622,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 127.0, 92.0, "Although ancient people apparently built it by working with clay, the source of its energy is unclear.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/622.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/622.png", 0f, "Golett", 153.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 623,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 222.0, 154.0, "When the seal on its chest is removed, it rages indiscriminately, turning the whole town around it into a mountain of rubble.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/623.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/623.png", true, 0f, "Golurk", 205.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 624,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "isActive", "name", "stamina" },
                values: new object[] { 154.0, 114.0, "It follows Bisharp's orders to a tee when it attacks enemies. After slashing an opponent, Pawniard clangs both of its blades together.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/624.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/624.png", true, "Pawniard", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 625,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 232.0, 176.0, "It leads a group of Pawniard. Bisharp doesn't even change its expression when it deals the finishing blow to an opponent.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/625.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/625.png", 0.5f, "Bisharp", "common", 163.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 626,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 195.0, 182.0, "Their fluffy fur absorbs damage, even if they strike foes with a fierce headbutt.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/626.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/626.png", 0.5f, "Bouffalant", "common", 216.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 627,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 150.0, 97.0, "Known as a natural-born warrior, soon after its hatching, it will challenge its parent to a fight in order to gain their acceptance.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/627.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/627.png", 1f, "Rufflet", "common", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 628,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 232.0, 152.0, "Known as “the hero of the skies,\" this Pokémon is so proud and so brave that it will never retreat, even when it's injured.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/628.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/628.png", "Braviary", "common", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 629,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 105.0, 139.0, "Its healthy appetite leads to visible growth spurts. It often has to replace the bones it wears as its size increases.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/629.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/629.png", 0f, "Vullaby", "common", 172.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 630,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "name", "rarity", "stamina" },
                values: new object[] { 129.0, 205.0, "It's always searching for food for Vullaby. When it finds a weak Pokémon, Mandibuzz swoops it right off to its nest.", 1f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/630.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/630.png", "Mandibuzz", "common", 242.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 631,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 204.0, 129.0, "It draws in air through its tail, transforms it into fire, and uses it like a tongue. It melts Durant and eats them.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/631.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/631.png", 0.5f, "Heatmor", "common", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 632,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 217.0, 188.0, "They attack in groups, covering themselves in steel armor to protect themselves from Heatmor.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/632.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/632.png", 0.5f, "Durant", "common", 151.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 633,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 116.0, 93.0, "Lacking sight, it's unaware of its surroundings, so it bumps into things and eats anything that moves.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/633.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/633.png", 0.5f, "Deino", "common", 141.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 634,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 159.0, 135.0, "After it has eaten up all the food in its territory, it moves to another area. Its two heads do not get along.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/634.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/634.png", true, 0.5f, "Zweilous", "common", 176.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 635,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 256.0, 188.0, "It responds to movement by attacking. This scary, three-headed Pokémon devours everything in its path!", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/635.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/635.png", 0.5f, "Hydreigon", "common", 211.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 636,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 156.0, 107.0, "It protects itself with flame. Long years ago, people believed Larvesta had a nest on the sun.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/636.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/636.png", false, 0.5f, "Larvesta", 146.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 637,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 264.0, 189.0, "According to legends, it was hatched from a flaming cocoon to save people and Pokémon that were suffering from the cold.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/637.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/637.png", false, 0.5f, "Volcarona", 198.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 638,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 192.0, 229.0, "It has a body and heart of steel. It worked with its allies to punish people when they hurt Pokémon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/638.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/638.png", 0f, "Cobalion", "Legendary", 209.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 639,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 260.0, 192.0, "Spoken of in legend, this Pokémon used its phenomenal power to destroy a castle in its effort to protect Pokémon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/639.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/639.png", 0f, "Terrakion", "Legendary", 209.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 640,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 192.0, 229.0, "Legends say this Pokémon confounded opponents with its swift movements.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/640.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/640.png", 0f, "Virizion", "Legendary", 209.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 641,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 266.0, 164.0, "Tornadus expels massive energy from its tail, causing severe storms. Its power is great enough to blow houses away.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/641.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/641.png", 1f, "Tornadus", "Legendary", 188.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 642,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 266.0, 164.0, "As it flies around, it shoots lightning all over the place and causes forest fires. It is therefore disliked.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/642.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/642.png", 1f, "Thundurus", "Legendary", 188.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 643,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 275.0, 211.0, "When Reshiram's tail flares, the heat energy moves the atmosphere and changes the world's weather.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/643.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/643.png", true, 0f, "Reshiram", "Legendary", 205.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 644,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 275.0, 211.0, "Concealing itself in lightning clouds, it flies throughout the Unova region. It creates electricity in its tail.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/644.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/644.png", 0f, "Zekrom", "Legendary", 205.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 645,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 261.0, 182.0, "From the forces of lightning and wind, it creates energy to give nutrients to the soil and make the land abundant.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/645.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/645.png", true, 1f, "Landorus", "Legendary", 205.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 646,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 246.0, 170.0, "It generates a powerful, freezing energy inside itself, but its body became frozen when the energy leaked out.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/646.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/646.png", 0f, "Kyurem", "Legendary", 245.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 647,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 260.0, 192.0, "When it is resolute, its body fills with power and it becomes swifter. Its jumps are then too fast to follow.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/647.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/647.png", false, 0f, "Keldeo", "Mythical", 209.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 648,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 250.0, 225.0, "Its melodies are sung with a special vocalization method that can control the feelings of those who hear it.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/648.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/648.png", 0f, "Meloetta", "Mythical", 225.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 650,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 110.0, 106.0, "The quills on its head are usually soft. When it flexes them, the points become so hard and sharp that they can pierce rock.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/650.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/650.png", 0.875f, "Chespin", 148.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 651,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 146.0, 156.0, "It relies on its sturdy shell to deflect predators' attacks. It counterattacks with its sharp quills.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/651.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/651.png", 0.875f, "Quilladin", 156.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 653,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "male_gender_rate", "name", "stamina" },
                values: new object[] { 116.0, 102.0, "Eating a twig fills it with energy, and its roomy ears give vent to air hotter than 390 degrees Fahrenheit.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/653.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/653.png", 0.875f, "Fennekin", 120.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 656,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 122.0, 84.0, "It secretes flexible bubbles from its chest and back. The bubbles reduce the damage it would otherwise take when attacked.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/656.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/656.png", true, 0.875f, "Froakie", 121.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 658,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 223.0, 152.0, "It creates throwing stars out of compressed water. When it spins them and throws them at high speed, these stars can split metal in two.", 0.125f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/658.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/658.png", true, 0.875f, "Greninja", 176.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 659,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 68.0, 72.0, "They use their large ears to dig burrows. They will dig the whole night through.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/659.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/659.png", true, 0.5f, "Bunnelby", 116.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 663,
                columns: new[] { "attack", "defense", "description", "img_back", "img_front", "name", "stamina" },
                values: new object[] { 176.0, 155.0, "In the fever of an exciting battle, it showers embers from the gaps between its feathers and takes to the air.", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/663.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/663.png", "Talonflame", 186.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 665,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 48.0, 89.0, "It lives hidden within thicket shadows. When predators attack, it quickly bristles the fur covering its body in an effort to threaten them.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/665.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/665.png", false, 0.5f, "Spewpa", "common", 128.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 667,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "stamina" },
                values: new object[] { 139.0, 112.0, "The stronger the opponent it faces, the more heat surges from its mane and the more power flows through its body.", 0.875f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/667.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/667.png", true, 0.125f, "Litleo", 158.0 });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 672,
                columns: new[] { "attack", "defense", "description", "female_gender_rate", "img_back", "img_front", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[] { 123.0, 102.0, "Thought to be one of the first Pokémon to live in harmony with humans, it has a placid disposition.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/672.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/672.png", false, 0.5f, "Skiddo", "common", 165.0 });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "num_pokedex", "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "isActive", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[,]
                {
                    { 674, 145.0, 107.0, "It does its best to be taken seriously by its enemies, but its glare is not sufficiently intimidating. Chewing on a leaf is its trademark.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/674.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/674.png", null, true, 0.5f, "Pancham", "common", 167.0 },
                    { 677, 120.0, 114.0, "The organ that emits its intense psychic power is sheltered by its ears to keep power from leaking out.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/677.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/677.png", null, true, 0.5f, "Espurr", "common", 158.0 },
                    { 682, 110.0, 113.0, "It emits a scent that enraptures those who smell it. This fragrance changes depending on what it has eaten.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/682.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/682.png", null, true, 0.5f, "Spritzee", "common", 186.0 },
                    { 683, 173.0, 150.0, "It devises various scents, pleasant and unpleasant, and emits scents that its enemies dislike in order to gain an edge in battle.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/683.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/683.png", null, true, 0.5f, "Aromatisse", "common", 226.0 },
                    { 684, 109.0, 119.0, "To entangle its opponents in battle, it extrudes white threads as sweet and sticky as cotton candy.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/684.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/684.png", null, true, 0.5f, "Swirlix", "common", 158.0 },
                    { 685, 168.0, 163.0, "It can distinguish the faintest of scents. It puts its sensitive sense of smell to use by helping pastry chefs in their work.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/685.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/685.png", null, true, 0.5f, "Slurpuff", "common", 193.0 },
                    { 688, 96.0, 120.0, "Two Binacle live together on one rock. When they fight, one of them will move to a different rock.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/688.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/688.png", null, true, 0.5f, "Binacle", "common", 123.0 },
                    { 690, 109.0, 109.0, "Camouflaged as rotten kelp, they spray liquid poison on prey that approaches unawares and then finish it off.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/690.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/690.png", null, true, 0.5f, "Skrelp", "common", 137.0 },
                    { 692, 108.0, 117.0, "They knock down flying prey by firing compressed water from their massive claws like shooting a pistol.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/692.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/692.png", null, true, 0.5f, "Clauncher", "common", 137.0 },
                    { 694, 115.0, 78.0, "They make their home in deserts. They can generate their energy from basking in the sun, so eating food is not a requirement.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/694.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/694.png", null, false, 0.5f, "Helioptile", "common", 127.0 },
                    { 697, 227.0, 191.0, "Thanks to its gargantuan jaws, which could shred thick metal plates as if they were paper, it was invincible in the ancient world it once inhabited.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/697.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/697.png", null, false, 0.5f, "Tyrantrum", "common", 193.0 },
                    { 701, 195.0, 153.0, "Although its body is small, its proficient fighting skills enable it to keep up with big bruisers like Machamp and Hariyama.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/701.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/701.png", null, false, 0.5f, "Hawlucha", "common", 186.0 },
                    { 702, 164.0, 134.0, "Its whiskers serve as antennas. By sending and receiving electrical waves, it can communicate with others over vast distances.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/702.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/702.png", null, false, 0.5f, "Dedenne", "common", 167.0 },
                    { 703, 95.0, 285.0, "Born from the temperatures and pressures deep underground, it fires beams from the stone in its head.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/703.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/703.png", null, false, 0f, "Carbink", "common", 137.0 },
                    { 704, 101.0, 112.0, "The weakest Dragon-type Pokémon, it lives in damp, shady places, so its body doesn't dry out.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/704.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/704.png", null, true, 0.5f, "Goomy", "common", 128.0 },
                    { 707, 160.0, 179.0, "These key collectors threaten any attackers by fiercely jingling their keys at them.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/707.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/707.png", null, true, 0.5f, "Klefki", "common", 149.0 },
                    { 708, 125.0, 103.0, "These Pokémon are created when spirits possess rotten tree stumps. They prefer to live in abandoned forests.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/708.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/708.png", null, true, 0.5f, "Phantump", "common", 125.0 },
                    { 710, 122.0, 124.0, "The pumpkin body is inhabited by a spirit trapped in this world. As the sun sets, it becomes restless and active.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/710.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/710.png", null, true, 0.5f, "Pumpkaboo", "common", 127.0 },
                    { 712, 117.0, 120.0, "It blocks opponents' attacks with the ice that shields its body. It uses cold air to repair any cracks with new ice.", 0.5f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/712.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/712.png", null, true, 0.5f, "Bergmite", "common", 146.0 },
                    { 720, 261.0, 187.0, "In its true form, it possess a huge amount of power. Legends of its avarice tell how it once carried off an entire castle to gain the treasure hidden within.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/720.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/720.png", null, true, 0f, "Hoopa", "Mythical", 173.0 },
                    { 802, 265.0, 190.0, "It sinks into the shadows of people and Pokémon, where it can understand their feelings and copy their capabilities.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/802.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/802.png", null, false, 0f, "Marshadow", "Mythical", 207.0 },
                    { 803, 1.0, 1.0, "An Ultra Beast that lives in a different world, it cackles wildly as it sprays its opponents with poison from the needles on its head.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/803.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/803.png", null, false, 0f, "Poipole", "common", 1.0 },
                    { 804, 1.0, 1.0, "One kind of Ultra Beast, it fires a glowing, venomous liquid from its needles. This liquid is also immensely adhesive.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/804.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/804.png", null, false, 0f, "Naganadel", "common", 1.0 },
                    { 805, 1.0, 1.0, "When stone walls started moving and attacking, the brute's true identity was this mysterious life-form, which brings to mind an Ultra Beast.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/805.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/805.png", null, false, 0f, "Stakataka", "common", 1.0 },
                    { 806, 1.0, 1.0, "A UB that appeared from an Ultra Wormhole, it causes explosions, then takes advantage of opponents' surprise to rob them of their vitality.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/806.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/806.png", null, false, 0f, "Blacephalon", "common", 1.0 },
                    { 807, 1.0, 1.0, "It approaches its enemies at the speed of lightning, then tears them limb from limb with its sharp claws.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/807.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/807.png", null, false, 0f, "Zeraora", "Mythical", 1.0 },
                    { 808, 118.0, 99.0, "It melts particles of iron and other metals found in the subsoil, so it can absorb them into its body of molten steel.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/808.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/808.png", null, true, 0f, "Meltan", "Mythical", 130.0 },
                    { 809, 226.0, 190.0, "Revered long ago for its capacity to create iron from nothing, for some reason it has come back to life after 3,000 years.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/809.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/809.png", null, true, 0f, "Melmetal", "Mythical", 264.0 }
                });
        }
    }
}
