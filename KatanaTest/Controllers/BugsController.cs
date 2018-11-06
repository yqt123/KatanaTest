using Katana.IService;
using Katana.Model;
using Katana.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace KatanaTest
{
    public class BugsController : ApiController
    {
        IBugsRepository _bugsRepository = new BugsRepository();
        public IEnumerable<Bug> Get()
        {
            return _bugsRepository.GetBugs();
        }

        [HttpPost]
        public Bug MoveToBacklog([FromBody] int id)
        {
            var bug = _bugsRepository.GetBugs().First(b => b.id == id);
            bug.state = "backlog";
            return bug;
        }

        //[HttpPost("api/bugs/working")]
        public Bug MoveToWorking([FromBody] int id)
        {
            var bug = _bugsRepository.GetBugs().First(b => b.id == id);
            bug.state = "working";
            return bug;
        }

        //[HttpPost("api/bugs/done")]
        public Bug MoveToDone([FromBody] int id)
        {
            var bug = _bugsRepository.GetBugs().First(b => b.id == id);
            bug.state = "done";
            return bug;
        }
    }
}