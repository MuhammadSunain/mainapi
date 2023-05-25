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

        [HttpDelete]
        [Route("Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var item = Delete<hdr_occupation>(id);
            if (item != null)
            {
                return Ok("Record Deleted Successfully");
            }
            return Ok();
        }

        [HttpPut]
        [Route("update_hdr_occupationData/{occupationid}/{obj}")]
        public IHttpActionResult update(int occupationid, hdr_occupation obj)
        {
            var dto = db.hdr_occupation.FirstOrDefault(n => n.Id == occupationid);
            if (dto != null)
            {
                dto.code = obj.code;
                dto.occupation = obj.occupation;
                dto.description = obj.description;
                db.SaveChanges();
            }
            return Ok("record updated successfully...");
        }
    }
}
