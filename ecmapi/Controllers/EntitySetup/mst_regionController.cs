using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ecmapi.dto;
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
                Save(obj);
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
        [HttpGet]
        [Route("getregionEntityWise/{id}")]
        public async Task<List<mstregion>> getregionEntityWise(int id)
        {
            var query = (from hdr in dta.mst_region
                         where
                         (id == hdr.entityId)
                         select new mstregion()
                         {
                             Id = hdr.Id,
                             code = hdr.code,
                             region = hdr.region,
                             country = hdr.country,
                             entityId = hdr.entityId
                         }).ToList();
            return query;
        }
    }
}
