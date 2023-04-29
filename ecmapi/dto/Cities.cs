using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class Cities
    {
        public int Id { get; internal set; }
        public string Code { get; internal set; }
        public string City { get; internal set; }
        public string Country { get; internal set; }
        public string State { get; internal set; }
        public string Description { get; internal set; }
    }
}