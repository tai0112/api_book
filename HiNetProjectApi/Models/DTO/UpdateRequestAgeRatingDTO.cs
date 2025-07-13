namespace HiNetProjectApi.Models.DTO
{
    public class UpdateRequestAgeRatingDTO : BaseAgeRating
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}
