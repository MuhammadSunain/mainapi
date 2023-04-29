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
    [RoutePrefix("api/v1/fr_case_group")]
    public class fr_CaseGroupController : BaseController<fr_CaseGroup>
    {
        ecomSchoolEntities frCaseGroup = new ecomSchoolEntities();
        [Route("Save/{caseGroup}")]
        [HttpPost]
        public IHttpActionResult SavecaseGroup(fr_CaseGroup caseGroup)
        {
            try
            {
                Save(caseGroup);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(caseGroup);
        }
        [HttpGet]
        [Route("GetCaseGroups")]
        public IEnumerable<fr_CaseGroup> GetCaseGroups()
        {
            var obj = frCaseGroup.Set<fr_CaseGroup>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("GetCaseGroupsByentityId/{id}")]
        public async Task<List<caseGROUP>> GetEntityById(int id)
        {
            var query = (from hdr in frCaseGroup.fr_CaseGroup
                         where
                         (id == hdr.entityId)
                         select new caseGROUP()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             CaseGroup = hdr.CaseGroup,
                             Description = hdr.Description
                         }).ToList();
            return query;
        }
    }
}
