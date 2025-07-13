namespace HiNetProjectApi.Models.Domain
{
    public class Genre
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public IEnumerable<SubGenre> SubGenres { get; set; }
    }
}
