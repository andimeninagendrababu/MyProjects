using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplication4.rep;

namespace WebApplication4.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class phase1Controller : ApiController
    {
        public readonly phase1Interface1 iemp;
        public phase1Controller() { }

        public phase1Controller(phase1Interface1 edf)

        {
            this.iemp = edf;
        }

        [Route("api/phase1/GetAllDetails")]
        [HttpGet]
        public IHttpActionResult GetAllVisitDetails()
        {
            var abc = iemp.GetAllDetails();
            if (abc == null)
            {
                return NotFound();
            }
            return Ok(abc);
        }

        [Route("api/phase1/insert")]
        [HttpPost]
        public HttpResponseMessage Insert(phase1 em)
        {
            var abc = iemp.insert(em);
            return Request.CreateResponse(HttpStatusCode.OK, abc);
        }


        [Route("api/phase1/updates")]
        [HttpPost]
        public IHttpActionResult Update(phase1 em)
        {
            var abc = iemp.Update(em);
            if (abc == null)
            {
                return NotFound();
            }
            return Ok("Updated");
        }

        [Route("api/phase1/delete")]
        [HttpPost]
        public string DeleteOne([FromBody]int Sl_No)
        {
            return iemp.Delete(Sl_No);
        }
    }
}
