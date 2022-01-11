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
            LoadGyms();
        }

        public async Task LoadPokemon() 
        {
            Pokemon actual;
            bool isIn = false;
            
            for(var gen = 1; gen <= 7; gen++) 
            {
                String pokemonJsonString = await getPokemon.getPokemons(gen.ToString());
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
                    if(!isIn)
                        pokemonGolot.pokemons.Add(actual);
                    isIn = false;
                }
            }
        }

        public async Task LoadPokemonDetails(Pokemon pokemon) 
        {
            String pokemonDetailsJson = await getPokemon.getPokemonDetails(pokemon.num_pokedex.ToString());
            JToken pokemonDetails = JToken.Parse(pokemonDetailsJson);
            pokemon.addDetails();
        }
        
        public async Task LoadPokemonImages(Pokemon pokemon)
        {
            String levelJsonString = await getPokemon.getPokemonImages(pokemon.name);
            JObject pokemonJson = JObject.Parse(levelJsonString);
            JToken pokemonImages = pokemonJson["sprites"];
            pokemon.addImages(pokemonImages);
        }

        public async Task LoadLevel()
        {
            Level actual;
            String levelJsonString = await getLevel.getLevels();
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
            String cpMultiplierJson = await getPokemonLevel.getCpMultiplier();
            String requirementsToPowerUpJson = await getPokemonLevel.getRequirementsToPowerUp();
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
            String elementsJson = await getElement.getElements();
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
            String gymsAndPokestopsJson = readPokestopsJson.readPokestopsData();
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
            String gymsAndPokestopsJson = readPokestopsJson.readPokestopsData();
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

    }
}
