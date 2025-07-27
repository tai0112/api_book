using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Repository.IRepository;
using HiNetProjectApi.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HiNetProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookImagesController : ControllerBase
    {
        private readonly IBookImageService bookImageService;

        public BookImagesController(IBookImageService bookImageService)
        {
            this.bookImageService = bookImageService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] SearchBookImageDTO search)
        {
            try
            {
                var images = await bookImageService.GetImagesAsync(search);
                return Ok(images);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message,ex);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] AddBookImageRequestDTO addBookImageRequest)
        {
            ValidateFileUpload(addBookImageRequest);
            if (ModelState.IsValid)
            {
                var bookImage = await bookImageService.CreateAsync(addBookImageRequest);
                return Ok(bookImage);
            }
            return BadRequest(ModelState);
        }

        private void ValidateFileUpload(AddBookImageRequestDTO request)
        {
            var allowedExtensions = new List<string> { ".jpg", ".jpeg", ".png", ".gif", ".webp" };

            if (!allowedExtensions.Contains(Path.GetExtension(request.File.FileName)))
            {
                ModelState.AddModelError("file", "File type is not valid");
            }

            if (request.File.Length > 10 * 1024 * 1024)
            {
                ModelState.AddModelError("file", "File size is too large");
            }
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Remove([FromRoute] Guid id)
        {
            try
            {
                var bookImage = await bookImageService.DeleteAsync(id);
                return Ok(bookImage);
            }catch (Exception ex)
            {
                return BadRequest("Something went wrong: " + ex.Message);
            }
        }
    }
}
