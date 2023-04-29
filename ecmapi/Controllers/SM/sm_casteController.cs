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
    [RoutePrefix("api/v1/hdr_SM_Caste")]
    public class hdr_Sm_CasteController : BaseController<Caste>
    {
        ecomSchoolEntities hdr_SM_Caste = new ecomSchoolEntities();
        [Route("Save/{hdr_SM_caste}")]
        [HttpPost]
        public IHttpActionResult Savehdr_SM_caste(Caste hdr_SM_caste)
        {
            try
            {
                Save(hdr_SM_caste);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(hdr_SM_caste);
        }
        //dto_Castes
        [HttpGet]
        [Route("Get_hdr_SM_Castes")]
        public IEnumerable<Caste> GetAll()
        {
            var obj = hdr_SM_Caste.Set<Caste>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("Gethdr_SM_Castes_ByentityId/{id}")]

        public async Task<List<dto_Castes>> GetEntityById(int id)
        {
            var query = (from hdr in hdr_SM_Caste.Castes
                         where
                         (id == hdr.entityId)
                         select new dto_Castes()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             Caste = hdr.Caste1,
                             Description = hdr.description,
                         }).ToList();
            return query;
        }
    }
}
