using apiREST.Data;
using apiREST.Logic;
using apiREST.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace apiREST.Controllers
{
    /// <summary>
    /// Login controller class for authenticate users
    /// </summary>
    [AllowAnonymous]
    [Route("login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly pokemonGolotApi _context;
        private readonly loginLogic _logic;
        private readonly playerLogic _playerLogic;
        public IConfiguration _configuration;

        public LoginController(IConfiguration config, pokemonGolotApi context)
        {
            _context = context;
            _logic = new loginLogic(context);
            _configuration = config;
        }

        /// <summary>
        /// Login request to authenticate users
        /// </summary>
        /// <remarks> That's request to login in admin profile </remarks>
        /// <response code="400"> No data on request </response>
        /// <response code ="403"> Invalid credentials </response>
        [HttpPost]
        [Route("authenticate")]
        public async Task<ActionResult<LoginResponse>> Authenticate(PlayerLogin? _login)
        {

            if (_login != null)
            {
                Player? user = await _logic.UserExist(_login);

                if (user != null)
                {
                    //create claims details based on the user information
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

                    

                    return Ok(new LoginResponse(tokenString, _playerLogic.toDecryptedPlayer(user)));
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

    }
}
