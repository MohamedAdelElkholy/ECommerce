using Microsoft.AspNetCore.Mvc;
using ECommerce.Domain.Entities;
using ECommerce.Application.Interfaces;
using ECommerce.Application.DTOs;
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
    }
}
