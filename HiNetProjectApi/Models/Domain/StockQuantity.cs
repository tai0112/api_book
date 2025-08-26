using System.Text.Json.Serialization;

namespace HiNetProjectApi.Models.Domain
{
    public class StockQuantity
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public int Quantities { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        //Navigator property
        [JsonIgnore]
        public Book Book { get; set; }
    }
}
