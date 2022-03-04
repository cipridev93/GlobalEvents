using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GloboTicket.Gateway.WebBff.Models;
using Microsoft.AspNetCore.Mvc;

namespace GloboTicket.Gateway.WebBff.Services
{
    public interface ICatalogService
    {
        Task<List<EventDto>> GetEventsPerCategory(Guid categoryId);
        Task<EventDto> GetEventById(Guid eventId);
        Task<List<CategoryDto>> GetAllCategories();
        Task<List<EventDto>> GetAllEvents();
        Task<ActionResult<PriceUpdateDto>> UpdatePrice(PriceUpdateDto priceUpdate);
    }
}