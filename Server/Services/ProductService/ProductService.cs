//using BlazingShop.Server.Data;
using BlazingShop.Server.Services.CategoryService;
using BlazingShop.Shared;
//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>
        {
            new Product{
                Id = 1,
                CategoryId = 1,
                Title = "The Hitchhikers guide to the Galaxy",
                Description = "Comedy Science Fiction",
                Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                Price = 9.99m,
                OriginalPrice = 19.99m
            },
            new Product
            {
                Id = 2,
                CategoryId = 3,
                Title = "Half Life 2",
                Description = "Game",
                Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                Price = 10.99m,
                OriginalPrice = 21.99m
            },
        };

        private readonly ICategoryService _categoryService;
        //private readonly DataContext _context;

        public ProductService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return Products;
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = Products.FirstOrDefault(p =>p.Id == id);
            return product;
            //Product product = await _context.Products
            //    .Include(p => p.Variants)
            //    .ThenInclude(v => v.Edition)
            //    .FirstOrDefaultAsync(p => p.Id == id);

            //product.Views++;

            //await _context.SaveChangesAsync();

            //return product;
        }


        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            //return Products.Where(p=>p.CategoryId==1).ToList();
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return  Products.Where(p => p.CategoryId == category.Id).ToList();
        }

        //public async Task<List<Product>> SearchProducts(string searchText)
        //{
        //    return await _context.Products
        //        .Where(p => p.Title.Contains(searchText) || p.Description.Contains(searchText))
        //        .ToListAsync();
        //}
    }
}
