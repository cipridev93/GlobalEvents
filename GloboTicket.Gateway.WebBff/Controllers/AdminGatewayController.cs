using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloboTicket.Gateway.WebBff.Controllers
{
    public class AdminGatewayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
