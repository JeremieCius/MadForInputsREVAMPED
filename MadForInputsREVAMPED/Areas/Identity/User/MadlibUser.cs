using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;

namespace MadForInputsREVAMPED.Areas.Identity.User
{
    public class MadlibUser : IdentityUser, IUser<string>
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Bio { get; set; }

        public MadlibUser() {}

        public MadlibUser(string firstName, string lastName, string bio)
        {
            FirstName = firstName;
            LastName = lastName;
            Bio = bio;
        }
    }
}
