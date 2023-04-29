using ecmapi.dto;
using ecmapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ecmapi.Controllers.FRD
{
    [RoutePrefix("api/v1/hdr_FOAdmEnquiry")]
    public class hdr_FOAdmEnquiryController : BaseController<hdr_FOAdmEnquiry>
    {
        ecomSchoolEntities fr_hdr_foadmEnquiry = new ecomSchoolEntities();
        [Route("Save/{hdr_foadmEnquiry}")]
        [HttpPost]
        public IHttpActionResult Savehdr_FOAdmEnquiry(hdr_FOAdmEnquiry hdr_foadmEnquiry)
        {
            try
            {
                Save(hdr_foadmEnquiry);
            }
            catch(Exception)
            {
                throw;
            }
            return Ok(hdr_foadmEnquiry);
        }
        [HttpGet]
        [Route("gethdr_foadmEnquiry_By_entityId/{entityid}")]
        public async Task<List<frD_hdr_foadmEnquiry>> GetEntityById(int entityid)
        {
            var query = (from hdr in fr_hdr_foadmEnquiry.hdr_FOAdmEnquiry
                         where
                         (entityid == hdr.entityId)
                         select new frD_hdr_foadmEnquiry()
                         {
                             Id = hdr.Id,
                             enquiryno = hdr.enquiryno,
                             enquirydate = hdr.enquirydate,
            campus = hdr.campus,
            sourcetypeid = hdr.sourcetypeid,
            applicantname = hdr.applicantname,
            cnic = hdr.cnic,
            dateofbirth = hdr.dateofbirth,
            genderid = hdr.genderid,
            applyforid = hdr.applyforid,
            preclassattid = hdr.preclassattid,
            preschoolname = hdr.preschoolname,
            address = hdr.address,
            coutryid = hdr.coutryid,
            stateid = hdr.stateid,
            cityid = hdr.cityid,
            cellno = hdr.cellno,
            whatsappno = hdr.whatsappno,
            email = hdr.email,
            preferrescommunication = hdr.preferrescommunication,
            fathername = hdr.fathername,
            fathercnic = hdr.fathercnic,
            fatheroccupationid = hdr.fatheroccupationid,
            fatherrganization = hdr.fatherrganization,
            fathercellno = hdr.fathercellno,
            fatherwhatsapp = hdr.whatsappno,
            fatheremail = hdr.fatheremail,
            fatherpreferrescommunication = hdr.fatherpreferrescommunication,
            mothername = hdr.mothername,
            mothercnic = hdr.mothercnic,
            motheroccupationid = hdr.motheroccupationid,
            motherrganization = hdr.motherrganization,
            mothercellno = hdr.mothercellno,
            motherwhatsapp = hdr.whatsappno,
            motheremail = hdr.motheremail,
            motherpreferrescommunication = hdr.motherpreferrescommunication,
            entityId = hdr.entityId,
        }).ToList();
            return query;
        }
    }
}
