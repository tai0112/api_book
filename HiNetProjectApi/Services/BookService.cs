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
        private readonly IBookImageService bookImageService;
        private readonly ILogService logger;
        private readonly IStockQuantityService stockQuantityService;

        public BookService(IBookRepository bookRepository, IValidator<AddBookRequestDTO> addValidator, IValidator<UpdateBookRequestDTO> updateValidator, IMapper mapper, IBookImageService bookImageService, ILogService logger, IStockQuantityService stockQuantityService)
        {
            this.bookRepository = bookRepository;
            this.addValidator = addValidator;
            this.updateValidator = updateValidator;
            this.mapper = mapper;
            this.bookImageService = bookImageService;
            this.logger = logger;
            this.stockQuantityService = stockQuantityService;
        }
        public async Task<BookDTO> CreateAsync(AddBookRequestDTO addBookRequestDTO)
        {
            var validation = addValidator.Validate(addBookRequestDTO);
            if (!validation.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validation.Errors));
            }
            try
            {
                var bookDomain = mapper.Map<Book>(addBookRequestDTO);
                bookDomain.Code = GenerateProductCode();
                var book = await bookRepository.CreateAsync(bookDomain);
                await stockQuantityService.CreateAsync(new AddStockQuantityDTO
                {
                    BookId = book.Id,
                    Quantities = 0,
                });
                return mapper.Map<BookDTO>(book);
            }
            catch (DbUpdateException ex)
            {
                logger.Error(ex.InnerException.Message, "Error updating book", ex.Message);
                throw;
            }
        }
        public async Task<IEnumerable<BookDTO>> GetAllAsync(SearchBookDTO search)
        {
            var books = bookRepository.GetAllAsync();
            if (search != null)
            {
                if (!string.IsNullOrEmpty(search.Name))
                {
                    books = books.Where(o => o.Name == search.Name);
                }

                if (!string.IsNullOrEmpty(search.Code))
                {
                    books = books.Where(o => o.Code == search.Code);
                }

                if (!string.IsNullOrEmpty(search.Note))
                {
                    books = books.Where(o => o.Note == search.Note);
                }

                if (!string.IsNullOrEmpty(search.Author))
                {
                    books = books.Where(o => o.Author == search.Author);
                }

                if (!string.IsNullOrEmpty(search.Description))
                {
                    books = books.Where(o => o.Description == search.Description);
                }

                if (!string.IsNullOrEmpty(search.Language))
                {
                    books = books.Where(o => o.Language == search.Language);
                }

                if (search.CoverType != Guid.Empty)
                {
                    books = books.Where(o => o.CoverType.Id == search.CoverType);
                }

                if (!string.IsNullOrEmpty(search.SubGenreId))
                {
                    books = books.Where(o => o.SubGenre.Name == search.SubGenreId);
                }

                if (!string.IsNullOrEmpty(search.Publisher))
                {
                    books = books.Where(o => o.Publisher.Name == search.Publisher);
                }

                if (search.AgeRating != Guid.Empty)
                {
                    books = books.Where(o => o.AgeRating.Id == search.AgeRating);
                }

                if (search.Price > 0)
                {
                    books = books.Where(o => o.PriceInit.Equals(search.Price) || o.PriceBeforeDiscount.Equals(search.Price));
                }

                if (search.PageTotal > 0)
                {
                    books = books.Where(o => o.PageTotal == (search.PageTotal));
                }
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
            var search = new SearchBookImageDTO()
            {
                BookId = id,
            };
            try
            {
                await bookImageService.RemoveRange(search);
                await stockQuantityService.RemoveAsyncByBookId(search.BookId);
                return mapper.Map<BookDTO>(book);
            }
            catch (DbUpdateException ex)
            {
                logger.Error(ex.InnerException.Message, "Error updating book with ID: {Id}", id);
                throw;
            }
        }

        public async Task<BookDTO?> UpdateAsync(Guid id, UpdateBookRequestDTO updateBookRequestDTO)
        {
            var validation = updateValidator.Validate(updateBookRequestDTO);
            if (!validation.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validation.Errors));
            }

            try
            {
                var bookDomain = mapper.Map<Book>(updateBookRequestDTO);
                var book = await bookRepository.UpdateAsync(id, bookDomain);

                if (book == null)
                {
                    logger.Warn("Không tìm thấy thông tin sách cần cập nhật", id);
                    return null;
                }

                return mapper.Map<BookDTO>(book);
            }
            catch (DbUpdateException ex)
            {
                logger.Error(ex.InnerException.Message, "Error updating book with ID: {Id}", id);
                throw;
            }
        }

        public string GenerateProductCode()
        {
            var timestamp = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff"); // ví dụ: 20250724123501234
            return $"SP-{timestamp}";
        }
    }
}
