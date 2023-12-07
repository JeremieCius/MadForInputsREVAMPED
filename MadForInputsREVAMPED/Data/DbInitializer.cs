using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MadForInputsREVAMPED.Data
{
    public class DbInitializer
    {
        public static void Initialize(MadlibContext context)
        {
            context.Database.EnsureCreated();

            SetupUsers(context);
        }

        public static void SetupUsers(MadlibContext context)
        {
            if (context.Madlibs.Any())
            {
                return;
            }
        }
    }
}
