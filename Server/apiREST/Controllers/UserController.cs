using apiREST.Data;
using apiREST.Logic;
using apiREST.Model;
using ExtensionMethods;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Mime;
using System.Security.Claims;
using Newtonsoft.Json.Linq;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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
        private readonly loginLogic _logic;
        public IConfiguration _configuration;

        public UserController(IConfiguration config, pokemonGolotApi context)
        {
            _context = context;
            _registerLogic = new registerLogic();
            _userLogic = new userLogic();
            _logic = new loginLogic(context);
            _configuration = config;
        }

        /// <summary>
        /// Login request to authenticate users
        /// </summary>
        /// <remarks> Returns a token key for authorize needed requests and user details </remarks>
        /// <response code="400"> No data on request </response>
        /// <response code="403"> Invalid credentials </response>
        /// <response code="415"> Unsuported media content type</response>
        [HttpPost]
        [Route("authenticate")]
        [Consumes("application/x-www-form-urlencoded")]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<LoginResponse>> AdminAuthenticate([FromForm] UserLogin? _login)
        {
            if (_login != null)
            {
                User? user = await _logic.UserExist(_login);

                if (user != null)
                {
                        var claims = new[] {
                            new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                            new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                            new Claim("FirstName", user.name!),
                            new Claim("Email", user.email!),
                            new Claim("UserName", user.user_name!),
                            new Claim("Rol", user.rol!)
                        };
                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

                        var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                        var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

                        string tokenString = new JwtSecurityTokenHandler().WriteToken(token);

                        JObject tokenJson = new();

                        return Ok(new LoginResponse(tokenString, _userLogic.toDecryptedUser(user)));
                }
                else
                {
                    return Forbid("Invalid credentials");
                }
            }
            else
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Register new user
        /// </summary>
        /// <remarks>Return user info</remarks>
        /// <returns></returns>
        [Route("register")]
        [HttpPost]
        public async Task<ActionResult<ResponseUser>> RegisterNewGlobalUser(GlobalUserRegister newPlayer)
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

            return Ok(_userLogic.toDecryptedUser(player));
        }

        /// <summary>
        /// Register new user with 'player' rol
        /// </summary>
        /// <remarks>Return a new player object with full info</remarks>
        /// <returns></returns>
        [Route("register/player")]
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
        /// Get a list of all admin users registered on database
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [Route("admins")]
        [HttpGet]
        public async Task<ActionResult<List<SimpleUserData>>> GetAdminUsersList()
        {
            List<User> admins = await _context.User.Where(u => u.rol == "Admin").ToListAsync();

            return Ok(admins.toSimpleResponseListUserData());
        }



        private bool UserExists(string? user_name, string? email)
        {
            return _context.User.Any(p => p.user_name == user_name || p.email == email);
        }

    }
}
