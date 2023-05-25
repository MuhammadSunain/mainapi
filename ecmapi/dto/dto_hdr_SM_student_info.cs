using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class dto_hdr_SM_student_info
    {
        public int Id { get; internal set; }
        public string requesterid { get; internal set; }
        public string StudentID { get; internal set; }
        public string GRno { get; internal set; }
        public string stdcategory { get; internal set; }
        public string Fullname { get; internal set; }
        public string requestername { get; internal set; }
        public string lastname { get; internal set; }
        public DateTime? dateofbirth { get; internal set; }
        public string CNIC { get; internal set; }
        public string Nationality { get; internal set; }
        public string Gender { get; internal set; }
        public string Religion { get; internal set; }
        public string Address { get; internal set; }
        public string Country { get; internal set; }
        public string State { get; internal set; }
        public string City { get; internal set; }
        public string PhoneNo { get; internal set; }
        public string MobileNo { get; internal set; }
        public string Email { get; internal set; }
        public DateTime? JoiningDate { get; internal set; }
        public DateTime? AdmissionDate { get; internal set; }
        public string Syllabus { get; internal set; }
        public string Course { get; internal set; }
        public string Section { get; internal set; }
        public string SectionGroup { get; internal set; }
        public string fathname { get; internal set; }
        public string FathersIncome { get; internal set; }
        public string fathcontactno { get; internal set; }
        public string fathcnic { get; internal set; }
        public string fathwhatsappno { get; internal set; }
        public string fathEmail { get; internal set; }
        public string fathAddress { get; internal set; }
        public string fathCountry { get; internal set; }
        public string fathState { get; internal set; }
        public string fathCity { get; internal set; }
        public string mothername { get; internal set; }
        public string mothercnic { get; internal set; }
        public string mothcontactno { get; internal set; }
        public string mothwhatsappno { get; internal set; }
        public string mothEmail { get; internal set; }
        public string mothAddress { get; internal set; }
        public string mothCountry { get; internal set; }
        public string mothState { get; internal set; }
        public string mothCity { get; internal set; }
        public string Relation { get; internal set; }
        public string emername { get; internal set; }
        public string emerCNIC { get; internal set; }
        public string emerContactNo { get; internal set; }
        public int? entityId { get; internal set; }
    }
}