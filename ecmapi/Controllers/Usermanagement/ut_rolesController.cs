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

        [Route("Saveut_Role_Rights/{ut_userrights}")]
        [HttpPost]
        public IHttpActionResult Saveut_Role_Rights(mst_usermoudulesrights ut_userrights)
        {
            try
            {
                ut_EntityRole.mst_usermoudulesrights.Add(ut_userrights);
                ut_EntityRole.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(ut_userrights);
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
                             Role1 = hdr.Role1,
                             Entity = hdr.clientname,
                         }).ToList();
            return query;
        }
        [HttpGet]
        [Route("getut_rolesby_role/{role}")]
        public async Task<List<utroles>> getut_rolesby_clientid(string role)
        {
            var query = (from hdr in ut_EntityRole.Roles
                         where
                         (role == hdr.Role1)
                         select new utroles()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             Role1 = hdr.Role1,
                             Entity = hdr.clientname,
                             appscreens = ut_EntityRole.mst_usermoudulesrights.Where(a => a.roleid == hdr.Id)
                         }).ToList();
            return query;
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var item = Delete<Role>(id);
            if (item != null)
            {
                return Ok("Record Deleted Successfully");
            }
            return Ok();
        }

        [HttpPut]
        [Route("update_RoleData/{roleid}/{obj}")]
        public IHttpActionResult update(int roleid, Role obj)
        {
            var dto = ut_EntityRole.Roles.FirstOrDefault(n => n.Id == roleid);
            if (dto != null)
            {
                dto.Code = obj.Code;
                dto.Role1 = obj.Role1;
                dto.clientname = obj.clientname;
                ut_EntityRole.SaveChanges();
            }
            return Ok("record updated successfully...");
        }
    }
}
