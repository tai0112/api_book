using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Models.DTO
{
    public class BasePaymentDTO
    {
        public Guid UserId { get; set; }
        public DateTime CreateAt { get; set; }
        public Guid OderId { get; set; }
        public float PriceTotal { get; set; }
        public string? Note { get; set; }
    }
}
