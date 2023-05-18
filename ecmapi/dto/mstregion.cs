using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class mstregion
    {
        public int Id { get; internal set; }
        public string code { get; internal set; }
        public string region { get; internal set; }
        public string country { get; internal set; }
        public int? entityId { get; internal set; }
    }
}