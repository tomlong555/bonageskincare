using Service.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Helpers
{
    public static class StringHelper
    {
        public static string ToFilePath(this string fileName,string path)
        {
            var result = Path.Combine(path, fileName);
            return result;
        }
    }
}
