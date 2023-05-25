using ecmapi.dto;
using ecmapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ecmapi.Controllers.HR
{
    [RoutePrefix("api/v1/hdr_HR_EmployeeProfile")]
    public class hdr_employeeProfileController : BaseController<hdr_HR_EmployeeProfile>
    {
        ecomSchoolEntities hdr_HR_EmployeeData = new ecomSchoolEntities();
        [Route("Save/{hdr_hr_employeeData}")]
        [HttpPost]
        public IHttpActionResult Savehdr_hr_employeeData(hdr_HR_EmployeeProfile hdr_hr_employeeData)
        {
            try
            {
                Save(hdr_hr_employeeData);   
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(hdr_hr_employeeData);
        }
        [HttpGet]
        [Route("Gethdr_HR_EMPLOYEE_InfoByentityId/{id}")]

        public async Task<List<hr_empProfile>> GetEntityById(int id)
        {
            var query = (from hdr in hdr_HR_EmployeeData.hdr_HR_EmployeeProfile
                         where
                         (id == hdr.entityId)
                         select new hr_empProfile()
                         {
                             Id = hdr.Id,
                             requesterid = hdr.empid,
                             requestername = hdr.firstname,
                             empid = hdr.empid,
                             shrotcode = hdr.shrotcode,
                             machinecode = hdr.machinecode,
                             joindate = hdr.joindate,
                             firstname = hdr.firstname,
                             lastname = hdr.lastname,
                             dateofbirth = hdr.dateofbirth,
                             Gender = hdr.Gender,
                             bloodgroup = hdr.bloodgroup,
                             CNIC = hdr.CNIC,
                             birthcountry = hdr.birthcountry,
                             birthcity = hdr.birthcity,
                             nationality = hdr.nationality,
                             religion = hdr.religion,
                             email = hdr.email,
                             contactno = hdr.contactno,
                             whatsappno = hdr.whatsappno,
                             emptype = hdr.emptype,
                             empcategory = hdr.empcategory,
                             empdepartment = hdr.empdepartment,
                             empdestination = hdr.empdestination,
                             site = hdr.site,
                         }).ToList();
            return query;
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var item = Delete<hdr_HR_EmployeeProfile>(id);
            if (item != null)
            {
                return Ok("Record Deleted Successfully");
            }
            return Ok();
        }
        [HttpPut]
        [Route("update_hdr_HR_employeeData/{employeeid}/{obj}")]
        public IHttpActionResult update(int employeeid, hdr_HR_EmployeeProfile obj)
        {
            var dto = hdr_HR_EmployeeData.hdr_HR_EmployeeProfile.FirstOrDefault(n => n.Id == employeeid);
            if (dto != null)
            {
                dto.empid = obj.empid;
                dto.shrotcode = obj.shrotcode;
                dto.machinecode = obj.machinecode;
                dto.joindate = obj.joindate;
                dto.firstname = obj.firstname;
                dto.lastname = obj.lastname;
                dto.dateofbirth = obj.dateofbirth;
                dto.Gender = obj.Gender;
                dto.bloodgroup = obj.bloodgroup;
                dto.CNIC = obj.CNIC;
                dto.birthcountry = obj.birthcountry;
                dto.birthcity = obj.birthcity;
                dto.nationality = obj.nationality;
                dto.religion = obj.religion;
                dto.email = obj.email;
                dto.contactno = obj.contactno;
                dto.whatsappno = obj.whatsappno;
                dto.emptype = obj.emptype;
                dto.empcategory = obj.empcategory;
                dto.empdepartment = obj.empdepartment;
                dto.empdestination = obj.empdestination;
                dto.site = obj.site;
                hdr_HR_EmployeeData.SaveChanges();
            }
            return Ok("record updated successfully...");
        }
    }
}
