using ECommerce.Application.DTOs;


namespace ECommerce.Application.DTOs
{
    public class CreateProductDto
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}