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
    [RoutePrefix("api/v1/fr_setup_purpose")]
    public class FR_Setup_PurposeController : BaseController<fr_Purpose>
    {
        ecomSchoolEntities frPurpose = new ecomSchoolEntities();
        [Route("Save/{Purpose}")]
        [HttpPost]
        public IHttpActionResult SavePurpose(fr_Purpose Purpose)
        {
            try
            {
                Save(Purpose);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(Purpose);
        }
        [HttpGet]
        [Route("GetPurposes")]
        public IEnumerable<fr_Purpose> GetCaseGroups()
        {
            var obj = frPurpose.Set<fr_Purpose>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("GetPurposeityId/{id}")]
        public async Task<List<fr_purpose>> GetEntityById(int id)
        {
            var query = (from hdr in frPurpose.fr_Purpose
                         where
                         (id == hdr.entityId)
                         select new fr_purpose()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             Purpose = hdr.Purpose,
                             Description = hdr.Description
                         }).ToList();
            return query;
        }
    }
}
