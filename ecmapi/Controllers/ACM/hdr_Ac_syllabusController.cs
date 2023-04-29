using ecmapi.dto;
using ecmapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ecmapi.Controllers.ACM
{
    [RoutePrefix("api/v1/hdr_Ac_syllabus")]
    public class hdr_Ac_SyllabusController : BaseController<hdr_Ac_Syllabus>
    {
        ecomSchoolEntities hdr_Ac_Syllabus = new ecomSchoolEntities();

        [Route("Save/{hdr_Ac_syllabus}")]
        [HttpPost]
        public IHttpActionResult Savehdr_Ac_syllabus(hdr_Ac_Syllabus hdr_Ac_syllabus)
        {
            try
            {
                Save(hdr_Ac_syllabus);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(hdr_Ac_syllabus);
        }
        [HttpGet]
        [Route("Get_hdr_Ac_Syllabus")]
        public IEnumerable<hdr_Ac_Syllabus> GetAll()
        {
            var obj = hdr_Ac_Syllabus.Set<hdr_Ac_Syllabus>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("Gethdr_Ac_SyllabusByentityId/{id}")]
        public async Task<List<dto_hdr_Ac_Syllabus>> GetEntityById(int id)
        {
            var query = (from hdr in hdr_Ac_Syllabus.hdr_Ac_Syllabus
                         where
                         (id == hdr.entityId)
                         select new dto_hdr_Ac_Syllabus()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             Syllabus = hdr.Syllabus,
                             description = hdr.Description
                         }).ToList();
            return query;
        }
    }
}
