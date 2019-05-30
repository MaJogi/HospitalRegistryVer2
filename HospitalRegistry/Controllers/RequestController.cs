using Microsoft.AspNetCore.Mvc;

namespace Open.HospitalRegistry.Controllers
{
    public class RequestController : Controller
    {
        //[ActionName("CreateRequest")]
        public IActionResult Index()
        {
            return View("CreateRequest");
        }

        public IActionResult RequestSent()
        {
            return View();
        }
    }
}