using apiREST.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace apiREST.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly dynamic _playerManager;

        public PlayersController(pokemonGolotApi context)
        {
            _playerManager = context.Player;
        }

        [Route("{userName}")]
        [HttpGet]
        public async Task<IActionResult> GetId(int userName)
        {
            var player = await _playerManager.FindAsync(userName);
            return Ok(player);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var players = await _playerManager.ToListAsync();
            return Ok(players);
        }
    }
}
