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
    [RoutePrefix("api/v1/hdr_AC_Book_Category")]
    public class hdr_Ac_bookCategoryController : BaseController<hdr_Ac_bookCategory>
    {
        ecomSchoolEntities hdr_Ac_Book_Category = new ecomSchoolEntities();
        [Route("Save/{hdr_Ac_BookCategory}")]
        [HttpPost]
        public IHttpActionResult Savehdr_Ac_BookCategory(hdr_Ac_bookCategory hdr_Ac_BookCategory)
        {
            try
            {
                Save(hdr_Ac_BookCategory);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(hdr_Ac_BookCategory);
        }
        [HttpGet]
        [Route("Get_hdr_AC_BookCategory")]
        public IEnumerable<hdr_Ac_bookCategory> GetAll()
        {
            var obj = hdr_Ac_Book_Category.Set<hdr_Ac_bookCategory>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("Gethdr_AC_BookCategory_ByentityId/{id}")]

        public async Task<List<dtohdr_Ac_bookCategory>> GetEntityById(int id)
        {
            var query = (from hdr in hdr_Ac_Book_Category.hdr_Ac_bookCategory
                         where
                         (id == hdr.entityId)
                         select new dtohdr_Ac_bookCategory()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             BookCategory = hdr.BookCategory,
                         }).ToList();
            return query;
        }
    }
}
