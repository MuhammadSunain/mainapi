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
    [RoutePrefix("api/v1/hdr_Ac_Section")]
    public class hdr_Ac_sectionController : BaseController<hdr_Ac_Section>
    {
        ecomSchoolEntities hdr_Ac_Section = new ecomSchoolEntities();
        [Route("Save/{hdr_Ac_section}")]
        [HttpPost]
        public IHttpActionResult Savehdr_Ac_section(hdr_Ac_Section hdr_Ac_section)
        {
            try
            {
                Save(hdr_Ac_section);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(hdr_Ac_section);
        }
        [HttpGet]
        [Route("Get_hdr_Ac_Section")]
        public IEnumerable<hdr_Ac_Section> GetAll()
        {
            var obj = hdr_Ac_Section.Set<hdr_Ac_Section>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("Gethdr_Ac_SectionByentityId/{id}")]

        public async Task<List<dtohdr_Ac_section>> GetEntityById(int id)
        {
            var query = (from hdr in hdr_Ac_Section.hdr_Ac_Section
                         where
                         (id == hdr.entityId)
                         select new dtohdr_Ac_section()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             Section = hdr.Section,
                             Description = hdr.Description,
                         }).ToList();
            return query;
        }
    }
}

