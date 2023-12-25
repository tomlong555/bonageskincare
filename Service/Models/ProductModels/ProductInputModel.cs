using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models.ProductModels
{
    public class ProductInputModel
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Unit { get; set; }
        public string Size { get; set; }
        public string ContentHeader { get; set; }
        public string ContentBody { get; set; }
        public int ProductGroupId { get; set; }

    }
}
