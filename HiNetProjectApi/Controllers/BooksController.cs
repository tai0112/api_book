﻿using HiNetProjectApi.Data;
using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HiNetProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService bookService;

        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] Guid? ageRating = null, [FromQuery] Guid? coverType = null, [FromQuery] string? name = "", [FromQuery] string? code = "", [FromQuery] string? note = "", [FromQuery] string? author = "", [FromQuery] string? description = "", [FromQuery] string? language = "", [FromQuery] float price = 0, [FromQuery] int pageTotal = 0, [FromQuery] string publisher = "", [FromQuery] string? subGenre = "")
        {
            try
            {
                var books = await bookService.GetAllAsync();
                return Ok(books);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddBookRequestDTO addBookRequestDTO)
        {
            try
            {
                var book = await bookService.CreateAsync(addBookRequestDTO);
                return Ok(book);
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
                var book = await bookService.RemoveAsync(id);
                return Ok(book);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateBookRequestDTO updateBookRequestDTO)
        {
            try
            {
                var book = await bookService.UpdateAsync(id, updateBookRequestDTO);
                return Ok(book);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
