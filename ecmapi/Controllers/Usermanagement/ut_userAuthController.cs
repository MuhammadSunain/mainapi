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
                             Username = hdr.Username,
                             Password = hdr.Password,
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
    }
}
