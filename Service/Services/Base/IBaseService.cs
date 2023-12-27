using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Base
{
    public interface IBaseService
    {
        public Task<string> SaveImage(IFormFile image);
    }
}
