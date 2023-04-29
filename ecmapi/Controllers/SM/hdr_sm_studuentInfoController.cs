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
                             grno = hdr.grno,
                             StudentCategory = hdr.StudentCategory,
                             FullName = hdr.FullName,
                             requestername = hdr.FullName,
                             LastName = hdr.LastName,
                             DateofBirth = hdr.DateofBirth,
                             CNIC = hdr.CNIC,
                             Nationality = hdr.Nationality,
                             gender = hdr.gender,
                             Religon = hdr.Religon,
                             Address = hdr.Address,
                             Country = hdr.Country,
                             State = hdr.State,
                             City = hdr.City,
                             Phoneno = hdr.Phoneno,
                             mobileno = hdr.mobileno,
                             Email = hdr.Email,
                             joingdate = hdr.joingdate,
                             admissiondate = hdr.admissiondate,
                             syllabus = hdr.syllabus,
                             Course = hdr.Course,
                             Section = hdr.Section,
                             Sectiongroup = hdr.Sectiongroup,
                             fatherName = hdr.fatherName,
                             fatherincome = hdr.fatherincome,
                             Contactno = hdr.Contactno,
                             fathercnic = hdr.fathercnic,
                             whatsappno = hdr.whatsappno,
                             fatheremail = hdr.fatheremail,
                             fatheraddress = hdr.fatheraddress,
                             fathercountry = hdr.fathercountry,
                             fatherstate = hdr.fatherstate,
                             fathercity = hdr.fathercity,
                             mothername = hdr.mothername,
                             mothercnic = hdr.mothercnic,
                             mothercontactno = hdr.mothercontactno,
                             motherwhatsapp = hdr.motherwhatsapp,
                             motheremail = hdr.motheremail,
                             motheraddres = hdr.motheraddres,
                             mothercountry = hdr.mothercountry,
                             motherstate = hdr.motherstate,
                             mothercity = hdr.mothercity,
                             emergencyrelagion = hdr.emergencyrelagion,
                             emergencypersonname = hdr.emergencypersonname,
                             emergencycnic = hdr.emergencycnic,
                             emergencycontactno = hdr.emergencycontactno
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
                             StudentID = hdr.StudentID,
                             grno = hdr.grno,
                             StudentCategory = hdr.StudentCategory,
                             FullName = hdr.FullName,
                             LastName = hdr.LastName,
                             DateofBirth = hdr.DateofBirth,
                             CNIC = hdr.CNIC,
                             Nationality = hdr.Nationality,
                             gender = hdr.gender,
                             Religon = hdr.Religon,
                             Address = hdr.Address,
                             Country = hdr.Country,
                             State = hdr.State,
                             City = hdr.City,
                             Phoneno = hdr.Phoneno,
                             mobileno = hdr.mobileno,
                             Email = hdr.Email,
                             joingdate = hdr.joingdate,
                             admissiondate = hdr.admissiondate,
                             syllabus = hdr.syllabus,
                             Course = hdr.Course,
                             Section = hdr.Section,
                             Sectiongroup = hdr.Sectiongroup,
                             fatherName = hdr.fatherName,
                             fatherincome = hdr.fatherincome,
                             Contactno = hdr.Contactno,
                             fathercnic = hdr.fathercnic,
                             whatsappno = hdr.whatsappno,
                             fatheremail = hdr.fatheremail,
                             fatheraddress = hdr.fatheraddress,
                             fathercountry = hdr.fathercountry,
                             fatherstate = hdr.fatherstate,
                             fathercity = hdr.fathercity,
                             mothername = hdr.mothername,
                             mothercnic = hdr.mothercnic,
                             mothercontactno = hdr.mothercontactno,
                             motherwhatsapp = hdr.motherwhatsapp,
                             motheremail = hdr.motheremail,
                             motheraddres = hdr.motheraddres,
                             mothercountry = hdr.mothercountry,
                             motherstate = hdr.motherstate,
                             mothercity = hdr.mothercity,
                             emergencyrelagion = hdr.emergencyrelagion,
                             emergencypersonname = hdr.emergencypersonname,
                             emergencycnic = hdr.emergencycnic,
                             emergencycontactno = hdr.emergencycontactno
                         }).ToList();
            return query;
        }
    }
}
