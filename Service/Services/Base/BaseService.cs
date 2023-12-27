using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Base
{
    public class BaseService : IBaseService
    {

        public BaseService()
        {
        }

        public async Task<string> SaveImage(IFormFile image)
        {
            var result = "";
            var uniqueFileName = GetUniqueFileName(image.FileName);

            var filePath = Path.Combine("Resources", uniqueFileName);
            var fullPath = Path.Combine(Directory.GetCurrentDirectory(), filePath);

            if (image.Length > 0)
            {
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                    result = filePath;
                }

            }
            return result;

        }

        private string GetUniqueFileName(string fileName)
        {

            fileName = Path.GetFileName(fileName);
            return string.Concat(Path.GetFileNameWithoutExtension(fileName), "_", Guid.NewGuid().ToString().AsSpan(0, 4), Path.GetExtension(fileName));


        }
    }
}
