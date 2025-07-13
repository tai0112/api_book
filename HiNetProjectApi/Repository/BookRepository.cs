using HiNetProjectApi.Data;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace HiNetProjectApi.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookEcommerceDbContext db;

        public BookRepository(BookEcommerceDbContext db)
        {
            this.db = db;
        }
        public async Task<Book> CreateAsync(Book book)
        {
            book.CreateAt = DateTime.Now;
            book.PriceBeforeDiscount = book.PriceInit - book.PriceInit * book.Discount / 100;
            await db.Books.AddAsync(book);
            await db.SaveChangesAsync();
            return book;
        }

        public async Task<IEnumerable<Book>> GetAllAsync(Guid? ageRating, Guid? coverType, string? name = "", string? code = "", string? note = "", string? author = "", string? description = "", string? language = "", float price = 0, int pageTotal = 0, string publisher = "", string? subGenre = "")
        {
            var books = db.Books.Include(o => o.StockQuantity).Include(o => o.CoverType).Include(o => o.SubGenre).Include(o => o.AgeRating).Include(o => o.Publisher).AsQueryable();
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


            return await books.ToListAsync();
        }

        public async Task<Book?> GetByIdAsync(Guid id)
        {
            var book = await db.Books.FindAsync(id);
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
                bookUpdate.Code = book.Code;
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
            }
            return book;
        }
    }
}
