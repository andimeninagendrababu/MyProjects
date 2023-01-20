using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication4.Models;
using WebApplication4.rep;

namespace WebApplication4.Controllers
{
    public class curdController : ApiController
    {
        public readonly empInterface1 iemp;
        public curdController() { }
        public curdController(empInterface1 edf)

        {
            this.iemp = edf;
        }
        [Route("api/employee/GetAllEmployee")]
        [HttpGet]
        public IHttpActionResult GetAllEmployee()
        {
            var abc = iemp.GetAllEmployee();
            if (abc.Count == 0)
            {
                return NotFound();
            }
            return Ok(abc);
        }
        

        
        [Route("api/curd/delete/{ID}")]
        [HttpDelete]
        public string DeleteEmp(int ID)
        {
            return iemp.DeleteEmp(ID);
        }
        [Route("api/curd/insert")]
        [HttpPost]  
        public HttpResponseMessage Insert(empDetail em)
        {
            var abc=iemp.insert(em);
            return Request.CreateResponse(HttpStatusCode.OK, abc);
        }
        [Route("api/curd/updates")]
        [HttpPost]
        public  IHttpActionResult Update(empDetail em)
        {
            var abc = iemp.Update(em);
            if(abc==null)
            {
                return NotFound();
            }
            return Ok("Updated");
        }
        [Route("api/Home/bulkinsert")]

        [HttpPost]
        public HttpResponseMessage bulkinsert(List<empDetail> em)
        {
            var abc = iemp.Bulkinsert(em);
            return Request.CreateResponse(HttpStatusCode.OK, abc);
        }

        [Route("api/curd/GetEmployeeByID/{ID}")]
        [HttpGet]
        
        public IHttpActionResult GetByEmployeeId(int ID)
        {
            var abc = iemp.GetEmployeeByID(ID);
            if (abc == null)
            {
                return NotFound();

            }
            return Ok(abc);
        }

    }
}

