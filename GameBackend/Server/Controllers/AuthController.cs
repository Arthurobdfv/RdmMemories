
using Google.Apis.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public class AuthenticateRequest
        {
            [Required]
            public string IdToken { get; set; }
        }

        private readonly JwtGenerator _jwtGenerator;

        public UserController(IConfiguration configuration)
        {
            _jwtGenerator = new JwtGenerator(configuration.GetValue<string>("JwtPrivateSigningKey"));
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] AuthenticateRequest data)
        {
            GoogleJsonWebSignature.ValidationSettings settings = new GoogleJsonWebSignature.ValidationSettings();

            // Change this to your google client ID
            settings.Audience = new List<string>() { "708313847097-qqhkk449k8ut39q0uf0290rhvgm4cthh.apps.googleusercontent.com" };

            GoogleJsonWebSignature.Payload payload = GoogleJsonWebSignature.ValidateAsync(data.IdToken, settings).Result;
            return Ok(new { AuthToken = _jwtGenerator.CreateUserAuthToken(payload.Email) });
        }
    }
}