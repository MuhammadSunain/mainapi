using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class States
    {
        public int Id { get; internal set; }
        public string Code { get; internal set; }
        public string State { get; internal set; }
        public string country { get; internal set; }
        public string Description { get; internal set; }
    }
}