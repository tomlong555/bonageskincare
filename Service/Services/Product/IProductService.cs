using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Models.ProductGroupModels;
using Service.Models.ProductModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Product
{
    public interface IProductService
    {
        public Task<ProductModel> GetProduct(int productId);
        public Task<List<ProductModel>> GetProducts();
        public Task<List<ProductModel>> GetProducts(int productGroupId);
        public Task<List<ProductModel>> GetProductPromotes();
        public Task<bool> CrateProduct(ProductInputModel input);
        public Task<bool> UpdateProduct(int productId, ProductInputModel input);
        public Task<bool> DeleteProduct(int productId);
        public Task<string> CrateProductFile( List<IFormFile> input);

    }
}
