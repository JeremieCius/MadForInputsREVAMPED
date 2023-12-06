using MadForInputsREVAMPED.Areas.Identity.User;
using MadForInputsREVAMPED.Interfaces;
using MadForInputsREVAMPED.Models;
using System.Threading;

namespace MadForInputsREVAMPED.Data
{
    public class MadlibDAL : IDataAccessLayer
    {
        public MadlibContext db;

        public MadlibDAL(MadlibContext db)
        {
            this.db = db;
        }

        public MadlibUser GetUser(string userId)
        {
            return db.AspNetUsers.FirstOrDefault(user => user.Id == userId);
        }

        public void DeleteMadlib(int? MadlibId)
        {
            if (MadlibId > 0)
            {
                db.Madlibs.Remove(db.Madlibs.Find(MadlibId));
                db.SaveChanges();
            }
        }

        public void AddMadlib(Madlib madlib)
        {
            var newId = GetMadlibs().Count() + 1;
            while (GetMadlib(newId) != null)
            {
                newId += 1;
            }
            madlib.Id = newId;
            db.Madlibs.Add(madlib);
            db.SaveChanges();
        }

        public IEnumerable<MadlibUser> GetUsers()
        {
            return db.AspNetUsers.ToList();
        }

        public IEnumerable<Madlib> GetMadlibs()
        {
            return db.Madlibs.ToList();
        }

        public IEnumerable<Madlib> GetUserMadlibs(string userId)
        {
            List<Madlib> madlibs = new List<Madlib>();
            // Make a foreach to loop in the database and add results that have the userId to list
            foreach (var userMadlibs in db.Madlibs)
            {
                if (userMadlibs.AuthorId == userId)
                {
                    madlibs.Add(userMadlibs);
                }
            }
            return madlibs;
        }

        public IEnumerable<Madlib> FilterMadlibs(string? genre, DateTime? latest, DateTime? oldest, string? title)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Madlib> SearchMadlibs(string search)
        {
            List<Madlib> foundMadlibs = new List<Madlib>();

            foreach (var madlib in db.Madlibs)
            {
                if (madlib.Title.ToUpper().Contains(search.ToUpper()))
                {
                    foundMadlibs.Add(madlib);
                }
            }
            return foundMadlibs;
        }

        public Madlib GetMadlib(int? id)
        {
            return db.Madlibs.FirstOrDefault(madlib => madlib.Id == id);
        }
    }
}
