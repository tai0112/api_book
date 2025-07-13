namespace HiNetProjectApi.Models.DTO
{
    public class BaseOrderDetailDTO
    {
        public Guid OrderId { get; set; }
        public Guid BookId { get; set; }
        public int Quantity { get; set; }
        public float PriceInit { get; set; }
        public float PriceTotal { get; set; }
    }
}
