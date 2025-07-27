using AutoMapper;
using FluentValidation;
using HiNetProjectApi.Helpers;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Repository.IRepository;
using HiNetProjectApi.Services.IServices;
using HiNetProjectApi.Validators;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace HiNetProjectApi.Services
{
    public class BookImageService : IBookImageService
    {
        private readonly IBookImageRepository bookImageRepository;
        private readonly IMapper mapper;
        private readonly BookImageAddValidator addValidator;
        private readonly BookImageUpdateValidator updateValidator;

        public BookImageService(IBookImageRepository bookImageRepository, IMapper mapper, BookImageAddValidator addValidator, BookImageUpdateValidator updateValidator)
        {
            this.bookImageRepository = bookImageRepository;
            this.mapper = mapper;
            this.addValidator = addValidator;
            this.updateValidator = updateValidator;
        }

        public async Task<BookImageDTO> CreateAsync(AddBookImageRequestDTO image)
        {
            var validation = addValidator.Validate(image);
            if (!validation.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validation.Errors));
            }

            var bookImageDomain = new BookImage
            {
                File = image.File,
                FileName = image.File.Name,
                FileDescription = image.File.FileName,
                FileExtension = Path.GetExtension(image.File.FileName),
                IsMain = false,
                BookId = image.BookId
            };
            var imageCreated = await bookImageRepository.CreateAsync(bookImageDomain);
            return mapper.Map<BookImageDTO>(imageCreated);
        }

        public async Task<BookImageDTO> DeleteAsync(Guid id)
        {
            var bookImage = await bookImageRepository.DeleteAsync(id);
            return mapper.Map<BookImageDTO>(bookImage);
        }

        public async Task<BookImageDTO> GetImageAsync(Guid id)
        {
            var bookImage = await bookImageRepository.GetByIdAsync(id);
            return mapper.Map<BookImageDTO>(bookImage);
        }

        public async Task<IEnumerable<BookImageDTO>> GetImagesAsync(SearchBookImageDTO search)
        {
            var bookImages = bookImageRepository.GetAllAsync();
            if (search != null)
            {
                if (!string.IsNullOrEmpty(search.FileName))
                {
                    bookImages = bookImages.Where(x => x.FileName == search.FileName);
                }
                if (search.BookId != Guid.Empty)
                {
                    bookImages = bookImages.Where(x => x.BookId == search.BookId);
                }
                if (search.IsMain != null)
                {
                    bookImages = bookImages.Where((x) => x.IsMain);
                }
            }

            var bookImageList = await bookImages.ToListAsync();
            return mapper.Map<IEnumerable<BookImageDTO>>(bookImageList);
        }

        public async Task RemoveRange(SearchBookImageDTO search)
        {
            var bookImages = await GetImagesAsync(search);
            if (bookImages != null)
            {
                foreach(var image in bookImages)
                {
                    await bookImageRepository.DeleteAsync(image.Id);
                }
            }
        }

        public async Task<BookImageDTO> UpdateAsync(Guid id, UpdateBookImageRequestDTO image)
        {
            var validation = updateValidator.Validate(image);
            if (!validation.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validation.Errors));
            }

            var imageDomain = mapper.Map<BookImage>(image);
            var bookImageUpdated = await bookImageRepository.UpdateAsync(id, imageDomain);
            return mapper.Map<BookImageDTO>(bookImageUpdated);

        }
    }
}
