using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Services.IServices
{
    public interface IAgeRatingService
    {
        public Task<IEnumerable<AgeRatingDTO?>> GetAgeRatingsAsync(string name = "", string description = "");
        public Task<AgeRatingDTO?> GetAgeRatingAsync(Guid id);
        public Task<AgeRatingDTO> CreateAsync(AddAgeRatingRequestDTO ageRatingDTO);
        public Task<AgeRatingDTO> UpdateAsync(Guid id, UpdateRequestAgeRatingDTO ageRatingDTO);
        public Task<AgeRatingDTO> RemoveAsync(Guid id);
    }
}
