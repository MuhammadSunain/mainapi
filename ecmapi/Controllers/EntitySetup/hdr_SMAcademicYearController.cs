using ecmapi.dto;
using ecmapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ecmapi.Controllers.EntitySetup
{
    [RoutePrefix("api/v1/hdr_SMAcademicYear")]
    public class hdr_SMAcademicYearController : BaseController<hdr_SMAcademicYear>
    {
        ecomSchoolEntities hdr_smacademicYear = new ecomSchoolEntities();

        [Route("Save/{hdr_academicYear}")]
        [HttpPost]
        public IHttpActionResult Savehdr_cademicYear(hdr_SMAcademicYear hdr_academicYear)
        {
            try
            {
                Save(hdr_academicYear);
            }
            catch(Exception)
            {
                throw;
            }
            return Ok(hdr_academicYear);
        }

        [HttpGet]
        [Route("gethdr_SMAcademicYear/{entityId}")]
        public async Task<List<hdr_SmacademicYear>> GetEntityById(int entityId)
        {
            var query = (from hdr in hdr_smacademicYear.hdr_SMAcademicYear
                         where
                         (entityId == hdr.entityId)
                         select new hdr_SmacademicYear()
                         {
                             Id = hdr.Id,
                             code = hdr.code,
                             academicregister = hdr.academicregister,
                             academicyear = hdr.academicyear,
                             startdate = hdr.startdate,
                             enddate = hdr.enddate,
                             syllabus = hdr.syllabus,
                             entityId = hdr.entityId,
                         }).ToList();
            return query;
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var item = Delete<hdr_SMAcademicYear>(id);
            if (item != null)
            {
                return Ok("Record Deleted Successfully");
            }
            return Ok();
        }

        [HttpPut]
        [Route("update_academicyearData/{academicYearid}/{obj}")]
        public IHttpActionResult update(int academicYearid, hdr_SMAcademicYear obj)
        {
            var dto = hdr_smacademicYear.hdr_SMAcademicYear.FirstOrDefault(n => n.Id == academicYearid);
            if (dto != null)
            {
                dto.code = obj.code;
                dto.academicregister = obj.academicregister;
                dto.academicyear = obj.academicyear;
                dto.startdate = obj.startdate;
                dto.enddate = obj.enddate;
                dto.syllabus = obj.syllabus;
                hdr_smacademicYear.SaveChanges();
            }
            return Ok("record updated successfully...");
        }
    }
}
