using AutoMapper;
using FluentValidation;
using HiNetProjectApi.Helpers;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Repository.IRepository;
using HiNetProjectApi.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace HiNetProjectApi.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;
        private readonly IValidator<AddBookRequestDTO> addValidator;
        private readonly IValidator<UpdateBookRequestDTO> updateValidator;
        private readonly IMapper mapper;

        public BookService(IBookRepository bookRepository, IValidator<AddBookRequestDTO> addValidator, IValidator<UpdateBookRequestDTO> updateValidator, IMapper mapper)
        {
            this.bookRepository = bookRepository;
            this.addValidator = addValidator;
            this.updateValidator = updateValidator;
            this.mapper = mapper;
        }
        public async Task<BookDTO> CreateAsync(AddBookRequestDTO addBookRequestDTO)
        {
            var validation = addValidator.Validate(addBookRequestDTO);
            if (!validation.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validation.Errors));
            }

            var bookDomain = mapper.Map<Book>(addBookRequestDTO);
            var book = await bookRepository.CreateAsync(bookDomain);
            return mapper.Map<BookDTO>(book);
        }

        public async Task<IEnumerable<BookDTO>> GetAllAsync(Guid? ageRating, Guid? coverType, string? name = "", string? code = "", string? note = "", string? author = "", string? description = "", string? language = "", float price = 0, int pageTotal = 0, string publisher = "", string? subGenre = "")
        {
            var books = bookRepository.GetAllAsync();
            if (!string.IsNullOrEmpty(name))
            {
                books = books.Where(o => o.Name == name);
            }

            if (!string.IsNullOrEmpty(code))
            {
                books = books.Where(o => o.Code == code);
            }

            if (!string.IsNullOrEmpty(note))
            {
                books = books.Where(o => o.Note == note);
            }

            if (!string.IsNullOrEmpty(author))
            {
                books = books.Where(o => o.Author == author);
            }

            if (!string.IsNullOrEmpty(description))
            {
                books = books.Where(o => o.Description == description);
            }

            if (!string.IsNullOrEmpty(language))
            {
                books = books.Where(o => o.Language == language);
            }

            if (coverType != Guid.Empty && coverType != null)
            {
                books = books.Where(o => o.CoverType.Id == coverType);
            }

            if (!string.IsNullOrEmpty(subGenre))
            {
                books = books.Where(o => o.SubGenre.Name == subGenre);
            }

            if (!string.IsNullOrEmpty(publisher))
            {
                books = books.Where(o => o.Publisher.Name == publisher);
            }

            if (ageRating != Guid.Empty && ageRating != null)
            {
                books = books.Where(o => o.AgeRating.Id == ageRating);
            }

            if (price > 0)
            {
                books = books.Where(o => o.PriceInit.Equals(price) || o.PriceBeforeDiscount.Equals(price));
            }

            if (pageTotal > 0)
            {
                books = books.Where(o => o.PageTotal.Equals(pageTotal));
            }

            var result = await books.ToListAsync();
            return mapper.Map<IEnumerable<BookDTO>>(result);
        }

        public async Task<BookDTO?> GetByIdAsync(Guid id)
        {
            var book = await bookRepository.GetByIdAsync(id);
            return mapper.Map<BookDTO>(book);
        }

        public async Task<BookDTO?> RemoveAsync(Guid id)
        {
            var book = await bookRepository.RemoveAsync(id);
            return mapper.Map<BookDTO>(book);
        }

        public async Task<BookDTO?> UpdateAsync(Guid id, UpdateBookRequestDTO updateBookRequestDTO)
        {
            var validation = updateValidator.Validate(updateBookRequestDTO);
            if (!validation.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validation.Errors));
            }

            var bookDomain = mapper.Map<Book>(updateBookRequestDTO);
            var book = await bookRepository.UpdateAsync(id, bookDomain);
            return mapper.Map<BookDTO>(book);
        }
    }
}
