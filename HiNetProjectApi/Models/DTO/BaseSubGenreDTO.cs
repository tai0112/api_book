namespace HiNetProjectApi.Models.DTO
{
    public class BaseSubGenreDTO
    {
        public string Name { get; set; }
        public Guid GenreId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
