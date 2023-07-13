using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class dtomst_SMFeetype
    {
        public int Id { get; internal set; }
        public string code { get; internal set; }
        public string sharedwith { get; internal set; }
        public string feecat { get; internal set; }
        public string feebaseon { get; internal set; }
        public string feetype { get; internal set; }
        public string taxable { get; internal set; }
        public string status { get; internal set; }
        public string description { get; internal set; }
        public int? entityId { get; internal set; }
    }
}