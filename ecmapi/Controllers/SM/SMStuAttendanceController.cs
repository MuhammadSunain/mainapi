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
                             attenDate = hdr.attenDate,
                             attenTime = hdr.attenTime,
                             attendactivity = hdr.attendactivity,
                             entityId = hdr.entityId
                         }).ToList();
            return query;
        }

        [HttpGet]
        [Route("AttendanceOverviewLast10Days/{entityId}")]

        public IHttpActionResult AttendanceOverviewLast10Days(string entityId)
        {
            DateTime startDate = DateTime.Today.AddDays(-10);
            DateTime endDate = DateTime.Today;

            var query = db.SMActivitiesSTUDENTAttendances
                .Where(a =>  a.entityId == entityId && a.attenDate >= startDate && a.attenDate <= endDate)
                .GroupBy(a => a.Id)
                .Select(g => new
                {
                    AttendanceDate = g.Select(a => new
                    {
                        attendancedate = a.attenDate.ToString(),
                    }).ToList(),
                    totalpresent = g.Count(a => a.attendactivity == "Present")
                }).ToList();
            return Ok(query);
        }

    }
}
