using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class utuserauth
    {
        public int Id { get; internal set; }
        public string Entity { get; internal set; }
        public string username { get; internal set; }
        public string pass { get; internal set; }
        public string Fullname { get; internal set; }
        public string Email { get; internal set; }
        public string CellNo { get; internal set; }
        public string UserCategory { get; internal set; }
        public string Role { get; internal set; }
        public string Status { get; internal set; }
        public int? entityid { get; internal set; }
    }
}