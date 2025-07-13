using System.Reflection.Emit;
using AutoMapper;
using FluentValidation;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Repository.IRepository;
using HiNetProjectApi.Services;
using HiNetProjectApi.Services.IServices;
using HiNetProjectApi.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HiNetProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreService genreService;

        public GenresController(IGenreService genreService)
        {
            this.genreService = genreService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string name = "")
        {
            try
            {
                var genres = await genreService.GetAllAsync(name);
                return Ok(genres);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddRequestGenreDTO genreDTO)
        {
            try
            {
                var genre = await genreService.CreateAsync(genreDTO);
                return CreatedAtAction(nameof(Get), new { Id = genre.Id }, genre);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRequestGenreDTO updateRequestGenreDTO)
        {
            try
            {
                var genre = await genreService.UpdateAsync(id, updateRequestGenreDTO);
                return Ok(genre);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            try
            {
                var genre = await genreService.GetByIdAsync(id);
                return Ok(genre);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            try
            {
                var genre = await genreService.DeleteAsync(id);
                return Ok();
            }catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
