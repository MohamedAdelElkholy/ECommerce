using Microsoft.AspNetCore.Mvc;
using ECommerce.Domain.Entities;
using ECommerce.Application.Interfaces;
using ECommerce.Application.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductsController (IProductService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDto dto)
        {
            var result = await _service.CreateAsync(dto);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Products =await _service.GetAllAsync();
            return Ok(Products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var Product = await _service.GetByIdAsync(id);
            if (Product == null)           
                return NotFound();

                return Ok(Product);        
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CreateProductDto createProductDto)
        {
            var Product = await _service.UpdateAsync(id,createProductDto);
            if (Product == null)
                return NotFound();

            return Ok(Product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult>Delete(int id)
        {
            var DeleteProduct = await _service.DeleteAsync(id);
            if (!DeleteProduct)
                return NotFound();
            return NoContent();
        }
    }
}
