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
    
    public partial class Entity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string EntityName { get; set; }
        public Nullable<System.DateTime> EntityDate { get; set; }
        public string EntityType { get; set; }
        public string ownerName { get; set; }
        public string contsctno { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public Nullable<int> clientid { get; set; }
    }
}
