using ecmapi.Models;
using ecmapi.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace ecmapi.Controllers.SS
{
    [RoutePrefix("api/v1/ut_Countries")]
    public class CountriesController : BaseController<Country>
    {
        ecomSchoolEntities Ut_Countries = new ecomSchoolEntities();
        [HttpPost]
        [Route("Save/{ut_Countries}")]
        public IHttpActionResult SaveUt_Countries(Country ut_Countries)
        {
            try
            {
                Save(ut_Countries);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(ut_Countries);
        }
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Country> GetAll()
        {
            var obj = Ut_Countries.Set<Country>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("Getut_Country_ByentityId/{id}")]
        public async Task<List<countries>> GetByEntityId(int id)
        {
            var query = (from hdr in Ut_Countries.Countries
                         where
                         (id == hdr.entityId)
                         select new countries()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             Country = hdr.Country1,
                             IsoCode = hdr.isocode,
                             DialCode = hdr.DialCode,
                             Description = hdr.Description
                         }).ToList();
            return query;
        }
    }
}
