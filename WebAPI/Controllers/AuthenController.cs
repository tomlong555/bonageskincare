﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Models.AuthenModels;
using Service.Models.ProductModels;
using Service.Services.Authen;
using Service.Services.Product;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        [AllowAnonymous]
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
