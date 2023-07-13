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
        [Route("SaveAttendence/{stdObj}")]
        public IHttpActionResult SaveAttendence(SMActivitiesSTUDENTAttendance stdObj)
        {
            try
            {
                db.SMActivitiesSTUDENTAttendances.Add(stdObj);
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

        public async Task<List<dtoSMS_Stu_Attendance>> GetDailyAttendanceByEntityId(string entityId, DateTime date)
        {
            var query = (from hdr in db.SMActivitiesSTUDENTAttendances
                         where
                         (entityId == hdr.entityId && date == hdr.attenDate)
                         select new dtoSMS_Stu_Attendance()
                         {
                             Id = hdr.Id,
                             stdid = hdr.stdid,
                             stdname = hdr.stdname,
                             courseid = hdr.courseid,
                             sectionid = hdr.sectionid,
                             gender = hdr.gender,
                             attenDate = hdr.attenDate.ToString(),
                             attenTime = hdr.attenTime,
                             attendactivity = hdr.attendactivity,
                             entityId = hdr.entityId,
                             //totalCount =
                         }).ToList();
            return query;
        }

        [HttpGet]
        [Route("GetStudentAttendanceHistoryStudentIDWise/{entityId}/{stdid}")]

        public async Task<List<dtoSMS_Stu_Attendance>> GetStudentAttendanceHistoryStudentIDWise(string entityId, string stdid)
        {
            var query = (from hdr in db.SMActivitiesSTUDENTAttendances
                         where
                         (entityId == hdr.entityId && stdid == hdr.stdid)
                         select new dtoSMS_Stu_Attendance()
                         {
                             Id = hdr.Id,
                             stdid = hdr.stdid,
                             stdname = hdr.stdname,
                             courseid = hdr.courseid,
                             sectionid = hdr.sectionid,
                             gender = hdr.gender,
                             attenDate = hdr.attenDate.ToString(),
                             attenTime = hdr.attenTime,
                             attendactivity = hdr.attendactivity,
                             entityId = hdr.entityId,
                             //totalCount =
                         }).ToList();
            return query;
        }

        [HttpGet]
        [Route("GetListCount/{entityId}/{date}")]

        public  IHttpActionResult GetListCount(string entityId, DateTime date)
        {
            var query = db.SMActivitiesSTUDENTAttendances
                 .Where(a => a.entityId == entityId && a.attenDate == date)
                 .GroupBy(a => a.Id)
                 .Select(g => new
                 {
                     course = g.Select(a => new
                     {
                         coursetxt = a.courseid
                     }).ToList(),
                     totalCount = g.Count(a => a.courseid == a.courseid)
                 }).ToList();
            return Ok(query);
        }

        [HttpGet]
        [Route("AttendanceOverviewLastPresent10Days/{entityId}")]

        public IEnumerable<AttendanceOverview> AttendanceOverviewLastPresent10Days(string entityId)
        {
            DateTime today = DateTime.Now;
            DateTime fromDate = today.AddDays(-10);
            DateTime toDate = today;

            var query = (from hdr in db.SMActivitiesSTUDENTAttendances
                         where
                         (entityId == hdr.entityId && hdr.attenDate >= fromDate && hdr.attenDate <= toDate && hdr.attendactivity == "Present")
                         select new AttendanceOverview()
                         {
                             AttendanceCount = db.SMActivitiesSTUDENTAttendances.Where(a => entityId == a.entityId && a.attenDate >= fromDate && a.attenDate <= toDate && a.attendactivity == "Present").Count(),
                         }).ToList();
            return query;
        }

    }
}
