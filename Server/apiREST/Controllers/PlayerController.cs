using apiREST.Data;
using apiREST.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace apiREST.Controllers
{

    [Authorize]
    [Route("api/[Controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {

        private readonly pokemonGolotApi _context;

        public PlayerController(pokemonGolotApi context)
        {
            _context = context;
        }

        [HttpGet("self")]
        public async Task<ActionResult<ResponsePlayer>> GetSelfPlayer()
        {

            try
            {

                if (HttpContext.User.Identity is ClaimsIdentity identity)
                {
                    IEnumerable<Claim> claims = identity.Claims;
                    // or
                    string? userName = claims.FirstOrDefault(c => c.Type == "UserName")?.Value;

                    if (userName != null)
                    {
                        Player? self = _context.Player.FirstOrDefault(p => p.user_name == userName.ToLower());
                        if (self == null)
                        {
                            Player newPlayer = new(userName.ToLower());

                            _context.Player.Add(newPlayer);

                            await _context.SaveChangesAsync();

                            return Ok(newPlayer.toResponsePlayer());
                        }
                        else
                        {
                            return Ok(self.toResponsePlayer());
                        }
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
    }
}
