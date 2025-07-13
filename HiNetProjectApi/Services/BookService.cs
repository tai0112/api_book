using AutoMapper;
using FluentValidation;
using HiNetProjectApi.Helpers;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Repository.IRepository;
using HiNetProjectApi.Services.IServices;

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
            var books = await bookRepository.GetAllAsync(ageRating, coverType, name, code, note, author, description, language, price, pageTotal, publisher);   
            return mapper.Map<IEnumerable<BookDTO>>(books);
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
