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
    [RoutePrefix("api/v1/hdr_AC_Book_Publisher")]
    public class hdr_Ac_bookPublisherController : BaseController<hdr_Ac_bookPublisher>
    {
        ecomSchoolEntities hdr_Ac_Book_Publisher = new ecomSchoolEntities();
        [Route("Save/{hdr_Ac_BookPublisher}")]
        [HttpPost]
        public IHttpActionResult Savehdr_Ac_BookPublisher(hdr_Ac_bookPublisher hdr_Ac_BookPublisher)
        {
            try
            {
                Save(hdr_Ac_BookPublisher);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(hdr_Ac_BookPublisher);
        }
        [HttpGet]
        [Route("Get_hdr_AC_BookPublisher")]
        public IEnumerable<hdr_Ac_bookPublisher> GetAll()
        {
            var obj = hdr_Ac_Book_Publisher.Set<hdr_Ac_bookPublisher>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("Gethdr_AC_BookPublisher_ByentityId/{id}")]

        public async Task<List<hdr_Ac_pulisher>> GetEntityById(int id)
        {
            var query = (from hdr in hdr_Ac_Book_Publisher.hdr_Ac_bookPublisher
                         where
                         (id == hdr.entityId)
                         select new hdr_Ac_pulisher()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             Publisher = hdr.Publisher,
                             Address = hdr.Address,
                             Country = hdr.Country,
                             PhoneNo = hdr.PhoneNo,
                             Email = hdr.Email,
                             WebUrl = hdr.WebUrl,
                         }).ToList();
            return query;
        }
    }
}
