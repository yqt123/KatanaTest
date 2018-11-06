using Katana.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katana.IService
{
    public interface IBugsRepository : IService
    {
        IEnumerable<Bug> GetBugs();
    }
}
