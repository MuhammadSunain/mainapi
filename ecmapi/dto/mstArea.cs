using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class mstArea
    {
        public int Id { get; internal set; }
        public string code { get; internal set; }
        public string country { get; internal set; }
        public string state { get; internal set; }
        public string city { get; internal set; }
        public string areaname { get; internal set; }
        public int? entityId { get; internal set; }
    }
}