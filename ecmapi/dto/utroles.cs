using ecmapi.Models;
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
        public string Role1 { get; internal set; }
        public int? client { get; internal set; }
        public string Entity { get; internal set; }
        public IQueryable<mst_usermoudulesrights> appscreens { get; internal set; }
    }
}