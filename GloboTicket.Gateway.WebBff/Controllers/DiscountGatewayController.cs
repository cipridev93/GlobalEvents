using Microsoft.AspNetCore.Mvc;

namespace GloboTicket.Gateway.WebBff.Controllers
{
    public class DiscountGatewayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
