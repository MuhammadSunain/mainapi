using ecmapi.dto;
using ecmapi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ecmapi.Controllers.EntitySetup
{
    [RoutePrefix("api/v1/hdr_MST_area")]
    public class AreaController : BaseController<mst_hdrArea>
    {

        ecomSchoolEntities db = new ecomSchoolEntities();

        [HttpPost]
        [Route("Save/{area}")]
        public IHttpActionResult SaveHdrAREA(mst_hdrArea area)
        {
            try
            {
                Save(area);
            }
            catch(Exception)
            {
                throw;
            }
            return Ok(area);
        }
        [HttpGet]
        [Route("getMst_HDR_AREA_entityWise/{id}")]
        public async Task<List<mstArea>> getMst_HDR_AREA_entityWise(int id)
        {
            var query = (from hdr in db.mst_hdrArea
                         where
                         (id == hdr.entityId)
                         select new mstArea()
                         {
                             Id = hdr.Id,
                             code = hdr.code,
                             country = hdr.country,
                             state = hdr.state,
                             city = hdr.city,
                             areaname = hdr.areaname,
                             entityId = hdr.entityId
                         }).ToList();
            return query;
        }
    }
}
