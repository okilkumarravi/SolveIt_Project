using Microsoft.AspNetCore.Mvc;
using SolveIt.Model;
using SolveIt.Service;

namespace SolveIt.Controllers.Authentication
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }
        [HttpPost]
        public ActionResult<bool> CreateUser(CreateUser createUser)
        {
            return _authenticationService.CreateUser(createUser);
        }

        [HttpGet]
        public ActionResult<bool> LoginUser(LoginUser loginUser)
        {
            _authenticationService.LoginUser(loginUser);
            return Ok(true);
        }
    }
}
