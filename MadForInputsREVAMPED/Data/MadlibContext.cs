using MadForInputsREVAMPED.Areas.Identity.Data;
using MadForInputsREVAMPED.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MadForInputsREVAMPED.Data
{
    public class MadlibContext : IdentityDbContext
    {
        public MadlibContext(DbContextOptions<MadlibContext> options)
            : base(options)
        {
        }

        public DbSet<Madlib?> Madlibs { get; set; }

        public DbSet<MadlibUser> AspNetUsers { get; set; }
    }
}