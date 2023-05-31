using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class dtoSMS_Stu_Attendance
    {
        public string entityId { get; internal set; }
        public string attendactivity { get; internal set; }
        public DateTime attenDate { get; internal set; }
        public string sectionid { get; internal set; }
        public string courseid { get; internal set; }
        public string stdid { get; internal set; }
        public int Id { get; internal set; }
        public string attenTime { get; internal set; }
        public string stdname { get; internal set; }
        public string gender { get; internal set; }
    }
}