namespace HiNetProjectApi.Models.Domain
{
    public class Payment
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public DateTime CreateAt { get; set; }
        public Guid OderId { get; set; }
        public string PaidMethod { get; set; }
        public float PriceTotal { get; set; }
        public string? Note { get; set; }
        //Navigator properties
        public ApplicationUser User { get; set; }
        public Order Order { get; set; }
    }
}
