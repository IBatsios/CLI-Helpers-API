using System.Collections.Generic;
using CLI_Helper.Models;

namespace CLI_Helper.Data
{
    public class MockHelperRepo : IHelperRepo
    {
        public IEnumerable<Helper> GetAppCommands()
        {
            var helpers = new List<Helper>
            {
                new Helper { Id = 0, HowTo = "How to cook a steak", Line = "Season it well", Platform = "Cast Iron Pan" },
                new Helper { Id = 1, HowTo = "How to boil an egg", Line = "Boil water", Platform = "Pot" },
                new Helper { Id = 2, HowTo = "How to fry a potato", Line = "Shred it", Platform = "Cast Iron Pan" }
            };

            return helpers;
        }

        public Helper GetHelperById(int id)
        {
            return new Helper { Id = 0, HowTo = "How to cook a steak", Line = "Season it well", Platform = "Cast Iron Pan" };
        }
    }
}