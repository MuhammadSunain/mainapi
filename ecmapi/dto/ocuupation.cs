using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class ocuupation
    {
        public int Id { get; internal set; }
        public string code { get; internal set; }
        public string occupation { get; internal set; }
        public string description { get; internal set; }
        public int? entityId { get; internal set; }
    }
}