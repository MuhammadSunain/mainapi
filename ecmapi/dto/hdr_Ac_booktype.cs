using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class hdr_Ac_booktype
    {
        public int Id { get; internal set; }
        public string Code { get; internal set; }
        public string BookType { get; internal set; }
    }
}