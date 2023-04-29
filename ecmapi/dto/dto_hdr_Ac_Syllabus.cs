using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class dto_hdr_Ac_Syllabus
    {
        public int Id { get; internal set; }
        public string Code { get; internal set; }
        public string Syllabus { get; internal set; }
        public string description { get; internal set; }
    }
}