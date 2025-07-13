using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Repository;
using HiNetProjectApi.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HiNetProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly ICartService cartService;

        public CartsController(ICartService cartService)
        {
            this.cartService = cartService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string userId)
        {
            try
            {
                var carts = await cartService.GetAllAsync(userId);
                return Ok(carts);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> Get([FromBody] Guid id)
        {
            try
            {
                var cart = await cartService.GetByIdAsync(id);
                return Ok(cart);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            try
            {
                var cart = await cartService.RemoveAsync(id);
                return Ok(cart);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateCartRequestDTO updateCartRequestDTO)
        {
            try
            {
                var cart = await cartService.UpdateAsync(id, updateCartRequestDTO);
                return Ok(cart);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddCartRequestDTO addCartRequestDTO)
        {
            try
            {
                var cart = await cartService.CreateAsync(addCartRequestDTO);
                return Ok(cart);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
