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
        public string grno { get; internal set; }
        public string StudentCategory { get; internal set; }
        public string FullName { get; internal set; }
        public string requestername { get; internal set; }
        public string LastName { get; internal set; }
        public DateTime? DateofBirth { get; internal set; }
        public string CNIC { get; internal set; }
        public string Nationality { get; internal set; }
        public string gender { get; internal set; }
        public string Religon { get; internal set; }
        public string Address { get; internal set; }
        public string Country { get; internal set; }
        public string State { get; internal set; }
        public string City { get; internal set; }
        public string Phoneno { get; internal set; }
        public string mobileno { get; internal set; }
        public string Email { get; internal set; }
        public DateTime? joingdate { get; internal set; }
        public DateTime? admissiondate { get; internal set; }
        public string syllabus { get; internal set; }
        public string Course { get; internal set; }
        public string Section { get; internal set; }
        public string Sectiongroup { get; internal set; }
        public string fatherName { get; internal set; }
        public string fatherincome { get; internal set; }
        public string Contactno { get; internal set; }
        public string fathercnic { get; internal set; }
        public string whatsappno { get; internal set; }
        public string fatheremail { get; internal set; }
        public string fatheraddress { get; internal set; }
        public string fathercountry { get; internal set; }
        public string fatherstate { get; internal set; }
        public string fathercity { get; internal set; }
        public string mothername { get; internal set; }
        public string mothercnic { get; internal set; }
        public string mothercontactno { get; internal set; }
        public string motherwhatsapp { get; internal set; }
        public string motheremail { get; internal set; }
        public string motheraddres { get; internal set; }
        public string mothercountry { get; internal set; }
        public string motherstate { get; internal set; }
        public string mothercity { get; internal set; }
        public string emergencyrelagion { get; internal set; }
        public string emergencypersonname { get; internal set; }
        public string emergencycnic { get; internal set; }
        public string emergencycontactno { get; internal set; }
    }
}