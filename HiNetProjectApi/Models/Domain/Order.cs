namespace HiNetProjectApi.Models.Domain
{
    public class Order
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string Status { get; set; }
        public DateTime CreateAt { get; set; }
        //Navigator properties
        public Payment Payment { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
        public ApplicationUser User { get; set; }
    }
}
