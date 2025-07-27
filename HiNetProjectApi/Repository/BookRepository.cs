using HiNetProjectApi.Data;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Repository.IRepository;
using HiNetProjectApi.Services.IServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HiNetProjectApi.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookEcommerceDbContext db;
        private readonly ILogService logger;

        public BookRepository(BookEcommerceDbContext db, ILogService logger)
        {
            this.db = db;
            this.logger = logger;
        }
        public async Task<Book> CreateAsync(Book book)
        {
            book.CreateAt = DateTime.Now;
            book.PriceBeforeDiscount = book.PriceInit - book.PriceInit * book.Discount / 100;
            await db.Books.AddAsync(book);
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine("Lỗi chi tiết: " + ex.InnerException?.Message);
            }
            return book;
        }

        public IQueryable<Book> GetAllAsync()
        {
            return db.Books.Include(o => o.StockQuantity).Include(o => o.CoverType).Include(o => o.SubGenre).Include(o => o.AgeRating).Include(o => o.Genre).Include(o => o.Publisher).Include(o => o.BookImages).AsNoTracking().AsQueryable();
        }

        public async Task<Book?> GetByIdAsync(Guid id)
        {
            var book = await db.Books.Include(o => o.StockQuantity).Include(o => o.CoverType).Include(o => o.SubGenre).Include(o => o.AgeRating).Include(o => o.Genre).Include(o => o.Publisher).Include(o => o.BookImages).FirstOrDefaultAsync(x => x.Id == id);
            return book;
        }

        public async Task<Book?> RemoveAsync(Guid id)
        {
            var book = await GetByIdAsync(id);
            if (book != null)
            {
                db.Books.Remove(book);
                await db.SaveChangesAsync();
            }
            return book;
        }

        public async Task<Book?> UpdateAsync(Guid id, Book book)
        {
            var bookUpdate = await GetByIdAsync(id);
            if (bookUpdate != null)
            {
                bookUpdate.SubGenre = book.SubGenre;
                bookUpdate.Name = book.Name;
                bookUpdate.Code = bookUpdate.Code;
                bookUpdate.Author = book.Author;
                bookUpdate.YearPublish = book.YearPublish;
                bookUpdate.Discount = book.Discount;
                bookUpdate.PriceInit = book.PriceInit;
                bookUpdate.PriceBeforeDiscount = book.PriceInit - book.PriceInit * book.Discount / 100;
                bookUpdate.IsActived = book.IsActived;
                if (bookUpdate.IsActived)
                {
                    bookUpdate.ActiveAt = DateTime.Now;
                }
                bookUpdate.AgeRatingId = book.AgeRatingId;
                bookUpdate.CoverTypeId = book.CoverTypeId;
                bookUpdate.Language = book.Language;
                bookUpdate.Language = book.Language;
                bookUpdate.Weight = book.Weight;
                bookUpdate.Height = book.Height;
                bookUpdate.UpdateAt = DateTime.Now;
                bookUpdate.Note = book.Note;
                bookUpdate.PageTotal = book.PageTotal;
                bookUpdate.SoldTotal = book.SoldTotal;
                bookUpdate.Description = book.Description;
                bookUpdate.PublisherId = book.PublisherId;
                bookUpdate.Translate = book.Translate;
                await db.SaveChangesAsync();
                return bookUpdate;
            }
            return null;
        }
    }
}
