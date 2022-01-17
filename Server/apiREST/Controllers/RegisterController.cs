using apiREST.Data;
using apiREST.Logic;
using apiREST.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apiREST.Controllers
{
    [AllowAnonymous]
    [Route("[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {

        private readonly pokemonGolotApi _context;
        private readonly registerLogic _registerLogic;
        private readonly playerLogic _playerLogic;

        public RegisterController(pokemonGolotApi context)
        {
            _context = context;
            _registerLogic = new registerLogic();
            _playerLogic = new playerLogic();
        }


        [Route("player")]
        [HttpPost]
        public async Task<IActionResult> RegisterNewPlayer(PlayerRegister newPlayer)
        {
            Player player =  _registerLogic.publicRegister(newPlayer);

            _context.Player.Add(player);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PlayerExists(player.user_name))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Ok(_playerLogic.toDecryptedPlayer(player));
        }
        private bool PlayerExists(string? user_name)
        {
            return _context.Player.Any(p => p.user_name == user_name);
        }

    }
}
