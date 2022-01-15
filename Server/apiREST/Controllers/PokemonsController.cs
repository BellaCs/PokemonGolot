#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiREST.Data;
using apiREST.Model;

namespace apiREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonsController : ControllerBase
    {
        private readonly pokemonGolotApi _context;

        public PokemonsController(pokemonGolotApi context)
        {
            _context = context;
        }

        // GET: api/Pokemons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pokemon>>> GetPokemon()
        {
            return await _context.Pokemon.ToListAsync();
        }

        // GET: api/Pokemons/5
        [HttpGet("{numPokedex}")]
        public async Task<ActionResult<Pokemon>> GetPokemon(int numPokedex)
        {
            var pokemon = await _context.Pokemon.FindAsync(numPokedex);

            if (pokemon == null)
            {
                return NotFound();
            }
            

            return pokemon;
        }

        private bool PokemonExists(int? id)
        {
            return _context.Pokemon.Any(e => e.num_pokedex == id);
        }
    }
}
