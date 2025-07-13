namespace HiNetProjectApi.Models.Domain
{
    public class CartDetail
    {
        public Guid Id { get; set; }
        public Guid CartId { get; set; }
        public Guid BookId { get; set; }
        public int Quantity { get; set; }
        public float PriceInit { get; set; }
        public float PriceTotal { get; set; }
    }
}
