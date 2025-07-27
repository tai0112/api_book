using Microsoft.AspNetCore.Mvc;

namespace HiNetProjectApi.Models.DTO
{
    public class SearchBookDTO
    {
        public Guid CoverType { get; set; }
        public Guid AgeRating{ get; set; }
        public string Name { get; set; } = "";
        public string Code { get; set; } = "";
        public string Note { get; set; } = "";
        public string Author { get; set; } = "";
        public string Description { get; set; } = "";
        public string Language { get; set; } = "";
        public float Price { get; set; }
        public int PageTotal { get; set; }
        public string Publisher { get; set; } = "";
        public string SubGenreId { get; set; } = "";
        public string GenreId { get; set; } = "";

    }
}
