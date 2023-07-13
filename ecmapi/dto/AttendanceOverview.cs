using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class AttendanceOverview
    {
        public int AttendanceCount { get; internal set; }
        public object atndate { get; internal set; }
        public object Id { get; internal set; }
    }
}