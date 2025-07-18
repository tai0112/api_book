using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HiNetProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgeRatingsController : ControllerBase
    {
        private readonly IAgeRatingService ageRatingService;

        public AgeRatingsController(IAgeRatingService ageRatingService)
        {
            this.ageRatingService = ageRatingService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string name = "", [FromQuery] string description = "")
        {
            try
            {
                var ageRatings = await ageRatingService.GetAgeRatingsAsync(name, description);
                return Ok(ageRatings);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetAsync([FromRoute] Guid id)
        {
            try
            {
                var ageRating = await ageRatingService.GetAgeRatingAsync(id);
                return Ok(ageRating);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] AddAgeRatingRequestDTO addAgeRatingRequestDTO)
        {
            try
            {
                var ageRating = await ageRatingService.CreateAsync(addAgeRatingRequestDTO);
                return CreatedAtAction(nameof(GetAsync), new { Id = ageRating.Id }, ageRating);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateAsync([FromRoute] Guid id,[FromBody] UpdateRequestAgeRatingDTO updateAgeRatingRequestDTO)
        {
            try
            {
                var ageRating = await ageRatingService.UpdateAsync(id, updateAgeRatingRequestDTO);
                return Ok(ageRating);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> RemoveAsync([FromRoute] Guid id)
        {
            try
            {
                var ageRating = await ageRatingService.RemoveAsync(id);
                return Ok(ageRating);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
