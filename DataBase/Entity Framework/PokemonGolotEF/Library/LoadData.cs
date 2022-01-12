using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PokemonGolotEF.Model;
using PokemonGolotEF.Library.Requests;
using Newtonsoft.Json.Linq;
using PokemonGolotEF.Library.Readers;

namespace PokemonGolotEF.Library
{
    internal class LoadData
    {
        public PokemonGolot pokemonGolot = new PokemonGolot();

        public LoadData()
        {
            LoadPokemon().Wait();
            LoadLevel().Wait();
            LoadPokemonLevels().Wait();
            LoadElement().Wait();
            LoadPokestops();
            LoadMovement().Wait();
            LoadGyms();
        }

        public async Task LoadPokemon() 
        {
            Pokemon actual;
            bool isIn = false;
            //string 
            
            
            for(var gen = 1; gen <= 7; gen++) 
            {
                string pokemonJsonString = await getPokemon.getPokemons(gen.ToString());
                JToken pokemonString = JToken.Parse(pokemonJsonString);
                foreach (JToken pokemon in pokemonString) 
                {
                    actual = new Pokemon(pokemon);

                    foreach (Pokemon poke in pokemonGolot.pokemons) 
                    {
                        if (poke.num_pokedex == actual.num_pokedex) 
                        {
                            isIn = true;
                            break;
                        }
                    }
                    if (!isIn)
                    {
                        LoadPokemonImages(actual).Wait();
                        LoadPokemonDetails(actual).Wait();
                        if(actual.description != null && actual.img_back != null && actual.img_front != null)
                            pokemonGolot.pokemons.Add(actual);
                    }
                    isIn = false;
                }
            }
        }

        public async Task LoadPokemonDetails(Pokemon pokemon) 
        {
            string pokemonDetailsJson = await getPokemon.getPokemonDetails(pokemon.num_pokedex.ToString());
            
            if (pokemonDetailsJson != null)
            {
                try
                {
                    JToken pokemonDetails = JToken.Parse(pokemonDetailsJson);
                    List<int> genders = new List<int>();

                    pokemon.setDetails(pokemonDetails, genders);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }

        public List<int> getGender() {

            return null;
        }
        
        public async Task LoadPokemonImages(Pokemon pokemon)
        {
            Console.WriteLine(pokemon.name + " " + pokemon.num_pokedex.ToString());
            string pokemonJsonString;
            pokemonJsonString = await getPokemon.getPokemonImages(pokemon.num_pokedex);
           
            JObject pokemonJson = JObject.Parse(pokemonJsonString);
            JToken pokemonImages = pokemonJson["sprites"];
            pokemon.addImages(pokemonImages);
        }

        public async Task LoadLevel()
        {
            Level actual;
            string levelJsonString = await getLevel.getLevels();
            JObject levelJson = JObject.Parse(levelJsonString);
            foreach (KeyValuePair<String, JToken> level in levelJson)
            {
                actual = new Level(level);
                pokemonGolot.userLevels.Add(actual);              
            }
        }

        public async Task LoadPokemonLevels()
        {
            PokemonLevel actual;
            string cpMultiplierJson = await getPokemonLevel.getCpMultiplier();
            string requirementsToPowerUpJson = await getPokemonLevel.getRequirementsToPowerUp();
            JToken cpMultiplier = JToken.Parse(cpMultiplierJson);
            JObject requirementsToPowerUp = JObject.Parse(requirementsToPowerUpJson);
            foreach (JToken pokemonLevel in cpMultiplier)
            {
                if ((double)pokemonLevel["level"] <= 40.0f)
                {
                    actual = new PokemonLevel(pokemonLevel);
                    foreach (KeyValuePair<String, JToken> requirment in requirementsToPowerUp)
                    {
                        if (requirment.Key.Replace('.', ',').Equals(actual.pokemon_level.ToString()))
                        {
                            actual.addData(requirment);
                            pokemonGolot.pokemonsLevels.Add(actual);
                        }
                    }
                }
            }
        }

        public async Task LoadElement() 
        {
            Element actual;
            string elementsJson = await getElement.getElements();
            JObject rawElements = JObject.Parse(elementsJson);
            JToken elements = rawElements["results"];
            foreach (JToken element in elements)
            {
                actual = new Element(element);
                pokemonGolot.elements.Add(actual);              
            }
        }

        public void LoadPokestops() 
        {            
            string gymsAndPokestopsJson = readPokestopsJson.readPokestopsData();
            JObject gymsAndPokestopsList = JObject.Parse(gymsAndPokestopsJson);
            JObject pokestopsList = (JObject)gymsAndPokestopsList["pokestops"];
            addPokestopsForJsonList(pokestopsList);            
        }

        public void addPokestopsForJsonList(JObject pokestopsList)
        {
            PokeStop actual;
            foreach (KeyValuePair<String, JToken> pokestop in pokestopsList)
            {
                actual = new PokeStop(pokestop);
                pokemonGolot.pokestops.Add(actual);
            }
        }

        public void LoadGyms() 
        {            
            string gymsAndPokestopsJson = readPokestopsJson.readPokestopsData();
            JObject gymsAndPokestopsList = JObject.Parse(gymsAndPokestopsJson);
            JObject gymsList = (JObject)gymsAndPokestopsList["gyms"];
            addPokestopsForJsonList(gymsList);
            Gym actual;
            foreach (KeyValuePair<String, JToken> gym in gymsList)
            {
                actual = new Gym(gym);
                pokemonGolot.gyms.Add(actual);
            }
        }

        public async Task LoadMovement()
        {
            Movement actual;
            String fastMovementsJson = await getMovement.getFastMovements();
            String chargedMovementsJson = await getMovement.getChargedMovements();
            JToken rawFastMovements = JToken.Parse(fastMovementsJson);
            JToken rawChargedMovements = JToken.Parse(chargedMovementsJson);
            bool isIn = false;
            foreach (JToken fastMovement in rawFastMovements)
            {
                actual = new Movement(fastMovement, pokemonGolot.elements);

                foreach (Movement move in pokemonGolot.moves)
                {
                    if (move.name == actual.name && move.isCharged == actual.isCharged)
                    {
                        isIn = true;
                        break;
                    }
                }
                if (!isIn)
                {
                    pokemonGolot.moves.Add(actual);
                }
                isIn = false;
                

            }

            foreach (JToken chargedMovement in rawChargedMovements)
            {

                actual = new Movement(chargedMovement, pokemonGolot.elements);
                foreach (Movement move in pokemonGolot.moves)
                {
                    if (move.name == actual.name && move.isCharged == actual.isCharged)
                    {
                        isIn = true;
                        break;
                    }
                }
                if (!isIn)
                {
                    pokemonGolot.moves.Add(actual);
                }
                isIn = false;

            }
        }
    }
}
