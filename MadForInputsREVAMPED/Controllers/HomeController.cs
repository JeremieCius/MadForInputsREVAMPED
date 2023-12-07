using MadForInputsREVAMPED.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MadForInputsREVAMPED.Areas.Identity.User;
using MadForInputsREVAMPED.Data;
using MadForInputsREVAMPED.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace MadForInputsREVAMPED.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<MadlibUser> _userManager;

        IDataAccessLayer dal;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IDataAccessLayer indal, MadlibContext inContext, UserManager<MadlibUser> userManager)
        {
            _logger = logger;
            this._userManager = userManager;
            this.dal = indal;
            if (inContext.GetType() == typeof(MadlibDAL))
            {
                ((MadlibDAL)dal).db = inContext;
            }
        }

        public IActionResult DisplayMadlibs()
        {
            
            return View("Index", dal.GetMadlibs());
        }
        [HttpPost]

        public IActionResult SearchMadlib()
        {
            return View("Index", dal.SearchMadlibs(Request.Form["txtSearch"]));
        }
        [HttpPost]

        public IActionResult FilterMadlibs()
        {
            //return View("Index", dal.FilterMadlibs());
            return null;
        }


        [HttpPost]
        public IActionResult DisplayMadlib()
        {
            Madlib madlib = new Madlib();
            return View("DisplayMadlib", madlib);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}