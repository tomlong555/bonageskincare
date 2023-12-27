using Microsoft.AspNetCore.Mvc;
using Service.Models.AuthenModels;
using Service.Models.ProductModels;
using Service.Services.Authen;
using Service.Services.Product;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenController : ControllerBase
    {
        private readonly IAuthenService _authenService;
        public AuthenController(
          IAuthenService authenService
          )
        {
            _authenService = authenService;
        }

        [HttpPost]
        public async Task<ActionResult<string>> Login([FromBody] UserLoginModel input)
        {
            var result = await _authenService.Login(input);
            if (string.IsNullOrEmpty(result))
            {
                return Unauthorized();

            }
            return Ok(result);
        }
    }
}
