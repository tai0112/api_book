﻿namespace HiNetProjectApi.Models.DTO
{
    public class CartDetailDTO
    {
        public Guid Id { get; set; }
        public Guid CartId { get; set; }
        public Guid BookId { get; set; }
        public int Quantity { get; set; }
        public float PriceInit { get; set; }
        public float PriceTotal { get; set; }
    }
}
