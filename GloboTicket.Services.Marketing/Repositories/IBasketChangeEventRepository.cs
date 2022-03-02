using GloboTicket.Services.Marketing.Entities;
using System.Threading.Tasks;

namespace GloboTicket.Services.Marketing.Repositories
{
    public interface IBasketChangeEventRepository
    {
        Task AddBasketChangeEvent(BasketChangeEvent basketChangeEvent);
    }
}
