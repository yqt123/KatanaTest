using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Katana.Model;
using Katana.IService;

namespace Katana.Service
{
    public class BugsRepository : IBugsRepository
    {
        public IEnumerable<Bug> GetBugs()
        {
            var res = new List<Bug>();
            res.Add(new Bug { id = 1, state = "backlog" });
            res.Add(new Bug { id = 2, state = "working" });
            res.Add(new Bug { id = 3, state = "done" });
            return res;
        }
    }
}
