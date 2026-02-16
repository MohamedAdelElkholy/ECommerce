using ECommerce.Application.DTOs;
using ECommerce.Application.Interfaces;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public async Task<ProductDto> CreateAsync(CreateProductDto dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                Description = dto.Description,
                Price = dto.Price,
                StockQuantity = dto.StockQuantity
            };
            await _repository.AddAsync(product);
            return new ProductDto
            {
                Name = dto.Name,
                Description = dto.Description,
                Price = dto.Price,
                StockQuantity = dto.StockQuantity
            };
        }
        public async Task<List<ProductDto>> GetAllAsync()
        {
            var products = await _repository.GetAllAsync();
            return products.Select(x => new ProductDto { 
                Name = x.Name, 
                Description = x.Description, 
                Price = x.Price, 
                StockQuantity = x.StockQuantity
            }).ToList();
        }
    }
}
