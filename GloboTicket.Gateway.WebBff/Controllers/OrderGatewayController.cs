using Microsoft.AspNetCore.Mvc;

namespace GloboTicket.Gateway.WebBff.Controllers
{
    public class OrderGatewayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
