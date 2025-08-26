namespace HiNetProjectApi.Models.DTO
{
    public class SearchStockQuantitiesDTO
    {
        public Guid? BookId { get; set; }
        public int Quantities { get; set; } = 0;
    }
}
