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
    [Route("player")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly pokemonGolotApi _context;
        private readonly registerLogic _registerLogic;
        private readonly userLogic _playerLogic;

        public UserController(pokemonGolotApi context)
        {
            _context = context;
            _registerLogic = new registerLogic();
            _playerLogic = new userLogic();
        }



        /// <summary>
        /// Register new user with 'player' rol
        /// </summary>
        /// <remarks>Return a new player object with full info</remarks>
        /// <returns></returns>
        [Route("public")]
        [HttpPost]
        public async Task<ActionResult<ResponsePlayer>> RegisterNewUser(UserRegister newPlayer)
        {
            User player =  _registerLogic.publicRegister(newPlayer);

            _context.User.Add(player);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserExists(player.user_name))
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
        private bool UserExists(string? user_name)
        {
            return _context.User.Any(p => p.user_name == user_name);
        }

    }
}
