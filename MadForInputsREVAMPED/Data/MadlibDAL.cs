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

        public Madlib GetMadlib(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
