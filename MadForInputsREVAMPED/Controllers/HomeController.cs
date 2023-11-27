using MadForInputsREVAMPED.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MadForInputsREVAMPED.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult DisplayMadlib()
        {
            Madlib madlib = new Madlib(Request.Form["NameBox"], Request.Form["LocationBox"],
                Request.Form["VerbBox"], Request.Form["AdverbBox"],
                Request.Form["AdjectiveBox"]);
            return View(madlib);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}