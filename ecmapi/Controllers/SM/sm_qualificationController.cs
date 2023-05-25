using ecmapi.dto;
using ecmapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ecmapi.Controllers.SS
{
    [RoutePrefix("api/v1/SmS_Qualification")]
    public class QualificationController : BaseController<Sms_Qualification>
    {
        ecomSchoolEntities Qualifications = new ecomSchoolEntities();
        [HttpPost]
        [Route("Save/{sms_Qualification}")]
        public IHttpActionResult Savesms_Qualification(Sms_Qualification sms_Qualification)
        {
            try
            {
                Save(sms_Qualification);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(sms_Qualification);
        }
        [HttpGet]
        [Route("SMS_Qualification")]
        public IEnumerable<Sms_Qualification> SMS_Qualification()
        {
            var obj = Qualifications.Set<Sms_Qualification>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("getSMS_Qualification_By_entityId/{entityid}")]
        public async Task<List<Qualification>> GetByEntityId(int entityid)
        {
            var query = (from hdr in Qualifications.Sms_Qualification
                         where
                         (entityid == hdr.entityid)
                         select new Qualification()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             qualificationtypeid = hdr.qualificationtypeid,
                             qualification = hdr.qualification,
                             Description = hdr.Description
                         }).ToList();
            return query;
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var item = Delete<Sms_Qualification>(id);
            if (item != null)
            {
                return Ok("Record Deleted Successfully");
            }
            return Ok();
        }
        [HttpPut]
        [Route("update_qualificationData/{qualificationid}/{obj}")]
        public IHttpActionResult update(int qualificationid, Sms_Qualification obj)
        {
            var dto = Qualifications.Sms_Qualification.FirstOrDefault(n => n.Id == qualificationid);
            if (dto != null)
            {
                dto.Code = obj.Code;
                dto.qualification = obj.qualification;
                dto.qualificationtypeid = obj.qualificationtypeid;
                dto.Description = obj.Description;
                Qualifications.SaveChanges();
            }
            return Ok("record updated successfully...");
        }
    }
}
