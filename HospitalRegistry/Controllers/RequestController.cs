using Microsoft.AspNetCore.Mvc;

namespace Open.HospitalRegistry.Controllers
{
    public class RequestController : Controller
    {
        public IActionResult Index()
        {
            return View("Request");
        }

        public IActionResult RequestSended()
        {
            return View();
        }
    }
}