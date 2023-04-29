using ecmapi.dto;
using ecmapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ecmapi.Controllers.Usermanagement
{
    [RoutePrefix("api/v1/ut_Entity_Roles")]
    public class ut_rolesController : BaseController<Role>
    {
        ecomSchoolEntities ut_EntityRole = new ecomSchoolEntities();

        [Route("Save/{ut_Role}")]
        [HttpPost]
        public IHttpActionResult Saveut_Role(Role ut_Role)
        {
            try
            {
                Save(ut_Role);   
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(ut_Role);
        }

        [HttpGet]
        [Route("getut_rolesby_clientid/{clientid}")]
        public async Task<List<utroles>> getut_rolesby_clientid(int clientid)
        {
            var query = (from hdr in ut_EntityRole.Roles
                         where
                         (clientid == hdr.client)
                         select new utroles()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             Role = hdr.Role1,
                             clientname = hdr.clientname,
                         }).ToList();
            return query;
        }
    }
}
