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
using System.Net.Mime;

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
        private readonly userLogic _userLogic;
        public IConfiguration _configuration;

        public LoginController(IConfiguration config, pokemonGolotApi context)
        {
            _context = context;
            _logic = new loginLogic(context);
            _configuration = config;
            _userLogic = new userLogic();
        }

        /// <summary>
        /// Login request to authenticate admin users
        /// </summary>
        /// <remarks> Returns a token key for authorize needed requests and user details </remarks>
        /// <response code="400"> No data on request </response>
        /// <response code="401"> Invalid user rol for this request </response>
        /// <response code="403"> Invalid credentials </response>
        /// <response code="415"> Unsuported media content type</response>
        [HttpPost]
        [Route("authenticate/admin")]
        [Consumes("application/x-www-form-urlencoded")]
        [Produces( MediaTypeNames.Application.Json )]
        public async Task<ActionResult<LoginResponse>> AdminAuthenticate(UserLogin? _login)
        {
            if (_login != null)
            {
                User? user = await _logic.UserExist(_login);

                if (user != null)
                {
                    if (user.rol!.Equals("Admin"))
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

                        return Ok(new LoginResponse(tokenString, _userLogic.toDecryptedPlayer(user)));
                    }
                    else
                    {
                        return Unauthorized("Invalid rol");
                    }

                    
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
