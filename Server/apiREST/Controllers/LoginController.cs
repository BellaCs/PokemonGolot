using apiREST.Data;
using apiREST.Logic;
using apiREST.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace apiREST.Controllers
{
    /// <summary>
    /// Login controller class for authenticate users
    /// </summary>
    [AllowAnonymous]
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly pokemonGolotApi _context;
        private readonly loginLogic _logic;
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
        /// <remarks>That's request to login in admin profile</remarks>
        /// <response code="401">Unauthorized</response>
        /// <response code ="403">Wrong login</response>
        /// <response code="500">Server error</response>
        [HttpPost]
        [Route("authenticate")]
        public async Task<IActionResult> Authenticate(PlayerLogin? _login)
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
                    
                    tokenJson["user_token"] = tokenString;

                    return Ok(tokenJson.ToString());
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
