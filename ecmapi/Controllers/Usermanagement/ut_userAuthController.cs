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
    [RoutePrefix("api/v1/ut_User_Auth")]
    public class ut_userAuthController : BaseController<ut_user_auth>
    {
        ecomSchoolEntities db = new ecomSchoolEntities();

        [HttpPost]
        [Route("Save/{ut_User_Auth}")]
        public IHttpActionResult Saveut_User_Auth(ut_user_auth ut_User_Auth)
        {
            try
            {
                Save(ut_User_Auth);
                
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(ut_User_Auth);
        }

        [HttpGet]
        [Route("Getut_Users_auth_ByclientId/{clientid}")]
        public async Task<List<utuserauth>> GetByclientId(int clientid)
        {
            var query = (from hdr in db.ut_user_auth
                         where
                         (clientid == hdr.clientid)
                         select new utuserauth()
                         {
                             Id = hdr.Id,
                             Entity = hdr.Entity,
                             username = hdr.Username,
                             pass = hdr.Password,
                             Fullname = hdr.Fullname,
                             Email = hdr.Email,
                             CellNo = hdr.CellNo,
                             UserCategory = hdr.UserCategory,
                             Role = hdr.Role,
                             Status = hdr.Status,
                             entityid = hdr.clientid
                         }).ToList();
            return query;
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var item = Delete<ut_user_auth>(id);
            if (item != null)
            {
                return Ok("Record Deleted Successfully");
            }
            return Ok();
        }

        [HttpPut]
        [Route("update_userData/{userid}/{obj}")]
        public IHttpActionResult update(int userid, ut_user_auth obj)
        {
            var dto = db.ut_user_auth.FirstOrDefault(n => n.Id == userid);
            if (dto != null)
            {
                dto.Username = obj.Username;
                dto.Password = obj.Password;
                dto.Fullname = obj.Fullname;
                dto.Email = obj.Email;
                dto.CellNo = obj.CellNo;
                dto.UserCategory = obj.UserCategory;
                dto.Role = obj.Role;
                dto.Status = obj.Status;
                db.SaveChanges();
            }
            return Ok("record updated successfully...");
        }

    }
}
