using Service.Models.AuthenModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Authen
{
    public interface IAuthenService
    {
        public Task<string> Login(UserLoginModel input);

    }
}
