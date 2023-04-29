using ecmapi.dto;
using ecmapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ecmapi.Controllers.SM
{
    [RoutePrefix("api/v1/student_Category")]
    public class StudentCategoryController : BaseController<student_category>
    {
        ecomSchoolEntities stdcategory = new ecomSchoolEntities();
        [Route("Save/{stdCategory}")]
        [HttpPost]
        public IHttpActionResult SaveStdCategory(student_category stdCategory)
        {
            try
            {
                Save(stdCategory);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(stdCategory);
        }
        [HttpGet]
        [Route("Getstudent_Category")]
        public IEnumerable<student_category> Getstudent_Category()
        {
            var obj = stdcategory.Set<student_category>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("GetStdCategoryByentityId/{id}")]
        public async Task<List<dtostdCategory>> GetEntityById(int id)
        {
            var query = (from hdr in stdcategory.student_category
                         where
                         (id == hdr.entityId)
                         select new dtostdCategory()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             studentcategory = hdr.studentcategory,
                             description = hdr.description
                         }).ToList();
            return query;
        }
    }
}
