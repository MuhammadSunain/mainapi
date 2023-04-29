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
    [RoutePrefix("api/v1/hdr_AC_Book_Author")]
    public class hdr_Ac_bookAuthorController : BaseController<hdr_Ac_bookAuthor>
    {
        ecomSchoolEntities hdr_Ac_Book_Author = new ecomSchoolEntities();
        [Route("Save/{hdr_Ac_BookAuthor}")]
        [HttpPost]
        public IHttpActionResult Savehdr_Ac_BookAuthor(hdr_Ac_bookAuthor hdr_Ac_BookAuthor)
        {
            try
            {
                Save(hdr_Ac_BookAuthor);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(hdr_Ac_BookAuthor);
        }
        [HttpGet]
        [Route("Get_hdr_AC_BookAuthor")]
        public IEnumerable<hdr_Ac_bookAuthor> GetAll()
        {
            var obj = hdr_Ac_Book_Author.Set<hdr_Ac_bookAuthor>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("Gethdr_AC_BookAuthor_ByentityId/{id}")]

        public async Task<List<hdr_Ac_Author>> GetEntityById(int id)
        {
            var query = (from hdr in hdr_Ac_Book_Author.hdr_Ac_bookAuthor
                         where
                         (id == hdr.entityId)
                         select new hdr_Ac_Author()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             AuthorType = hdr.AuthorType,
                             NickName = hdr.NickName,
                             Name = hdr.Name,
                             Country = hdr.Country,
                             YearBorn = hdr.YearBorn,
                             YearDied = hdr.YearDied,
                             Awards = hdr.Awards,
                         }).ToList();
            return query;
        }
    }
}
