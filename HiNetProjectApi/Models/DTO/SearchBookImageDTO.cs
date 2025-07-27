namespace HiNetProjectApi.Models.DTO
{
    public class SearchBookImageDTO
    {
        public Guid BookId { get; set; }
        public string? FileName { get; set; } = "";
        public bool? IsMain { get; set; }
    }
}
