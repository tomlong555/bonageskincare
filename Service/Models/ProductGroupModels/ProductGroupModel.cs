using Service.Models.ProductModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models.ProductGroupModels
{
    public class ProductGroupModel
    {
        public int ProductGroupId { get; set; }
        public string ProductGroupName { get; set; }
        public string ProductGroupDescription { get; set; }
        public List<ProductModel> Products { get; set; }
    }
}
