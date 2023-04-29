using ecmapi.dto;
using ecmapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ecmapi.Controllers.SS
{
    [RoutePrefix("api/v1/ut_Cities")]
    public class CitiesController : BaseController<City>
    {
        ecomSchoolEntities Ut_City = new ecomSchoolEntities();
        [HttpPost]
        [Route("Save/{ut_City}")]
        public IHttpActionResult SaveUt_Countries(City ut_City)
        {
            try
            {
                Save(ut_City);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(ut_City);
        }
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<City> GetAll()
        {
            var obj = Ut_City.Set<City>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("Getut_Cities_ByentityId/{id}")]
        public async Task<List<Cities>> GetByEntityId(int id)
        {
            var query = (from hdr in Ut_City.Cities
                         where
                         (id == hdr.entityId)
                         select new Cities()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             City = hdr.City1,
                             Country = hdr.Country,
                             State = hdr.State,
                             Description = hdr.Description
                         }).ToList();
            return query;
        }
    }
}
