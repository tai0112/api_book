using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Models.DTO
{
    public class BookDTO
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime ActiveAt { get; set; }
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
        public Guid SubGenreId { get; set; }
        public Guid CoverTypeId { get; set; }
        public Guid AgeRatingId { get; set; }
        public Guid StockQuantityId { get; set; }
        public int SoldTotal { get; set; }
        public string? Translate { get; set; }
        public Guid PublisherId { get; set; }
        //Navigation properties
        public CoverType CoverType { get; set; }
        public StockQuantityDTO StockQuantity { get; set; }
        public SubGenre SubGenre { get; set; }
        public Publisher Publisher { get; set; }
        public AgeRating AgeRating { get; set; }
    }
}
