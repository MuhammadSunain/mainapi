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
    [RoutePrefix("api/v1/SmS_QualificationType")]
    public class SMS_QualificationTypeController : BaseController<SMS_QualificationType>
    {
        ecomSchoolEntities QualificationType = new ecomSchoolEntities();
        [HttpPost]
        [Route("Save/{sms_Qualificationtype}")]
        public IHttpActionResult Savesms_Qualificationtype(SMS_QualificationType sms_Qualificationtype)
        {
            try
            {
                Save(sms_Qualificationtype);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(sms_Qualificationtype);
        }
        [HttpGet]
        [Route("getSMS_QualificationType_By_entityId/{entityid}")]
        public async Task<List<sms_Qualification_Type>> GetByEntityId(int entityid)
        {
            var query = (from hdr in QualificationType.SMS_QualificationType
                         where
                         (entityid == hdr.entityid)
                         select new sms_Qualification_Type()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             QualificationType = hdr.QualificationType,
                             Description = hdr.Dexcription,
                         }).ToList();
            return query;
        }
    }
}
