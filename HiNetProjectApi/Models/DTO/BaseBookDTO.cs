namespace HiNetProjectApi.Models.DTO
{
    public class BaseBookDTO
    {
        public string Name { get; set; }
        public string Note { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public float Height { get; set; }
        public float Witdh { get; set; }
        public int Discount { get; set; }
        public float PriceInit { get; set; }
        public float PriceBeforeDiscount { get; set; }
        public float Weight { get; set; }
        public int PageTotal { get; set; }
        public int YearPublish { get; set; }
        public bool IsActived { get; set; }
        public Guid? SubGenreId { get; set; }
        public Guid? GenreId { get; set; }
        public Guid? CoverTypeId { get; set; }
        public Guid AgeRatingId { get; set; }
        public int SoldTotal { get; set; }
        public string? Translate { get; set; }
        public Guid PublisherId { get; set; }
    }
}
