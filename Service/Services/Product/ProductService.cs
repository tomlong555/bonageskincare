using Database.Entitys;
using Microsoft.EntityFrameworkCore;
using Service.Models.ProductGroupModels;
using Service.Models.ProductModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly DBContext _dBContext;
        public ProductService(
            DBContext dBContext
            )
        {
            _dBContext = dBContext;
        }
        public async Task<ProductModel> GetProduct(int productId)
        {
            var result = new ProductModel();

            result = await (from product in _dBContext.TbProduct
                            where product.ProductId == productId
                            && !product.IsDeleted
                            select new ProductModel
                            {
                                ProductId = product.ProductId,
                                ProductName = product.ProductName,
                                Price = product.Price,
                                Unit = product.Unit,
                                Size = product.Size,
                                ContentHeader = product.ContentHeader,
                                ContentBody = product.ContentBody,
                                ProductGroupId = product.ProductGroupId,
                                ProductGroupName = product.TbProductGroup.ProductGroupName
                            }).SingleAsync();

            return result;
        }

        public async Task<List<ProductModel>> GetProducts()
        {
            var results = new List<ProductModel>();

            results = await (from product in _dBContext.TbProduct
                             where !product.IsDeleted
                             select new ProductModel
                             {
                                 ProductId = product.ProductId,
                                 ProductName = product.ProductName,
                                 Price = product.Price,
                                 Unit = product.Unit,
                                 Size = product.Size,
                                 ContentHeader = product.ContentHeader,
                                 ContentBody = product.ContentBody,
                                 ProductGroupId = product.ProductGroupId,
                                 ProductGroupName = product.TbProductGroup.ProductGroupName
                             }).ToListAsync();

            return results;
        }

        public async Task<List<ProductModel>> GetProductPromotes()
        {
            var results = new List<ProductModel>();

            results = await (from product in _dBContext.TbProduct
                             where !product.IsDeleted
                             && product.IsPromote
                             select new ProductModel
                             {
                                 ProductId = product.ProductId,
                                 ProductName = product.ProductName,
                                 Price = product.Price,
                                 Unit = product.Unit,
                                 Size = product.Size,
                                 ContentHeader = product.ContentHeader,
                                 ContentBody = product.ContentBody,
                                 ProductGroupId = product.ProductGroupId,
                                 ProductGroupName = product.TbProductGroup.ProductGroupName
                             }).ToListAsync();

            return results;
        }

        public async Task<List<ProductModel>> GetProducts(int productGroupId)
        {
            var results = new List<ProductModel>();

            results = await (from product in _dBContext.TbProduct
                             where product.ProductGroupId == productGroupId
                             && !product.IsDeleted
                             select new ProductModel
                             {
                                 ProductId = product.ProductId,
                                 ProductName = product.ProductName,
                                 Price = product.Price,
                                 Unit = product.Unit,
                                 Size = product.Size,
                                 ContentHeader = product.ContentHeader,
                                 ContentBody = product.ContentBody,
                                 ProductGroupId = product.ProductGroupId,
                                 ProductGroupName = product.TbProductGroup.ProductGroupName
                             }).ToListAsync();

            return results;
        }

        public async Task<bool> CrateProduct(ProductInputModel input)
        {
            var newData = new TbProduct()
            {
                ProductName = input.ProductName,
                Price = input.Price,
                Unit = input.Unit,
                Size = input.Size,
                ContentHeader = input.ContentHeader,
                ContentBody = input.ContentBody,
                ProductGroupId = input.ProductGroupId,
                CreateBy = 1,
                CreateDate = DateTime.UtcNow,
            };

            await _dBContext.TbProduct.AddAsync(newData);
            await _dBContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            var productData = new TbProduct();

            productData = await (from product in _dBContext.TbProduct
                            where product.ProductId == productId
                            && !product.IsDeleted
                            select product).SingleAsync();

            productData.IsDeleted = true;
            productData.CreateDate = DateTime.UtcNow;
            productData.CreateBy = 1;

            await _dBContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateProduct(int productId, ProductInputModel input)
        {
            var productData = new TbProduct();

            productData = await (from product in _dBContext.TbProduct
                                 where product.ProductId == productId
                                 && !product.IsDeleted
                                 select product).SingleAsync();

            productData.ProductName = input.ProductName;
            productData.Price = input.Price;
            productData.Unit = input.Unit;
            productData.Size = input.Size;
            productData.ContentHeader = input.ContentHeader;
            productData.ContentBody  = input.ContentBody;
            productData.UpdateDate = DateTime.UtcNow;
            productData.UpdateBy = 1;

            await _dBContext.SaveChangesAsync();

            return true;
        }
    }
}
