using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrphanageAPI.Controllers
{
    public class ChildController : ApiController
    {
        private ActionLearningEntities db = new ActionLearningEntities();

        [HttpPost]
        public IHttpActionResult ChildRegistration(childRegisteration orp)
        {
            Console.WriteLine(orp);

            db.childRegisterations.Add(orp);
            
            db.SaveChanges();
            return Ok();
        }
    }
}
