using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class mstHdrSite
    {
        public int Id { get; internal set; }
        public string code { get; internal set; }
        public string sitename { get; internal set; }
        public string sitetype { get; internal set; }
        public string sitefor { get; internal set; }
        public string region { get; internal set; }
        public int? entityId { get; internal set; }
    }
}