using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class Qualification
    {
        public int Id { get; internal set; }
        public string Code { get; internal set; }
        public string qualificationtypeid { get; internal set; }
        public string qualification { get; internal set; }
        public string Description { get; internal set; }
    }
}