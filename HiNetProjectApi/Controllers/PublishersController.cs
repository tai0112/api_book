using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace HiNetProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private readonly IPublisherService publisherService;

        public PublishersController(IPublisherService publisherService)
        {
            this.publisherService = publisherService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? name)
        {
            try
            {
                var publishers = await publisherService.GetAllAsync(name);
                return Ok(publishers);
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
                var publisher = await publisherService.GetByIdAsync(id);
                return Ok(publisher);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdatePublisherRequestDTO updatePublisherRequestDTO)
        {
            try
            {
                var publisher = await publisherService.UpdateAsync(id, updatePublisherRequestDTO);
                return Ok(publisher);
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
                var publisher = await publisherService.RemoveAsync(id);
                return Ok(publisher);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddPublisherRequestDTO addPublisherRequestDTO)
        {
            try
            {
                var publisher = await publisherService.CreateAsync(addPublisherRequestDTO);
                return CreatedAtAction(nameof(Get), new { Id = publisher.Id }, publisher);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
