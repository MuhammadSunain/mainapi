using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class fr_Sources
    {
        public int Id { get; internal set; }
        public string Code { get; internal set; }
        public string Source { get; internal set; }
        public string Description { get; internal set; }
    }
}