using Core.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PresentationWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationWeb.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
