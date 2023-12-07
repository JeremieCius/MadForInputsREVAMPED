using MadForInputsREVAMPED.Areas.Identity.Data;
using MadForInputsREVAMPED.Interfaces;
using MadForInputsREVAMPED.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MadForInputsREVAMPED.Data;

namespace MadForInputsREVAMPED.Controllers
{
    public class MadlibController : Controller
    {
        private readonly UserManager<MadlibUser> _userManager;

        IDataAccessLayer dal;


        public MadlibController(IDataAccessLayer indal, MadlibContext inContext, UserManager<MadlibUser> userManager)
        {
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