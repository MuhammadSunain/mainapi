//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ecmapi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class fr_Desk_caseRegister
    {
        public int Id { get; set; }
        public string caseid { get; set; }
        public Nullable<System.DateTime> casedate { get; set; }
        public string requestertype { get; set; }
        public string requester { get; set; }
        public string course { get; set; }
        public string section { get; set; }
        public string casegrp { get; set; }
        public string casetype { get; set; }
        public string priority { get; set; }
        public string assignto { get; set; }
        public string subject { get; set; }
        public string txtmessage { get; set; }
        public Nullable<int> entityId { get; set; }
        public Nullable<int> clientId { get; set; }
    }
}
