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
    [Route("user")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly pokemonGolotApi _context;
        private readonly registerLogic _registerLogic;
        private readonly userLogic _userLogic;

        public UserController(pokemonGolotApi context)
        {
            _context = context;
            _registerLogic = new registerLogic();
            _userLogic = new userLogic();
        }


        /// <summary>
        /// Get a list of all admin users registered on database
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [Route("admins")]
        [HttpGet]
        public async Task<ActionResult<List<ResponsePlayer>>>? GetAdminUsersList()
        {
            List<User> admins = await _context.User.Where(u => u.rol == "Admin").ToListAsync();

            return null;
        }

        private bool UserExists(string? user_name, string? email)
        {
            return _context.User.Any(p => p.user_name == user_name || p.email == email);
        }

        /// <summary>
        /// Register new user with 'player' rol
        /// </summary>
        /// <remarks>Return a new player object with full info</remarks>
        /// <returns></returns>
        [Route("public")]
        [HttpPost]
        public async Task<ActionResult<ResponseUser>> RegisterNewUser(UserRegister newPlayer)
        {
            User player =  _registerLogic.publicRegister(newPlayer);

            _context.User.Add(player);
            

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserExists(player.user_name, player.email))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Ok(_userLogic.toDecryptedUser(player));
        }




        /// <summary>
        /// Register new user with 'global' rol
        /// </summary>
        /// <remarks>Return a new global player object with full info</remarks>
        /// <returns></returns>
        [Route("global")]
        [HttpPost]
        public async Task<ActionResult<ResponseGlobalUser>> RegisterNewGlobalUser(GlobalUserRegister newPlayer)
        {
            User player = _registerLogic.globalRegister(newPlayer);

            _context.User.Add(player);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserExists(player.user_name, player.email))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Ok(_userLogic.toDecryptedGlobalUser(player));
        }
    }
}
