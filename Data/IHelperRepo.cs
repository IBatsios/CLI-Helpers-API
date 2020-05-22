using System.Collections.Generic;
using CLI_Helper.Models;

namespace CLI_Helper.Data
{
    public interface IHelperRepo
    {
        IEnumerable<Helper> GetAppCommands();
        Helper GetHelperById(int id);
    }
}