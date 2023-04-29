using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class frCertificateType
    {
        public int Id { get; internal set; }
        public string Code { get; internal set; }
        public string CertificateFor { get; internal set; }
        public string certificateType { get; internal set; }
        public string Description { get; internal set; }
    }
}