using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Models.DTO
{
    public class StockQuantityDTO
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public int Quantities { get; set; }
        //Navigator property
        public Book Book { get; set; }
    }
}
