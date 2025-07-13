using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Services;
using HiNetProjectApi.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HiNetProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartDetailsController : ControllerBase
    {
        private readonly ICartDetailService cartDetailService;

        public CartDetailsController(ICartDetailService cartDetailService)
        {
            this.cartDetailService = cartDetailService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromBody] Guid cartId)
        {
            try
            {
                var cartDetails = await cartDetailService.GetAllAsync(cartId);
                return Ok(cartDetails);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            try
            {
                var cartDetail = await cartDetailService.GetByIdAsync(id);
                return Ok(cartDetail);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddCartDetailRequestDTO cartDetailRequestDTO)
        {
            try
            {
                var cartDetail = await cartDetailService.CreateAsync(cartDetailRequestDTO);
                return Ok(cartDetail);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateCartDetailRequestDTO updateCartDetailRequestDTO)
        {
            try
            {
                var cartDetail = await cartDetailService.UpdateAsync(id, updateCartDetailRequestDTO.BookId, updateCartDetailRequestDTO.Quantity);
                return Ok(cartDetail);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
