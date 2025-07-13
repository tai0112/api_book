using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Models.DTO
{
    public class PaymentDTO
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreateAt { get; set; }
        public Guid OderId { get; set; }
        public float PriceTotal { get; set; }
        public string? Note { get; set; }
        //Navigator properties
        public ApplicationUser User { get; set; }
        public Order Order { get; set; }
    }
}
