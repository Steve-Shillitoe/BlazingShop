using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        //private readonly HttpClient _http;

        public List<Category> Categories { get; set; } = new List<Category>();

        //public CategoryService(HttpClient http)
        //{
       //     _http = http;
       // }

        public void LoadCategories()
        {
            Categories = new List<Category>
            {
                new Category{Id=1, Name="Books", Url="books", Icon="book"},
                new Category{Id=2, Name="Electronics", Url="electronics", Icon="camera-slr"},
                new Category{Id=3, Name="Video Games", Url="video-games", Icon="aperture"}
            };
        }
    }
}
