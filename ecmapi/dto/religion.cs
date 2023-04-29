using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class religion
    {
        public int Id { get; internal set; }
        public string Code { get; internal set; }
        public string Religion { get; internal set; }
        public string Description { get; internal set; }
    }
}