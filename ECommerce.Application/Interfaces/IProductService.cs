using ECommerce.Application.DTOs;

namespace ECommerce.Application.Interfaces
{
    public interface IProductService
    {
        Task<ProductDto> CreateAsync(CreateProductDto dto);
        Task<List<ProductDto>> GetAllAsync();
        Task<ProductDto> GetByIdAsync(int id);
        Task<ProductDto> UpdateAsync(int id, CreateProductDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
