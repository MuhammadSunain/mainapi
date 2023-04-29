using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class hdr_academicregister
    {
        public int? entityId { get; internal set; }
        public string description { get; internal set; }
        public string academicregister { get; internal set; }
        public string code { get; internal set; }
        public int Id { get; internal set; }
    }
}