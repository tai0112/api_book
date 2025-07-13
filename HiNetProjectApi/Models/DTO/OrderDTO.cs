using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Models.DTO
{
    public class OrderDTO
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string Status { get; set; }
        public DateTime CreateAt { get; set; }
        //Navigator properties
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
        public ApplicationUser User { get; set; }
    }
}
