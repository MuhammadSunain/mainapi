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
    public class EntitySetupController : ApiController
    {
        ecomSchoolEntities Entities = new ecomSchoolEntities();
 
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
                             EntityDate = hdr.EntityDate,
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
    }
}
