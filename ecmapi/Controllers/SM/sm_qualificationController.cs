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
                             QualificationType = hdr.qualificationtypeid,
                             qualification = hdr.qualification,
                             Description = hdr.Description
                         }).ToList();
            return query;
        }
    }
}
