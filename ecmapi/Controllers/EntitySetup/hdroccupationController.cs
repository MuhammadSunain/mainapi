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
    [RoutePrefix("api/v1/hdr_occupation")]
    public class OccupationController: BaseController<hdr_occupation>
    {
        ecomSchoolEntities db = new ecomSchoolEntities();
        [HttpPost]
        [Route("Save/{obj}")]
        public IHttpActionResult Savehdroccupation(hdr_occupation obj)
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
        [Route("gethdr_occupationEntityWise/{id}")]
        public  List<ocuupation> gethdr_occupationEntityWise(int id)
        {
            var dto = (from hdr in db.hdr_occupation
                       where
                       (id == hdr.entityId)
                       select new ocuupation()
                       {
                           Id = hdr.Id,
                           code = hdr.code,
                           occupation = hdr.occupation,
                           description = hdr.description,
                           entityId = hdr.entityId
                       }).ToList();
            return dto;
        }
    }
}
