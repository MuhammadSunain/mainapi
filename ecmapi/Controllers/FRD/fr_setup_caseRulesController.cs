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
    [RoutePrefix("api/v1/fr_setup_CaseRules")]
    public class fr_CaseRulesController : BaseController<fr_CASERULES>
    {
        ecomSchoolEntities frCaseRules = new ecomSchoolEntities();
        [Route("Save/{CaseRules}")]
        [HttpPost]
        public IHttpActionResult SaveCaseRules(fr_CASERULES CaseRules)
        {
            try
            {
                Save(CaseRules);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(CaseRules);
        }
        [HttpGet]
        [Route("GetfrCaseRules")]
        public IEnumerable<fr_CASERULES> GetCaseGroups()
        {
            var obj = frCaseRules.Set<fr_CASERULES>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("GetcaseRulesByEntityId/{id}")]
        public async Task<List<frCaseRules>> GetEntityById(int id)
        {
            var query = (from hdr in frCaseRules.fr_CASERULES
                         where
                         (id == hdr.entityId)
                         select new frCaseRules()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             CaseGroup = hdr.CaseGroup,
                             CaseType = hdr.CaseType,
                             CaseRule = hdr.CaseRule,
                             Description = hdr.Description,
                             asignto = hdr.AssignTo
                         }).ToList();
            return query;
        }
    }
}
