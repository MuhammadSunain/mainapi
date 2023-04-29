using ecmapi.dto;
using ecmapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ecmapi.Controllers.ACM
{
    [RoutePrefix("api/v1/hdr_AC_Book_Type")]
    public class hdr_AC_bookTypeController : BaseController<hdr_Ac_bookType>
    {
        ecomSchoolEntities hdr_Ac_Book_Type = new ecomSchoolEntities();
        [Route("Save/{hdr_Ac_BookType}")]
        [HttpPost]
        public IHttpActionResult Savehdr_Ac_BookType(hdr_Ac_bookType hdr_Ac_BookType)
        {
            try
            {
                Save(hdr_Ac_BookType);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(hdr_Ac_BookType);
        }
        [HttpGet]
        [Route("Get_hdr_AC_BookType")]
        public IEnumerable<hdr_Ac_bookType> GetAll()
        {
            var obj = hdr_Ac_Book_Type.Set<hdr_Ac_bookType>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("Gethdr_AC_BookType_ByentityId/{id}")]

        public async Task<List<hdr_Ac_booktype>> GetEntityById(int id)
        {
            var query = (from hdr in hdr_Ac_Book_Type.hdr_Ac_bookType
                         where
                         (id == hdr.entityId)
                         select new hdr_Ac_booktype()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             BookType = hdr.BookType,
                         }).ToList();
            return query;
        }
    }
}
