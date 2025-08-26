using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HiNetProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockQuantitiesController : ControllerBase
    {
        private readonly IStockQuantityService stockQuantityService;

        public StockQuantitiesController(IStockQuantityService stockQuantityService)
        {
            this.stockQuantityService = stockQuantityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] SearchStockQuantitiesDTO search)
        {
            try
            {
                var stockQuantities = await stockQuantityService.GetAllAsync(search);
                return Ok(stockQuantities);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            try
            {
                var stockQuantity = await stockQuantityService.GetByIdAsync(id);
                return Ok(stockQuantity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddStockQuantityDTO addStockQuantityDTO)
        {
            try
            {
                var stockQuantity = await stockQuantityService.CreateAsync(addStockQuantityDTO);
                return CreatedAtAction(nameof(Get), new { Id = stockQuantity.Id }, stockQuantity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateStockQuantityRequestDTO updateStockQuantityRequestDTO)
        {
            try
            {
                var stockQuantity = await stockQuantityService.UpdateAsync(id, updateStockQuantityRequestDTO);
                return Ok(stockQuantity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            try
            {
                var stockQuantity = await stockQuantityService.RemoveAsync(id);
                return Ok(stockQuantity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
