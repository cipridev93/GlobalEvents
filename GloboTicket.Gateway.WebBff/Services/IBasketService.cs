using GloboTicket.Gateway.WebBff.Models;
using System;
using System.Threading.Tasks;

namespace GloboTicket.Gateway.WebBff.Services
{
    public interface IBasketService
    {
        Task<BasketDto> GetBasket(Guid basketId);
    }
}