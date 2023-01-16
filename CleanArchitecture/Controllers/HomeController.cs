using Core.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Controllers
{
    public class HomeController : Controller
    {
        IPersonService _service;
        public HomeController(IPersonService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test(int? Id)
        {
            if (Id == null)
            {
                var people = _service.getAllPeople();

                return Json(new { people });
            }
            else
            {
                var person = _service.getById((int)Id);
                return Json(new { person });
            }

        }
    }
}
