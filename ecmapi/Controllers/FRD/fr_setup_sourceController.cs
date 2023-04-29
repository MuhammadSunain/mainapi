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
    [RoutePrefix("api/v1/fr_setup_source")]
    public class FR_Setup_SourceController : BaseController<fr_Source>
    {
        ecomSchoolEntities frSources = new ecomSchoolEntities();
        [Route("Save/{Sources}")]
        [HttpPost]
        public IHttpActionResult SaveSources(fr_Source Sources)
        {
            try
            {
                Save(Sources);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(Sources);
        }
        [HttpGet]
        [Route("GetSources")]
        public IEnumerable<fr_Source> GetCaseGroups()
        {
            var obj = frSources.Set<fr_Source>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("GetSourcesByentityId/{id}")]
        public async Task<List<fr_Sources>> GetEntityById(int id)
        {
            var query = (from hdr in frSources.fr_Source
                         where
                         (id == hdr.entityId)
                         select new fr_Sources()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             Source = hdr.Source,
                             Description = hdr.Description
                         }).ToList();
            return query;
        }
    }
}
