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
        public async Task<ProductDto?> GetByIdAsync(int id)
        {
            var product = await _repository.GetByIdAsync(id);
            if (product == null)
                return null;
            return new ProductDto
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                StockQuantity = product.StockQuantity
            };
        }
        public async Task<ProductDto> UpdateAsync(int id, CreateProductDto dto)
        {
            var product = await _repository.GetByIdAsync(id);
            if (product == null)
                return null;
            product.Name = dto.Name;
            product.Description = dto.Description;
            product.Price = dto.Price;
            product.StockQuantity = dto.StockQuantity;

            await _repository.UpdateAsync(product);
            return new ProductDto
            {
                Name = product.Name,
                Description= product.Description,
                Price = product.Price,
                StockQuantity = product.StockQuantity
            };
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var product = await _repository.GetByIdAsync(id);
            if (product == null)
                return false;
            await _repository.DeleteAsync(id); 
            return true;
        }
    }
}
