using HiNetProjectApi.Data;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace HiNetProjectApi.Repository
{
    public class BookImageRepository : IBookImageRepository
    {
        private readonly BookEcommerceDbContext db;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IHttpContextAccessor httpContextAccessor;

        public BookImageRepository(BookEcommerceDbContext db, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)
        {
            this.db = db;
            this.webHostEnvironment = webHostEnvironment;
            this.httpContextAccessor = httpContextAccessor;
        }
        public async Task<BookImage> CreateAsync(BookImage bookImage)
        {
            var localPath = Path.Combine(webHostEnvironment.ContentRootPath, "Images", $"{bookImage.FileName}{bookImage.FileExtension}");

            //Upload image to local path
            using var stream = new FileStream(localPath, FileMode.Create);
            await bookImage.File.CopyToAsync(stream);

            //Upload image to database
            var userFilePath = $"{httpContextAccessor.HttpContext.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}{httpContextAccessor.HttpContext.Request.PathBase}/Images/{bookImage.FileName}{bookImage.FileExtension}";
            bookImage.FilePath = userFilePath;
            //Add to database

            await db.BookImages.AddAsync(bookImage);
            await db.SaveChangesAsync();
            return bookImage;
        }

        public async Task<BookImage?> DeleteAsync(Guid id)
        {
            var bookImage = await GetByIdAsync(id);
            if (bookImage != null)
            {
                db.BookImages.Remove(bookImage);
                await db.SaveChangesAsync();
            }
            return bookImage;
        }

        public async Task<IEnumerable<BookImage>> GetAllAsync(Guid? bookId, bool? isMain, string? fileName = "")
        {
            var bookImages = db.BookImages.AsQueryable();
            if (bookId != Guid.Empty)
            {
                bookImages = bookImages.Where(o => o.BookId  == bookId);
            }

            if (isMain != null)
            {
                bookImages = bookImages.Where(o => o.IsMain == isMain);
            }

            if (!string.IsNullOrEmpty(fileName))
            {
                bookImages = bookImages.Where(o => o.FileName == fileName);
            }

            return await bookImages.ToListAsync();
        }

        public async Task<BookImage?> GetByIdAsync(Guid id)
        {
            var bookImage = await db.BookImages.FindAsync(id);
            return bookImage;
            
        }

        public async Task<BookImage?> UpdateAsync(Guid id, BookImage bookImage)
        {
            var bookImageUpdate = await GetByIdAsync(id);
            if (bookImageUpdate != null)
            {
                bookImageUpdate.IsMain = bookImage.IsMain;
                await db.SaveChangesAsync();
            }
            return bookImageUpdate;
        }
    }
}
