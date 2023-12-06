using MadForInputsREVAMPED.Areas.Identity.User;
using MadForInputsREVAMPED.Models;

namespace MadForInputsREVAMPED.Interfaces
{
    public interface IDataAccessLayer
    {
        MadlibUser GetUser(string userId);

        IEnumerable<Madlib> GetMadlibs();

        IEnumerable<Madlib> GetUserMadlibs(string userId);

        IEnumerable<Madlib> FilterMadlibs(string? genre, DateTime? latest, DateTime? oldest, string? title);

        Madlib GetMadlib(int? id);


    }
}
