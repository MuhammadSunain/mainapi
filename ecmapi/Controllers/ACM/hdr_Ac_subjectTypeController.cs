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
    [RoutePrefix("api/v1/hdr_AC_Subject_Type")]
    public class hdr_Ac_subjectTypeController : BaseController<hdr_Ac_subjectType>
    {
        ecomSchoolEntities hdr_AC_subjectType = new ecomSchoolEntities();
        [Route("Save/{hdr_AC_SubjectType}")]
        [HttpPost]
        public IHttpActionResult Savehdr_AC_SubjectType(hdr_Ac_subjectType hdr_AC_SubjectType)
        {
            try
            {
                Save(hdr_AC_SubjectType);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(hdr_AC_SubjectType);
        }
        [HttpGet]
        [Route("Get_hdr_AC_SubjectType")]
        public IEnumerable<hdr_Ac_subjectType> GetAll()
        {
            var obj = hdr_AC_subjectType.Set<hdr_Ac_subjectType>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("Gethdr_AC_SubjectType_ByentityId/{id}")]

        public async Task<List<dto_ac_subjectType>> GetEntityById(int id)
        {
            var query = (from hdr in hdr_AC_subjectType.hdr_Ac_subjectType
                         where
                         (id == hdr.entityId)
                         select new dto_ac_subjectType()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             SubjectType = hdr.SubjectType,
                             Description = hdr.Description,
                         }).ToList();
            return query;
        }
    }
}
