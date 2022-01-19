#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiREST.Data;
using apiREST.Model;
using Microsoft.AspNetCore.Authorization;

namespace apiREST.Controllers
{
    [Authorize]
    [Route("api/pokemon")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly pokemonGolotApi _context;

        public PokemonController(pokemonGolotApi context)
        {
            _context = context;
        }

        /// <summary>
        /// Return all pokemons ordered by pokedex num
        /// </summary>
        /// <remarks> Return pokemons with short info format </remarks>
        /// <response code="401"> Unauthorized </response>
        /// <response code="500"> Server error </response>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pokemon>>> GetPokemon()
        {
            // todo format pokemon to shor info data
            return await _context.Pokemon.OrderBy(p => p.num_pokedex).ToListAsync();            
        }


        /// <summary>
        /// Return concret pokemon by pokedex number
        /// </summary>
        /// <remarks> Return pokemon with full info </remarks>
        /// <param name="numPokedex"> The number of pokemon in the pokedex </param>
        /// <response code="401"> Unauthorized </response>
        /// <response code="404"> Pokemon not found </response>
        /// <response code="500"> Server error </response>
        [HttpGet("detail/{numPokedex}")]
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
