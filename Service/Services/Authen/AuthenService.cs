using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Service.Models.AuthenModels;
using Service.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Authen
{
    public class AuthenService : IAuthenService
    {
        private readonly JwtOptionModel _jwtOptionModel;
        public AuthenService(
            IOptions<JwtOptionModel> jwtOptionModel)
        {
            _jwtOptionModel = jwtOptionModel.Value;
        }

        public async Task<string> Login(UserLoginModel input)
        {
            var result = "";
            if (input != null)
            {
                if (input.UserName != "admin" || input.Password != "password")
                {
                    return result;
                }

                var issuer = _jwtOptionModel.Issuer;
                var audience = _jwtOptionModel.Audience;
                var key = Encoding.UTF8.GetBytes(_jwtOptionModel.Key);
                var signingCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha512Signature);

                var subject = new ClaimsIdentity(new[]
                {
                        new Claim(JwtRegisteredClaimNames.Sub, input.UserName),
                        new Claim(JwtRegisteredClaimNames.Email, input.UserName),
                    });

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = subject,
                    Expires = DateTime.UtcNow.AddMinutes(10),
                    Issuer = issuer,
                    Audience = audience,
                    SigningCredentials = signingCredentials
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(tokenDescriptor);
                result = tokenHandler.WriteToken(token);

                return result;
            }

            return result;
        }

    }
}
