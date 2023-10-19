using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //readonly değerler sadece 1 kez set edilebilir 1- tanımlandığı yerde 2- constructor içerisinde
        //ILogger bir interface yapısıdır
        private readonly ILogger<ProductsController> _logger;

        
        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = new List<Product>()
            {
                new Product { Id = 1, ProductName = "Keyboard"},
                new Product { Id = 2, ProductName = "Monitor"},
                new Product { Id = 3, ProductName = "Mouse"}
            };

            //alttaki mesaj debug consolunda gözükür
            _logger.LogInformation("GetAllProducts action has been called.");

            return Ok(products);
        }

    }
}
