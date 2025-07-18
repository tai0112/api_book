using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Repository.IRepository
{
    public interface IAgeRatingRepository
    {
        IQueryable<AgeRating> GetAllAsync();
        Task<AgeRating?> GetByIdAsync(Guid id);
        Task<AgeRating> CreateAsync(AgeRating ageRating);
        Task<AgeRating> UpdateAsync(Guid id, AgeRating ageRating);
        Task<AgeRating?> DeleteAsync(Guid id);
    }
}
