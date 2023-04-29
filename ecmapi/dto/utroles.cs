using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class utroles
    {
        public int Id { get; internal set; }
        public string Code { get; internal set; }
        public string Role { get; internal set; }
        public int? client { get; internal set; }
        public string clientname { get; internal set; }
    }
}