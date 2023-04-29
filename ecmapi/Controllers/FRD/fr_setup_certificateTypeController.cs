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
    [RoutePrefix("api/v1/fr_setup_CertificateType")]
    public class fr_CertificateTypeController : BaseController<fr_certificateType>
    {
        ecomSchoolEntities frCertificateType = new ecomSchoolEntities();
        [Route("Save/{CertificateType}")]
        [HttpPost]
        public IHttpActionResult SaveCertificateType(fr_certificateType CertificateType)
        {
            try
            {
                Save(CertificateType);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(CertificateType);
        }
        [HttpGet]
        [Route("GetfrCertificateType")]
        public IEnumerable<fr_certificateType> GetCaseGroups()
        {
            var obj = frCertificateType.Set<fr_certificateType>().ToList();
            return obj;
        }
        [HttpGet]

        [Route("GetcertificateTypesByEntityId/{id}")]
        public async Task<List<frCertificateType>> GetEntityById(int id)
        {
            var query = (from hdr in frCertificateType.fr_certificateType
                         where
                         (id == hdr.entityId)
                         select new frCertificateType()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             CertificateFor = hdr.CertificateFor,
                             certificateType = hdr.CertificateType,
                             Description = hdr.Description
                         }).ToList();
            return query;
        }
    }
}
