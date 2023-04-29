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
    [RoutePrefix("api/v1/hdr_AC_course_books")]
    public class hdr_AC_bookController : BaseController<hdr_Ac_Book>
    {
        ecomSchoolEntities hdr_Ac_Course_Book = new ecomSchoolEntities();
        [Route("Save/{hdr_ac_Book}")]
        [HttpPost]
        public IHttpActionResult Savehdr_ac_course_book(hdr_Ac_Book hdr_ac_coursebook)
        {
            try
            {
                Save(hdr_ac_coursebook);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(hdr_ac_coursebook);
        }
        [HttpGet]
        [Route("Get_hdr_AC_CourseBook")]
        public IEnumerable<hdr_Ac_Book> GetAll()
        {
            var obj = hdr_Ac_Course_Book.Set<hdr_Ac_Book>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("Getut_getCourseBooks_ByentityId/{id}")]
        public async Task<List<coursebooks>> GetByEntityId(int id)
        {
            var query = (from hdr in hdr_Ac_Course_Book.hdr_Ac_Book
                         where
                         (id == hdr.entityId)
                         select new coursebooks()
                         {
                             Id = hdr.Id,
                             bookno = hdr.bookno,
                             course = hdr.course,
                             subject = hdr.Subject,
                             subtype = hdr.subtype,
                             bookname = hdr.bookname,
                             tag = hdr.tag,
                             author = hdr.author,
                             publisher = hdr.publisher,
                             barcode = hdr.barcode,
                             price = hdr.price,
                             edition = hdr.edition,
                             year = hdr.year,
                             seriesname = hdr.seriesname
                         }).ToList();
            return query;
        }
        [HttpGet]
        [Route("Getut_getCourseBooks_ByentityId/{id}/{courseid}")]
        public async Task<List<coursebooks>> GetByEntityId_and_courseWise(int id, string courseid)
        {
            var query = (from hdr in hdr_Ac_Course_Book.hdr_Ac_Book
                         where
                         (id == hdr.entityId && courseid == hdr.course)
                         select new coursebooks()
                         {
                             Id = hdr.Id,
                             bookno = hdr.bookno,
                             course = hdr.course,
                             subject = hdr.Subject,
                             subtype = hdr.subtype,
                             bookname = hdr.bookname,
                             tag = hdr.tag,
                             author = hdr.author,
                             publisher = hdr.publisher,
                             barcode = hdr.barcode,
                             price = hdr.price,
                             edition = hdr.edition,
                             year = hdr.year,
                             seriesname = hdr.seriesname
                         }).ToList();
            return query;
        }
    }

}
