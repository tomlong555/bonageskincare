using Database.Entitys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Service.Helpers;
using Service.Models.BaseModels;
using Service.Models.ProductGroupModels;
using Service.Models.ProductModels;
using Service.Services.Base;
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
        private readonly IBaseService _baseService;
        private readonly PathOptionModel _pathOptionModel;

        public ProductService(
            DBContext dBContext
            , IBaseService baseService
            , IOptions<PathOptionModel> pathOptionModel
            )
        {
            _dBContext = dBContext;
            _baseService = baseService;
            _pathOptionModel = pathOptionModel.Value;
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
                                ProductGroupName = product.TbProductGroup.ProductGroupName,
                                IsPromote = product.IsPromote,
                                IsVegan = product.IsVegan,
                                Filess = product.TbFileProducts
                                .Where(file => !file.TbFile.IsDeleted)
                                .Select(file =>
                                    new FileModel
                                    {
                                        FileName = file.TbFile.FileName.ToFilePath(_pathOptionModel.ResoucesPath),
                                        IsProduct = file.IsProduct,
                                    }).ToList()
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
                                 ProductGroupName = product.TbProductGroup.ProductGroupName,
                                 IsPromote = product.IsPromote,
                                 IsVegan = product.IsVegan,
                                 Filess = product.TbFileProducts
                                .Where(file => !file.TbFile.IsDeleted)
                                .Select(file =>
                                    new FileModel
                                    {
                                        FileName = file.TbFile.FileName.ToFilePath(_pathOptionModel.ResoucesPath),
                                        IsProduct = file.IsProduct,
                                    }).ToList()
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
                                 ProductGroupName = product.TbProductGroup.ProductGroupName,
                                 IsPromote = product.IsPromote,
                                 IsVegan = product.IsVegan,
                                 Filess = product.TbFileProducts
                                .Where(file => !file.TbFile.IsDeleted)
                                .Select(file =>
                                    new FileModel
                                    {
                                        FileName = file.TbFile.FileName.ToFilePath(_pathOptionModel.ResoucesPath),
                                        IsProduct = file.IsProduct,
                                    }).ToList()
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
                                 ProductGroupName = product.TbProductGroup.ProductGroupName,
                                 IsPromote = product.IsPromote,
                                 IsVegan = product.IsVegan,
                                 Filess = product.TbFileProducts
                                .Where(file => !file.TbFile.IsDeleted)
                                .Select(file =>
                                    new FileModel
                                    {
                                        FileName = file.TbFile.FileName.ToFilePath(_pathOptionModel.ResoucesPath),
                                        IsProduct = file.IsProduct,
                                    }).ToList()
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
                CreateDate = DateTime.UtcNow,
            };

            //newData.TbFileProducts

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
            productData.ContentBody = input.ContentBody;
            productData.UpdateDate = DateTime.UtcNow;

            await _dBContext.SaveChangesAsync();

            return true;
        }

        public async Task<string> CrateProductFile(List<IFormFile> input)
        {
            var result = "";
            foreach (var image in input)
            {
                var a = await _baseService.SaveImage(image);
            }
            return result;
        }
    }
}
