using ECommerce.Application.DTOs;

namespace ECommerce.Application.Interfaces
{
    public interface IProductService
    {
        Task<ProductDto> CreateAsync(CreateProductDto dto);
        Task<List<ProductDto>> GetAllAsync();
    }
}
