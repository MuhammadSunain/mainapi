using ecmapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ecmapi.Controllers.EntitySetup
{
    [RoutePrefix("api/v1/Entities")]
    public class EntitySetupController : BaseController<Entity>
    {
        ecomSchoolEntities Entities = new ecomSchoolEntities();
 
        [HttpPost]
        [Route("Save/{obj}")]
        public IHttpActionResult SaveEntity(Entity obj)
        {
            try
            {
                Save(obj);
            }
            catch(Exception)
            {
                throw;
            }
            return Ok(obj);
        }

        [HttpGet]
        [Route("GetEntityById/{clientid}")]
        public async Task<List<dtoentity>> GetEntityById(int clientid)
        {
            var query = (from hdr in Entities.Entities
                         where
                         (clientid == hdr.clientid)
                         select new dtoentity()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             EntityName = hdr.EntityName,
                             EntityDate = hdr.EntityDate.ToString(),
                             EntityType = hdr.EntityType,
                             ownerName = hdr.ownerName,
                             contsctno = hdr.contsctno,
                             email = hdr.email,
                             address = hdr.address
                         }).ToList();
            return query;
        }
        [HttpGet]
        [Route("GetEntityByIdandid/{entityid}")]
        public async Task<List<dtoentity>> GetEntityByIdandid(int entityid)
        {
            var query = (from hdr in Entities.Entities
                         where
                         (entityid == hdr.Id)
                         select new dtoentity()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             EntityName = hdr.EntityName
                         }).ToList();
            return query;
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var item = Delete<Entity>(id);
            if (item != null)
            {
                return Ok("Record Deleted Successfully");
            }
            return Ok();
        }

        [HttpPut]
        [Route("update_entityData/{entityid}/{obj}")]
        public IHttpActionResult update(int entityid, Entity obj)
        {
            var dto = Entities.Entities.FirstOrDefault(n => n.Id == entityid);
            if (dto != null)
            {
                dto.Code = obj.Code;
                dto.EntityName = obj.EntityName;
                dto.EntityType = obj.EntityType;
                dto.EntityDate = obj.EntityDate;
                dto.ownerName = obj.ownerName;
                dto.contsctno = obj.contsctno;
                dto.email = obj.email;
                dto.address = obj.address;
                Entities.SaveChanges();
            }
            return Ok("record updated successfully...");
        }
    }
}
