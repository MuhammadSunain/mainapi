using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class countries
    {
        public int Id { get; internal set; }
        public string Code { get; internal set; }
        public string Country { get; internal set; }
        public string IsoCode { get; internal set; }
        public string DialCode { get; internal set; }
        public string Description { get; internal set; }
    }
}