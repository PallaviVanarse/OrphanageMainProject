using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrphanageAPI.Controllers
{
    public class LoginController : ApiController
    {
        [HttpPost]
        public IHttpActionResult PostLogin(orphanageRegistration1 orp)
        {
            using (ActionLearningEntities db = new ActionLearningEntities())
            {
                bool isUservalid = false;
                var obj = db.orphanageRegistration1.Where(a => a.oRegistrationNum.Equals(orp.oRegistrationNum) && a.password.Equals(orp.password)).FirstOrDefault();
                if (obj != null)
                {
                    isUservalid = true;
                }
                if (isUservalid)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            
        }
    }
}
