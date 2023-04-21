using API.DbContext.Db;
using API.Models.DTO.Product;
using API.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Helpers.Repositories
{

    public class ProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        // <-*-> GET ALL PRODUCTS
        public async Task<List<ProductResponseDTO>> GetProductsAsync()
        {
            var products = await _db.Products.Include("Category").ToListAsync();
            return products.Select(product => product.ToProductResponse()).ToList();
        }

        // GET ONE PRODUCT
        public async Task<ProductResponseDTO> GetProductAsync(Guid? id)
        {
            if (id == null)
            {
                return null!;
            }

            ProductEntity? product = await _db.Products.Include("Category").Where(p => p.ProductId == id).FirstOrDefaultAsync();

            if (product == null)
            {
                return null!;
            }

            return product.ToProductResponse();
        }


        // GET SORTED PRODUCTS
        public async Task<List<ProductResponseDTO>> GetSortedProductsAsync(string? category)
        {
            if (category == null)
            {
                return null;
            }

            List<ProductEntity> products = new List<ProductEntity>();

            switch (category.ToLower())
            {
                case "new":
                    products = await _db.Products.Where(item => item.Category.CategoryName.ToLower() == "new").OrderByDescending(temp => temp.Date).Take(8).ToListAsync();
                    break;

                case "featured":
                    products = await _db.Products.Where(item => item.Category.CategoryName.ToLower() == "featured").OrderByDescending(temp => temp.Date).Take(8).ToListAsync();
                    break;

                case "popular":
                    products = await _db.Products.Where(item => item.Category.CategoryName.ToLower() == "popular").OrderByDescending(temp => temp.Date).Take(8).ToListAsync();
                    break;

            }

            return products.Select(product => product.ToProductResponse()).ToList();
        }


        // POST PRODUCT
        public async Task<ProductResponseDTO> PostProductAsync(ProductAddRequestDTO productAddRequestDTO)
        {
            if (productAddRequestDTO == null)
            {
                return null!;
            }

            ProductEntity product = productAddRequestDTO.ToProduct();
            product.ProductId = Guid.NewGuid();
            product.Category = await _db.Categories.Where(c => c.CategoryId == productAddRequestDTO.CategoryId).FirstOrDefaultAsync();

            _db.Products.Add(product);
            await _db.SaveChangesAsync();

            return product.ToProductResponse();

        }

        // DELETE PRODUCT
        public async Task<bool> DeleteProductAsync(Guid? id)
        {
            if (id == null)
            {
                return false;
            }

            ProductEntity? product = await _db.Products.Where(p => p.ProductId == id).FirstOrDefaultAsync();
            if (product == null)
            {
                return false;
            }

            _db.Products.Remove(product);
            await _db.SaveChangesAsync();
            return true;
        }


    }
}
