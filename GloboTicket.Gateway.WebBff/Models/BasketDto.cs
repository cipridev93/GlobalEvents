using System;

namespace GloboTicket.Gateway.WebBff.Models
{
    public class BasketDto
    {
        public Guid BasketId { get; set; }
        public Guid UserId { get; set; }
        public int NumberOfItems { get; set; }
        public string Code { get; set; }
        public int Discount { get; set; }
        public Guid? CouponId { get; set; }
    }
}
