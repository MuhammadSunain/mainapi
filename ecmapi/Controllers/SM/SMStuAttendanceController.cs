using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ecmapi.dto;
using ecmapi.Models;

namespace ecmapi.Controllers.SM
{
    [RoutePrefix("api/v1/SMStuAttendance")]
    public class SMStuAttendanceController : ApiController
    {
        ecomSchoolEntities db = new ecomSchoolEntities();
        [HttpPost]
        [Route("SaveAttendence/{stdsObj}")]
        public IHttpActionResult SaveAttendence(SMStuAttendance stdsObj)
        {
            try
            {
                db.SMStuAttendances.Add(stdsObj);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return Ok("attendence marked successfully...");
        }
        [HttpGet]
        [Route("GetDailyAttendanceByEntityId/{entityId}/{date}")]

        public async Task<List<dtoSMS_Stu_Attendance>> GetDailyAttendanceByEntityId(int entityId, string date)
        {
            var query = (from hdr in db.SMStuAttendances
                         where
                         (entityId == hdr.entityId && date == hdr.attenDate)
                         select new dtoSMS_Stu_Attendance()
                         {
                             Id = hdr.Id,
                             stdid = hdr.stdid,
                             courseid = hdr.courseid,
                             sectionid = hdr.sectionid,
                             attenDate = hdr.attenDate,
                             attendactivity = hdr.attendactivity,
                             entityId = hdr.entityId
                         }).ToList();
            return query;
        }

    }
}
