using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class casestages
    {
        public int Id { get; internal set; }
        public string Code { get; internal set; }
        public string casesuer { get; internal set; }
        public string stagetype { get; internal set; }
        public string stages { get; internal set; }
        public string Description { get; internal set; }
    }
}