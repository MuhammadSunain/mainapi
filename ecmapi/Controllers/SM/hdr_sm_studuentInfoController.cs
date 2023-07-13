using ecmapi.dto;
using ecmapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ecmapi.Controllers.SM
{
    [RoutePrefix("api/v1/hdr_SM_StudentInfo")]
    public class hdr_Sm_studentinfoController : BaseController<hdr_Sm_studentinfo>
    {
        ecomSchoolEntities hdr_SM_StudentInfo = new ecomSchoolEntities();
        [Route("Save/{hdr_SM_studentInfo}")]
        [HttpPost]
        public IHttpActionResult Savehdr_SM_studentInfo(hdr_Sm_studentinfo hdr_SM_studentInfo)
        {
            try
            {
                Save(hdr_SM_studentInfo);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(hdr_SM_studentInfo);
        }
        [HttpGet]
        [Route("Get_hdr_SM_student_Info")]
        public IEnumerable<hdr_Sm_studentinfo> GetAll()
        {
            var obj = hdr_SM_StudentInfo.Set<hdr_Sm_studentinfo>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("Gethdr_SM_student_InfoByentityId/{id}")]

        public async Task<List<dto_hdr_SM_student_info>> GetEntityById(int id)
        {
            var query = (from hdr in hdr_SM_StudentInfo.hdr_Sm_studentinfo
                         where
                         (id == hdr.entityId)
                         select new dto_hdr_SM_student_info()
                         {
                             Id = hdr.Id,
                             requesterid = hdr.StudentID,
                             StudentID = hdr.StudentID,
                             GRno = hdr.grno,
                             stdcategory = hdr.StudentCategory,
                             Fullname = hdr.FullName,
                             requestername = hdr.FullName,
                             lastname = hdr.LastName,
                             dateofbirth = hdr.DateofBirth.ToString(),
                             CNIC = hdr.CNIC,
                             Nationality = hdr.Nationality,
                             Gender = hdr.gender,
                             Religion = hdr.Religon,
                             Address = hdr.Address,
                             Country = hdr.Country,
                             State = hdr.State,
                             City = hdr.City,
                             PhoneNo = hdr.Phoneno,
                             MobileNo = hdr.mobileno,
                             Email = hdr.Email,
                             JoiningDate = hdr.joingdate.ToString(),
                             AdmissionDate = hdr.admissiondate.ToString(),
                             Syllabus = hdr.syllabus,
                             Course = hdr.Course,
                             Section = hdr.Section,
                             SectionGroup = hdr.Sectiongroup,
                             fathname = hdr.fatherName,
                             FathersIncome = hdr.fatherincome,
                             fathcontactno = hdr.Contactno,
                             fathcnic = hdr.fathercnic,
                             fathwhatsappno = hdr.whatsappno,
                             fathEmail = hdr.fatheremail,
                             mothername = hdr.mothername,
                             mothercnic = hdr.mothercnic,
                             mothcontactno = hdr.mothercontactno,
                             mothwhatsappno = hdr.motherwhatsapp,
                             mothEmail = hdr.motheremail,
                             Relation = hdr.emergencyrelagion,
                             emername = hdr.emergencypersonname,
                             emerCNIC = hdr.emergencycnic,
                             emerContactNo = hdr.emergencycontactno,
                             monthfee = hdr.monthfee,
                             discountedstudnet = hdr.discountedstudnet,
                             dis_amount = hdr.dis_amount,
                         }).ToList();
            return query;
        }
        [HttpGet]
        [Route("Gethdr_SM_student_InfoByentityId_course_and_section/{id}/{course}/{section}")]

        public async Task<List<dto_hdr_SM_student_info>> GetEntityById(int id, string course, string section)
        {
            var query = (from hdr in hdr_SM_StudentInfo.hdr_Sm_studentinfo
                         where
                         (id == hdr.entityId && course == hdr.Course && section == hdr.Section)
                         select new dto_hdr_SM_student_info()
                         {
                             Id = hdr.Id,
                             requesterid = hdr.StudentID,
                             StudentID = hdr.StudentID,
                             GRno = hdr.grno,
                             stdcategory = hdr.StudentCategory,
                             Fullname = hdr.FullName,
                             requestername = hdr.FullName,
                             lastname = hdr.LastName,
                             dateofbirth = hdr.DateofBirth.ToString(),
                             CNIC = hdr.CNIC,
                             Nationality = hdr.Nationality,
                             Gender = hdr.gender,
                             Religion = hdr.Religon,
                             Address = hdr.Address,
                             Country = hdr.Country,
                             State = hdr.State,
                             City = hdr.City,
                             PhoneNo = hdr.Phoneno,
                             MobileNo = hdr.mobileno,
                             Email = hdr.Email,
                             JoiningDate = hdr.joingdate.ToString(),
                             AdmissionDate = hdr.admissiondate.ToString(),
                             Syllabus = hdr.syllabus,
                             Course = hdr.Course,
                             Section = hdr.Section,
                             SectionGroup = hdr.Sectiongroup,
                             fathname = hdr.fatherName,
                             FathersIncome = hdr.fatherincome,
                             fathcontactno = hdr.Contactno,
                             fathcnic = hdr.fathercnic,
                             fathwhatsappno = hdr.whatsappno,
                             fathEmail = hdr.fatheremail,
                             mothername = hdr.mothername,
                             mothercnic = hdr.mothercnic,
                             mothcontactno = hdr.mothercontactno,
                             mothwhatsappno = hdr.motherwhatsapp,
                             mothEmail = hdr.motheremail,
                             Relation = hdr.emergencyrelagion,
                             emername = hdr.emergencypersonname,
                             emerCNIC = hdr.emergencycnic,
                             emerContactNo = hdr.emergencycontactno,
                             monthfee = hdr.monthfee,
                             discountedstudnet = hdr.discountedstudnet,
                             dis_amount = hdr.dis_amount,
                         }).ToList();
            return query;
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var item = Delete<hdr_Sm_studentinfo>(id);
            if (item != null)
            {
                return Ok("Record Deleted Successfully");
            }
            return Ok();
        }
        [HttpPut]
        [Route("update_studentData/{stdid}/{obj}")]
        public IHttpActionResult update(int stdid, hdr_Sm_studentinfo obj)
        {
            var dto = hdr_SM_StudentInfo.hdr_Sm_studentinfo.FirstOrDefault(n => n.Id == stdid);
            if (dto != null)
            {
                dto.StudentCategory = obj.StudentCategory;
                dto.FullName = obj.FullName;
                dto.LastName = obj.LastName;
                dto.DateofBirth = obj.DateofBirth;
                dto.CNIC = obj.CNIC;
                dto.Nationality = obj.Nationality;
                dto.gender = obj.gender;
                dto.Religon = obj.Religon;
                dto.Address = obj.Address;
                dto.Country = obj.Country;
                dto.State = obj.State;
                dto.City = obj.City;
                dto.Phoneno = obj.Phoneno;
                dto.mobileno = obj.mobileno;
                dto.Email = obj.Email;
                dto.joingdate = obj.joingdate;
                dto.admissiondate = obj.admissiondate;
                dto.syllabus = obj.syllabus;
                dto.Course = obj.Course;
                dto.Section = obj.Section;
                dto.Sectiongroup = obj.Sectiongroup;
                dto.fatherName = obj.fatherName;
                dto.fatherincome = obj.fatherincome;
                dto.Contactno = obj.Contactno;
                dto.fathercnic = obj.fathercnic;
                dto.whatsappno = obj.whatsappno;
                dto.fatheremail = obj.fatheremail;
                dto.mothername = obj.mothername;
                dto.mothercnic = obj.mothercnic;
                dto.mothercontactno = obj.mothercontactno;
                             dto.motherwhatsapp = obj.motherwhatsapp;
                             dto.motheremail = obj.motheremail;
                dto.emergencyrelagion = obj.emergencyrelagion;
                dto.emergencypersonname = obj.emergencypersonname;
                             dto.emergencycnic = obj.emergencycnic;
                dto.emergencycontactno = obj.emergencycontactno;
                dto.monthfee = obj.monthfee;
                dto.discountedstudnet = obj.discountedstudnet;
                dto.dis_amount = obj.dis_amount;
            }
            return Ok("record updated successfully...");
        }
    }
}
