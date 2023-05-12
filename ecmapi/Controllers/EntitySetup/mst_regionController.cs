using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ecmapi.Models;

namespace ecmapi.Controllers.EntitySetup
{
    [RoutePrefix("api/v1/mst_region")]
    public class mst_regionController : BaseController<mst_region>
    {
        ecomSchoolEntities dta = new ecomSchoolEntities();

        [HttpPost]
        [Route("Save/{obj}")]

        public IHttpActionResult saveregion(mst_region obj)
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
            return Ok(obj);
        }

        [HttpGet]
        [Route("Get_region")]

        public IEnumerable<mst_region> getregion()
        {
            var dto = dta.Set<mst_region>().ToList();
            return dto;
        }
    }
}
