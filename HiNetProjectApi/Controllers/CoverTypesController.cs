using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic;

namespace HiNetProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoverTypesController : ControllerBase
    {
        private readonly ICoverTypeService coverTypeService;

        public CoverTypesController(ICoverTypeService coverTypeService)
        {
            this.coverTypeService = coverTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? name = null)
        {
            try
            {
                var coverTypes = await coverTypeService.GetAllAsync(name);
                return Ok(coverTypes);
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
                var coverType = await coverTypeService.GetByIdAsync(id);
                return Ok(coverType);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddCoverTypeRequestDTO addCoverTypeRequestDTO)
        {
            try
            {
                var coverType = await coverTypeService.CreateAsync(addCoverTypeRequestDTO);
                return CreatedAtAction(nameof(Get), new {Id = coverType.Id}, coverType);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateCoverTypeRequestDTO updateCoverTypeRequestDTO)
        {
            try
            {
                var coverType = await coverTypeService.UpdateAsync(id, updateCoverTypeRequestDTO);
                return Ok(coverType);
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
                var coverTage = await coverTypeService.RemoveAsync(id);
                return Ok(coverTage);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 
    }
}
