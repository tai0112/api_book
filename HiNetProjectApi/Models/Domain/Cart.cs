using System.Text.Json.Serialization;

namespace HiNetProjectApi.Models.Domain
{
    public class Cart
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public float TotalPrice { get; set; }
        [JsonIgnore]
        public ApplicationUser User { get; set; }
        public IEnumerable<CartDetail> CartDetails { get; set; }
    }
}
