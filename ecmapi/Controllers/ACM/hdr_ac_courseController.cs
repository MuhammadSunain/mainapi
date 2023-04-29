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
    [RoutePrefix("api/v1/hdr_Ac_Course")]
    public class hdr_Ac_CourseController : BaseController<hdr_Ac_Course>
    {
        ecomSchoolEntities hdr_Ac_Course = new ecomSchoolEntities();
        [Route("Save/{hdr_Ac_course}")]
        [HttpPost]
        public IHttpActionResult Savehdr_Ac_course(hdr_Ac_Course hdr_Ac_course)
        {
            try
            {
                Save(hdr_Ac_course);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(hdr_Ac_course);
        }
        //dto_hdr_Ac_Course
        [HttpGet]
        [Route("Get_hdr_Ac_Course")]
        public IEnumerable<hdr_Ac_Course> GetAll()
        {
            var obj = hdr_Ac_Course.Set<hdr_Ac_Course>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("Gethdr_Ac_CourseByentityId/{id}")]

        public async Task<List<dto_hdr_Ac_Course>> GetEntityById(int id)
        {
            var query = (from hdr in hdr_Ac_Course.hdr_Ac_Course
                         where
                         (id == hdr.entityId)
                         select new dto_hdr_Ac_Course()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             CourseCategory = hdr.CourseCategory,
                             Course = hdr.Course,
                             Syllabus = hdr.Syllabus,
                             AgeFrom = hdr.AgeFrom,
                             AgeTill = hdr.AgeTill
                         }).ToList();
            return query;
        }
        [HttpGet]
        [Route("Gethdr_Ac_CourseByentityId_and_Syllabus/{id}/{Syllabus}")]

        public async Task<List<dto_hdr_Ac_Course>> GetEntityById(int id, string Syllabus)
        {
            var query = (from hdr in hdr_Ac_Course.hdr_Ac_Course
                         where
                         (id == hdr.entityId && Syllabus == hdr.Syllabus)
                         select new dto_hdr_Ac_Course()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             CourseCategory = hdr.CourseCategory,
                             Course = hdr.Course,
                             Syllabus = hdr.Syllabus,
                             AgeFrom = hdr.AgeFrom,
                             AgeTill = hdr.AgeTill
                         }).ToList();
            return query;
        }
    }
}
