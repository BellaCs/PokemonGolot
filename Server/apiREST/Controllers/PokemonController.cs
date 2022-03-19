using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiREST.Data;
using apiREST.Model;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using ExtensionMethods;

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

        [HttpGet("self/owned")]
        public async Task<ActionResult<List<PokemonOwnedForList>>> GetPokemonOwned()
        {
            try
            {
                if (HttpContext.User.Identity is ClaimsIdentity identity)
                {
                    // obtenir les propietats del token (identitat de l'usuari)
                    IEnumerable<Claim> claims = identity.Claims;
                    // obtenir el valor del claim (el nom_usuari)
                    string? userName = claims.FirstOrDefault(c => c.Type == "UserName")?.Value;

                    if (userName != null) {

                        List<PokemonOwned>? PokemonsOwnedList = await _context.Pokemon_owned.Where(p => p.owner == userName).ToListAsync();

                        return PokemonsOwnedList.toPokemonOwnedForListList(_context);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                else
                {
                    return Unauthorized();
                }

            }
            catch
            {
                return StatusCode(500);
            }


        }


        private bool PokemonExists(int? id)
        {
            return _context.Pokemon.Any(e => e.num_pokedex == id);
        }

    }
}
