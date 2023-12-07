using MadForInputsREVAMPED.Areas.Identity.Data;
using MadForInputsREVAMPED.Models;

namespace MadForInputsREVAMPED.Interfaces
{
    public interface IDataAccessLayer
    {
        MadlibUser GetUser(string userId);

        void DeleteMadlib(int? MadlibId);

        void AddMadlib(Madlib madlib);

        IEnumerable<MadlibUser> GetUsers();

        IEnumerable<Madlib> GetMadlibs();

        IEnumerable<Madlib> GetUserMadlibs(string userId);

        IEnumerable<Madlib> FilterMadlibs(string? genre, DateTime? date, string? title);

        IEnumerable<Madlib> SearchMadlibs(string search);

        Madlib GetMadlib(int? id);


    }
}