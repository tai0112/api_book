namespace HiNetProjectApi.Models.Domain
{
    public class OrderDetail
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid BookId { get; set; }
        public int Quantity { get; set; }
        public float PriceInit { get; set; }
        public float PriceTotal { get; set; }
        //Navigator properties
        public Book Book { get; set; }
    }
}
