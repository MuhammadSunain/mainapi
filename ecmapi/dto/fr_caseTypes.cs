﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class fr_caseTypes
    {
        public int Id { get; internal set; }
        public string Code { get; internal set; }
        public string CaseGroup { get; internal set; }
        public string CaseType { get; internal set; }
        public string Description { get; internal set; }
        public string CaseFor { get; internal set; }
    }
}