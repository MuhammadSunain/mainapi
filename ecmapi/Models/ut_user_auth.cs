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
    
    public partial class ut_user_auth
    {
        public int Id { get; set; }
        public string Entity { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string CellNo { get; set; }
        public string UserCategory { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public Nullable<int> entityId { get; set; }
        public Nullable<int> clientid { get; set; }
        public string entitiesname { get; set; }
    
        public virtual mst_user_Entity mst_user_Entity { get; set; }
    }
}
