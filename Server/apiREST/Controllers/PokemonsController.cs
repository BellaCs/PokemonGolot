#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiREST.Data;
using apiREST.Model;
using Microsoft.AspNetCore.Authorization;

namespace apiREST.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonsController : ControllerBase
    {
        private readonly pokemonGolotApi _context;

        public PokemonsController(pokemonGolotApi context)
        {
            _context = context;
        }

        /// <summary>
        /// Return all pokemons ordered by pokedex num
        /// </summary>
        /// <remarks></remarks>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Server error</response>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pokemon>>> GetPokemon()
        {
            return await _context.Pokemon.OrderBy(p => p.num_pokedex).ToListAsync();
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
