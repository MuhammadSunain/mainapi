using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class dtohdr_Ac_section_group
    {
        public int Id { get; internal set; }
        public string Code { get; internal set; }
        public string SectionGroup { get; internal set; }
        public string Description { get; internal set; }
        public string Section { get; internal set; }
    }
}