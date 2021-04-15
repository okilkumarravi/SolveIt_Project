using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SolveIt.Model;
using SolveIt.Service;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace SolveIt.Controllers.Authentication
{
    [Route("api/[controller]")]
    public class BasicAuthController : ControllerBase
    {
        private IConfiguration _config;
        private IAuthenticationService _authenticationService;
        public BasicAuthController(IConfiguration config, IAuthenticationService authenticationService)
        {
            _config = config;
            _authenticationService = authenticationService;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult AuthLogin(LoginUser loginUser)
        {
            IActionResult response = Unauthorized();

            var user = Authenticate(loginUser);

            if (user != null)
            {
                var tokenString = BuildToken(user);

                response = Ok(new
                {
                    token = tokenString
                });
            }

            return response;
        }

        private string BuildToken(object user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:key"]));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["JWT:Issuer"], _config["JWT:Audience"], signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private UserModel Authenticate(LoginUser loginUser)
        {
            return  _authenticationService.BaseLogin(loginUser);
        }
    }
}
