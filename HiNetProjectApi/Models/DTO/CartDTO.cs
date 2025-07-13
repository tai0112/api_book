using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Models.DTO
{
    public class CartDTO
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public float TotalPrice { get; set; }
        public IEnumerable<CartDetail> CartDetails { get; set; }
    }
}
