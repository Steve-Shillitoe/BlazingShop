using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        //private readonly HttpClient _http;

       // public event Action OnChange;

        public List<Product> Products { get; set; } = new List<Product>();

        public void LoadProducts()
        {
            Products = new List<Product> {
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
}
     

    //    public ProductService(HttpClient http)
    //    {
    //        _http = http;
    //    }

    //    public async Task LoadProducts(string categoryUrl = null)
    //    {
    //        if (categoryUrl == null)
    //        {
    //            Products = await _http.GetFromJsonAsync<List<Product>>("api/Product");
    //        }
    //        else
    //        {
    //            Products = await _http.GetFromJsonAsync<List<Product>>($"api/Product/Category/{categoryUrl}");
    //        }
    //        OnChange.Invoke();
    //    }

    //    public async Task<Product> GetProduct(int id)
    //    {
    //        return await _http.GetFromJsonAsync<Product>($"api/Product/{id}");
    //    }

    //    public async Task<List<Product>> SearchProducts(string searchText)
    //    {
    //        return await _http.GetFromJsonAsync<List<Product>>($"api/Product/Search/{searchText}");
    //    }
    }
}