using System.Text.Json.Serialization;

namespace HiNetProjectApi.Models.Domain
{
    public class StockQuantity
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public int Quantities { get; set; }
        //Navigator property
    }
}
