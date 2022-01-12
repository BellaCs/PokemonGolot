using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class loadpokemondatawhithoutgenderrates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "img_back_female",
                table: "Pokemon",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "img_front_female",
                table: "Pokemon",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "num_pokedex", "Eggkm_egg", "attack", "defense", "description", "female_gender_rate", "img_back", "img_back_female", "img_front", "img_front_female", "male_gender_rate", "name", "rarity", "stamina" },
                values: new object[,]
                {
                    { 1, null, 118.0, 111.0, "Bulbasaur can be seen napping in bright sunlight. There is a seed on its back. By soaking up the sun's rays, the seed grows progressively larger.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/1.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png", null, 0f, "Bulbasaur", "common", 128.0 },
                    { 2, null, 151.0, 143.0, "There is a bud on this Pokémon's back. To support its weight, Ivysaur's legs and trunk grow thick and strong. If it starts spending more time lying in the sunlight, it's a sign that the bud will bloom into a large flower soon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/2.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/2.png", null, 0f, "Ivysaur", "common", 155.0 },
                    { 3, null, 198.0, 189.0, "There is a large flower on Venusaur's back. The flower is said to take on vivid colors if it gets plenty of nutrition and sunlight. The flower's aroma soothes the emotions of people.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/3.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/3.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/3.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/3.png", 0f, "Venusaur", "common", 190.0 },
                    { 4, null, 116.0, 93.0, "The flame that burns at the tip of its tail is an indication of its emotions. The flame wavers when Charmander is enjoying itself. If the Pokémon becomes enraged, the flame burns fiercely.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/4.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/4.png", null, 0f, "Charmander", "common", 118.0 },
                    { 5, null, 158.0, 126.0, "Charmeleon mercilessly destroys its foes using its sharp claws. If it encounters a strong foe, it turns aggressive. In this excited state, the flame at the tip of its tail flares with a bluish white color.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/5.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/5.png", null, 0f, "Charmeleon", "common", 151.0 },
                    { 6, null, 223.0, 173.0, "Charizard flies around the sky in search of powerful opponents. It breathes fire of such great heat that it melts anything. However, it never turns its fiery breath on any opponent weaker than itself.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/6.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/6.png", null, 0f, "Charizard", "common", 186.0 },
                    { 7, null, 94.0, 121.0, "Squirtle's shell is not merely used for protection. The shell's rounded shape and the grooves on its surface help minimize resistance in water, enabling this Pokémon to swim at high speeds.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/7.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/7.png", null, 0f, "Squirtle", "common", 127.0 },
                    { 8, null, 126.0, 155.0, "Its tail is large and covered with a rich, thick fur. The tail becomes increasingly deeper in color as Wartortle ages. The scratches on its shell are evidence of this Pokémon's toughness as a battler.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/8.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/8.png", null, 0f, "Wartortle", "common", 153.0 },
                    { 9, null, 171.0, 207.0, "Blastoise has water spouts that protrude from its shell. The water spouts are very accurate. They can shoot bullets of water with enough accuracy to strike empty cans from a distance of over 160 feet.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/9.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/9.png", null, 0f, "Blastoise", "common", 188.0 },
                    { 10, null, 55.0, 55.0, "Caterpie has a voracious appetite. It can devour leaves bigger than its body right before your eyes. From its antenna, this Pokémon releases a terrifically strong odor.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/10.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/10.png", null, 0f, "Caterpie", "common", 128.0 },
                    { 11, null, 45.0, 80.0, "The shell covering this Pokémon's body is as hard as an iron slab. Metapod does not move very much. It stays still because it is preparing its soft innards for evolution inside the hard shell.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/11.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/11.png", null, 0f, "Metapod", "common", 137.0 },
                    { 12, null, 167.0, 137.0, "Butterfree has a superior ability to search for delicious honey from flowers. It can even search out, extract, and carry honey from flowers that are blooming over six miles from its nest.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/12.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/12.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/12.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/12.png", 0f, "Butterfree", "common", 155.0 },
                    { 13, null, 63.0, 50.0, "Weedle has an extremely acute sense of smell. It is capable of distinguishing its favorite kinds of leaves from those it dislikes just by sniffing with its big red proboscis (nose).", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/13.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/13.png", null, 0f, "Weedle", "common", 120.0 },
                    { 14, null, 46.0, 75.0, "Kakuna remains virtually immobile as it clings to a tree. However, on the inside, it is extremely busy as it prepares for its coming evolution. This is evident from how hot the shell becomes to the touch.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/14.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/14.png", null, 0f, "Kakuna", "common", 128.0 },
                    { 15, null, 169.0, 130.0, "Beedrill is extremely territorial. No one should ever approach its nest—this is for their own safety. If angered, they will attack in a furious swarm.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/15.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/15.png", null, 0f, "Beedrill", "common", 163.0 },
                    { 16, null, 85.0, 73.0, "Pidgey has an extremely sharp sense of direction. It is capable of unerringly returning home to its nest, however far it may be removed from its familiar surroundings.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/16.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/16.png", null, 0f, "Pidgey", "common", 120.0 },
                    { 17, null, 117.0, 105.0, "Pidgeotto claims a large area as its own territory. This Pokémon flies around, patrolling its living space. If its territory is violated, it shows no mercy in thoroughly punishing the foe with its sharp claws.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/17.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/17.png", null, 0f, "Pidgeotto", "common", 160.0 },
                    { 18, null, 166.0, 154.0, "This Pokémon has a dazzling plumage of beautifully glossy feathers. Many Trainers are captivated by the striking beauty of the feathers on its head, compelling them to choose Pidgeot as their Pokémon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/18.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/18.png", null, 0f, "Pidgeot", "common", 195.0 },
                    { 19, null, 103.0, 70.0, "Rattata is cautious in the extreme. Even while it is asleep, it constantly listens by moving its ears around. It is not picky about where it lives—it will make its nest anywhere.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/19.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/19.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/19.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/19.png", 0f, "Rattata", "common", 102.0 },
                    { 20, null, 161.0, 139.0, "Raticate's sturdy fangs grow steadily. To keep them ground down, it gnaws on rocks and logs. It may even chew on the walls of houses.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/20.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/20.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/20.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/20.png", 0f, "Raticate", "common", 146.0 },
                    { 21, null, 112.0, 60.0, "Spearow has a very loud cry that can be heard over half a mile away. If its high, keening cry is heard echoing all around, it is a sign that they are warning each other of danger.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/21.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/21.png", null, 0f, "Spearow", "common", 120.0 },
                    { 22, null, 182.0, 133.0, "Fearow is recognized by its long neck and elongated beak. They are conveniently shaped for catching prey in soil or water. It deftly moves its long and skinny beak to pluck prey.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/22.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/22.png", null, 0f, "Fearow", "common", 163.0 },
                    { 23, null, 110.0, 97.0, "Ekans curls itself up in a spiral while it rests. Assuming this position allows it to quickly respond to a threat from any direction with a glare from its upraised head.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/23.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/23.png", null, 0f, "Ekans", "common", 111.0 },
                    { 24, null, 167.0, 153.0, "This Pokémon is terrifically strong in order to constrict things with its body. It can even flatten steel oil drums. Once Arbok wraps its body around its foe, escaping its crushing embrace is impossible.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/24.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/24.png", null, 0f, "Arbok", "common", 155.0 },
                    { 25, null, 112.0, 96.0, "Whenever Pikachu comes across something new, it blasts it with a jolt of electricity. If you come across a blackened berry, it's evidence that this Pokémon mistook the intensity of its charge.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/25.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/25.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/25.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/25.png", 0f, "Pikachu", "common", 111.0 },
                    { 26, null, 193.0, 151.0, "If the electrical sacs become excessively charged, Raichu plants its tail in the ground and discharges. Scorched patches of ground will be found near this Pokémon's nest.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/26.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/26.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/26.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/26.png", 0f, "Raichu", "common", 155.0 },
                    { 27, null, 126.0, 120.0, "Sandshrew's body is configured to absorb water without waste, enabling it to survive in an arid desert. This Pokémon curls up to protect itself from its enemies.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/27.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/27.png", null, 0f, "Sandshrew", "common", 137.0 },
                    { 28, null, 182.0, 175.0, "Sandslash's body is covered by tough spikes, which are hardened sections of its hide. Once a year, the old spikes fall out, to be replaced with new spikes that grow out from beneath the old ones.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/28.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/28.png", null, 0f, "Sandslash", "common", 181.0 },
                    { 29, null, 86.0, 89.0, "Nidoran♀ has barbs that secrete a powerful poison. They are thought to have developed as protection for this small-bodied Pokémon. When enraged, it releases a horrible toxin from its horn.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/29.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/29.png", null, 0f, "Nidoran♀", "common", 146.0 },
                    { 30, null, 117.0, 120.0, "When Nidorina are with their friends or family, they keep their barbs tucked away to prevent hurting each other. This Pokémon appears to become nervous if separated from the others.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/30.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/30.png", null, 0f, "Nidorina", "common", 172.0 },
                    { 31, null, 180.0, 173.0, "Nidoqueen's body is encased in extremely hard scales. It is adept at sending foes flying with harsh tackles. This Pokémon is at its strongest when it is defending its young.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/31.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/31.png", null, 0f, "Nidoqueen", "common", 207.0 },
                    { 32, null, 105.0, 76.0, "Nidoran♂ has developed muscles for moving its ears. Thanks to them, the ears can be freely moved in any direction. Even the slightest sound does not escape this Pokémon's notice.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/32.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/32.png", null, 0f, "Nidoran♂", "common", 130.0 },
                    { 33, null, 137.0, 111.0, "Nidorino has a horn that is harder than a diamond. If it senses a hostile presence, all the barbs on its back bristle up at once, and it challenges the foe with all its might.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/33.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/33.png", null, 0f, "Nidorino", "common", 156.0 },
                    { 34, null, 204.0, 156.0, "Nidoking's thick tail packs enormously destructive power. With one swing, it can topple a metal transmission tower. Once this Pokémon goes on a rampage, there is no stopping it.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/34.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/34.png", null, 0f, "Nidoking", "common", 191.0 },
                    { 35, null, 107.0, 108.0, "On every night of a full moon, groups of this Pokémon come out to play. When dawn arrives, the tired Clefairy return to their quiet mountain retreats and go to sleep nestled up against each other.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/35.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/35.png", null, 0f, "Clefairy", "common", 172.0 },
                    { 36, null, 178.0, 162.0, "Clefable moves by skipping lightly as if it were flying using its wings. Its bouncy step lets it even walk on water. It is known to take strolls on lakes on quiet, moonlit nights.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/36.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/36.png", null, 0f, "Clefable", "common", 216.0 },
                    { 37, null, 96.0, 109.0, "At the time of its birth, Vulpix has one white tail. The tail separates into six if this Pokémon receives plenty of love from its Trainer. The six tails become magnificently curled.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/37.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/37.png", null, 0f, "Vulpix", "common", 116.0 },
                    { 38, null, 169.0, 190.0, "Ninetales casts a sinister light from its bright red eyes to gain total control over its foe's mind. This Pokémon is said to live for a thousand years.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/38.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/38.png", null, 0f, "Ninetales", "common", 177.0 },
                    { 39, null, 80.0, 41.0, "Jigglypuff's vocal cords can freely adjust the wavelength of its voice. This Pokémon uses this ability to sing at precisely the right wavelength to make its foes most drowsy.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/39.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/39.png", null, 0f, "Jigglypuff", "common", 251.0 },
                    { 40, null, 156.0, 90.0, "Wigglytuff has large, saucerlike eyes. The surfaces of its eyes are always covered with a thin layer of tears. If any dust gets in this Pokémon's eyes, it is quickly washed away.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/40.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/40.png", null, 0f, "Wigglytuff", "common", 295.0 },
                    { 41, null, 83.0, 73.0, "Zubat remains quietly unmoving in a dark spot during the bright daylight hours. It does so because prolonged exposure to the sun causes its body to become slightly burned.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/41.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/41.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/41.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/41.png", 0f, "Zubat", "common", 120.0 },
                    { 42, null, 161.0, 150.0, "Golbat loves to drink the blood of living things. It is particularly active in the pitch black of night. This Pokémon flits around in the night skies, seeking fresh blood.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/42.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/42.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/42.png", 0f, "Golbat", "common", 181.0 },
                    { 43, null, 131.0, 112.0, "During the daytime, Oddish buries itself in soil to absorb nutrients from the ground using its entire body. The more fertile the soil, the glossier its leaves become.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/43.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/43.png", null, 0f, "Oddish", "common", 128.0 },
                    { 44, null, 153.0, 136.0, "Gloom releases a foul fragrance from the pistil of its flower. When faced with danger, the stench worsens. If this Pokémon is feeling calm and secure, it does not release its usual stinky aroma.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/44.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/44.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/44.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/44.png", 0f, "Gloom", "common", 155.0 },
                    { 45, null, 202.0, 167.0, "Vileplume's toxic pollen triggers atrocious allergy attacks. That's why it is advisable never to approach any attractive flowers in a jungle, however pretty they may be.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/45.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/45.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/45.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/45.png", 0f, "Vileplume", "common", 181.0 },
                    { 46, null, 121.0, 99.0, "Paras has parasitic mushrooms growing on its back called tochukaso. They grow large by drawing nutrients from this Bug Pokémon host. They are highly valued as a medicine for extending life.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/46.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/46.png", null, 0f, "Paras", "common", 111.0 },
                    { 47, null, 165.0, 146.0, "Parasect is known to infest large trees en masse and drain nutrients from the lower trunk and roots. When an infested tree dies, they move onto another tree all at once.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/47.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/47.png", null, 0f, "Parasect", "common", 155.0 },
                    { 48, null, 100.0, 100.0, "Venonat is said to have evolved with a coat of thin, stiff hair that covers its entire body for protection. It possesses large eyes that never fail to spot even minuscule prey.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/48.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/48.png", null, 0f, "Venonat", "common", 155.0 },
                    { 49, null, 179.0, 143.0, "Venomoth is nocturnal—it is a Pokémon that only becomes active at night. Its favorite prey are small insects that gather around streetlights, attracted by the light in the darkness.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/49.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/49.png", null, 0f, "Venomoth", "common", 172.0 },
                    { 50, null, 109.0, 78.0, "Diglett are raised in most farms. The reason is simple—wherever this Pokémon burrows, the soil is left perfectly tilled for planting crops. This soil is made ideal for growing delicious vegetables.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/50.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/50.png", null, 0f, "Diglett", "common", 67.0 },
                    { 51, null, 167.0, 134.0, "Dugtrio are actually triplets that emerged from one body. As a result, each triplet thinks exactly like the other two triplets. They work cooperatively to burrow endlessly.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/51.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/51.png", null, 0f, "Dugtrio", "common", 111.0 },
                    { 52, null, 92.0, 78.0, "Meowth withdraws its sharp claws into its paws to slinkily sneak about without making any incriminating footsteps. For some reason, this Pokémon loves shiny coins that glitter with light.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/52.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/52.png", null, 0f, "Meowth", "common", 120.0 },
                    { 53, null, 150.0, 136.0, "Persian has six bold whiskers that give it a look of toughness. The whiskers sense air movements to determine what is in the Pokémon's surrounding vicinity. It becomes docile if grabbed by the whiskers.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/53.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/53.png", null, 0f, "Persian", "common", 163.0 },
                    { 54, null, 122.0, 95.0, "Psyduck uses a mysterious power. When it does so, this Pokémon generates brain waves that are supposedly only seen in sleepers. This discovery spurred controversy among scholars.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/54.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/54.png", null, 0f, "Psyduck", "common", 137.0 },
                    { 55, null, 191.0, 162.0, "The webbed flippers on its forelegs and hind legs and the streamlined body of Golduck give it frightening speed. This Pokémon is definitely much faster than even the most athletic swimmer.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/55.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/55.png", null, 0f, "Golduck", "common", 190.0 },
                    { 56, null, 148.0, 82.0, "When Mankey starts shaking and its nasal breathing turns rough, it's a sure sign that it is becoming angry. However, because it goes into a towering rage almost instantly, it is impossible for anyone to flee its wrath.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/56.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/56.png", null, 0f, "Mankey", "common", 120.0 },
                    { 57, null, 207.0, 138.0, "When Primeape becomes furious, its blood circulation is boosted. In turn, its muscles are made even stronger. However, it also becomes much less intelligent at the same time.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/57.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/57.png", null, 0f, "Primeape", "common", 163.0 },
                    { 58, null, 136.0, 93.0, "Growlithe has a superb sense of smell. Once it smells anything, this Pokémon won't forget the scent, no matter what. It uses its advanced olfactory sense to determine the emotions of other living things.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/58.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/58.png", null, 0f, "Growlithe", "common", 146.0 },
                    { 59, null, 227.0, 166.0, "Arcanine is known for its high speed. It is said to be capable of running over 6,200 miles in a single day and night. The fire that blazes wildly within this Pokémon's body is its source of power.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/59.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/59.png", null, 0f, "Arcanine", "common", 207.0 },
                    { 60, null, 101.0, 82.0, "Poliwag has a very thin skin. It is possible to see the Pokémon's spiral innards right through the skin. Despite its thinness, however, the skin is also very flexible. Even sharp fangs bounce right off it.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/60.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/60.png", null, 0f, "Poliwag", "common", 120.0 },
                    { 61, null, 130.0, 123.0, "The surface of Poliwhirl's body is always wet and slick with a slimy fluid. Because of this slippery covering, it can easily slip and slide out of the clutches of any enemy in battle.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/61.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/61.png", null, 0f, "Poliwhirl", "common", 163.0 },
                    { 62, null, 182.0, 184.0, "Poliwrath's highly developed, brawny muscles never grow fatigued, however much it exercises. It is so tirelessly strong, this Pokémon can swim back and forth across the ocean without effort.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/62.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/62.png", null, 0f, "Poliwrath", "common", 207.0 },
                    { 63, null, 195.0, 82.0, "Abra sleeps for 18 hours a day. However, it can sense the presence of foes even while it is sleeping. In such a situation, this Pokémon immediately teleports to safety.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/63.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/63.png", null, 0f, "Abra", "common", 93.0 },
                    { 64, null, 232.0, 117.0, "Kadabra emits a peculiar alpha wave if it develops a headache. Only those people with a particularly strong psyche can hope to become a Trainer of this Pokémon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/64.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/64.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/64.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/64.png", 0f, "Kadabra", "common", 120.0 },
                    { 65, null, 271.0, 167.0, "Alakazam's brain continually grows, making its head far too heavy to support with its neck. This Pokémon holds its head up using its psychokinetic power instead.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/65.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/65.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/65.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/65.png", 0f, "Alakazam", "common", 146.0 },
                    { 66, null, 137.0, 82.0, "Machop's muscles are special—they never get sore no matter how much they are used in exercise. This Pokémon has sufficient power to hurl a hundred adult humans.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/66.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/66.png", null, 0f, "Machop", "common", 172.0 },
                    { 67, null, 177.0, 125.0, "Machoke's thoroughly toned muscles possess the hardness of steel. This Pokémon has so much strength, it can easily hold aloft a sumo wrestler on just one finger.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/67.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/67.png", null, 0f, "Machoke", "common", 190.0 },
                    { 68, null, 234.0, 159.0, "Machamp has the power to hurl anything aside. However, trying to do any work requiring care and dexterity causes its arms to get tangled. This Pokémon tends to leap into action before it thinks.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/68.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/68.png", null, 0f, "Machamp", "common", 207.0 },
                    { 69, null, 139.0, 61.0, "Bellsprout's thin and flexible body lets it bend and sway to avoid any attack, however strong it may be. From its mouth, this Pokémon spits a corrosive fluid that melts even iron.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/69.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/69.png", null, 0f, "Bellsprout", "common", 137.0 },
                    { 70, null, 172.0, 92.0, "Weepinbell has a large hook on its rear end. At night, the Pokémon hooks on to a tree branch and goes to sleep. If it moves around in its sleep, it may wake up to find itself on the ground.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/70.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/70.png", null, 0f, "Weepinbell", "common", 163.0 },
                    { 71, null, 207.0, 135.0, "Victreebel has a long vine that extends from its head. This vine is waved and flicked about as if it were an animal to attract prey. When an unsuspecting prey draws near, this Pokémon swallows it whole.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/71.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/71.png", null, 0f, "Victreebel", "common", 190.0 },
                    { 72, null, 97.0, 149.0, "Tentacool's body is largely composed of water. If it is removed from the sea, it dries up like parchment. If this Pokémon happens to become dehydrated, put it back into the sea.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/72.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/72.png", null, 0f, "Tentacool", "common", 120.0 },
                    { 73, null, 166.0, 209.0, "Tentacruel has large red orbs on its head. The orbs glow before lashing the vicinity with a harsh ultrasonic blast. This Pokémon's outburst creates rough waves around it.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/73.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/73.png", null, 0f, "Tentacruel", "common", 190.0 },
                    { 74, null, 132.0, 132.0, "The longer a Geodude lives, the more its edges are chipped and worn away, making it more rounded in appearance. However, this Pokémon's heart will remain hard, craggy, and rough always.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/74.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/74.png", null, 0f, "Geodude", "common", 120.0 },
                    { 75, null, 164.0, 164.0, "Graveler grows by feeding on rocks. Apparently, it prefers to eat rocks that are covered in moss. This Pokémon eats its way through a ton of rocks on a daily basis.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/75.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/75.png", null, 0f, "Graveler", "common", 146.0 },
                    { 76, null, 211.0, 198.0, "Golem live up on mountains. If there is a large earthquake, these Pokémon will come rolling down off the mountains en masse to the foothills below.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/76.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/76.png", null, 0f, "Golem", "common", 190.0 },
                    { 77, null, 170.0, 127.0, "Ponyta is very weak at birth. It can barely stand up. This Pokémon becomes stronger by stumbling and falling to keep up with its parent.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/77.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/77.png", null, 0f, "Ponyta", "common", 137.0 },
                    { 78, null, 207.0, 162.0, "Rapidash usually can be seen casually cantering in the fields and plains. However, when this Pokémon turns serious, its fiery manes flare and blaze as it gallops its way up to 150 mph.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/78.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/78.png", null, 0f, "Rapidash", "common", 163.0 },
                    { 79, null, 109.0, 98.0, "Slowpoke uses its tail to catch prey by dipping it in water at the side of a river. However, this Pokémon often forgets what it's doing and often spends entire days just loafing at water's edge.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/79.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/79.png", null, 0f, "Slowpoke", "common", 207.0 },
                    { 80, null, 177.0, 180.0, "Slowbro's tail has a Shellder firmly attached with a bite. As a result, the tail can't be used for fishing anymore. This causes Slowbro to grudgingly swim and catch prey instead.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/80.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/80.png", null, 0f, "Slowbro", "common", 216.0 },
                    { 81, null, 165.0, 121.0, "Magnemite attaches itself to power lines to feed on electricity. If your house has a power outage, check your circuit breakers. You may find a large number of this Pokémon clinging to the breaker box.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/81.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/81.png", null, 0f, "Magnemite", "common", 93.0 },
                    { 82, null, 223.0, 169.0, "Magneton emits a powerful magnetic force that is fatal to mechanical devices. As a result, large cities sound sirens to warn citizens of large-scale outbreaks of this Pokémon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/82.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/82.png", null, 0f, "Magneton", "common", 137.0 },
                    { 83, null, 124.0, 115.0, "Farfetch'd is always seen with a stalk from a plant of some sort. Apparently, there are good stalks and bad stalks. This Pokémon has been known to fight with others over stalks.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/83.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/83.png", null, 0f, "Farfetch'd", "common", 141.0 },
                    { 84, null, 158.0, 83.0, "Doduo's two heads never sleep at the same time. Its two heads take turns sleeping, so one head can always keep watch for enemies while the other one sleeps.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/84.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/84.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/84.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/84.png", 0f, "Doduo", "common", 111.0 },
                    { 85, null, 218.0, 140.0, "Watch out if Dodrio's three heads are looking in three separate directions. It's a sure sign that it is on its guard. Don't go near this Pokémon if it's being wary—it may decide to peck you.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/85.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/85.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/85.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/85.png", 0f, "Dodrio", "common", 155.0 },
                    { 86, null, 85.0, 121.0, "Seel hunts for prey in the frigid sea underneath sheets of ice. When it needs to breathe, it punches a hole through the ice with the sharply protruding section of its head.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/86.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/86.png", null, 0f, "Seel", "common", 163.0 },
                    { 87, null, 139.0, 177.0, "Dewgong loves to snooze on bitterly cold ice. The sight of this Pokémon sleeping on a glacier was mistakenly thought to be a mermaid by a mariner long ago.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/87.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/87.png", null, 0f, "Dewgong", "common", 207.0 },
                    { 88, null, 135.0, 90.0, "Grimer's sludgy and rubbery body can be forced through any opening, however small it may be. This Pokémon enters sewer pipes to drink filthy wastewater.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/88.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/88.png", null, 0f, "Grimer", "common", 190.0 },
                    { 89, null, 190.0, 172.0, "From Muk's body seeps a foul fluid that gives off a nose-bendingly horrible stench. Just one drop of this Pokémon's body fluid can turn a pool stagnant and rancid.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/89.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/89.png", null, 0f, "Muk", "common", 233.0 },
                    { 90, null, 116.0, 134.0, "At night, this Pokémon uses its broad tongue to burrow a hole in the seafloor sand and then sleep in it. While it is sleeping, Shellder closes its shell, but leaves its tongue hanging out.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/90.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/90.png", null, 0f, "Shellder", "common", 102.0 },
                    { 91, null, 186.0, 256.0, "Cloyster is capable of swimming in the sea. It does so by swallowing water, then jetting it out toward the rear. This Pokémon shoots spikes from its shell using the same system.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/91.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/91.png", null, 0f, "Cloyster", "common", 137.0 },
                    { 92, null, 186.0, 67.0, "Gastly is largely composed of gaseous matter. When exposed to a strong wind, the gaseous body quickly dwindles away. Groups of this Pokémon cluster under the eaves of houses to escape the ravages of wind.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/92.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/92.png", null, 0f, "Gastly", "common", 102.0 },
                    { 93, null, 223.0, 107.0, "Haunter is a dangerous Pokémon. If one beckons you while floating in darkness, you must never approach it. This Pokémon will try to lick you with its tongue and steal your life away.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/93.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/93.png", null, 0f, "Haunter", "common", 128.0 },
                    { 94, null, 261.0, 149.0, "Sometimes, on a dark night, your shadow thrown by a streetlight will suddenly and startlingly overtake you. It is actually a Gengar running past you, pretending to be your shadow.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/94.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/94.png", null, 0f, "Gengar", "common", 155.0 },
                    { 95, null, 85.0, 232.0, "Onix has a magnet in its brain. It acts as a compass so that this Pokémon does not lose direction while it is tunneling. As it grows older, its body becomes increasingly rounder and smoother.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/95.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/95.png", null, 0f, "Onix", "common", 111.0 },
                    { 96, null, 89.0, 136.0, "If your nose becomes itchy while you are sleeping, it's a sure sign that one of these Pokémon is standing above your pillow and trying to eat your dream through your nostrils.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/96.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/96.png", null, 0f, "Drowzee", "common", 155.0 },
                    { 97, null, 144.0, 193.0, "Hypno holds a pendulum in its hand. The arcing movement and glitter of the pendulum lull the foe into a deep state of hypnosis. While this Pokémon searches for prey, it polishes the pendulum.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/97.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/97.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/97.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/97.png", 0f, "Hypno", "common", 198.0 },
                    { 98, null, 181.0, 124.0, "Krabby live on beaches, burrowed inside holes dug into the sand. On sandy beaches with little in the way of food, these Pokémon can be seen squabbling with each other over territory.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/98.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/98.png", null, 0f, "Krabby", "common", 102.0 },
                    { 99, null, 240.0, 181.0, "Kingler has an enormous, oversized claw. It waves this huge claw in the air to communicate with others. However, because the claw is so heavy, the Pokémon quickly tires.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/99.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/99.png", null, 0f, "Kingler", "common", 146.0 },
                    { 100, null, 109.0, 111.0, "Voltorb was first sighted at a company that manufactures Poké Balls. The link between that sighting and the fact that this Pokémon looks very similar to a Poké Ball remains a mystery.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/100.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/100.png", null, 0f, "Voltorb", "common", 120.0 },
                    { 101, null, 173.0, 173.0, "Electrode eats electricity in the atmosphere. On days when lightning strikes, you can see this Pokémon exploding all over the place from eating too much electricity.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/101.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/101.png", null, 0f, "Electrode", "common", 155.0 },
                    { 102, null, 107.0, 125.0, "This Pokémon consists of six eggs that form a closely knit cluster. The six eggs attract each other and spin around. When cracks increasingly appear on the eggs, Exeggcute is close to evolution.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/102.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/102.png", null, 0f, "Exeggcute", "common", 155.0 },
                    { 103, null, 233.0, 149.0, "Exeggutor originally came from the tropics. Its heads steadily grow larger from exposure to strong sunlight. It is said that when the heads fall off, they group together to form Exeggcute.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/103.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/103.png", null, 0f, "Exeggutor", "common", 216.0 },
                    { 104, null, 90.0, 144.0, "Cubone pines for the mother it will never see again. Seeing a likeness of its mother in the full moon, it cries. The stains on the skull the Pokémon wears are made by the tears it sheds.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/104.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/104.png", null, 0f, "Cubone", "common", 137.0 },
                    { 105, null, 144.0, 186.0, "Marowak is the evolved form of a Cubone that has overcome its sadness at the loss of its mother and grown tough. This Pokémon's tempered and hardened spirit is not easily broken.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/105.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/105.png", null, 0f, "Marowak", "common", 155.0 },
                    { 106, null, 224.0, 181.0, "Hitmonlee's legs freely contract and stretch. Using these springlike legs, it bowls over foes with devastating kicks. After battle, it rubs down its legs and loosens the muscles to overcome fatigue.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/106.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/106.png", null, 0f, "Hitmonlee", "common", 137.0 },
                    { 107, null, 193.0, 197.0, "Hitmonchan is said to possess the spirit of a boxer who had been working toward a world championship. This Pokémon has an indomitable spirit and will never give up in the face of adversity.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/107.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/107.png", null, 0f, "Hitmonchan", "common", 137.0 },
                    { 108, null, 108.0, 137.0, "Whenever Lickitung comes across something new, it will unfailingly give it a lick. It does so because it memorizes things by texture and by taste. It is somewhat put off by sour things.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/108.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/108.png", null, 0f, "Lickitung", "common", 207.0 },
                    { 109, null, 119.0, 141.0, "If Koffing becomes agitated, it raises the toxicity of its internal gases and jets them out from all over its body. This Pokémon may also overinflate its round body, then explode.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/109.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/109.png", null, 0f, "Koffing", "common", 120.0 },
                    { 110, null, 174.0, 197.0, "Weezing loves the gases given off by rotted kitchen garbage. This Pokémon will find a dirty, unkempt house and make it its home. At night, when the people in the house are asleep, it will go through the trash.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/110.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/110.png", null, 0f, "Weezing", "common", 163.0 },
                    { 111, null, 140.0, 127.0, "Rhyhorn runs in a straight line, smashing everything in its path. It is not bothered even if it rushes headlong into a block of steel. This Pokémon may feel some pain from the collision the next day, however.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/111.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/111.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/111.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/111.png", 0f, "Rhyhorn", "common", 190.0 },
                    { 112, null, 222.0, 171.0, "Rhydon's horn can crush even uncut diamonds. One sweeping blow of its tail can topple a building. This Pokémon's hide is extremely tough. Even direct cannon hits don't leave a scratch.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/112.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/112.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/112.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/112.png", 0f, "Rhydon", "common", 233.0 },
                    { 113, null, 60.0, 128.0, "Chansey lays nutritionally excellent eggs on an everyday basis. The eggs are so delicious, they are easily and eagerly devoured by even those people who have lost their appetite.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/113.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/113.png", null, 0f, "Chansey", "common", 487.0 },
                    { 114, null, 183.0, 169.0, "Tangela's vines snap off easily if they are grabbed. This happens without pain, allowing it to make a quick getaway. The lost vines are replaced by newly grown vines the very next day.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/114.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/114.png", null, 0f, "Tangela", "common", 163.0 },
                    { 115, null, 181.0, 165.0, "If you come across a young Kangaskhan playing by itself, you must never disturb it or attempt to catch it. The baby Pokémon's parent is sure to be in the area, and it will become violently enraged at you.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/115.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/115.png", null, 0f, "Kangaskhan", "common", 233.0 },
                    { 116, null, 129.0, 103.0, "Horsea eats small insects and moss off of rocks. If the ocean current turns fast, this Pokémon anchors itself by wrapping its tail around rocks or coral to prevent being washed away.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/116.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/116.png", null, 0f, "Horsea", "common", 102.0 },
                    { 117, null, 187.0, 156.0, "Seadra sleeps after wriggling itself between the branches of coral. Those trying to harvest coral are occasionally stung by this Pokémon's poison barbs if they fail to notice it.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/117.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/117.png", null, 0f, "Seadra", "common", 146.0 },
                    { 118, null, 123.0, 110.0, "Goldeen is a very beautiful Pokémon with fins that billow elegantly in water. However, don't let your guard down around this Pokémon—it could ram you powerfully with its horn.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/118.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/118.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/118.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/118.png", 0f, "Goldeen", "common", 128.0 },
                    { 119, null, 175.0, 147.0, "In the autumn, Seaking males can be seen performing courtship dances in riverbeds to woo females. During this season, this Pokémon's body coloration is at its most beautiful.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/119.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/119.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/119.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/119.png", 0f, "Seaking", "common", 190.0 },
                    { 120, null, 137.0, 112.0, "Staryu's center section has an organ called the core that shines bright red. If you go to a beach toward the end of summer, the glowing cores of these Pokémon look like the stars in the sky.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/120.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/120.png", null, 0f, "Staryu", "common", 102.0 },
                    { 121, null, 210.0, 184.0, "Starmie's center section—the core—glows brightly in seven colors. Because of its luminous nature, this Pokémon has been given the nickname “the gem of the sea.”", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/121.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/121.png", null, 0f, "Starmie", "common", 155.0 },
                    { 122, null, 192.0, 205.0, "Mr. Mime is a master of pantomime. Its gestures and motions convince watchers that something unseeable actually exists. Once the watchers are convinced, the unseeable thing exists as if it were real.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/122.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/122.png", null, 0f, "Mr. Mime", "common", 120.0 },
                    { 123, null, 218.0, 170.0, "Scyther is blindingly fast. Its blazing speed enhances the effectiveness of the twin scythes on its forearms. This Pokémon's scythes are so effective, they can slice through thick logs in one wicked stroke.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/123.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/123.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/123.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/123.png", 0f, "Scyther", "common", 172.0 },
                    { 124, null, 223.0, 151.0, "Jynx walks rhythmically, swaying and shaking its hips as if it were dancing. Its motions are so bouncingly alluring, people seeing it are compelled to shake their hips without giving any thought to what they are doing.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/124.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/124.png", null, 0f, "Jynx", "common", 163.0 },
                    { 125, null, 198.0, 158.0, "When a storm arrives, gangs of this Pokémon compete with each other to scale heights that are likely to be stricken by lightning bolts. Some towns use Electabuzz in place of lightning rods.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/125.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/125.png", null, 0f, "Electabuzz", "common", 163.0 },
                    { 126, null, 206.0, 154.0, "In battle, Magmar blows out intensely hot flames from all over its body to intimidate its opponent. This Pokémon's fiery bursts create heat waves that ignite grass and trees in its surroundings.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/126.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/126.png", null, 0f, "Magmar", "common", 163.0 },
                    { 127, null, 238.0, 182.0, "Pinsir is astoundingly strong. It can grip a foe weighing twice its weight in its horns and easily lift it. This Pokémon's movements turn sluggish in cold places.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/127.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/127.png", null, 0f, "Pinsir", "common", 163.0 },
                    { 128, null, 198.0, 183.0, "This Pokémon is not satisfied unless it is rampaging at all times. If there is no opponent for Tauros to battle, it will charge at thick trees and knock them down to calm itself.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/128.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/128.png", null, 0f, "Tauros", "common", 181.0 },
                    { 129, null, 29.0, 85.0, "Magikarp is a pathetic excuse for a Pokémon that is only capable of flopping and splashing. This behavior prompted scientists to undertake research into it.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/129.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/129.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/129.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/129.png", 0f, "Magikarp", "common", 85.0 },
                    { 130, null, 237.0, 186.0, "When Magikarp evolves into Gyarados, its brain cells undergo a structural transformation. It is said that this transformation is to blame for this Pokémon's wildly violent nature.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/130.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/130.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/130.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/130.png", 0f, "Gyarados", "common", 216.0 },
                    { 131, null, 165.0, 174.0, "People have driven Lapras almost to the point of extinction. In the evenings, this Pokémon is said to sing plaintively as it seeks what few others of its kind still remain.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/131.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/131.png", null, 0f, "Lapras", "common", 277.0 },
                    { 132, null, 91.0, 91.0, "Ditto rearranges its cell structure to transform itself into other shapes. However, if it tries to transform itself into something by relying on its memory, this Pokémon manages to get details wrong.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/132.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/132.png", null, 0f, "Ditto", "common", 134.0 },
                    { 133, null, 104.0, 114.0, "Eevee has an unstable genetic makeup that suddenly mutates due to the environment in which it lives. Radiation from various stones causes this Pokémon to evolve.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/133.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/133.png", null, 0f, "Eevee", "common", 146.0 },
                    { 134, null, 205.0, 161.0, "Vaporeon underwent a spontaneous mutation and grew fins and gills that allow it to live underwater. This Pokémon has the ability to freely control water.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/134.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/134.png", null, 0f, "Vaporeon", "common", 277.0 },
                    { 135, null, 232.0, 182.0, "Jolteon's cells generate a low level of electricity. This power is amplified by the static electricity of its fur, enabling the Pokémon to drop thunderbolts. The bristling fur is made of electrically charged needles.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/135.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/135.png", null, 0f, "Jolteon", "common", 163.0 },
                    { 136, null, 246.0, 179.0, "Flareon's fluffy fur has a functional purpose—it releases heat into the air so that its body does not get excessively hot. This Pokémon's body temperature can rise to a maximum of 1,650 degrees Fahrenheit.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/136.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/136.png", null, 0f, "Flareon", "common", 163.0 },
                    { 137, null, 153.0, 136.0, "Porygon is capable of reverting itself entirely back to program data and entering cyberspace. This Pokémon is copy protected so it cannot be duplicated by copying.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/137.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/137.png", null, 0f, "Porygon", "common", 163.0 },
                    { 138, null, 155.0, 153.0, "Omanyte is one of the ancient and long-since-extinct Pokémon that have been regenerated from fossils by people. If attacked by an enemy, it withdraws itself inside its hard shell.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/138.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/138.png", null, 0f, "Omanyte", "common", 111.0 },
                    { 139, null, 207.0, 201.0, "Omastar uses its tentacles to capture its prey. It is believed to have become extinct because its shell grew too large and heavy, causing its movements to become too slow and ponderous.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/139.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/139.png", null, 0f, "Omastar", "common", 172.0 },
                    { 140, null, 148.0, 140.0, "Kabuto is a Pokémon that has been regenerated from a fossil. However, in extremely rare cases, living examples have been discovered. The Pokémon has not changed at all for 300 million years.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/140.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/140.png", null, 0f, "Kabuto", "common", 102.0 },
                    { 141, null, 220.0, 186.0, "Kabutops swam underwater to hunt for its prey in ancient times. The Pokémon was apparently evolving from being a water dweller to living on land as evident from the beginnings of change in its gills and legs.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/141.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/141.png", null, 0f, "Kabutops", "common", 155.0 },
                    { 142, null, 221.0, 159.0, "Aerodactyl is a Pokémon from the age of dinosaurs. It was regenerated from genetic material extracted from amber. It is imagined to have been the king of the skies in ancient times.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/142.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/142.png", null, 0f, "Aerodactyl", "common", 190.0 },
                    { 143, null, 190.0, 169.0, "Snorlax's typical day consists of nothing more than eating and sleeping. It is such a docile Pokémon that there are children who use its expansive belly as a place to play.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/143.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/143.png", null, 0f, "Snorlax", "common", 330.0 },
                    { 144, null, 192.0, 236.0, "Articuno is a Legendary Pokémon that can control ice. The flapping of its wings chills the air. As a result, it is said that when this Pokémon flies, snow will fall.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/144.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/144.png", null, 0f, "Articuno", "Legendary", 207.0 },
                    { 145, null, 253.0, 185.0, "Zapdos is a Legendary Pokémon that has the ability to control electricity. It usually lives in thunderclouds. The Pokémon gains power if it is stricken by lightning bolts.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/145.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/145.png", null, 0f, "Zapdos", "Legendary", 207.0 },
                    { 146, null, 251.0, 181.0, "Moltres is a Legendary Pokémon that has the ability to control fire. If this Pokémon is injured, it is said to dip its body in the molten magma of a volcano to burn and heal itself.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/146.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/146.png", null, 0f, "Moltres", "Legendary", 207.0 },
                    { 147, null, 119.0, 91.0, "Dratini continually molts and sloughs off its old skin. It does so because the life energy within its body steadily builds to reach uncontrollable levels.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/147.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/147.png", null, 0f, "Dratini", "common", 121.0 },
                    { 148, null, 163.0, 135.0, "Dragonair stores an enormous amount of energy inside its body. It is said to alter weather conditions in its vicinity by discharging energy from the crystals on its neck and tail.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/148.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/148.png", null, 0f, "Dragonair", "common", 156.0 },
                    { 149, null, 263.0, 198.0, "Dragonite is capable of circling the globe in just 16 hours. It is a kindhearted Pokémon that leads lost and foundering ships in a storm to the safety of land.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/149.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/149.png", null, 0f, "Dragonite", "common", 209.0 },
                    { 150, null, 300.0, 182.0, "Mewtwo is a Pokémon that was created by genetic manipulation. However, even though the scientific power of humans created this Pokémon's body, they failed to endow Mewtwo with a compassionate heart.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/150.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/150.png", null, 0f, "Mewtwo", "Legendary", 214.0 },
                    { 151, null, 210.0, 210.0, "Mew is said to possess the genetic composition of all Pokémon. It is capable of making itself invisible at will, so it entirely avoids notice even if it approaches people.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/151.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/151.png", null, 0f, "Mew", "Mythical", 225.0 },
                    { 152, null, 92.0, 122.0, "In battle, Chikorita waves its leaf around to keep the foe at bay. However, a sweet fragrance also wafts from the leaf, becalming the battling Pokémon and creating a cozy, friendly atmosphere all around.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/152.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/152.png", null, 0f, "Chikorita", "common", 128.0 },
                    { 153, null, 122.0, 155.0, "Bayleef's neck is ringed by curled-up leaves. Inside each tubular leaf is a small shoot of a tree. The fragrance of this shoot makes people peppy.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/153.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/153.png", null, 0f, "Bayleef", "common", 155.0 },
                    { 154, null, 168.0, 202.0, "The fragrance of Meganium's flower soothes and calms emotions. In battle, this Pokémon gives off more of its becalming scent to blunt the foe's fighting spirit.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/154.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/154.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/154.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/154.png", 0f, "Meganium", "common", 190.0 },
                    { 155, null, 116.0, 93.0, "Cyndaquil protects itself by flaring up the flames on its back. The flames are vigorous if the Pokémon is angry. However, if it is tired, the flames splutter fitfully with incomplete combustion.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/155.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/155.png", null, 0f, "Cyndaquil", "common", 118.0 },
                    { 156, null, 158.0, 126.0, "Quilava keeps its foes at bay with the intensity of its flames and gusts of superheated air. This Pokémon applies its outstanding nimbleness to dodge attacks even while scorching the foe with flames.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/156.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/156.png", null, 0f, "Quilava", "common", 151.0 },
                    { 157, null, 223.0, 173.0, "Typhlosion obscures itself behind a shimmering heat haze that it creates using its intensely hot flames. This Pokémon creates blazing explosive blasts that burn everything to cinders.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/157.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/157.png", null, 0f, "Typhlosion", "common", 186.0 },
                    { 158, null, 117.0, 109.0, "Despite the smallness of its body, Totodile's jaws are very powerful. While the Pokémon may think it is just playfully nipping, its bite has enough power to cause serious injury.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/158.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/158.png", null, 0f, "Totodile", "common", 137.0 },
                    { 159, null, 150.0, 142.0, "Once Croconaw has clamped its jaws on its foe, it will absolutely not let go. Because the tips of its fangs are forked back like barbed fishhooks, they become impossible to remove when they have sunk in.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/159.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/159.png", null, 0f, "Croconaw", "common", 163.0 },
                    { 160, null, 205.0, 188.0, "Feraligatr intimidates its foes by opening its huge mouth. In battle, it will kick the ground hard with its thick and powerful hind legs to charge at the foe at an incredible speed.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/160.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/160.png", null, 0f, "Feraligatr", "common", 198.0 },
                    { 161, null, 79.0, 73.0, "When Sentret sleeps, it does so while another stands guard. The sentry wakes the others at the first sign of danger. When this Pokémon becomes separated from its pack, it becomes incapable of sleep due to fear.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/161.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/161.png", null, 0f, "Sentret", "common", 111.0 },
                    { 162, null, 148.0, 125.0, "Furret has a very slim build. When under attack, it can slickly squirm through narrow spaces and get away. In spite of its short limbs, this Pokémon is very nimble and fleet.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/162.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/162.png", null, 0f, "Furret", "common", 198.0 },
                    { 163, null, 67.0, 88.0, "Hoothoot has an internal organ that senses and tracks the earth's rotation. Using this special organ, this Pokémon begins hooting at precisely the same time every day.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/163.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/163.png", null, 0f, "Hoothoot", "common", 155.0 },
                    { 164, null, 145.0, 156.0, "Noctowl never fails at catching prey in darkness. This Pokémon owes its success to its superior vision that allows it to see in minimal light, and to its soft, supple wings that make no sound in flight.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/164.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/164.png", null, 0f, "Noctowl", "common", 225.0 },
                    { 165, null, 72.0, 118.0, "Ledyba secretes an aromatic fluid from where its legs join its body. This fluid is used for communicating with others. This Pokémon conveys its feelings to others by altering the fluid's scent.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/165.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/165.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/165.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/165.png", 0f, "Ledyba", "common", 120.0 },
                    { 166, null, 107.0, 179.0, "It is said that in lands with clean air, where the stars fill the sky, there live Ledian in countless numbers. There is a good reason for this—the Pokémon uses the light of the stars as its energy.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/166.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/166.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/166.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/166.png", 0f, "Ledian", "common", 146.0 },
                    { 167, null, 105.0, 73.0, "The web spun by Spinarak can be considered its second nervous system. It is said that this Pokémon can determine what kind of prey is touching its web just by the tiny vibrations it feels through the web's strands.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/167.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/167.png", null, 0f, "Spinarak", "common", 120.0 },
                    { 168, null, 161.0, 124.0, "Ariados's feet are tipped with tiny hooked claws that enable it to scuttle on ceilings and vertical walls. This Pokémon constricts the foe with thin and strong silk webbing.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/168.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/168.png", null, 0f, "Ariados", "common", 172.0 },
                    { 169, null, 194.0, 178.0, "If this Pokémon is flying by fluttering only a pair of wings on either the forelegs or hind legs, it's proof that Crobat has been flying a long distance. It switches the wings it uses if it is tired.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/169.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/169.png", null, 0f, "Crobat", "common", 198.0 },
                    { 170, null, 106.0, 97.0, "Chinchou lets loose positive and negative electrical charges from its two antennas to make its prey faint. This Pokémon flashes its electric lights to exchange signals with others.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/170.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/170.png", null, 0f, "Chinchou", "common", 181.0 },
                    { 171, null, 146.0, 137.0, "Lanturn is nicknamed “the deep-sea star” for its illuminated antenna. This Pokémon produces light by causing a chemical reaction between bacteria and its bodily fluids inside the antenna.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/171.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/171.png", null, 0f, "Lanturn", "common", 268.0 },
                    { 172, null, 77.0, 53.0, "Pichu charges itself with electricity more easily on days with thunderclouds or when the air is very dry. You can hear the crackling of static electricity coming off this Pokémon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/172.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/172.png", null, 0f, "Pichu", "common", 85.0 },
                    { 173, null, 75.0, 79.0, "On nights with many shooting stars, Cleffa can be seen dancing in a ring. They dance through the night and stop only at the break of day, when these Pokémon quench their thirst with the morning dew.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/173.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/173.png", null, 0f, "Cleffa", "common", 137.0 },
                    { 174, null, 69.0, 32.0, "Igglybuff's vocal cords are not sufficiently developed. It would hurt its throat if it were to sing too much. This Pokémon gargles with freshwater from a clean stream.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/174.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/174.png", null, 0f, "Igglybuff", "common", 207.0 },
                    { 175, null, 67.0, 116.0, "As its energy, Togepi uses the positive emotions of compassion and pleasure exuded by people and Pokémon. This Pokémon stores up feelings of happiness inside its shell, then shares them with others.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/175.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/175.png", null, 0f, "Togepi", "common", 111.0 },
                    { 176, null, 139.0, 181.0, "Togetic is said to be a Pokémon that brings good fortune. When the Pokémon spots someone who is pure of heart, it is said to appear and share its happiness with that person.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/176.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/176.png", null, 0f, "Togetic", "common", 146.0 },
                    { 177, null, 134.0, 89.0, "Natu cannot fly because its wings are not yet fully grown. If your eyes meet with this Pokémon's eyes, it will stare back intently at you. But if you move even slightly, it will hop away to safety.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/177.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/177.png", null, 0f, "Natu", "common", 120.0 },
                    { 178, null, 192.0, 146.0, "Xatu stands rooted and still in one spot all day long. People believe that this Pokémon does so out of fear of the terrible things it has foreseen in the future.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/178.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/178.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/178.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/178.png", 0f, "Xatu", "common", 163.0 },
                    { 179, null, 114.0, 79.0, "Mareep's fluffy coat of wool rubs together and builds a static charge. The more static electricity is charged, the more brightly the lightbulb at the tip of its tail glows.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/179.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/179.png", null, 0f, "Mareep", "common", 146.0 },
                    { 180, null, 145.0, 109.0, "Flaaffy's wool quality changes so that it can generate a high amount of static electricity with a small amount of wool. The bare and slick parts of its hide are shielded against electricity.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/180.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/180.png", null, 0f, "Flaaffy", "common", 172.0 },
                    { 181, null, 211.0, 169.0, "Ampharos gives off so much light that it can be seen even from space. People in the old days used the light of this Pokémon to send signals back and forth with others far away.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/181.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/181.png", null, 0f, "Ampharos", "common", 207.0 },
                    { 182, null, 169.0, 186.0, "When Bellossom gets exposed to plenty of sunlight, the leaves ringing its body begin to spin around. This Pokémon's dancing is renowned in the southern lands.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/182.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/182.png", null, 0f, "Bellossom", "common", 181.0 },
                    { 183, null, 37.0, 93.0, "Marill's oil-filled tail acts much like a life preserver. If you see just its tail bobbing on the water's surface, it's a sure indication that this Pokémon is diving beneath the water to feed on aquatic plants.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/183.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/183.png", null, 0f, "Marill", "common", 172.0 },
                    { 184, null, 112.0, 152.0, "Azumarill's long ears are indispensable sensors. By focusing its hearing, this Pokémon can identify what kinds of prey are around, even in rough and fast-running rivers.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/184.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/184.png", null, 0f, "Azumarill", "common", 225.0 },
                    { 185, null, 167.0, 176.0, "Sudowoodo camouflages itself as a tree to avoid being attacked by enemies. However, because its hands remain green throughout the year, the Pokémon is easily identified as a fake during the winter.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/185.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/185.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/185.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/185.png", 0f, "Sudowoodo", "common", 172.0 },
                    { 186, null, 174.0, 179.0, "The curled hair on Politoed's head is proof of its status as a king. It is said that the longer and more curled the hair, the more respect this Pokémon earns from its peers.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/186.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/186.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/186.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/186.png", 0f, "Politoed", "common", 207.0 },
                    { 187, null, 67.0, 94.0, "This Pokémon drifts and floats with the wind. If it senses the approach of strong winds, Hoppip links its leaves with other Hoppip to prepare against being blown away.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/187.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/187.png", null, 0f, "Hoppip", "common", 111.0 },
                    { 188, null, 91.0, 120.0, "Skiploom's flower blossoms when the temperature rises above 64 degrees Fahrenheit. How much the flower opens depends on the temperature. For that reason, this Pokémon is sometimes used as a thermometer.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/188.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/188.png", null, 0f, "Skiploom", "common", 146.0 },
                    { 189, null, 118.0, 183.0, "Jumpluff rides warm southern winds to cross the sea and fly to foreign lands. The Pokémon descends to the ground when it encounters cold air while it is floating.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/189.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/189.png", null, 0f, "Jumpluff", "common", 181.0 },
                    { 190, null, 136.0, 112.0, "Aipom's tail ends in a hand-like appendage that can be cleverly manipulated. However, because the Pokémon uses its tail so much, its real hands have become rather clumsy.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/190.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/190.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/190.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/190.png", 0f, "Aipom", "common", 146.0 },
                    { 191, null, 55.0, 55.0, "Sunkern tries to move as little as it possibly can. It does so because it tries to conserve all the nutrients it has stored in its body for its evolution. It will not eat a thing, subsisting only on morning dew.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/191.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/191.png", null, 0f, "Sunkern", "common", 102.0 },
                    { 192, null, 185.0, 135.0, "Sunflora converts solar energy into nutrition. It moves around actively in the daytime when it is warm. It stops moving as soon as the sun goes down for the night.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/192.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/192.png", null, 0f, "Sunflora", "common", 181.0 },
                    { 193, null, 154.0, 94.0, "Yanma is capable of seeing 360 degrees without having to move its eyes. It is a great flier that is adept at making sudden stops and turning midair. This Pokémon uses its flying ability to quickly chase down targeted prey.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/193.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/193.png", null, 0f, "Yanma", "common", 163.0 },
                    { 194, null, 75.0, 66.0, "Wooper usually lives in water. However, it occasionally comes out onto land in search of food. On land, it coats its body with a gooey, toxic film.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/194.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/194.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/194.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/194.png", 0f, "Wooper", "common", 146.0 },
                    { 195, null, 152.0, 143.0, "Quagsire hunts for food by leaving its mouth wide open in water and waiting for its prey to blunder in unaware. Because the Pokémon does not move, it does not get very hungry.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/195.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/195.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/195.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/195.png", 0f, "Quagsire", "common", 216.0 },
                    { 196, null, 261.0, 175.0, "Espeon is extremely loyal to any Trainer it considers to be worthy. It is said that this Pokémon developed its precognitive powers to protect its Trainer from harm.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/196.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/196.png", null, 0f, "Espeon", "common", 163.0 },
                    { 197, null, 126.0, 240.0, "Umbreon evolved as a result of exposure to the moon's waves. It hides silently in darkness and waits for its foes to make a move. The rings on its body glow when it leaps to attack.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/197.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/197.png", null, 0f, "Umbreon", "common", 216.0 },
                    { 198, null, 175.0, 87.0, "Murkrow was feared and loathed as the alleged bearer of ill fortune. This Pokémon shows strong interest in anything that sparkles or glitters. It will even try to steal rings from women.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/198.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/198.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/198.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/198.png", 0f, "Murkrow", "common", 155.0 },
                    { 199, null, 177.0, 180.0, "Slowking undertakes research every day in an effort to solve the mysteries of the world. However, this Pokémon apparently forgets everything it has learned if the Shellder on its head comes off.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/199.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/199.png", null, 0f, "Slowking", "common", 216.0 },
                    { 200, null, 167.0, 154.0, "Misdreavus frightens people with a creepy, sobbing cry. The Pokémon apparently uses its red spheres to absorb the fearful feelings of foes and turn them into nutrition.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/200.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/200.png", null, 0f, "Misdreavus", "common", 155.0 },
                    { 201, null, 136.0, 91.0, "This Pokémon is shaped like ancient writing. It is a mystery as to which came first, the ancient writings or the various Unown. Research into this topic is ongoing but nothing is known.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/201.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/201.png", null, 0f, "Unown", "common", 134.0 },
                    { 202, null, 60.0, 106.0, "If two or more Wobbuffet meet, they will turn competitive and try to outdo each other's endurance. However, they may try to see which one can endure the longest without food. Trainers need to beware of this habit.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/202.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/202.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/202.png", 0f, "Wobbuffet", "common", 382.0 },
                    { 203, null, 182.0, 133.0, "Girafarig's rear head also has a brain, but it is small. The rear head attacks in response to smells and sounds. Approaching this Pokémon from behind can cause the rear head to suddenly lash out and bite.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/203.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/203.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/203.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/203.png", 0f, "Girafarig", "common", 172.0 },
                    { 204, null, 108.0, 122.0, "Pineco hangs from a tree branch and patiently waits for prey to come along. If the Pokémon is disturbed while eating by someone shaking its tree, it drops down to the ground and explodes with no warning.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/204.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/204.png", null, 0f, "Pineco", "common", 137.0 },
                    { 205, null, 161.0, 205.0, "Forretress conceals itself inside its hardened steel shell. The shell is opened when the Pokémon is catching prey, but it does so at such a quick pace that the shell's inside cannot be seen.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/205.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/205.png", null, 0f, "Forretress", "common", 181.0 },
                    { 206, null, 131.0, 128.0, "Dunsparce has a drill for its tail. It uses this tail to burrow into the ground backward. This Pokémon is known to make its nest in complex shapes deep under the ground.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/206.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/206.png", null, 0f, "Dunsparce", "common", 225.0 },
                    { 207, null, 143.0, 184.0, "Gligar glides through the air without a sound as if it were sliding. This Pokémon hangs on to the face of its foe using its clawed hind legs and the large pincers on its forelegs, then injects the prey with its poison barb.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/207.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/207.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/207.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/207.png", 0f, "Gligar", "common", 163.0 },
                    { 208, null, 148.0, 272.0, "Steelix lives even further underground than Onix. This Pokémon is known to dig toward the earth's core. There are records of this Pokémon reaching a depth of over six-tenths of a mile underground.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/208.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/208.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/208.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/208.png", 0f, "Steelix", "common", 181.0 },
                    { 209, null, 137.0, 85.0, "By baring its fangs and making a scary face, Snubbull sends smaller Pokémon scurrying away in terror. However, this Pokémon seems a little sad at making its foes flee.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/209.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/209.png", null, 0f, "Snubbull", "common", 155.0 },
                    { 210, null, 212.0, 131.0, "Granbull has a particularly well-developed lower jaw. The enormous fangs are heavy, causing the Pokémon to tip its head back for balance. Unless it is startled, it will not try to bite indiscriminately.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/210.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/210.png", null, 0f, "Granbull", "common", 207.0 },
                    { 211, null, 184.0, 138.0, "Qwilfish sucks in water, inflating itself. This Pokémon uses the pressure of the water it swallowed to shoot toxic quills all at once from all over its body. It finds swimming somewhat challenging.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/211.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/211.png", null, 0f, "Qwilfish", "common", 163.0 },
                    { 212, null, 236.0, 181.0, "Scizor has a body with the hardness of steel. It is not easily fazed by ordinary sorts of attacks. This Pokémon flaps its wings to regulate its body temperature.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/212.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/212.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/212.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/212.png", 0f, "Scizor", "common", 172.0 },
                    { 213, null, 17.0, 396.0, "Shuckle quietly hides itself under rocks, keeping its body concealed inside its hard shell while eating berries it has stored away. The berries mix with its body fluids to become a juice.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/213.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/213.png", null, 0f, "Shuckle", "common", 85.0 },
                    { 214, null, 234.0, 179.0, "Heracross charges in a straight line at its foe, slips beneath the foe's grasp, and then scoops up and hurls the opponent with its mighty horn. This Pokémon even has enough power to topple a massive tree.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/214.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/214.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/214.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/214.png", 0f, "Heracross", "common", 190.0 },
                    { 215, null, 189.0, 146.0, "Sneasel scales trees by punching its hooked claws into the bark. This Pokémon seeks out unguarded nests and steals eggs for food while the parents are away.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/215.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/215.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/215.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/215.png", 0f, "Sneasel", "common", 146.0 },
                    { 216, null, 142.0, 93.0, "This Pokémon likes to lick its palms that are sweetened by being soaked in honey. Teddiursa concocts its own honey by blending fruits and pollen collected by Beedrill.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/216.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/216.png", null, 0f, "Teddiursa", "common", 155.0 },
                    { 217, null, 236.0, 144.0, "In the forests inhabited by Ursaring, it is said that there are many streams and towering trees where they gather food. This Pokémon walks through its forest gathering food every day.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/217.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/217.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/217.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/217.png", 0f, "Ursaring", "common", 207.0 },
                    { 218, null, 118.0, 71.0, "Molten magma courses throughout Slugma's circulatory system. If this Pokémon is chilled, the magma cools and hardens. Its body turns brittle and chunks fall off, reducing its size.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/218.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/218.png", null, 0f, "Slugma", "common", 120.0 },
                    { 219, null, 139.0, 191.0, "Magcargo's shell is actually its skin that hardened as a result of cooling. Its shell is very brittle and fragile—just touching it causes it to crumble apart. This Pokémon returns to its original size by dipping itself in magma.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/219.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/219.png", null, 0f, "Magcargo", "common", 137.0 },
                    { 220, null, 90.0, 69.0, "Swinub roots for food by rubbing its snout against the ground. Its favorite food is a mushroom that grows under the cover of dead grass. This Pokémon occasionally roots out hot springs.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/220.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/220.png", null, 0f, "Swinub", "common", 137.0 },
                    { 221, null, 181.0, 138.0, "Piloswine is covered by a thick coat of long hair that enables it to endure the freezing cold. This Pokémon uses its tusks to dig up food that has been buried under ice.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/221.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/221.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/221.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/221.png", 0f, "Piloswine", "common", 225.0 },
                    { 222, null, 118.0, 156.0, "Corsola's branches glitter very beautifully in seven colors when they catch sunlight. If any branch breaks off, this Pokémon grows it back in just one night.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/222.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/222.png", null, 0f, "Corsola", "common", 146.0 },
                    { 223, null, 127.0, 69.0, "Remoraid sucks in water, then expels it at high velocity using its abdominal muscles to shoot down flying prey. When evolution draws near, this Pokémon travels downstream from rivers.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/223.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/223.png", null, 0f, "Remoraid", "common", 111.0 },
                    { 224, null, 197.0, 141.0, "Octillery grabs onto its foe using its tentacles. This Pokémon tries to immobilize it before delivering the finishing blow. If the foe turns out to be too strong, Octillery spews ink to escape.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/224.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/224.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/224.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/224.png", 0f, "Octillery", "common", 181.0 },
                    { 225, null, 128.0, 90.0, "Delibird carries its food bundled up in its tail. There once was a famous explorer who managed to reach the peak of the world's highest mountain, thanks to one of these Pokémon sharing its food.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/225.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/225.png", null, 0f, "Delibird", "common", 128.0 },
                    { 226, null, 148.0, 226.0, "On sunny days, schools of Mantine can be seen elegantly leaping over the sea's waves. This Pokémon is not bothered by the Remoraid that hitches rides.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/226.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/226.png", null, 0f, "Mantine", "common", 163.0 },
                    { 227, null, 148.0, 226.0, "Skarmory is entirely encased in hard, protective armor. This Pokémon flies at close to 190 mph. It slashes foes with its wings that possess swordlike cutting edges.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/227.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/227.png", null, 0f, "Skarmory", "common", 163.0 },
                    { 228, null, 152.0, 83.0, "Houndour hunt as a coordinated pack. They communicate with each other using a variety of cries to corner their prey. This Pokémon's remarkable teamwork is unparalleled.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/228.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/228.png", null, 0f, "Houndour", "common", 128.0 },
                    { 229, null, 224.0, 144.0, "In a Houndoom pack, the one with its horns raked sharply toward the back serves a leadership role. These Pokémon choose their leader by fighting among themselves.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/229.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/229.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/229.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/229.png", 0f, "Houndoom", "common", 181.0 },
                    { 230, null, 194.0, 194.0, "Kingdra lives at extreme ocean depths that are otherwise uninhabited. It has long been believed that the yawning of this Pokémon creates spiraling ocean currents.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/230.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/230.png", null, 0f, "Kingdra", "common", 181.0 },
                    { 231, null, 107.0, 98.0, "For its nest, Phanpy digs a vertical pit in the ground at the edge of a river. It marks the area around its nest with its trunk to let the others know that the area has been claimed.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/231.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/231.png", null, 0f, "Phanpy", "common", 207.0 },
                    { 232, null, 214.0, 185.0, "Donphan's favorite attack is curling its body into a ball, then charging at its foe while rolling at high speed. Once it starts rolling, this Pokémon can't stop very easily.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/232.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/232.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/232.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/232.png", 0f, "Donphan", "common", 207.0 },
                    { 233, null, 198.0, 180.0, "Porygon2 was created by humans using the power of science. The man-made Pokémon has been endowed with artificial intelligence that enables it to learn new gestures and emotions on its own.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/233.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/233.png", null, 0f, "Porygon2", "common", 198.0 },
                    { 234, null, 192.0, 131.0, "Stantler's magnificent antlers were traded at high prices as works of art. As a result, this Pokémon was hunted close to extinction by those who were after the priceless antlers.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/234.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/234.png", null, 0f, "Stantler", "common", 177.0 },
                    { 235, null, 40.0, 83.0, "Smeargle marks the boundaries of its territory using a body fluid that leaks out from the tip of its tail. Over 5,000 different marks left by this Pokémon have been found.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/235.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/235.png", null, 0f, "Smeargle", "common", 146.0 },
                    { 236, null, 64.0, 64.0, "Tyrogue becomes stressed out if it does not get to train every day. When raising this Pokémon, the Trainer must establish and uphold various training methods.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/236.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/236.png", null, 0f, "Tyrogue", "common", 111.0 },
                    { 237, null, 173.0, 207.0, "Hitmontop spins on its head at high speed, all the while delivering kicks. This technique is a remarkable mix of both offense and defense at the same time. The Pokémon travels faster spinning than it does walking.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/237.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/237.png", null, 0f, "Hitmontop", "common", 137.0 },
                    { 238, null, 153.0, 91.0, "Smoochum actively runs about, but also falls quite often. Whenever the chance arrives, it will look for its reflection to make sure its face hasn't become dirty.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/238.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/238.png", null, 0f, "Smoochum", "common", 128.0 },
                    { 239, null, 135.0, 101.0, "Elekid stores electricity in its body. If it touches metal and accidentally discharges all its built-up electricity, this Pokémon begins swinging its arms in circles to recharge itself.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/239.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/239.png", null, 0f, "Elekid", "common", 128.0 },
                    { 240, null, 151.0, 99.0, "Magby's state of health is determined by observing the fire it breathes. If the Pokémon is spouting yellow flames from its mouth, it is in good health. When it is fatigued, black smoke will be mixed in with the flames.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/240.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/240.png", null, 0f, "Magby", "common", 128.0 },
                    { 241, null, 157.0, 193.0, "Miltank gives over five gallons of milk on a daily basis. Its sweet milk is enjoyed by children and grown-ups alike. People who can't drink milk turn it into yogurt and eat it instead.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/241.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/241.png", null, 0f, "Miltank", "common", 216.0 },
                    { 242, null, 129.0, 169.0, "Blissey senses sadness with its fluffy coat of fur. If it does so, this Pokémon will rush over to a sad person, no matter how far away, to share a Lucky Egg that brings a smile to any face.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/242.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/242.png", null, 0f, "Blissey", "common", 496.0 },
                    { 243, null, 241.0, 195.0, "Raikou embodies the speed of lightning. The roars of this Pokémon send shock waves shuddering through the air and shake the ground as if lightning bolts had come crashing down.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/243.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/243.png", null, 0f, "Raikou", "Legendary", 207.0 },
                    { 244, null, 235.0, 171.0, "Entei embodies the passion of magma. This Pokémon is thought to have been born in the eruption of a volcano. It sends up massive bursts of fire that utterly consume all that they touch.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/244.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/244.png", null, 0f, "Entei", "Legendary", 251.0 },
                    { 245, null, 180.0, 235.0, "Suicune embodies the compassion of a pure spring of water. It runs across the land with gracefulness. This Pokémon has the power to purify dirty water.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/245.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/245.png", null, 0f, "Suicune", "Legendary", 225.0 },
                    { 246, null, 115.0, 93.0, "Larvitar is born deep under the ground. To come up to the surface, this Pokémon must eat its way through the soil above. Until it does so, Larvitar cannot see its parents.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/246.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/246.png", null, 0f, "Larvitar", "common", 137.0 },
                    { 247, null, 155.0, 133.0, "Pupitar creates a gas inside its body that it compresses and forcefully ejects to propel itself like a jet. The body is very durable—it avoids damage even if it hits solid steel.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/247.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/247.png", null, 0f, "Pupitar", "common", 172.0 },
                    { 248, null, 251.0, 207.0, "Tyranitar is so overwhelmingly powerful, it can bring down a whole mountain to make its nest. This Pokémon wanders about in mountains seeking new opponents to fight.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/248.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/248.png", null, 0f, "Tyranitar", "common", 225.0 },
                    { 249, null, 193.0, 310.0, "Lugia's wings pack devastating power—a light fluttering of its wings can blow apart regular houses. As a result, this Pokémon chooses to live out of sight deep under the sea.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/249.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/249.png", null, 0f, "Lugia", "Legendary", 235.0 },
                    { 250, null, 239.0, 244.0, "Ho-Oh's feathers glow in seven colors depending on the angle at which they are struck by light. These feathers are said to bring happiness to the bearers. This Pokémon is said to live at the foot of a rainbow.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/250.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/250.png", null, 0f, "Ho-Oh", "Legendary", 214.0 },
                    { 251, null, 210.0, 210.0, "This Pokémon came from the future by crossing over time. It is thought that so long as Celebi appears, a bright and shining future awaits us.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/251.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/251.png", null, 0f, "Celebi", "Mythical", 225.0 },
                    { 252, null, 124.0, 94.0, "Treecko has small hooks on the bottom of its feet that enable it to scale vertical walls. This Pokémon attacks by slamming foes with its thick tail.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/252.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/252.png", null, 0f, "Treecko", "common", 120.0 },
                    { 253, null, 172.0, 120.0, "The leaves growing out of Grovyle's body are convenient for camouflaging it from enemies in the forest. This Pokémon is a master at climbing trees in jungles.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/253.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/253.png", null, 0f, "Grovyle", "common", 137.0 },
                    { 254, null, 223.0, 169.0, "The leaves growing on Sceptile's body are very sharp edged. This Pokémon is very agile—it leaps all over the branches of trees and jumps on its foe from above or behind.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/254.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/254.png", null, 0f, "Sceptile", "common", 172.0 },
                    { 255, null, 130.0, 87.0, "Torchic sticks with its Trainer, following behind with unsteady steps. This Pokémon breathes fire of over 1,800 degrees Fahrenheit, including fireballs that leave the foe scorched black.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/255.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/255.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/255.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/255.png", 0f, "Torchic", "common", 128.0 },
                    { 256, null, 163.0, 115.0, "Combusken toughens up its legs and thighs by running through fields and mountains. This Pokémon's legs possess both speed and power, enabling it to dole out 10 kicks in one second.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/256.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/256.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/256.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/256.png", 0f, "Combusken", "common", 155.0 },
                    { 257, null, 240.0, 141.0, "In battle, Blaziken blows out intense flames from its wrists and attacks foes courageously. The stronger the foe, the more intensely this Pokémon's wrists burn.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/257.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/257.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/257.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/257.png", 0f, "Blaziken", "common", 190.0 },
                    { 258, null, 126.0, 93.0, "The fin on Mudkip's head acts as highly sensitive radar. Using this fin to sense movements of water and air, this Pokémon can determine what is taking place around it without using its eyes.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/258.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/258.png", null, 0f, "Mudkip", "common", 137.0 },
                    { 259, null, 156.0, 133.0, "The surface of Marshtomp's body is enveloped by a thin, sticky film that enables it to live on land. This Pokémon plays in mud on beaches when the ocean tide is low.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/259.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/259.png", null, 0f, "Marshtomp", "common", 172.0 },
                    { 260, null, 208.0, 175.0, "Swampert is very strong. It has enough power to easily drag a boulder weighing more than a ton. This Pokémon also has powerful vision that lets it see even in murky water.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/260.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/260.png", null, 0f, "Swampert", "common", 225.0 },
                    { 261, null, 96.0, 61.0, "At first sight, Poochyena takes a bite at anything that moves. This Pokémon chases after prey until the victim becomes exhausted. However, it may turn tail if the prey strikes back.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/261.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/261.png", null, 0f, "Poochyena", "common", 111.0 },
                    { 262, null, 171.0, 132.0, "Mightyena gives obvious signals when it is preparing to attack. It starts to growl deeply and then flattens its body. This Pokémon will bite savagely with its sharply pointed fangs.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/262.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/262.png", null, 0f, "Mightyena", "common", 172.0 },
                    { 263, null, 58.0, 80.0, "Zigzagoon restlessly wanders everywhere at all times. This Pokémon does so because it is very curious. It becomes interested in anything that it happens to see.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/263.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/263.png", null, 0f, "Zigzagoon", "common", 116.0 },
                    { 264, null, 142.0, 128.0, "Linoone always runs full speed and only in straight lines. If facing an obstacle, it makes a right-angle turn to evade it. This Pokémon is very challenged by gently curving roads.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/264.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/264.png", null, 0f, "Linoone", "common", 186.0 },
                    { 265, null, 75.0, 59.0, "Using the spikes on its rear end, Wurmple peels the bark off trees and feeds on the sap that oozes out. This Pokémon's feet are tipped with suction pads that allow it to cling to glass without slipping.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/265.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/265.png", null, 0f, "Wurmple", "common", 128.0 },
                    { 266, null, 60.0, 77.0, "Silcoon tethers itself to a tree branch using silk to keep from falling. There, this Pokémon hangs quietly while it awaits evolution. It peers out of the silk cocoon through a small hole.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/266.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/266.png", null, 0f, "Silcoon", "common", 137.0 },
                    { 267, null, 189.0, 98.0, "Beautifly's favorite food is the sweet pollen of flowers. If you want to see this Pokémon, just leave a potted flower by an open window. Beautifly is sure to come looking for pollen.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/267.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/267.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/267.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/267.png", 0f, "Beautifly", "common", 155.0 },
                    { 268, null, 60.0, 77.0, "Cascoon makes its protective cocoon by wrapping its body entirely with a fine silk from its mouth. Once the silk goes around its body, it hardens. This Pokémon prepares for its evolution inside the cocoon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/268.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/268.png", null, 0f, "Cascoon", "common", 137.0 },
                    { 269, null, 98.0, 162.0, "Dustox is instinctively drawn to light. Swarms of this Pokémon are attracted by the bright lights of cities, where they wreak havoc by stripping the leaves off roadside trees for food.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/269.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/269.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/269.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/269.png", 0f, "Dustox", "common", 155.0 },
                    { 270, null, 71.0, 77.0, "Lotad live in ponds and lakes, where they float on the surface. It grows weak if its broad leaf dies. On rare occasions, this Pokémon travels on land in search of clean water.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/270.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/270.png", null, 0f, "Lotad", "common", 120.0 },
                    { 271, null, 112.0, 119.0, "Lombre is nocturnal—it will get active after dusk. It is also a mischief maker. When this Pokémon spots anglers, it tugs on their fishing lines from beneath the surface and enjoys their consternation.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/271.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/271.png", null, 0f, "Lombre", "common", 155.0 },
                    { 272, null, 173.0, 176.0, "Ludicolo begins dancing as soon as it hears cheerful, festive music. This Pokémon is said to appear when it hears the singing of children on hiking outings.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/272.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/272.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/272.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/272.png", 0f, "Ludicolo", "common", 190.0 },
                    { 273, null, 71.0, 77.0, "Seedot attaches itself to a tree branch using the top of its head. It sucks moisture from the tree while hanging off the branch. The more water it drinks, the glossier this Pokémon's body becomes.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/273.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/273.png", null, 0f, "Seedot", "common", 120.0 },
                    { 274, null, 134.0, 78.0, "Nuzleaf live in densely overgrown forests. They occasionally venture out of the forest to startle people. This Pokémon dislikes having its long nose pinched.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/274.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/274.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/274.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/274.png", 0f, "Nuzleaf", "common", 172.0 },
                    { 275, null, 200.0, 121.0, "Shiftry is a mysterious Pokémon that is said to live atop towering trees dating back over a thousand years. It creates terrific windstorms with the fans it holds.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/275.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/275.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/275.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/275.png", 0f, "Shiftry", "common", 207.0 },
                    { 276, null, 106.0, 61.0, "Taillow courageously stands its ground against foes, however strong they may be. This gutsy Pokémon will remain defiant even after a loss. On the other hand, it cries loudly if it becomes hungry.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/276.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/276.png", null, 0f, "Taillow", "common", 120.0 },
                    { 277, null, 185.0, 124.0, "Swellow flies high above our heads, making graceful arcs in the sky. This Pokémon dives at a steep angle as soon as it spots its prey. The hapless prey is tightly grasped by Swellow's clawed feet, preventing escape.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/277.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/277.png", null, 0f, "Swellow", "common", 155.0 },
                    { 278, null, 106.0, 61.0, "Wingull has the habit of carrying prey and valuables in its beak and hiding them in all sorts of locations. This Pokémon rides the winds and flies as if it were skating across the sky.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/278.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/278.png", null, 0f, "Wingull", "common", 120.0 },
                    { 279, null, 175.0, 174.0, "Pelipper is a flying transporter that carries small Pokémon and eggs inside its massive bill. This Pokémon builds its nest on steep cliffs facing the sea.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/279.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/279.png", null, 0f, "Pelipper", "common", 155.0 },
                    { 280, null, 79.0, 59.0, "Ralts senses the emotions of people using the horns on its head. This Pokémon rarely appears before people. But when it does, it draws closer if it senses that the person has a positive disposition.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/280.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/280.png", null, 0f, "Ralts", "common", 99.0 },
                    { 281, null, 117.0, 90.0, "It is said that a Kirlia that is exposed to the positive emotions of its Trainer grows beautiful. This Pokémon controls psychokinetic powers with its highly developed brain.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/281.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/281.png", null, 0f, "Kirlia", "common", 116.0 },
                    { 282, null, 237.0, 195.0, "Gardevoir has the ability to read the future. If it senses impending danger to its Trainer, this Pokémon is said to unleash its psychokinetic energy at full power.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/282.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/282.png", null, 0f, "Gardevoir", "common", 169.0 },
                    { 283, null, 93.0, 87.0, "From the tips of its feet, Surskit secretes an oil that enables it to walk on water as if it were skating. This Pokémon feeds on microscopic organisms in ponds and lakes.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/283.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/283.png", null, 0f, "Surskit", "common", 120.0 },
                    { 284, null, 192.0, 150.0, "Masquerain intimidates enemies with the eyelike patterns on its antennas. This Pokémon flaps its four wings to freely fly in any direction—even sideways and backwards—as if it were a helicopter.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/284.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/284.png", null, 0f, "Masquerain", "common", 172.0 },
                    { 285, null, 74.0, 110.0, "Shroomish live in damp soil in the dark depths of forests. They are often found keeping still under fallen leaves. This Pokémon feeds on compost that is made up of fallen, rotted leaves.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/285.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/285.png", null, 0f, "Shroomish", "common", 155.0 },
                    { 286, null, 241.0, 144.0, "Breloom closes in on its foe with light and sprightly footwork, then throws punches with its stretchy arms. This Pokémon's fighting technique puts boxers to shame.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/286.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/286.png", null, 0f, "Breloom", "common", 155.0 },
                    { 287, null, 104.0, 92.0, "Slakoth lolls around for over 20 hours every day. Because it moves so little, it does not need much food. This Pokémon's sole daily meal consists of just three leaves.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/287.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/287.png", null, 0f, "Slakoth", "common", 155.0 },
                    { 288, null, 159.0, 145.0, "Vigoroth is always itching and agitated to go on a wild rampage. It simply can't tolerate sitting still for even a minute. This Pokémon's stress level rises if it can't be moving constantly.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/288.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/288.png", null, 0f, "Vigoroth", "common", 190.0 },
                    { 289, null, 290.0, 166.0, "Slaking spends all day lying down and lolling about. It eats grass growing within its reach. If it eats all the grass it can reach, this Pokémon reluctantly moves to another spot.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/289.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/289.png", null, 0f, "Slaking", "common", 284.0 },
                    { 290, null, 80.0, 126.0, "Nincada lives underground for many years in complete darkness. This Pokémon absorbs nutrients from the roots of trees. It stays motionless as it waits for evolution.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/290.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/290.png", null, 0f, "Nincada", "common", 104.0 },
                    { 291, null, 199.0, 112.0, "Ninjask moves around at such a high speed that it cannot be seen, even while its crying can be clearly heard. For that reason, this Pokémon was long believed to be invisible.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/291.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/291.png", null, 0f, "Ninjask", "common", 156.0 },
                    { 292, null, 153.0, 73.0, "Shedinja's hard body doesn't move—not even a twitch. In fact, its body appears to be merely a hollow shell. It is believed that this Pokémon will steal the spirit of anyone peering into its hollow body from its back.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/292.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/292.png", null, 0f, "Shedinja", "common", 1.0 },
                    { 293, null, 92.0, 42.0, "Normally, Whismur's voice is very quiet—it is barely audible even if one is paying close attention. However, if this Pokémon senses danger, it starts crying at an earsplitting volume.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/293.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/293.png", null, 0f, "Whismur", "common", 162.0 },
                    { 294, null, 134.0, 81.0, "Loudred's bellowing can completely decimate a wood-frame house. It uses its voice to punish its foes. This Pokémon's round ears serve as loudspeakers.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/294.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/294.png", null, 0f, "Loudred", "common", 197.0 },
                    { 295, null, 179.0, 137.0, "Exploud triggers earthquakes with the tremors it creates by bellowing. If this Pokémon violently inhales from the ports on its body, it's a sign that it is preparing to let loose a huge bellow.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/295.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/295.png", null, 0f, "Exploud", "common", 232.0 },
                    { 296, null, 99.0, 54.0, "Makuhita is tenacious—it will keep getting up and attacking its foe however many times it is knocked down. Every time it gets back up, this Pokémon stores more energy in its body for evolving.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/296.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/296.png", null, 0f, "Makuhita", "common", 176.0 },
                    { 297, null, 209.0, 114.0, "Hariyama practices its straight-arm slaps in any number of locations. One hit of this Pokémon's powerful, openhanded, straight-arm punches could snap a telephone pole in two.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/297.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/297.png", null, 0f, "Hariyama", "common", 302.0 },
                    { 298, null, 36.0, 71.0, "Azurill spins its tail as if it were a lasso, then hurls it far. The momentum of the throw sends its body flying, too. Using this unique action, one of these Pokémon managed to hurl itself a record 33 feet.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/298.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/298.png", null, 0f, "Azurill", "common", 137.0 },
                    { 299, null, 82.0, 215.0, "Nosepass's magnetic nose is always pointed to the north. If two of these Pokémon meet, they cannot turn their faces to each other when they are close because their magnetic noses repel one another.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/299.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/299.png", null, 0f, "Nosepass", "common", 102.0 },
                    { 300, null, 84.0, 79.0, "Skitty has the habit of becoming fascinated by moving objects and chasing them around. This Pokémon is known to chase after its own tail and become dizzy.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/300.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/300.png", null, 0f, "Skitty", "common", 137.0 },
                    { 301, null, 132.0, 127.0, "Delcatty prefers to live an unfettered existence in which it can do as it pleases at its own pace. Because this Pokémon eats and sleeps whenever it decides, its daily routines are completely random.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/301.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/301.png", null, 0f, "Delcatty", "common", 172.0 },
                    { 302, null, 141.0, 136.0, "Sableye lead quiet lives deep inside caverns. They are feared, however, because these Pokémon are thought to steal the spirits of people when their eyes burn with a sinister glow in the darkness.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/302.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/302.png", null, 0f, "Sableye", "common", 137.0 },
                    { 303, null, 155.0, 141.0, "Mawile's huge jaws are actually steel horns that have been transformed. Its docile-looking face serves to lull its foe into letting down its guard. When the foe least expects it, Mawile chomps it with its gaping jaws.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/303.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/303.png", null, 0f, "Mawile", "common", 137.0 },
                    { 304, null, 121.0, 141.0, "This Pokémon has a body of steel. To make its body, Aron feeds on iron ore that it digs from mountains. Occasionally, it causes major trouble by eating bridges and rails.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/304.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/304.png", null, 0f, "Aron", "common", 137.0 },
                    { 305, null, 158.0, 198.0, "Lairon tempers its steel body by drinking highly nutritious mineral springwater until it is bloated. This Pokémon makes its nest close to springs of delicious water.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/305.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/305.png", null, 0f, "Lairon", "common", 155.0 },
                    { 306, null, 198.0, 257.0, "Aggron claims an entire mountain as its own territory. It mercilessly beats up anything that violates its environment. This Pokémon vigilantly patrols its territory at all times.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/306.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/306.png", null, 0f, "Aggron", "common", 172.0 },
                    { 307, null, 78.0, 107.0, "Meditite undertakes rigorous mental training deep in the mountains. However, whenever it meditates, this Pokémon always loses its concentration and focus. As a result, its training never ends.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/307.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/307.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/307.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/307.png", 0f, "Meditite", "common", 102.0 },
                    { 308, null, 121.0, 152.0, "It is said that through meditation, Medicham heightens energy inside its body and sharpens its sixth sense. This Pokémon hides its presence by merging itself with fields and mountains.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/308.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/308.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/308.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/308.png", 0f, "Medicham", "common", 155.0 },
                    { 309, null, 123.0, 78.0, "Electrike stores electricity in its long body hair. This Pokémon stimulates its leg muscles with electric charges. These jolts of power give its legs explosive acceleration performance.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/309.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/309.png", null, 0f, "Electrike", "common", 120.0 },
                    { 310, null, 215.0, 127.0, "Manectric is constantly discharging electricity from its mane. The sparks sometimes ignite forest fires. When it enters a battle, this Pokémon creates thunderclouds.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/310.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/310.png", null, 0f, "Manectric", "common", 172.0 },
                    { 311, null, 167.0, 129.0, "Plusle always acts as a cheerleader for its partners. Whenever a teammate puts out a good effort in battle, this Pokémon shorts out its body to create the crackling noises of sparks to show its joy.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/311.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/311.png", null, 0f, "Plusle", "common", 155.0 },
                    { 312, null, 147.0, 150.0, "Minun is more concerned about cheering on its partners than its own safety. It shorts out the electricity in its body to create brilliant showers of sparks to cheer on its teammates.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/312.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/312.png", null, 0f, "Minun", "common", 155.0 },
                    { 313, null, 143.0, 166.0, "With the arrival of night, Volbeat emits light from its tail. It communicates with others by adjusting the intensity and flashing of its light. This Pokémon is attracted by the sweet aroma of Illumise.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/313.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/313.png", null, 0f, "Volbeat", "common", 163.0 },
                    { 314, null, 143.0, 166.0, "Illumise attracts a swarm of Volbeat using a sweet fragrance. Once the Volbeat have gathered, this Pokémon leads the lit-up swarm in drawing geometric designs on the canvas of the night sky.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/314.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/314.png", null, 0f, "Illumise", "common", 163.0 },
                    { 315, null, 186.0, 131.0, "Roselia shoots sharp thorns as projectiles at any opponent that tries to steal the flowers on its arms. The aroma of this Pokémon brings serenity to living things.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/315.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/315.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/315.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/315.png", 0f, "Roselia", "common", 137.0 },
                    { 316, null, 80.0, 99.0, "Virtually all of Gulpin's body is its stomach. As a result, it can swallow something its own size. This Pokémon's stomach contains a special fluid that digests anything.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/316.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/316.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/316.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/316.png", 0f, "Gulpin", "common", 172.0 },
                    { 317, null, 140.0, 159.0, "When Swalot spots prey, it spurts out a hideously toxic fluid from its pores and sprays the target. Once the prey has weakened, this Pokémon gulps it down whole with its cavernous mouth.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/317.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/317.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/317.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/317.png", 0f, "Swalot", "common", 225.0 },
                    { 318, null, 171.0, 39.0, "Carvanha's strongly developed jaws and its sharply pointed fangs pack the destructive power to rip out boat hulls. Many boats have been attacked and sunk by this Pokémon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/318.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/318.png", null, 0f, "Carvanha", "common", 128.0 },
                    { 319, null, 243.0, 83.0, "Nicknamed “the bully of the sea,” Sharpedo is widely feared. Its cruel fangs grow back immediately if they snap off. Just one of these Pokémon can thoroughly tear apart a supertanker.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/319.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/319.png", null, 0f, "Sharpedo", "common", 172.0 },
                    { 320, null, 136.0, 68.0, "Wailmer's nostrils are located above its eyes. This playful Pokémon loves to startle people by forcefully snorting out seawater it stores inside its body out of its nostrils.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/320.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/320.png", null, 0f, "Wailmer", "common", 277.0 },
                    { 321, null, 175.0, 87.0, "Wailord is the largest of all identified Pokémon up to now. This giant Pokémon swims languorously in the vast open sea, eating massive amounts of food at once with its enormous mouth.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/321.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/321.png", null, 0f, "Wailord", "common", 347.0 },
                    { 322, null, 119.0, 79.0, "Numel is extremely dull witted—it doesn't notice being hit. However, it can't stand hunger for even a second. This Pokémon's body is a seething cauldron of boiling magma.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/322.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/322.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/322.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/322.png", 0f, "Numel", "common", 155.0 },
                    { 323, null, 194.0, 136.0, "Camerupt has a volcano inside its body. Magma of 18,000 degrees Fahrenheit courses through its body. Occasionally, the humps on this Pokémon's back erupt, spewing the superheated magma.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/323.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/323.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/323.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/323.png", 0f, "Camerupt", "common", 172.0 },
                    { 324, null, 151.0, 203.0, "Torkoal digs through mountains in search of coal. If it finds some, it fills hollow spaces on its shell with the coal and burns it. If it is attacked, this Pokémon spouts thick black smoke to beat a retreat.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/324.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/324.png", null, 0f, "Torkoal", "common", 172.0 },
                    { 325, null, 125.0, 122.0, "Spoink bounces around on its tail. The shock of its bouncing makes its heart pump. As a result, this Pokémon cannot afford to stop bouncing—if it stops, its heart will stop.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/325.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/325.png", null, 0f, "Spoink", "common", 155.0 },
                    { 326, null, 171.0, 188.0, "Grumpig uses the black pearls on its body to amplify its psychic power waves for gaining total control over its foe. When this Pokémon uses its special power, its snorting breath grows labored.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/326.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/326.png", null, 0f, "Grumpig", "common", 190.0 },
                    { 327, null, 116.0, 116.0, "All the Spinda that exist in the world are said to have utterly unique spot patterns. The shaky, tottering steps of this Pokémon give it the appearance of dancing.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/327.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/327.png", null, 0f, "Spinda", "common", 155.0 },
                    { 328, null, 162.0, 78.0, "Trapinch's nest is a sloped, bowl-like pit dug in sand. This Pokémon patiently waits for prey to tumble down the pit. Its giant jaws have enough strength to crush even boulders.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/328.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/328.png", null, 0f, "Trapinch", "common", 128.0 },
                    { 329, null, 134.0, 99.0, "To make prey faint, Vibrava generates ultrasonic waves by vigorously making its two wings vibrate. This Pokémon's ultrasonic waves are so powerful, they can bring on headaches in people.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/329.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/329.png", null, 0f, "Vibrava", "common", 137.0 },
                    { 330, null, 205.0, 168.0, "Flygon is nicknamed “the elemental spirit of the desert.” Because its flapping wings whip up a cloud of sand, this Pokémon is always enveloped in a sandstorm while flying.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/330.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/330.png", null, 0f, "Flygon", "common", 190.0 },
                    { 331, null, 156.0, 74.0, "Cacnea lives in arid locations such as deserts. It releases a strong aroma from its flower to attract prey. When prey comes near, this Pokémon shoots sharp thorns from its body to bring the victim down.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/331.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/331.png", null, 0f, "Cacnea", "common", 137.0 },
                    { 332, null, 221.0, 115.0, "During the daytime, Cacturne remains unmoving so that it does not lose any moisture to the harsh desert sun. This Pokémon becomes active at night when the temperature drops.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/332.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/332.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/332.png", 0f, "Cacturne", "common", 172.0 },
                    { 333, null, 76.0, 132.0, "Swablu has light and fluffy wings that are like cottony clouds. This Pokémon is not frightened of people. It lands on the heads of people and sits there like a cotton-fluff hat.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/333.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/333.png", null, 0f, "Swablu", "common", 128.0 },
                    { 334, null, 141.0, 201.0, "Altaria dances and wheels through the sky among billowing, cotton-like clouds. By singing melodies in its crystal-clear voice, this Pokémon makes its listeners experience dreamy wonderment.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/334.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/334.png", null, 0f, "Altaria", "common", 181.0 },
                    { 335, null, 222.0, 124.0, "Memories of battling its archrival Seviper are etched into every cell of Zangoose's body. This Pokémon adroitly dodges attacks with incredible agility.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/335.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/335.png", null, 0f, "Zangoose", "common", 177.0 },
                    { 336, null, 196.0, 118.0, "Seviper shares a generations-long feud with Zangoose. The scars on its body are evidence of vicious battles. This Pokémon attacks using its sword-edged tail.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/336.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/336.png", null, 0f, "Seviper", "common", 177.0 },
                    { 337, null, 178.0, 153.0, "Lunatone was discovered at a location where a meteoroid fell. As a result, some people theorize that this Pokémon came from space. However, no one has been able to prove this theory so far.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/337.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/337.png", null, 0f, "Lunatone", "common", 207.0 },
                    { 338, null, 178.0, 153.0, "Solrock is a new species of Pokémon that is said to have fallen from space. It floats in air and moves silently. In battle, this Pokémon releases intensely bright light.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/338.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/338.png", null, 0f, "Solrock", "common", 207.0 },
                    { 339, null, 93.0, 82.0, "Barboach's sensitive whiskers serve as a superb radar system. This Pokémon hides in mud, leaving only its two whiskers exposed while it waits for prey to come along.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/339.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/339.png", null, 0f, "Barboach", "common", 137.0 },
                    { 340, null, 151.0, 141.0, "Whiscash is extremely territorial. Just one of these Pokémon will claim a large pond as its exclusive territory. If a foe approaches it, it thrashes about and triggers a massive earthquake.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/340.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/340.png", null, 0f, "Whiscash", "common", 242.0 },
                    { 341, null, 141.0, 99.0, "Corphish were originally foreign Pokémon that were imported as pets. They eventually turned up in the wild. This Pokémon is very hardy and has greatly increased its population.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/341.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/341.png", null, 0f, "Corphish", "common", 125.0 },
                    { 342, null, 224.0, 142.0, "Crawdaunt has an extremely violent nature that compels it to challenge other living things to battle. Other life-forms refuse to live in ponds inhabited by this Pokémon, making them desolate places.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/342.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/342.png", null, 0f, "Crawdaunt", "common", 160.0 },
                    { 343, null, 77.0, 124.0, "Baltoy moves while spinning around on its one foot. Primitive wall paintings depicting this Pokémon living among people were discovered in some ancient ruins.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/343.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/343.png", null, 0f, "Baltoy", "common", 120.0 },
                    { 344, null, 140.0, 229.0, "Claydol are said to be dolls of mud made by primitive humans and brought to life by exposure to a mysterious ray. This Pokémon moves about while levitating.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/344.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/344.png", null, 0f, "Claydol", "common", 155.0 },
                    { 345, null, 105.0, 150.0, "Lileep became extinct approximately a hundred million years ago. This ancient Pokémon attaches itself to a rock on the seafloor and catches approaching prey using tentacles shaped like flower petals.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/345.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/345.png", null, 0f, "Lileep", "common", 165.0 },
                    { 346, null, 152.0, 194.0, "Cradily roams around the ocean floor in search of food. This Pokémon freely extends its tree trunk-like neck and captures unwary prey using its eight tentacles.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/346.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/346.png", null, 0f, "Cradily", "common", 200.0 },
                    { 347, null, 176.0, 100.0, "Anorith was regenerated from a prehistoric fossil. This primitive Pokémon once lived in warm seas. It grips its prey firmly between its two large claws.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/347.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/347.png", null, 0f, "Anorith", "common", 128.0 },
                    { 348, null, 222.0, 174.0, "Armaldo's tough armor makes all attacks bounce off. This Pokémon's two enormous claws can be freely extended or contracted. They have the power to punch right through a steel slab.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/348.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/348.png", null, 0f, "Armaldo", "common", 181.0 },
                    { 349, null, 29.0, 85.0, "Feebas's fins are ragged and tattered from the start of its life. Because of its shoddy appearance, this Pokémon is largely ignored. It is capable of living in both the sea and in rivers.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/349.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/349.png", null, 0f, "Feebas", "common", 85.0 },
                    { 350, null, 192.0, 219.0, "Milotic is said to be the most beautiful of all the Pokémon. It has the power to becalm such emotions as anger and hostility to quell bitter feuding.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/350.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/350.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/350.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/350.png", 0f, "Milotic", "common", 216.0 },
                    { 351, null, 139.0, 139.0, "Castform's appearance changes with the weather. This Pokémon gained the ability to use the vast power of nature to protect its tiny body.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/351.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/351.png", null, 0f, "Castform", "common", 172.0 },
                    { 352, null, 161.0, 189.0, "Kecleon is capable of changing its body colors at will to blend in with its surroundings. There is one exception—this Pokémon can't change the zigzag pattern on its belly.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/352.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/352.png", null, 0f, "Kecleon", "common", 155.0 },
                    { 353, null, 138.0, 65.0, "Shuppet is attracted by feelings of jealousy and vindictiveness. If someone develops strong feelings of vengeance, this Pokémon will appear in a swarm and line up beneath the eaves of that person's home.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/353.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/353.png", null, 0f, "Shuppet", "common", 127.0 },
                    { 354, null, 218.0, 126.0, "Banette generates energy for laying strong curses by sticking pins into its own body. This Pokémon was originally a pitiful plush doll that was thrown away.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/354.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/354.png", null, 0f, "Banette", "common", 162.0 },
                    { 355, null, 70.0, 162.0, "Duskull can pass through any wall no matter how thick it may be. Once this Pokémon chooses a target, it will doggedly pursue the intended victim until the break of dawn.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/355.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/355.png", null, 0f, "Duskull", "common", 85.0 },
                    { 356, null, 124.0, 234.0, "Dusclops's body is completely hollow—there is nothing at all inside. It is said that its body is like a black hole. This Pokémon will absorb anything into its body, but nothing will ever come back out.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/356.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/356.png", null, 0f, "Dusclops", "common", 120.0 },
                    { 357, null, 136.0, 163.0, "The bunches of fruit around Tropius's neck are very popular with children. This Pokémon loves fruit, and eats it continuously. Apparently, its love for fruit resulted in its own outgrowth of fruit.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/357.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/357.png", null, 0f, "Tropius", "common", 223.0 },
                    { 358, null, 175.0, 170.0, "Chimecho makes its cries echo inside its hollow body. When this Pokémon becomes enraged, its cries result in ultrasonic waves that have the power to knock foes flying.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/358.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/358.png", null, 0f, "Chimecho", "common", 181.0 },
                    { 359, null, 246.0, 120.0, "Every time Absol appears before people, it is followed by a disaster such as an earthquake or a tidal wave. As a result, it came to be known as the disaster Pokémon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/359.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/359.png", null, 0f, "Absol", "common", 163.0 },
                    { 360, null, 41.0, 86.0, "Wynaut can always be seen with a big, happy smile on its face. Look at its tail to determine if it is angry. When angered, this Pokémon will be slapping the ground with its tail.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/360.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/360.png", null, 0f, "Wynaut", "common", 216.0 },
                    { 361, null, 95.0, 95.0, "Snorunt live in regions with heavy snowfall. In seasons without snow, such as spring and summer, this Pokémon steals away to live quietly among stalactites and stalagmites deep in caverns.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/361.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/361.png", null, 0f, "Snorunt", "common", 137.0 },
                    { 362, null, 162.0, 162.0, "Glalie has a body made of rock, which it hardens with an armor of ice. This Pokémon has the ability to freeze moisture in the atmosphere into any shape it desires.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/362.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/362.png", null, 0f, "Glalie", "common", 190.0 },
                    { 363, null, 95.0, 90.0, "Spheal is much faster rolling than walking to get around. When groups of this Pokémon eat, they all clap at once to show their pleasure. Because of this, their mealtimes are noisy.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/363.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/363.png", null, 0f, "Spheal", "common", 172.0 },
                    { 364, null, 137.0, 132.0, "Sealeo has the habit of always juggling on the tip of its nose anything it sees for the first time. This Pokémon occasionally entertains itself by balancing and rolling a Spheal on its nose.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/364.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/364.png", null, 0f, "Sealeo", "common", 207.0 },
                    { 365, null, 182.0, 176.0, "Walrein's two massively developed tusks can totally shatter blocks of ice weighing 10 tons with one blow. This Pokémon's thick coat of blubber insulates it from subzero temperatures.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/365.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/365.png", null, 0f, "Walrein", "common", 242.0 },
                    { 366, null, 133.0, 135.0, "Clamperl's sturdy shell is not only good for protection—it is also used for clamping and catching prey. A fully grown Clamperl's shell will be scored with nicks and scratches all over.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/366.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/366.png", null, 0f, "Clamperl", "common", 111.0 },
                    { 367, null, 197.0, 179.0, "Huntail's presence went unnoticed by people for a long time because it lives at extreme depths in the sea. This Pokémon's eyes can see clearly even in the murky dark depths of the ocean.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/367.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/367.png", null, 0f, "Huntail", "common", 146.0 },
                    { 368, null, 211.0, 179.0, "Gorebyss lives in the southern seas at extreme depths. Its body is built to withstand the enormous pressure of water at incredible depths. Because of this, this Pokémon's body is unharmed by ordinary attacks.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/368.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/368.png", null, 0f, "Gorebyss", "common", 146.0 },
                    { 369, null, 162.0, 203.0, "Relicanth is a Pokémon species that existed for a hundred million years without ever changing its form. This ancient Pokémon feeds on microscopic organisms with its toothless mouth.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/369.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/369.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/369.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/369.png", 0f, "Relicanth", "common", 225.0 },
                    { 370, null, 81.0, 128.0, "Luvdisc live in shallow seas in the tropics. This heart-shaped Pokémon earned its name by swimming after loving couples it spotted in the ocean's waves.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/370.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/370.png", null, 0f, "Luvdisc", "common", 125.0 },
                    { 371, null, 134.0, 93.0, "Bagon has a dream of one day soaring in the sky. In doomed efforts to fly, this Pokémon hurls itself off cliffs. As a result of its dives, its head has grown tough and as hard as tempered steel.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/371.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/371.png", null, 0f, "Bagon", "common", 128.0 },
                    { 372, null, 172.0, 155.0, "Inside Shelgon's armor-like shell, cells are in the midst of transformation to create an entirely new body. This Pokémon's shell is extremely heavy, making its movements sluggish.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/372.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/372.png", null, 0f, "Shelgon", "common", 163.0 },
                    { 373, null, 277.0, 168.0, "Salamence came about as a result of a strong, long-held dream of growing wings. It is said that this powerful desire triggered a sudden mutation in this Pokémon's cells, causing it to sprout its magnificent wings.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/373.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/373.png", null, 0f, "Salamence", "common", 216.0 },
                    { 374, null, 96.0, 132.0, "Instead of blood, a powerful magnetic force courses throughout Beldum's body. This Pokémon communicates with others by sending controlled pulses of magnetism.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/374.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/374.png", null, 0f, "Beldum", "common", 120.0 },
                    { 375, null, 138.0, 176.0, "When two Beldum fuse together, Metang is formed. The brains of the Beldum are joined by a magnetic nervous system. By linking its brains magnetically, this Pokémon generates strong psychokinetic power.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/375.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/375.png", null, 0f, "Metang", "common", 155.0 },
                    { 376, null, 257.0, 228.0, "Metagross has four brains in total. Combined, the four brains can breeze through difficult calculations faster than a supercomputer. This Pokémon can float in the air by tucking in its four legs.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/376.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/376.png", null, 0f, "Metagross", "common", 190.0 },
                    { 377, null, 179.0, 309.0, "Regirock was sealed away by people long ago. If this Pokémon's body is damaged in battle, it is said to seek out suitable rocks on its own to repair itself.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/377.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/377.png", null, 0f, "Regirock", "Legendary", 190.0 },
                    { 378, null, 179.0, 309.0, "Regice's body was made during an ice age. The deep-frozen body can't be melted, even by fire. This Pokémon controls frigid air of -328 degrees Fahrenheit.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/378.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/378.png", null, 0f, "Regice", "Legendary", 190.0 },
                    { 379, null, 143.0, 285.0, "Registeel has a body that is harder than any kind of metal. Its body is apparently hollow. No one has any idea what this Pokémon eats.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/379.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/379.png", null, 0f, "Registeel", "Legendary", 190.0 },
                    { 380, null, 228.0, 246.0, "Latias is highly sensitive to the emotions of people. If it senses any hostility, this Pokémon ruffles the feathers all over its body and cries shrilly to intimidate the foe.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/380.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/380.png", null, 0f, "Latias", "Legendary", 190.0 },
                    { 381, null, 268.0, 212.0, "Latios has the ability to make others see an image of what it has seen or imagines in its head. This Pokémon is intelligent and understands human speech.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/381.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/381.png", null, 0f, "Latios", "Legendary", 190.0 },
                    { 382, null, 270.0, 228.0, "Through Primal Reversion and with nature's full power, it will take back its true form. It can summon storms that cause the sea levels to rise.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/382.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/382.png", null, 0f, "Kyogre", "Legendary", 205.0 },
                    { 383, null, 270.0, 228.0, "Groudon is said to be the personification of the land itself. Legends tell of its many clashes against Kyogre, as each sought to gain the power of nature.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/383.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/383.png", null, 0f, "Groudon", "Legendary", 205.0 },
                    { 384, null, 284.0, 170.0, "Rayquaza is said to have lived for hundreds of millions of years. Legends remain of how it put to rest the clash between Kyogre and Groudon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/384.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/384.png", null, 0f, "Rayquaza", "Legendary", 213.0 },
                    { 385, null, 210.0, 210.0, "A legend states that Jirachi will make true any wish that is written on notes attached to its head when it awakens. If this Pokémon senses danger, it will fight without awakening.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/385.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/385.png", null, 0f, "Jirachi", "Mythical", 225.0 },
                    { 387, null, 119.0, 110.0, "It undertakes photosynthesis with its body, making oxygen. The leaf on its head wilts if it is thirsty.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/387.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/387.png", null, 0f, "Turtwig", "common", 146.0 },
                    { 388, null, 157.0, 143.0, "It knows where pure water wells up. It carries fellow Pokémon there on its back.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/388.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/388.png", null, 0f, "Grotle", "common", 181.0 },
                    { 389, null, 202.0, 188.0, "Small Pokémon occasionally gather on its unmoving back to begin building their nests.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/389.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/389.png", null, 0f, "Torterra", "common", 216.0 },
                    { 390, null, 113.0, 86.0, "The gas made in its belly burns from its rear end. The fire burns weakly when it feels sick.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/390.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/390.png", null, 0f, "Chimchar", "common", 127.0 },
                    { 391, null, 158.0, 105.0, "It uses ceilings and walls to launch aerial attacks. Its fiery tail is but one weapon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/391.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/391.png", null, 0f, "Monferno", "common", 162.0 },
                    { 392, null, 222.0, 151.0, "It tosses its enemies around with agility. It uses all its limbs to fight in its own unique style.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/392.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/392.png", null, 0f, "Infernape", "common", 183.0 },
                    { 393, null, 112.0, 102.0, "Because it is very proud, it hates accepting food from people. Its thick down guards it from cold.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/393.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/393.png", null, 0f, "Piplup", "common", 142.0 },
                    { 394, null, 150.0, 139.0, "It lives a solitary life. Its wings deliver wicked blows that can snap even the thickest of trees.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/394.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/394.png", null, 0f, "Prinplup", "common", 162.0 },
                    { 395, null, 210.0, 186.0, "The three horns that extend from its beak attest to its power. The leader has the biggest horns.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/395.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/395.png", null, 0f, "Empoleon", "common", 197.0 },
                    { 396, null, 101.0, 58.0, "They flock around mountains and fields, chasing after bug Pokémon. Their singing is noisy and annoying.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/396.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/396.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/396.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/396.png", 0f, "Starly", "common", 120.0 },
                    { 397, null, 142.0, 94.0, "It lives in forests and fields. Squabbles over territory occur when flocks collide.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/397.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/397.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/397.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/397.png", 0f, "Staravia", "common", 146.0 },
                    { 398, null, 234.0, 140.0, "When Staravia evolve into Staraptor, they leave the flock to live alone. They have sturdy wings.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/398.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/398.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/398.png", 0f, "Staraptor", "common", 198.0 },
                    { 399, null, 80.0, 73.0, "It constantly gnaws on logs and rocks to whittle down its front teeth. It nests alongside water.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/399.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/399.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/399.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/399.png", 0f, "Bidoof", "common", 153.0 },
                    { 400, null, 162.0, 119.0, "It makes its nest by damming streams with bark and mud. It is known as an industrious worker.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/400.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/400.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/400.png", 0f, "Bibarel", "common", 188.0 },
                    { 401, null, 45.0, 74.0, "When its antennae hit each other, it sounds like the music of a xylophone.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/401.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/401.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/401.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/401.png", 0f, "Kricketot", "common", 114.0 },
                    { 402, null, 160.0, 100.0, "It signals its emotions with its melodies. Scientists are studying these melodic patterns.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/402.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/402.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/402.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/402.png", 0f, "Kricketune", "common", 184.0 },
                    { 403, null, 117.0, 64.0, "All of its fur dazzles if danger is sensed. It flees while the foe is momentarily blinded.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/403.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/403.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/403.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/403.png", 0f, "Shinx", "common", 128.0 },
                    { 404, null, 159.0, 95.0, "Strong electricity courses through the tips of its sharp claws. A light scratch causes fainting in foes.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/404.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/404.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/404.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/404.png", 0f, "Luxio", "common", 155.0 },
                    { 405, null, 232.0, 156.0, "Luxray's ability to see through objects comes in handy when it's scouting for danger.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/405.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/405.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/405.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/405.png", 0f, "Luxray", "common", 190.0 },
                    { 406, null, 91.0, 109.0, "Over the winter, it closes its bud and endures the cold. In spring, the bud opens and releases pollen.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/406.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/406.png", null, 0f, "Budew", "common", 120.0 },
                    { 407, null, 243.0, 185.0, "With the movements of a dancer, it strikes with whips that are densely lined with poison thorns.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/407.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/407.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/407.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/407.png", 0f, "Roserade", "common", 155.0 },
                    { 408, null, 218.0, 71.0, "Its hard skull is its distinguishing feature. It snapped trees by headbutting them, and then it fed on their ripe berries.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/408.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/408.png", null, 0f, "Cranidos", "common", 167.0 },
                    { 409, null, 295.0, 109.0, "This ancient Pokémon used headbutts skillfully. Its brain was really small, so some theories suggest that its stupidity led to its extinction.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/409.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/409.png", null, 0f, "Rampardos", "common", 219.0 },
                    { 410, null, 76.0, 195.0, "Although its fossils can be found in layers of primeval rock, nothing but its face has ever been discovered.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/410.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/410.png", null, 0f, "Shieldon", "common", 102.0 },
                    { 411, null, 94.0, 286.0, "This Pokémon is from roughly 100 million years ago. Its terrifyingly tough face is harder than steel.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/411.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/411.png", null, 0f, "Bastiodon", "common", 155.0 },
                    { 412, null, 53.0, 83.0, "If its cloak is broken in battle, it quickly remakes the cloak with materials nearby.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/412.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/412.png", null, 0f, "Burmy", "common", 120.0 },
                    { 413, null, 141.0, 180.0, "When Burmy evolved, its cloak became a part of this Pokémon's body. The cloak is never shed.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/413.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/413.png", null, 0f, "Wormadam", "common", 155.0 },
                    { 414, null, 185.0, 98.0, "It flutters around at night and steals honey from the Combee hive.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/414.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/414.png", null, 0f, "Mothim", "common", 172.0 },
                    { 415, null, 59.0, 83.0, "It collects and delivers honey to its colony. At night, they cluster to form a beehive and sleep.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/415.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/415.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/415.png", 0f, "Combee", "common", 102.0 },
                    { 416, null, 149.0, 190.0, "Its abdomen is a honeycomb for grubs. It raises its grubs on honey collected by Combee.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/416.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/416.png", null, 0f, "Vespiquen", "common", 172.0 },
                    { 417, null, 94.0, 172.0, "A pair may be seen rubbing their cheek pouches together in an effort to share stored electricity.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/417.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/417.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/417.png", 0f, "Pachirisu", "common", 155.0 },
                    { 418, null, 132.0, 67.0, "It inflates the flotation sac around its neck and pokes its head out of the water to see what is going on.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/418.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/418.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/418.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/418.png", 0f, "Buizel", "common", 146.0 },
                    { 419, null, 221.0, 114.0, "Its flotation sac developed as a result of pursuing aquatic prey. It can double as a rubber raft.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/419.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/419.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/419.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/419.png", 0f, "Floatzel", "common", 198.0 },
                    { 420, null, 108.0, 92.0, "It evolves by sucking the energy out of the small ball where it had been storing nutrients.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/420.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/420.png", null, 0f, "Cherubi", "common", 128.0 },
                    { 421, null, 170.0, 153.0, "If it senses strong sunlight, it opens its folded petals to absorb the sun's rays with its whole body.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/421.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/421.png", null, 0f, "Cherrim", "common", 172.0 },
                    { 424, null, 205.0, 143.0, "It uses its tails for everything. If it wraps both of its tails around you and gives you a squeeze, that's proof it really likes you.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/424.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/424.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/424.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/424.png", 0f, "Ambipom", "common", 181.0 },
                    { 425, null, 117.0, 80.0, "Wandering souls gathered together to form this Pokémon. When trying to make friends with children, Drifloon grabs them by the hand.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/425.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/425.png", null, 0f, "Drifloon", "common", 207.0 },
                    { 426, null, 180.0, 102.0, "The raw material for the gas inside its body is souls. When its body starts to deflate, it's thought to carry away people and Pokémon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/426.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/426.png", null, 0f, "Drifblim", "common", 312.0 },
                    { 427, null, 130.0, 105.0, "The reason it keeps one ear rolled up is so it can launch a swift counterattack if it's attacked by an enemy.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/427.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/427.png", null, 0f, "Buneary", "common", 146.0 },
                    { 428, null, 156.0, 194.0, "It's notably wary and has a dislike of fighting, but at the same time, it can deliver powerful kicks with its lithe legs.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/428.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/428.png", null, 0f, "Lopunny", "common", 163.0 },
                    { 429, null, 211.0, 187.0, "Its muttered curses can cause awful headaches or terrifying visions that torment others.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/429.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/429.png", null, 0f, "Mismagius", "common", 155.0 },
                    { 430, null, 243.0, 103.0, "Its goons take care of most of the fighting for it. The only time it dirties its own hands is in delivering a final blow to finish off an opponent.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/430.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/430.png", null, 0f, "Honchkrow", "common", 225.0 },
                    { 431, null, 109.0, 82.0, "When it's happy, Glameow demonstrates beautiful movements of its tail, like a dancing ribbon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/431.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/431.png", null, 0f, "Glameow", "common", 135.0 },
                    { 432, null, 172.0, 133.0, "To make itself appear intimidatingly beefy, it tightly cinches its waist with its twin tails.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/432.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/432.png", null, 0f, "Purugly", "common", 174.0 },
                    { 433, null, 114.0, 94.0, "There is an orb inside its mouth. When it hops, the orb bounces all over and makes a ringing sound.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/433.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/433.png", null, 0f, "Chingling", "common", 128.0 },
                    { 434, null, 121.0, 90.0, "It protects itself by spraying a noxious fluid from its rear. The stench lingers for 24 hours.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/434.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/434.png", null, 0f, "Stunky", "common", 160.0 },
                    { 435, null, 184.0, 132.0, "It sprays a stinky fluid from its tail. The fluid smells worse the longer it is allowed to fester.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/435.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/435.png", null, 0f, "Skuntank", "common", 230.0 },
                    { 436, null, 43.0, 154.0, "Implements shaped like it were discovered in ancient tombs. It is unknown if they are related.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/436.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/436.png", null, 0f, "Bronzor", "common", 149.0 },
                    { 437, null, 161.0, 213.0, "Ancient people believed that petitioning Bronzong for rain was the way to make crops grow.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/437.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/437.png", null, 0f, "Bronzong", "common", 167.0 },
                    { 438, null, 124.0, 133.0, "If its body gets too damp, it will die. So, in a process reminiscent of sweating, its eyes expel moisture.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/438.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/438.png", null, 0f, "Bonsly", "common", 137.0 },
                    { 439, null, 125.0, 142.0, "When this gifted mimic surprises an opponent, Mime Jr. feels so happy that it ends up forgetting it was imitating something.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/439.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/439.png", null, 0f, "Mime Jr.", "common", 85.0 },
                    { 440, null, 25.0, 77.0, "When it sees something round and white, Happiny puts it into the pouch on its stomach. It sometimes becomes overloaded and can't move.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/440.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/440.png", null, 0f, "Happiny", "common", 225.0 },
                    { 441, null, 183.0, 91.0, "It can learn and speak human words. If they gather, they all learn the same saying.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/441.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/441.png", null, 0f, "Chatot", "common", 183.0 },
                    { 442, null, 169.0, 199.0, "It was bound to a fissure in an odd keystone as punishment for misdeeds 500 years ago.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/442.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/442.png", null, 0f, "Spiritomb", "common", 137.0 },
                    { 443, null, 124.0, 84.0, "Its original home is an area much hotter than Alola. If you're planning to live with one, your heating bill will soar.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/443.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/443.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/443.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/443.png", 0f, "Gible", "common", 151.0 },
                    { 444, null, 172.0, 125.0, "It sheds its skin and gradually grows larger. Its scales can be ground into a powder and used as raw materials for traditional medicine.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/444.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/444.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/444.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/444.png", 0f, "Gabite", "common", 169.0 },
                    { 445, null, 261.0, 193.0, "Its fine scales don't just reduce wind resistance—their sharp edges also cause injury to any opponent who attacks it.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/445.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/445.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/445.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/445.png", 0f, "Garchomp", "common", 239.0 },
                    { 446, null, 137.0, 117.0, "Anything that looks edible, Munchlax will go on and swallow whole. Its stomach is tough enough to handle it even if the food has gone rotten.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/446.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/446.png", null, 0f, "Munchlax", "common", 286.0 },
                    { 447, null, 127.0, 78.0, "It uses waves called auras to communicate with others of its kind. It doesn't make any noise during this time, so its enemies can't detect it.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/447.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/447.png", null, 0f, "Riolu", "common", 120.0 },
                    { 448, null, 236.0, 144.0, "Lucario reads its opponent's feelings with its aura waves. It finds out things it would rather not know, so it gets stressed out easily.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/448.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/448.png", null, 0f, "Lucario", "common", 172.0 },
                    { 449, null, 124.0, 118.0, "It enshrouds itself with sand to protect itself from germs. It does not enjoy getting wet.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/449.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/449.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/449.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/449.png", 0f, "Hippopotas", "common", 169.0 },
                    { 450, null, 201.0, 191.0, "It blasts internally stored sand from ports on its body to create a towering twister for attack.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/450.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/450.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/450.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/450.png", 0f, "Hippowdon", "common", 239.0 },
                    { 451, null, 93.0, 151.0, "It burrows under the sand to lie in wait for prey. Its tail claws can inject its prey with a savage poison.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/451.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/451.png", null, 0f, "Skorupi", "common", 120.0 },
                    { 452, null, 180.0, 202.0, "It has the power in its clawed arms to make scrap of a car. The tips of its claws release poison.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/452.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/452.png", null, 0f, "Drapion", "common", 172.0 },
                    { 453, null, 116.0, 76.0, "Inflating its poison sacs, it fills the area with an odd sound and hits flinching opponents with a poison jab.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/453.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/453.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/453.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/453.png", 0f, "Croagunk", "common", 134.0 },
                    { 454, null, 211.0, 133.0, "Its knuckle claws secrete a toxin so vile that even a scratch could prove fatal.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/454.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/454.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/454.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/454.png", 0f, "Toxicroak", "common", 195.0 },
                    { 455, null, 187.0, 136.0, "It binds itself to trees in marshes. It attracts prey with its sweet-smelling drool and gulps them down.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/455.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/455.png", null, 0f, "Carnivine", "common", 179.0 },
                    { 456, null, 96.0, 116.0, "It lures in prey with its shining tail fins. It stays near the surface during the day and moves to the depths when night falls.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/456.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/456.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/456.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/456.png", 0f, "Finneon", "common", 135.0 },
                    { 457, null, 142.0, 170.0, "They traverse the deep waters as if crawling over the seafloor. The fantastic lights of its fins shine like stars in the night sky.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/457.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/457.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/457.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/457.png", 0f, "Lumineon", "common", 170.0 },
                    { 458, null, 105.0, 179.0, "Mantyke are friendly toward people and will approach boats closely. The patterns on their backs differ depending on their habitat.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/458.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/458.png", null, 0f, "Mantyke", "common", 128.0 },
                    { 459, null, 115.0, 105.0, "In the spring, it grows berries with the texture of frozen treats around its belly.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/459.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/459.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/459.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/459.png", 0f, "Snover", "common", 155.0 },
                    { 460, null, 178.0, 158.0, "It lives a quiet life on mountains that are perpetually covered in snow. It hides itself by whipping up blizzards.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/460.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/460.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/460.png", 0f, "Abomasnow", "common", 207.0 },
                    { 461, null, 243.0, 171.0, "Thanks to its increased intelligence, scrapping over food is a thing of the past. A scratch from its claws will give you a case of frostbite!", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/461.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/461.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/461.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/461.png", 0f, "Weavile", "common", 172.0 },
                    { 462, null, 238.0, 205.0, "There are still people who believe that this Pokémon came from outer space. It emanates a powerful magnetic field.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/462.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/462.png", null, 0f, "Magnezone", "common", 172.0 },
                    { 463, null, 161.0, 181.0, "It uses its tongue much more skillfully than its hands or its feet. It can deftly pick up a single small bean with its tongue.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/463.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/463.png", null, 0f, "Lickilicky", "common", 242.0 },
                    { 464, null, 241.0, 190.0, "It puts rocks in holes in its palms and uses its muscles to shoot them. Geodude are shot at rare times.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/464.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/464.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/464.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/464.png", 0f, "Rhyperior", "common", 251.0 },
                    { 465, null, 207.0, 184.0, "Its vines grow so profusely that, in the warm season, you can't even see its eyes.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/465.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/465.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/465.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/465.png", 0f, "Tangrowth", "common", 225.0 },
                    { 466, null, 249.0, 163.0, "A single Electivire can provide enough electricity for all the buildings in a big city for a year.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/466.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/466.png", null, 0f, "Electivire", "common", 181.0 },
                    { 467, null, 247.0, 172.0, "Magmortar takes down its enemies by shooting fireballs, which burn them to a blackened crisp. It avoids this method when hunting prey.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/467.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/467.png", null, 0f, "Magmortar", "common", 181.0 },
                    { 468, null, 225.0, 217.0, "It shares many blessings with people who respect one another's rights and avoid needless strife.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/468.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/468.png", null, 0f, "Togekiss", "common", 198.0 },
                    { 469, null, 231.0, 156.0, "This six-legged Pokémon is easily capable of transporting an adult in flight. The wings on its tail help it stay balanced.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/469.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/469.png", null, 0f, "Yanmega", "common", 200.0 },
                    { 470, null, 216.0, 219.0, "It gets its nutrition from photosynthesis. It lives a quiet life deep in forests where clean rivers flow.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/470.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/470.png", null, 0f, "Leafeon", "common", 163.0 },
                    { 471, null, 238.0, 205.0, "It can instantaneously freeze any moisture that's around it, creating ice pellets to shoot at its prey.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/471.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/471.png", null, 0f, "Glaceon", "common", 163.0 },
                    { 472, null, 185.0, 222.0, "Its flight is soundless. It uses its lengthy tail to carry off its prey... Then its elongated fangs do the rest.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/472.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/472.png", null, 0f, "Gliscor", "common", 181.0 },
                    { 473, null, 247.0, 146.0, "Its impressive tusks are made of ice. The population thinned when it turned warm after the ice age.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/473.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/473.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/473.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/473.png", 0f, "Mamoswine", "common", 242.0 },
                    { 474, null, 264.0, 150.0, "A faulty update was added to its programming. Its behavior is noticeably strange, so the experiment may have been a failure.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/474.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/474.png", null, 0f, "Porygon-Z", "common", 198.0 },
                    { 475, null, 237.0, 195.0, "A master of courtesy and swordsmanship, it fights using extending swords on its elbows.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/475.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/475.png", null, 0f, "Gallade", "common", 169.0 },
                    { 476, null, 135.0, 275.0, "It uses three small units to catch prey and battle enemies. The main body mostly just gives orders.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/476.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/476.png", null, 0f, "Probopass", "common", 155.0 },
                    { 477, null, 180.0, 254.0, "The antenna on its head captures radio waves from the world of spirits that command it to take people there.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/477.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/477.png", null, 0f, "Dusknoir", "common", 128.0 },
                    { 478, null, 171.0, 150.0, "It's said that on nights of terrible blizzards, it comes down to human settlements. If you hear it knocking at your door, do not open it!", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/478.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/478.png", null, 0f, "Froslass", "common", 172.0 },
                    { 479, null, 185.0, 159.0, "Its body is composed of plasma. It is known to infiltrate electronic devices and wreak havoc.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/479.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/479.png", null, 0f, "Rotom", "common", 137.0 },
                    { 480, null, 156.0, 270.0, "It is said that its emergence gave humans the intelligence to improve their quality of life.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/480.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/480.png", null, 0f, "Uxie", "Legendary", 181.0 },
                    { 481, null, 212.0, 212.0, "It sleeps at the bottom of a lake. Its spirit is said to leave its body to fly on the lake's surface.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/481.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/481.png", null, 0f, "Mesprit", "Legendary", 190.0 },
                    { 482, null, 270.0, 151.0, "It is thought that Uxie, Mesprit, and Azelf all came from the same egg.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/482.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/482.png", null, 0f, "Azelf", "Legendary", 181.0 },
                    { 483, null, 275.0, 211.0, "It has the power to control time. It appears in Sinnoh-region myths as an ancient deity.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/483.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/483.png", null, 0f, "Dialga", "Legendary", 205.0 },
                    { 484, null, 280.0, 215.0, "It has the ability to distort space. It is described as a deity in Sinnoh-region mythology.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/484.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/484.png", null, 0f, "Palkia", "Legendary", 189.0 },
                    { 485, null, 251.0, 213.0, "Boiling blood, like magma, circulates through its body. It makes its dwelling place in volcanic caves.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/485.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/485.png", null, 0f, "Heatran", "Legendary", 209.0 },
                    { 486, null, 287.0, 210.0, "There is an enduring legend that states this Pokémon towed continents with ropes.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/486.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/486.png", null, 0f, "Regigigas", "Legendary", 221.0 },
                    { 487, null, 187.0, 225.0, "It was banished for its violence. It silently gazed upon the old world from the Distortion World.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/487.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/487.png", null, 0f, "Giratina", "Legendary", 284.0 },
                    { 488, null, 152.0, 258.0, "Those who sleep holding Cresselia's feather are assured of joyful dreams. It is said to represent the crescent moon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/488.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/488.png", null, 0f, "Cresselia", "Legendary", 260.0 },
                    { 489, null, 162.0, 162.0, "It drifts in warm seas. It always returns to where it was born, no matter how far it may have drifted.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/489.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/489.png", null, 0f, "Phione", "Mythical", 190.0 },
                    { 490, null, 210.0, 210.0, "It starts its life with a wondrous power that permits it to bond with any kind of Pokémon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/490.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/490.png", null, 0f, "Manaphy", "Mythical", 225.0 },
                    { 491, null, 285.0, 198.0, "It can lull people to sleep and make them dream. It is active during nights of the new moon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/491.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/491.png", null, 0f, "Darkrai", "Mythical", 172.0 },
                    { 492, null, 210.0, 210.0, "The blooming of Gracidea flowers confers the power of flight upon it. Feelings of gratitude are the message it delivers.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/492.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/492.png", null, 0f, "Shaymin", "Mythical", 225.0 },
                    { 494, null, 210.0, 210.0, "When it shares the infinite energy it creates, that being's entire body will be overflowing with power.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/494.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/494.png", null, 0f, "Victini", "Mythical", 225.0 },
                    { 495, null, 88.0, 107.0, "They photosynthesize by bathing their tails in sunlight. When they are not feeling well, their tails droop.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/495.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/495.png", null, 0f, "Snivy", "common", 128.0 },
                    { 496, null, 122.0, 152.0, "When it gets dirty, its leaves can't be used in photosynthesis, so it always keeps itself clean.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/496.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/496.png", null, 0f, "Servine", "common", 155.0 },
                    { 497, null, 161.0, 204.0, "It can stop its opponents' movements with just a glare. It takes in solar energy and boosts it internally.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/497.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/497.png", null, 0f, "Serperior", "common", 181.0 },
                    { 498, null, 115.0, 85.0, "It loves to eat roasted berries, but sometimes it gets too excited and burns them to a crisp.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/498.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/498.png", null, 0f, "Tepig", "common", 163.0 },
                    { 499, null, 173.0, 106.0, "When its internal fire flares up, its movements grow sharper and faster. When in trouble, it emits smoke.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/499.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/499.png", null, 0f, "Pignite", "common", 207.0 },
                    { 500, null, 235.0, 127.0, "It has mastered fast and powerful fighting moves. It grows a beard of fire.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/500.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/500.png", null, 0f, "Emboar", "common", 242.0 },
                    { 501, null, 117.0, 85.0, "It fights using the scalchop on its stomach. In response to an attack, it retaliates immediately by slashing.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/501.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/501.png", null, 0f, "Oshawott", "common", 146.0 },
                    { 502, null, 159.0, 116.0, "As a result of strict training, each Dewott learns different forms for using the scalchops.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/502.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/502.png", null, 0f, "Dewott", "common", 181.0 },
                    { 503, null, 212.0, 157.0, "One swing of the sword incorporated in its armor can fell an opponent. A simple glare from one of them quiets everybody.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/503.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/503.png", null, 0f, "Samurott", "common", 216.0 },
                    { 504, null, 98.0, 73.0, "Extremely cautious, one of them will always be on the lookout, but it won't notice a foe coming from behind.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/504.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/504.png", null, 0f, "Patrat", "common", 128.0 },
                    { 505, null, 165.0, 139.0, "When they see an enemy, their tails stand high, and they spit the seeds of berries stored in their cheek pouches.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/505.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/505.png", null, 0f, "Watchog", "common", 155.0 },
                    { 506, null, 107.0, 86.0, "This Pokémon is popular with beginners because it's intelligent, obedient to its Trainer's commands, and easy to raise.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/506.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/506.png", null, 0f, "Lillipup", "common", 128.0 },
                    { 507, null, 145.0, 126.0, "It has been living with people for so long that portrayals of it can be found on the walls of caves from long, long ago.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/507.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/507.png", null, 0f, "Herdier", "common", 163.0 },
                    { 508, null, 206.0, 182.0, "Its fur is long and thick. A long time ago in cold regions, every household kept a Stoutland.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/508.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/508.png", null, 0f, "Stoutland", "common", 198.0 },
                    { 509, null, 98.0, 73.0, "They steal from people for fun, but their victims can't help but forgive them. Their deceptively cute act is perfect.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/509.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/509.png", null, 0f, "Purrloin", "common", 121.0 },
                    { 510, null, 187.0, 106.0, "Stealthily, it sneaks up on its target, striking from behind before its victim has a chance to react.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/510.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/510.png", null, 0f, "Liepard", "common", 162.0 },
                    { 511, null, 104.0, 94.0, "It's good at finding berries and gathers them from all over. It's kind enough to share them with friends.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/511.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/511.png", null, 0f, "Pansage", "common", 137.0 },
                    { 512, null, 206.0, 133.0, "Ill tempered, it fights by swinging its barbed tail around wildly. The leaf growing on its head is very bitter.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/512.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/512.png", null, 0f, "Simisage", "common", 181.0 },
                    { 513, null, 104.0, 94.0, "This Pokémon lives in caves in volcanoes. The fire within the tuft on its head can reach 600 degrees Fahrenheit.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/513.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/513.png", null, 0f, "Pansear", "common", 137.0 },
                    { 514, null, 206.0, 133.0, "When it gets excited, embers rise from its head and tail and it gets hot. For some reason, it loves sweets.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/514.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/514.png", null, 0f, "Simisear", "common", 181.0 },
                    { 515, null, 104.0, 94.0, "The water stored inside the tuft on its head is full of nutrients. Plants that receive its water grow large.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/515.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/515.png", null, 0f, "Panpour", "common", 137.0 },
                    { 516, null, 206.0, 133.0, "It prefers places with clean water. When its tuft runs low, it replenishes it by siphoning up water with its tail.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/516.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/516.png", null, 0f, "Simipour", "common", 181.0 },
                    { 517, null, 111.0, 92.0, "It eats the dreams of people and Pokémon. When it eats a pleasant dream, it expels pink-colored mist.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/517.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/517.png", null, 0f, "Munna", "common", 183.0 },
                    { 518, null, 183.0, 166.0, "The dream mist coming from its forehead changes into many different colors depending on the dream that was eaten.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/518.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/518.png", null, 0f, "Musharna", "common", 253.0 },
                    { 519, null, 98.0, 80.0, "These Pokémon live in cities. They are accustomed to people. Flocks often gather in parks and plazas.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/519.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/519.png", null, 0f, "Pidove", "common", 137.0 },
                    { 520, null, 144.0, 107.0, "No matter where in the world it goes, it knows where its nest is, so it never gets separated from its Trainer.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/520.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/520.png", null, 0f, "Tranquill", "common", 158.0 },
                    { 521, null, 226.0, 146.0, "Males have plumage on their heads. They will never let themselves feel close to anyone other than their Trainers.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/521.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/521.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/521.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/521.png", 0f, "Unfezant", "common", 190.0 },
                    { 522, null, 118.0, 64.0, "Its mane shines when it discharges electricity. They use the frequency and rhythm of these flashes to communicate.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/522.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/522.png", null, 0f, "Blitzle", "common", 128.0 },
                    { 523, null, 211.0, 136.0, "They have lightning-like movements. When Zebstrika run at full speed, the sound of thunder reverberates.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/523.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/523.png", null, 0f, "Zebstrika", "common", 181.0 },
                    { 524, null, 121.0, 110.0, "It was found in a fissure in a layer of exposed rock. The material that makes up its body is dirt from several hundred years ago.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/524.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/524.png", null, 0f, "Roggenrola", "common", 146.0 },
                    { 525, null, 174.0, 143.0, "Its orange crystals are lumps of powerful energy. They're valuable, so Boldore is sometimes targeted for them.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/525.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/525.png", null, 0f, "Boldore", "common", 172.0 },
                    { 526, null, 226.0, 201.0, "It absorbs rays of sunlight and shoots out energy. It's usually lurking deep beneath the surface.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/526.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/526.png", null, 0f, "Gigalith", "common", 198.0 },
                    { 527, null, 107.0, 85.0, "The heart-shaped mark left on a body after a Woobat has been attached to it is said to bring good fortune.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/527.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/527.png", null, 0f, "Woobat", "common", 163.0 },
                    { 528, null, 161.0, 119.0, "Anyone who comes into contact with the ultrasonic waves emitted by a courting male experiences a positive mood shift.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/528.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/528.png", null, 0f, "Swoobat", "common", 167.0 },
                    { 529, null, 154.0, 85.0, "By spinning its body, it can dig straight through the ground at a speed of 30 mph.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/529.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/529.png", null, 0f, "Drilbur", "common", 155.0 },
                    { 530, null, 255.0, 129.0, "More than 300 feet below the surface, they build mazelike nests. Their activity can be destructive to subway tunnels.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/530.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/530.png", null, 0f, "Excadrill", "common", 242.0 },
                    { 531, null, 114.0, 163.0, "It touches others with the feelers on its ears, using the sound of their heartbeats to tell how they are feeling.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/531.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/531.png", null, 0f, "Audino", "common", 230.0 },
                    { 532, null, 134.0, 87.0, "Always carrying squared logs, they help out with construction. As they grow, they carry bigger logs.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/532.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/532.png", null, 0f, "Timburr", "common", 181.0 },
                    { 533, null, 180.0, 134.0, "This Pokémon is so muscular and strongly built that even a group of wrestlers could not make it budge an inch.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/533.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/533.png", null, 0f, "Gurdurr", "common", 198.0 },
                    { 534, null, 243.0, 158.0, "Rather than rely on force, they master moves that utilize the centrifugal force of spinning concrete.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/534.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/534.png", null, 0f, "Conkeldurr", "common", 233.0 },
                    { 535, null, 98.0, 78.0, "By vibrating its cheeks, it emits sound waves imperceptible to humans. It uses the rhythm of these sounds to talk.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/535.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/535.png", null, 0f, "Tympole", "common", 137.0 },
                    { 536, null, 128.0, 109.0, "It lives in the water and on land. It uses its long, sticky tongue to immobilize its opponents.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/536.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/536.png", null, 0f, "Palpitoad", "common", 181.0 },
                    { 537, null, 188.0, 150.0, "They shoot paralyzing liquid from their head bumps. They use vibration to hurt their opponents.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/537.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/537.png", null, 0f, "Seismitoad", "common", 233.0 },
                    { 538, null, 172.0, 160.0, "When it encounters a foe bigger than itself, it wants to throw it. It changes belts as it gets stronger.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/538.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/538.png", null, 0f, "Throh", "common", 260.0 },
                    { 539, null, 231.0, 153.0, "Tying their belts gets them pumped and makes their punches more destructive. Disturbing their training angers them.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/539.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/539.png", null, 0f, "Sawk", "common", 181.0 },
                    { 540, null, 96.0, 124.0, "Since this Pokémon makes its own clothes out of leaves, it is a popular mascot for fashion designers.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/540.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/540.png", null, 0f, "Sewaddle", "common", 128.0 },
                    { 541, null, 115.0, 162.0, "It protects itself from the cold by wrapping up in leaves. It stays on the move, eating leaves in forests.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/541.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/541.png", null, 0f, "Swadloon", "common", 146.0 },
                    { 542, null, 205.0, 165.0, "It keeps its eggs warm with heat from fermenting leaves. It also uses leaves to make warm wrappings for Sewaddle.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/542.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/542.png", null, 0f, "Leavanny", "common", 181.0 },
                    { 543, null, 83.0, 99.0, "Its bite injects a potent poison, enough to paralyze large bird Pokémon that try to prey on it.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/543.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/543.png", null, 0f, "Venipede", "common", 102.0 },
                    { 544, null, 100.0, 173.0, "It is usually motionless, but when attacked, it rotates at high speed and then crashes into its opponent.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/544.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/544.png", null, 0f, "Whirlipede", "common", 120.0 },
                    { 545, null, 203.0, 175.0, "With quick movements, it chases down its foes, attacking relentlessly with its horns until it prevails.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/545.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/545.png", null, 0f, "Scolipede", "common", 155.0 },
                    { 546, null, 71.0, 111.0, "When attacked, it expels cotton from its body to create a diversion. The cotton it loses grows back in quickly.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/546.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/546.png", null, 0f, "Cottonee", "common", 120.0 },
                    { 547, null, 164.0, 176.0, "Whimsicott doesn't live in a fixed location. It floats around on whirling winds, appearing all over the place to perform its mischief.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/547.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/547.png", null, 0f, "Whimsicott", "common", 155.0 },
                    { 548, null, 119.0, 91.0, "They prefer clean water and soil. When the environment they live in turns bad, the whole bunch will up and move to a new area.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/548.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/548.png", null, 0f, "Petilil", "common", 128.0 },
                    { 549, null, 214.0, 155.0, "It's well liked by other Pokémon because of its beauty. The flower on its head needs constant care, or it will soon wither and rot.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/549.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/549.png", null, 0f, "Lilligant", "common", 172.0 },
                    { 550, null, 189.0, 129.0, "When a school of Basculin appears in a lake, everything else disappears, except for Corphish and Crawdaunt. That's how violent Basculin are.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/550.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/550.png", null, 0f, "Basculin", "common", 172.0 },
                    { 551, null, 132.0, 69.0, "Sandile's still not good at hunting, so it mostly eats things that have collapsed in the desert. It's called “the cleaner of the desert.\"", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/551.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/551.png", null, 0f, "Sandile", "common", 137.0 },
                    { 552, null, 155.0, 90.0, "It buries some of its prey in the sand to use as emergency meals when its hunts are unsuccessful.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/552.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/552.png", null, 0f, "Krokorok", "common", 155.0 },
                    { 553, null, 229.0, 158.0, "It conceals itself in sandstorms that Flygon whip up and waits patiently for prey to appear.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/553.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/553.png", null, 0f, "Krookodile", "common", 216.0 },
                    { 554, null, 153.0, 86.0, "When it sleeps, it pulls its limbs into its body and its internal fire goes down to 1,100 degrees Fahrenheit.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/554.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/554.png", null, 0f, "Darumaka", "common", 172.0 },
                    { 555, null, 263.0, 114.0, "Its internal fire burns at 2,500 degrees Fahrenheit, making enough power that it can destroy a dump truck with one punch.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/555.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/555.png", null, 0f, "Darmanitan", "common", 233.0 },
                    { 556, null, 201.0, 130.0, "Arid regions are their habitat. They move rhythmically, making a sound similar to maracas.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/556.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/556.png", null, 0f, "Maractus", "common", 181.0 },
                    { 557, null, 118.0, 128.0, "When it finds a stone of a suitable size, it secretes a liquid from its mouth to open up a hole to crawl into.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/557.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/557.png", null, 0f, "Dwebble", "common", 137.0 },
                    { 558, null, 188.0, 200.0, "Competing for territory, Crustle fight viciously. The one whose boulder is broken is the loser of the battle.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/558.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/558.png", null, 0f, "Crustle", "common", 172.0 },
                    { 559, null, 132.0, 132.0, "It stretches its saggy skin up to its neck to protect itself. The saggier their skin, the more respect they garner.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/559.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/559.png", null, 0f, "Scraggy", "common", 137.0 },
                    { 560, null, 163.0, 222.0, "It taunts its opponents by spitting. It has a certain territory that it never leaves its whole life long.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/560.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/560.png", null, 0f, "Scrafty", "common", 163.0 },
                    { 561, null, 204.0, 167.0, "The guardians of an ancient city, they always fly the same route while keeping watch for invaders.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/561.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/561.png", null, 0f, "Sigilyph", "common", 176.0 },
                    { 562, null, 95.0, 141.0, "Each of them carries a mask that used to be its face when it was human. Sometimes they look at it and cry.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/562.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/562.png", null, 0f, "Yamask", "common", 116.0 },
                    { 563, null, 163.0, 237.0, "Grave robbers who mistake them for real coffins and get too close end up trapped inside their bodies.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/563.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/563.png", null, 0f, "Cofagrigus", "common", 151.0 },
                    { 564, null, 134.0, 146.0, "Its hunting grounds encompassed a broad area, from the land to more than half a mile deep in the ocean.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/564.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/564.png", null, 0f, "Tirtouga", "common", 144.0 },
                    { 565, null, 192.0, 197.0, "Carracosta eats every last bit of the prey it catches, even the shells and bones, to further strengthen its sturdy shell.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/565.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/565.png", null, 0f, "Carracosta", "common", 179.0 },
                    { 566, null, 213.0, 89.0, "Restored from a fossil, this ancient bird Pokémon has wings but can't yet fly.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/566.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/566.png", null, 0f, "Archen", "common", 146.0 },
                    { 567, null, 292.0, 139.0, "Said to be an ancestor of bird Pokémon, the muscles it uses to flap its wings are still weak, so it needs a long runway in order to take off.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/567.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/567.png", null, 0f, "Archeops", "common", 181.0 },
                    { 568, null, 96.0, 122.0, "If a young Pokémon or child breathes in the toxic gas that Trubbish belches out, it could be a life-threatening situation.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/568.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/568.png", null, 0f, "Trubbish", "common", 137.0 },
                    { 569, null, 181.0, 164.0, "Some say the reason Garbodor in Alola are a little stronger than their counterparts elsewhere is the presence of Muk, their natural enemy.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/569.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/569.png", null, 0f, "Garbodor", "common", 190.0 },
                    { 570, null, 153.0, 78.0, "If a normally talkative child suddenly stops talking, it may have been replaced by Zorua.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/570.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/570.png", null, 0f, "Zorua", "common", 120.0 },
                    { 571, null, 250.0, 127.0, "If it thinks humans are going to discover its den, Zoroark shows them visions that make them wander around in the woods.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/571.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/571.png", null, 0f, "Zoroark", "common", 155.0 },
                    { 572, null, 98.0, 80.0, "When its tail has gotten dirty from self-cleaning or from cleaning its nest, Minccino spends a whole day washing its tail in clean spring water.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/572.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/572.png", null, 0f, "Minccino", "common", 146.0 },
                    { 573, null, 198.0, 130.0, "The oil that seeps from its body is really smooth. For people troubled by bad skin, this oil is an effective treatment.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/573.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/573.png", null, 0f, "Cinccino", "common", 181.0 },
                    { 574, null, 98.0, 112.0, "They intently observe both Trainers and Pokémon. Apparently, they are looking at something that only Gothita can see.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/574.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/574.png", null, 0f, "Gothita", "common", 128.0 },
                    { 575, null, 137.0, 153.0, "According to many old tales, it creates friends for itself by controlling sleeping children on starry nights.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/575.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/575.png", null, 0f, "Gothorita", "common", 155.0 },
                    { 576, null, 176.0, 205.0, "They can predict the future from the placement and movement of the stars. They can see Trainers' life spans.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/576.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/576.png", null, 0f, "Gothitelle", "common", 172.0 },
                    { 577, null, 170.0, 83.0, "They drive away attackers by unleashing psychic power. They can use telepathy to talk with others.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/577.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/577.png", null, 0f, "Solosis", "common", 128.0 },
                    { 578, null, 208.0, 103.0, "When their two divided brains think the same thoughts, their psychic power is maximized.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/578.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/578.png", null, 0f, "Duosion", "common", 163.0 },
                    { 579, null, 214.0, 148.0, "When Reuniclus shake hands, a network forms between their brains, increasing their psychic power.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/579.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/579.png", null, 0f, "Reuniclus", "common", 242.0 },
                    { 580, null, 84.0, 96.0, "They are better at swimming than flying, and they happily eat their favorite food, peat moss, as they dive underwater.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/580.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/580.png", null, 0f, "Ducklett", "common", 158.0 },
                    { 581, null, 182.0, 132.0, "Swanna start to dance at dusk. The one dancing in the middle is the leader of the flock.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/581.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/581.png", null, 0f, "Swanna", "common", 181.0 },
                    { 582, null, 118.0, 106.0, "When the morning sun hit an icicle, it wished not to melt, and thus Vanillite was born. At night, it buries itself in snow to sleep.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/582.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/582.png", null, 0f, "Vanillite", "common", 113.0 },
                    { 583, null, 151.0, 138.0, "This hearty Pokémon survived the Ice Age. It's incredibly popular in very hot regions.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/583.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/583.png", null, 0f, "Vanillish", "common", 139.0 },
                    { 584, null, 218.0, 184.0, "Vanilluxe is born when two Vanillish, half-melted by the day's light, stick to each other and freeze together in the cold return of night.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/584.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/584.png", null, 0f, "Vanilluxe", "common", 174.0 },
                    { 585, null, 115.0, 100.0, "The turning of the seasons changes the color and scent of this Pokémon's fur. People use it to mark the seasons.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/585.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/585.png", null, 0f, "Deerling", "common", 155.0 },
                    { 586, null, 198.0, 146.0, "They migrate according to the seasons, so some people call Sawsbuck the harbingers of spring.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/586.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/586.png", null, 0f, "Sawsbuck", "common", 190.0 },
                    { 587, null, 158.0, 127.0, "As it flies, it scatters electricity around, so bird Pokémon keep their distance. That's why Emolga can keep all its food to itself.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/587.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/587.png", null, 0f, "Emolga", "common", 146.0 },
                    { 588, null, 137.0, 87.0, "For some reason they evolve when they receive electrical energy while they are attacking Shelmet.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/588.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/588.png", null, 0f, "Karrablast", "common", 137.0 },
                    { 589, null, 223.0, 187.0, "These Pokémon evolve by wearing the shell covering of a Shelmet. The steel armor protects their whole body.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/589.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/589.png", null, 0f, "Escavalier", "common", 172.0 },
                    { 590, null, 97.0, 91.0, "It lures Pokémon with its pattern that looks just like a Poké Ball, then releases poison spores.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/590.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/590.png", null, 0f, "Foongus", "common", 170.0 },
                    { 591, null, 155.0, 139.0, "It lures prey close by dancing and waving its arm caps, which resemble Poké Balls, in a swaying motion.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/591.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/591.png", null, 0f, "Amoonguss", "common", 249.0 },
                    { 592, null, 115.0, 134.0, "Using the invisible poison spikes on its veillike arms and legs, it paralyzes its enemies and causes them to drown.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/592.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/592.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/592.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/592.png", 0f, "Frillish", "common", 146.0 },
                    { 593, null, 159.0, 178.0, "Fishermen are terrified of Jellicent. It's rumored to drag them into the sea and steal their lives away.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/593.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/593.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/593.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/593.png", 0f, "Jellicent", "common", 225.0 },
                    { 594, null, 138.0, 131.0, "The reason it helps Pokémon in a weakened condition is that any Pokémon coming after them may also attack Alomomola.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/594.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/594.png", null, 0f, "Alomomola", "common", 338.0 },
                    { 595, null, 110.0, 98.0, "They attach themselves to large-bodied Pokémon and absorb static electricity, which they store in an electric pouch.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/595.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/595.png", null, 0f, "Joltik", "common", 137.0 },
                    { 596, null, 201.0, 128.0, "When attacked, they create an electric barrier by spitting out many electrically charged threads.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/596.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/596.png", null, 0f, "Galvantula", "common", 172.0 },
                    { 597, null, 82.0, 155.0, "It absorbs the iron it finds in the rock while clinging to the ceiling. It shoots spikes when in danger.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/597.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/597.png", null, 0f, "Ferroseed", "common", 127.0 },
                    { 598, null, 158.0, 223.0, "They attach themselves to cave ceilings, firing steel spikes at targets passing beneath them.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/598.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/598.png", null, 0f, "Ferrothorn", "common", 179.0 },
                    { 599, null, 98.0, 121.0, "The two minigears that mesh together are predetermined. Each will rebound from other minigears without meshing.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/599.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/599.png", null, 0f, "Klink", "common", 120.0 },
                    { 600, null, 150.0, 174.0, "A minigear and big gear comprise its body. If the minigear it launches at a foe doesn't return, it will die.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/600.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/600.png", null, 0f, "Klang", "common", 155.0 },
                    { 601, null, 199.0, 214.0, "Its red core functions as an energy tank. It fires the charged energy through its spikes into an area.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/601.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/601.png", null, 0f, "Klinklang", "common", 155.0 },
                    { 602, null, 105.0, 78.0, "One alone can emit only a trickle of electricity, so a group of them gathers to unleash a powerful electric shock.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/602.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/602.png", null, 0f, "Tynamo", "common", 111.0 },
                    { 603, null, 156.0, 130.0, "These Pokémon have a big appetite. When they spot their prey, they attack it and paralyze it with electricity.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/603.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/603.png", null, 0f, "Eelektrik", "common", 163.0 },
                    { 604, null, 217.0, 152.0, "They crawl out of the ocean using their arms. They will attack prey on shore and immediately drag it into the ocean.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/604.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/604.png", null, 0f, "Eelektross", "common", 198.0 },
                    { 605, null, 148.0, 100.0, "This Pokémon is shrouded in mystery. It's said to have appeared from a UFO that fell from the sky about 50 years ago.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/605.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/605.png", null, 0f, "Elgyem", "common", 146.0 },
                    { 606, null, 221.0, 163.0, "It has strong psychic powers. Using its fingers that flash three different colors, it controls its opponents and rewrites their memories.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/606.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/606.png", null, 0f, "Beheeyem", "common", 181.0 },
                    { 607, null, 108.0, 98.0, "Litwick shines a light that absorbs the life energy of people and Pokémon, which becomes the fuel that it burns.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/607.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/607.png", null, 0f, "Litwick", "common", 137.0 },
                    { 608, null, 169.0, 115.0, "It arrives near the moment of death and steals spirit from the body.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/608.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/608.png", null, 0f, "Lampent", "common", 155.0 },
                    { 609, null, 271.0, 182.0, "The spirits burned up in its ominous flame lose their way and wander this world forever.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/609.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/609.png", null, 0f, "Chandelure", "common", 155.0 },
                    { 610, null, 154.0, 101.0, "They mark their territory by leaving gashes in trees with their tusks. If a tusk breaks, a new one grows in quickly.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/610.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/610.png", null, 0f, "Axew", "common", 130.0 },
                    { 611, null, 212.0, 123.0, "A broken tusk will not grow back, so it diligently sharpens its tusks on river rocks after the end of a battle.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/611.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/611.png", null, 0f, "Fraxure", "common", 165.0 },
                    { 612, null, 284.0, 172.0, "Their sturdy tusks will stay sharp even if used to cut steel beams. These Pokémon are covered in hard armor.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/612.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/612.png", null, 0f, "Haxorus", "common", 183.0 },
                    { 613, null, 128.0, 74.0, "Their snot is a barometer of health. When healthy, their snot is sticky and the power of their ice moves increases.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/613.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/613.png", null, 0f, "Cubchoo", "common", 146.0 },
                    { 614, null, 233.0, 152.0, "It freezes its breath to create fangs and claws of ice to fight with. Cold northern areas are its habitat.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/614.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/614.png", null, 0f, "Beartic", "common", 216.0 },
                    { 615, null, 190.0, 218.0, "They are composed of ice crystals. They capture prey with chains of ice, freezing the prey at -148 degrees Fahrenheit.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/615.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/615.png", null, 0f, "Cryogonal", "common", 190.0 },
                    { 616, null, 72.0, 140.0, "It evolves when bathed in an electric-like energy along with Karrablast. The reason is still unknown.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/616.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/616.png", null, 0f, "Shelmet", "common", 137.0 },
                    { 617, null, 220.0, 120.0, "When its body dries out, it weakens. So, to prevent dehydration, it wraps itself in many layers of thin membrane.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/617.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/617.png", null, 0f, "Accelgor", "common", 190.0 },
                    { 618, null, 144.0, 171.0, "It conceals itself in the mud of the seashore. Then it waits. When prey touch it, it delivers a jolt of electricity.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/618.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/618.png", null, 0f, "Stunfisk", "common", 240.0 },
                    { 619, null, 160.0, 98.0, "They seclude themselves in the mountains and devote themselves to training. The form of their kicks and chops differs from pack to pack.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/619.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/619.png", null, 0f, "Mienfoo", "common", 128.0 },
                    { 620, null, 258.0, 127.0, "When Mienshao lets out a bizarre wail, you're in danger. A flurry of kicks and chops too fast to see is about to be unleashed!", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/620.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/620.png", null, 0f, "Mienshao", "common", 163.0 },
                    { 621, null, 213.0, 170.0, "It infiltrates tunnels that Pokémon like Diglett and Dugtrio have dug and quietly waits for prey to pass through.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/621.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/621.png", null, 0f, "Druddigon", "common", 184.0 },
                    { 622, null, 127.0, 92.0, "Although ancient people apparently built it by working with clay, the source of its energy is unclear.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/622.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/622.png", null, 0f, "Golett", "common", 153.0 },
                    { 623, null, 222.0, 154.0, "When the seal on its chest is removed, it rages indiscriminately, turning the whole town around it into a mountain of rubble.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/623.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/623.png", null, 0f, "Golurk", "common", 205.0 },
                    { 624, null, 154.0, 114.0, "It follows Bisharp's orders to a tee when it attacks enemies. After slashing an opponent, Pawniard clangs both of its blades together.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/624.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/624.png", null, 0f, "Pawniard", "common", 128.0 },
                    { 625, null, 232.0, 176.0, "It leads a group of Pawniard. Bisharp doesn't even change its expression when it deals the finishing blow to an opponent.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/625.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/625.png", null, 0f, "Bisharp", "common", 163.0 },
                    { 626, null, 195.0, 182.0, "Their fluffy fur absorbs damage, even if they strike foes with a fierce headbutt.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/626.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/626.png", null, 0f, "Bouffalant", "common", 216.0 },
                    { 627, null, 150.0, 97.0, "Known as a natural-born warrior, soon after its hatching, it will challenge its parent to a fight in order to gain their acceptance.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/627.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/627.png", null, 0f, "Rufflet", "common", 172.0 },
                    { 628, null, 232.0, 152.0, "Known as “the hero of the skies,\" this Pokémon is so proud and so brave that it will never retreat, even when it's injured.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/628.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/628.png", null, 0f, "Braviary", "common", 225.0 },
                    { 629, null, 105.0, 139.0, "Its healthy appetite leads to visible growth spurts. It often has to replace the bones it wears as its size increases.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/629.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/629.png", null, 0f, "Vullaby", "common", 172.0 },
                    { 630, null, 129.0, 205.0, "It's always searching for food for Vullaby. When it finds a weak Pokémon, Mandibuzz swoops it right off to its nest.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/630.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/630.png", null, 0f, "Mandibuzz", "common", 242.0 },
                    { 631, null, 204.0, 129.0, "It draws in air through its tail, transforms it into fire, and uses it like a tongue. It melts Durant and eats them.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/631.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/631.png", null, 0f, "Heatmor", "common", 198.0 },
                    { 632, null, 217.0, 188.0, "They attack in groups, covering themselves in steel armor to protect themselves from Heatmor.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/632.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/632.png", null, 0f, "Durant", "common", 151.0 },
                    { 633, null, 116.0, 93.0, "Lacking sight, it's unaware of its surroundings, so it bumps into things and eats anything that moves.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/633.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/633.png", null, 0f, "Deino", "common", 141.0 },
                    { 634, null, 159.0, 135.0, "After it has eaten up all the food in its territory, it moves to another area. Its two heads do not get along.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/634.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/634.png", null, 0f, "Zweilous", "common", 176.0 },
                    { 635, null, 256.0, 188.0, "It responds to movement by attacking. This scary, three-headed Pokémon devours everything in its path!", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/635.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/635.png", null, 0f, "Hydreigon", "common", 211.0 },
                    { 636, null, 156.0, 107.0, "It protects itself with flame. Long years ago, people believed Larvesta had a nest on the sun.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/636.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/636.png", null, 0f, "Larvesta", "common", 146.0 },
                    { 637, null, 264.0, 189.0, "According to legends, it was hatched from a flaming cocoon to save people and Pokémon that were suffering from the cold.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/637.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/637.png", null, 0f, "Volcarona", "common", 198.0 },
                    { 638, null, 192.0, 229.0, "It has a body and heart of steel. It worked with its allies to punish people when they hurt Pokémon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/638.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/638.png", null, 0f, "Cobalion", "Legendary", 209.0 },
                    { 639, null, 260.0, 192.0, "Spoken of in legend, this Pokémon used its phenomenal power to destroy a castle in its effort to protect Pokémon.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/639.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/639.png", null, 0f, "Terrakion", "Legendary", 209.0 },
                    { 640, null, 192.0, 229.0, "Legends say this Pokémon confounded opponents with its swift movements.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/640.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/640.png", null, 0f, "Virizion", "Legendary", 209.0 },
                    { 641, null, 266.0, 164.0, "Tornadus expels massive energy from its tail, causing severe storms. Its power is great enough to blow houses away.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/641.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/641.png", null, 0f, "Tornadus", "Legendary", 188.0 },
                    { 642, null, 266.0, 164.0, "As it flies around, it shoots lightning all over the place and causes forest fires. It is therefore disliked.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/642.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/642.png", null, 0f, "Thundurus", "Legendary", 188.0 },
                    { 643, null, 275.0, 211.0, "When Reshiram's tail flares, the heat energy moves the atmosphere and changes the world's weather.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/643.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/643.png", null, 0f, "Reshiram", "Legendary", 205.0 },
                    { 644, null, 275.0, 211.0, "Concealing itself in lightning clouds, it flies throughout the Unova region. It creates electricity in its tail.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/644.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/644.png", null, 0f, "Zekrom", "Legendary", 205.0 },
                    { 645, null, 261.0, 182.0, "From the forces of lightning and wind, it creates energy to give nutrients to the soil and make the land abundant.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/645.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/645.png", null, 0f, "Landorus", "Legendary", 205.0 },
                    { 646, null, 246.0, 170.0, "It generates a powerful, freezing energy inside itself, but its body became frozen when the energy leaked out.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/646.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/646.png", null, 0f, "Kyurem", "Legendary", 245.0 },
                    { 647, null, 260.0, 192.0, "When it is resolute, its body fills with power and it becomes swifter. Its jumps are then too fast to follow.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/647.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/647.png", null, 0f, "Keldeo", "Mythical", 209.0 },
                    { 648, null, 250.0, 225.0, "Its melodies are sung with a special vocalization method that can control the feelings of those who hear it.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/648.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/648.png", null, 0f, "Meloetta", "Mythical", 225.0 },
                    { 650, null, 110.0, 106.0, "The quills on its head are usually soft. When it flexes them, the points become so hard and sharp that they can pierce rock.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/650.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/650.png", null, 0f, "Chespin", "common", 148.0 },
                    { 651, null, 146.0, 156.0, "It relies on its sturdy shell to deflect predators' attacks. It counterattacks with its sharp quills.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/651.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/651.png", null, 0f, "Quilladin", "common", 156.0 },
                    { 653, null, 116.0, 102.0, "Eating a twig fills it with energy, and its roomy ears give vent to air hotter than 390 degrees Fahrenheit.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/653.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/653.png", null, 0f, "Fennekin", "common", 120.0 },
                    { 656, null, 122.0, 84.0, "It secretes flexible bubbles from its chest and back. The bubbles reduce the damage it would otherwise take when attacked.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/656.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/656.png", null, 0f, "Froakie", "common", 121.0 },
                    { 658, null, 223.0, 152.0, "It creates throwing stars out of compressed water. When it spins them and throws them at high speed, these stars can split metal in two.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/658.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/658.png", null, 0f, "Greninja", "common", 176.0 },
                    { 659, null, 68.0, 72.0, "They use their large ears to dig burrows. They will dig the whole night through.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/659.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/659.png", null, 0f, "Bunnelby", "common", 116.0 },
                    { 663, null, 176.0, 155.0, "In the fever of an exciting battle, it showers embers from the gaps between its feathers and takes to the air.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/663.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/663.png", null, 0f, "Talonflame", "common", 186.0 },
                    { 665, null, 48.0, 89.0, "It lives hidden within thicket shadows. When predators attack, it quickly bristles the fur covering its body in an effort to threaten them.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/665.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/665.png", null, 0f, "Spewpa", "common", 128.0 },
                    { 667, null, 139.0, 112.0, "The stronger the opponent it faces, the more heat surges from its mane and the more power flows through its body.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/667.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/667.png", null, 0f, "Litleo", "common", 158.0 },
                    { 672, null, 123.0, 102.0, "Thought to be one of the first Pokémon to live in harmony with humans, it has a placid disposition.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/672.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/672.png", null, 0f, "Skiddo", "common", 165.0 },
                    { 674, null, 145.0, 107.0, "It does its best to be taken seriously by its enemies, but its glare is not sufficiently intimidating. Chewing on a leaf is its trademark.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/674.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/674.png", null, 0f, "Pancham", "common", 167.0 },
                    { 677, null, 120.0, 114.0, "The organ that emits its intense psychic power is sheltered by its ears to keep power from leaking out.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/677.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/677.png", null, 0f, "Espurr", "common", 158.0 },
                    { 682, null, 110.0, 113.0, "It emits a scent that enraptures those who smell it. This fragrance changes depending on what it has eaten.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/682.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/682.png", null, 0f, "Spritzee", "common", 186.0 },
                    { 683, null, 173.0, 150.0, "It devises various scents, pleasant and unpleasant, and emits scents that its enemies dislike in order to gain an edge in battle.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/683.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/683.png", null, 0f, "Aromatisse", "common", 226.0 },
                    { 684, null, 109.0, 119.0, "To entangle its opponents in battle, it extrudes white threads as sweet and sticky as cotton candy.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/684.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/684.png", null, 0f, "Swirlix", "common", 158.0 },
                    { 685, null, 168.0, 163.0, "It can distinguish the faintest of scents. It puts its sensitive sense of smell to use by helping pastry chefs in their work.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/685.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/685.png", null, 0f, "Slurpuff", "common", 193.0 },
                    { 688, null, 96.0, 120.0, "Two Binacle live together on one rock. When they fight, one of them will move to a different rock.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/688.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/688.png", null, 0f, "Binacle", "common", 123.0 },
                    { 690, null, 109.0, 109.0, "Camouflaged as rotten kelp, they spray liquid poison on prey that approaches unawares and then finish it off.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/690.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/690.png", null, 0f, "Skrelp", "common", 137.0 },
                    { 692, null, 108.0, 117.0, "They knock down flying prey by firing compressed water from their massive claws like shooting a pistol.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/692.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/692.png", null, 0f, "Clauncher", "common", 137.0 },
                    { 694, null, 115.0, 78.0, "They make their home in deserts. They can generate their energy from basking in the sun, so eating food is not a requirement.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/694.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/694.png", null, 0f, "Helioptile", "common", 127.0 },
                    { 697, null, 227.0, 191.0, "Thanks to its gargantuan jaws, which could shred thick metal plates as if they were paper, it was invincible in the ancient world it once inhabited.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/697.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/697.png", null, 0f, "Tyrantrum", "common", 193.0 },
                    { 701, null, 195.0, 153.0, "Although its body is small, its proficient fighting skills enable it to keep up with big bruisers like Machamp and Hariyama.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/701.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/701.png", null, 0f, "Hawlucha", "common", 186.0 },
                    { 702, null, 164.0, 134.0, "Its whiskers serve as antennas. By sending and receiving electrical waves, it can communicate with others over vast distances.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/702.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/702.png", null, 0f, "Dedenne", "common", 167.0 },
                    { 703, null, 95.0, 285.0, "Born from the temperatures and pressures deep underground, it fires beams from the stone in its head.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/703.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/703.png", null, 0f, "Carbink", "common", 137.0 },
                    { 704, null, 101.0, 112.0, "The weakest Dragon-type Pokémon, it lives in damp, shady places, so its body doesn't dry out.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/704.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/704.png", null, 0f, "Goomy", "common", 128.0 },
                    { 707, null, 160.0, 179.0, "These key collectors threaten any attackers by fiercely jingling their keys at them.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/707.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/707.png", null, 0f, "Klefki", "common", 149.0 },
                    { 708, null, 125.0, 103.0, "These Pokémon are created when spirits possess rotten tree stumps. They prefer to live in abandoned forests.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/708.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/708.png", null, 0f, "Phantump", "common", 125.0 },
                    { 710, null, 122.0, 124.0, "The pumpkin body is inhabited by a spirit trapped in this world. As the sun sets, it becomes restless and active.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/710.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/710.png", null, 0f, "Pumpkaboo", "common", 127.0 },
                    { 712, null, 117.0, 120.0, "It blocks opponents' attacks with the ice that shields its body. It uses cold air to repair any cracks with new ice.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/712.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/712.png", null, 0f, "Bergmite", "common", 146.0 },
                    { 720, null, 261.0, 187.0, "In its true form, it possess a huge amount of power. Legends of its avarice tell how it once carried off an entire castle to gain the treasure hidden within.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/720.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/720.png", null, 0f, "Hoopa", "Mythical", 173.0 },
                    { 802, null, 265.0, 190.0, "It sinks into the shadows of people and Pokémon, where it can understand their feelings and copy their capabilities.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/802.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/802.png", null, 0f, "Marshadow", "Mythical", 207.0 },
                    { 803, null, 1.0, 1.0, "An Ultra Beast that lives in a different world, it cackles wildly as it sprays its opponents with poison from the needles on its head.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/803.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/803.png", null, 0f, "Poipole", "common", 1.0 },
                    { 804, null, 1.0, 1.0, "One kind of Ultra Beast, it fires a glowing, venomous liquid from its needles. This liquid is also immensely adhesive.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/804.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/804.png", null, 0f, "Naganadel", "common", 1.0 },
                    { 805, null, 1.0, 1.0, "When stone walls started moving and attacking, the brute's true identity was this mysterious life-form, which brings to mind an Ultra Beast.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/805.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/805.png", null, 0f, "Stakataka", "common", 1.0 },
                    { 806, null, 1.0, 1.0, "A UB that appeared from an Ultra Wormhole, it causes explosions, then takes advantage of opponents' surprise to rob them of their vitality.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/806.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/806.png", null, 0f, "Blacephalon", "common", 1.0 },
                    { 807, null, 1.0, 1.0, "It approaches its enemies at the speed of lightning, then tears them limb from limb with its sharp claws.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/807.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/807.png", null, 0f, "Zeraora", "Mythical", 1.0 },
                    { 808, null, 118.0, 99.0, "It melts particles of iron and other metals found in the subsoil, so it can absorb them into its body of molten steel.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/808.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/808.png", null, 0f, "Meltan", "Mythical", 130.0 },
                    { 809, null, 226.0, 190.0, "Revered long ago for its capacity to create iron from nothing, for some reason it has come back to life after 3,000 years.", 0f, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/809.png", null, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/809.png", null, 0f, "Melmetal", "Mythical", 264.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 51);

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
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 262);

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
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 561);

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
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "num_pokedex",
                keyValue: 672);

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

            migrationBuilder.DropColumn(
                name: "img_back_female",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "img_front_female",
                table: "Pokemon");
        }
    }
}
