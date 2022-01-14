using apiREST.Data;
using apiREST.Logic;
using apiREST.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace apiREST.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly pokemonGolotApi _context;
        private readonly loginLogic _logic;

        public LoginController(pokemonGolotApi context)
        {
            _context = context;
            _logic = new loginLogic(context); 
        }

        /// <summary>
        /// Login request for admin users
        /// </summary>
        /// <remarks>That's request to login in admin profile</remarks>
        /// <response code="401">Unauthorized</response>
        /// <response code ="403">Wrong login</response>
        /// <response code="500">Server error</response>
        [Route("admin")]
        [HttpGet]
        public async Task<IActionResult> AdminLogin(PlayerLogin player)
        {
            Player? fullPlayer = await _logic.userExist(player);
            if (fullPlayer != null)
            {
                return Ok();
            }
            else
            {
                return Forbid();
            }     
        }
        
    }
}
