

using OrphanageAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrphanageAPI.Controllers
{
    public class OrphanageController : ApiController
    {

        private ActionLearningEntities db = new ActionLearningEntities();

        //public IHttpActionResult GetAllOrphanage()
        //{
        //    IList<OrphanageRegistrationView> ORP = null;
        //    using (var x = new ActionLearningEntities())
        //    {
        //        ORP = x.orphanageRegistration1.Select(o => new OrphanageRegistrationView()
        //        {
        //            oId = o.oId,
        //            oName = o.oName,
        //            oRegistrationNum = o.oRegistrationNum,
        //            addressLine1 = o.addressLine1,
        //            addressLine2 = o.addressLine2,
        //            landmark = o.landmark,
        //            city = o.city,
        //            state = o.state,
        //            country = o.country,
        //            pincode = o.pincode,
        //            phoneNum = o.phoneNum,
        //            password = o.password

        //        }).ToList<OrphanageRegistrationView>();

        //        if (ORP.Count == 0)
        //        {
        //            return NotFound();
        //        }
        //        return Ok(ORP);
        //    }
        //}


        [HttpPost]
        public IHttpActionResult OrphanageRegistration(orphanageRegistration1 orp)
        {
            db.orphanageRegistration1.Add(orp);
            db.SaveChanges();
            return Ok();
        }
        [HttpGet]
        [Route("GetChildById/{id:int}")]
        public IHttpActionResult GetChildById(int id)
        {
            var result = db.childRegisterations.Where(c => c.oId==id).ToList();
            return Ok(result);


        }

        

    }
}
