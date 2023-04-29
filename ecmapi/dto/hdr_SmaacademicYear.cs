using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class hdr_SmacademicYear
    {
        public int? entityId { get; internal set; }
        public string syllabus { get; internal set; }
        public string enddate { get; internal set; }
        public int Id { get; internal set; }
        public string code { get; internal set; }
        public string academicregister { get; internal set; }
        public string academicyear { get; internal set; }
        public string startdate { get; internal set; }
    }
}