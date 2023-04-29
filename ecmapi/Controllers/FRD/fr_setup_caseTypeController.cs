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
    [RoutePrefix("api/v1/fr_caseType")]
    public class fr_CaseTypeController : BaseController<fr_CaseType>
    {
        ecomSchoolEntities frCaseType = new ecomSchoolEntities();
        [Route("Save/{caseType}")]
        [HttpPost]
        public IHttpActionResult SavecaseType(fr_CaseType caseType)
        {
            try
            {
                Save(caseType);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(caseType);
        }
        [HttpGet]
        [Route("GetCaseTypes")]
        public IEnumerable<fr_CaseType> GetCaseGroups()
        {
            var obj = frCaseType.Set<fr_CaseType>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("GetCaseTypesByentityId/{id}")]
        public async Task<List<fr_caseTypes>> GetEntityById(int id)
        {
            var query = (from hdr in frCaseType.fr_CaseType
                         where
                         (id == hdr.entityId)
                         select new fr_caseTypes()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             CaseGroup = hdr.CaseGroup,
                             CaseType = hdr.CaseType,
                             Description = hdr.Description,
                             CaseFor = hdr.CaseFor,
                         }).ToList();
            return query;
        }
        [HttpGet]
        [Route("GetCaseTypesByentityidandcasegroup/{id}/{casegroup}")]
        public async Task<List<fr_caseTypes>> getBycaseGroup(int id, string casegroup)
        {
            var query = (from hdr in frCaseType.fr_CaseType
                         where
                         (id == hdr.entityId && casegroup == hdr.CaseGroup)
                         select new fr_caseTypes()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             CaseGroup = hdr.CaseGroup,
                             CaseType = hdr.CaseType,
                             Description = hdr.Description,
                             CaseFor = hdr.CaseFor,
                         }).ToList();
            return query;
        }
    }
}
