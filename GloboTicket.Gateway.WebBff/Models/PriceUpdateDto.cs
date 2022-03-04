using System;

namespace GloboTicket.Gateway.WebBff.Models
{
    public class PriceUpdateDto
    {
        public Guid EventId { get; set; }
        public int Price { get; set; }
    }
}
