using MadForInputsREVAMPED.Areas.Identity.User;
using MadForInputsREVAMPED.Interfaces;

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

        
    }
}
