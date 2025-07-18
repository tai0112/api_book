using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HiNetProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubGenresController : ControllerBase
    {
        private readonly ISubGenreService subGenreService;

        public SubGenresController(ISubGenreService subGenreService)
        {
            this.subGenreService = subGenreService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] DateTime timeCreate, [FromQuery] DateTime timeUpdate, [FromQuery] string name = "")
        {
            try
            {
                var subGenres = await subGenreService.GetAllAsync();
                return Ok(subGenres);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddSubGenreRequestDTO addSubGenreRequestDTO)
        {
            try
            {
                var subGenre = await subGenreService.CreateAsync(addSubGenreRequestDTO);
                return CreatedAtAction(nameof(Get), new {Id = subGenre.Id}, subGenre);
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
                var subGenre = await subGenreService.GetByIdAsync(id);
                return Ok(subGenre);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message); 
            }
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateSubGenreRequestDTO updateSubGenreRequestDTO)  
        {
            try
            {
                var subGenre = await subGenreService.UpdateAsync(id, updateSubGenreRequestDTO);
                return Ok(subGenre);
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
                var subGenre = await subGenreService.RemoveAsync(id);
                return Ok(subGenre);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
