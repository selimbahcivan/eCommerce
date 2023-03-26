using ECommerceProject.Application.Repositories.Product;
using ECommerceProject.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }
        [HttpPost]
        public async Task AddProducts()
        {
            //await _productWriteRepository.AddRangeAsync(new()
            //{
            //    new() { Name = "Basketbol Topu", Price = 170, Stock = 10 },
            //    new() { Name = "Masa", Price = 333, Stock = 15 },
            //    new() { Name = "Kitap", Price = 555, Stock = 22 }
            //});
            //await _productWriteRepository.SaveAsync();
            Product p = await _productReadRepository.GetByIdAsync(7);
            p.Name = "TEST";
            await _productWriteRepository.SaveAsync();
        }
        [HttpGet]
        public IActionResult GetProducts()
        { 
            return Ok(_productReadRepository.GetAll());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }
    }
}
