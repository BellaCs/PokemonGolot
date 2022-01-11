﻿using System;
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
            LoadLevel().Wait();
            LoadPokemonLevels().Wait();
            LoadElement().Wait();
            LoadPokestops();
        }

        public async Task LoadPokemon() 
        {
            Pokemon actual;
            for(var gen = 1; gen <= 7; gen++) 
            {
                String pokmeonJsonString = await getPokemon.getPokemons(gen.ToString());
                JToken pokemonString = JObject.Parse(pokmeonJsonString);
                foreach (JToken pokemon in pokemonString) 
                {
                    actual = new Pokemon(pokemon);
                }
            
            }

            
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
            JToken gymsList = gymsAndPokestopsList["gyms"];
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
    }
}
