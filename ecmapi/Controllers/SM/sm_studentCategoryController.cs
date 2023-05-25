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
        [HttpDelete]
        [Route("Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var item = Delete<student_category>(id);
            if (item != null)
            {
                return Ok("Record Deleted Successfully");
            }
            return Ok();
        }
        [HttpPut]
        [Route("update_student_categoryData/{stdcatid}/{obj}")]
        public IHttpActionResult update(int stdcatid, student_category obj)
        {
            var dto = stdcategory.student_category.FirstOrDefault(n => n.Id == stdcatid);
            if (dto != null)
            {
                dto.Code = obj.Code;
                dto.studentcategory = obj.studentcategory;
                dto.description = obj.description;
                stdcategory.SaveChanges();
            }
            return Ok("record updated successfully...");
        }
    }
}
