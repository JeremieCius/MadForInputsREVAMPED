using MadForInputsREVAMPED.Areas.Identity.Data;
using MadForInputsREVAMPED.Interfaces;
using MadForInputsREVAMPED.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MadForInputsREVAMPED.Data;
using System.Security.Claims;

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

            return View("MadlibCollection", dal.GetMadlibs());
        }
        [HttpPost]

        public IActionResult SearchMadlib()
        {
            return View("MadlibCollection", dal.SearchMadlibs(Request.Form["txtSearch"]));
        }
        [HttpPost]

        public IActionResult FilterMadlibs()
        {
            //return View("Index", dal.FilterMadlibs());
            return null;
        }

        public IActionResult CreateMadlibPage(MadLibViewModel viewModel)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return Redirect("/Identity/Account/Login");
            }

            return View("CreateMadlib", viewModel);
        }

        [HttpPost]
        public IActionResult GenerateMadlib(MadLibViewModel madLibViewModel)
        {
            var loggedInUser = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Madlib madlib = new Madlib();
            madlib.AuthorId = loggedInUser;
            if (madLibViewModel.RandomTemplate != null)
            {
                madlib.Story = madLibViewModel.RandomTemplate.ToString();
                madlib.Genre = "random";
                madlib.Title = madLibViewModel.RandomTemplate.NounFour;
            } else if (madLibViewModel.ComedyTemplate != null)
            {
                madlib.Story = madLibViewModel.ComedyTemplate.ToString();
                madlib.Genre = "comedy";
                madlib.Title = madLibViewModel.ComedyTemplate.AnythingOne;
            }
            else if (madLibViewModel.AdventureTemplate != null)
            {
                madlib.Story = madLibViewModel.AdventureTemplate.ToString();
                madlib.Genre = "adventure";
                madlib.Title = madLibViewModel.AdventureTemplate.PowerOne;
            }
            else if (madLibViewModel.HorrorTemplate != null)
            {
                madlib.Story = madLibViewModel.HorrorTemplate.ToString();
                madlib.Genre = "horror";
                madlib.Title = madLibViewModel.HorrorTemplate.Villain;
            }
            else if (madLibViewModel.RomanceTemplate != null)
            {
                madlib.Story = madLibViewModel.RomanceTemplate.ToString();
                madlib.Genre = "romance";
                madlib.Title = madLibViewModel.RomanceTemplate.Anything;
            }
            var newId = dal.GetMadlibs().Count() + 1;
            while (dal.GetMadlib(newId) != null)
            {
                newId += 1;
            }
            madlib.Id = newId;
            madlib.DatePublish = DateTime.Now;
            return View("GenerateMadlib", madlib);
        }

        [HttpPost]
        public IActionResult SaveMadlib(Madlib madlib)
        {
            dal.AddMadlib(madlib);
            var loggedInUser = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return View("MyCollection", dal.GetUserMadlibs(loggedInUser));
        }

        [HttpPost]
        public IActionResult DeleteMadlib(Madlib madlib)
        {
            dal.DeleteMadlib(madlib.Id);
            var loggedInUser = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return View("MyCollection", dal.GetUserMadlibs(loggedInUser));
        }

        public IActionResult MyCollection()
        {
            var loggedInUser = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View("MyCollection", dal.GetUserMadlibs(loggedInUser));
        }

        [HttpPost]
        public IActionResult DisplaySelectedMadLib(Madlib madlib)
        {
            return View("DisplayMadlib", madlib);
        }

        [HttpPost]
        public IActionResult ExportMadlib(Madlib madlib)
        {
            var filePath = Path.Combine(Path.GetTempPath(), $"{madlib.Title}.txt");

            try
            {
                System.IO.File.WriteAllText(filePath, madlib.Story);

                var fileBytes = System.IO.File.ReadAllBytes(filePath);
                return File(fileBytes, "text/plain", $"{madlib.Title}.txt");
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            finally
            {
                // Clean up
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                }
            }
        }

    }
}