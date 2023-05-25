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
    [RoutePrefix("api/v1/ut_States")]
    public class StatesController : BaseController<State>
    {
        ecomSchoolEntities Ut_State = new ecomSchoolEntities();
        [HttpPost]
        [Route("Save/{ut_States}")]
        public IHttpActionResult SaveUt_Countries(State ut_States)
        {
            try
            {
                Save(ut_States);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(ut_States);
        }
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<State> GetAll()
        {
            var obj = Ut_State.Set<State>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("Getut_States_ByentityId/{id}")]
        public async Task<List<States>> GetByEntityId(int id)
        {
            var query = (from hdr in Ut_State.States
                         where
                         (id == hdr.entityId)
                         select new States()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             State = hdr.State1,
                             country = hdr.Country,
                             Description = hdr.Description
                         }).ToList();
            return query;
        }
        [HttpGet]
        [Route("Getut_States_ByentityIdandCountryId/{id}/{Country}")]
        public async Task<List<States>> GetByEntityId(int id, string Country)
        {
            var query = (from hdr in Ut_State.States
                         where
                         (id == hdr.entityId && Country == hdr.Country)
                         select new States()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             State = hdr.State1,
                             country = hdr.Country,
                             Description = hdr.Description
                         }).ToList();
            return query;
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IHttpActionResult delete(int id)
        {
            var item = Delete<State>(id);
            if (item != null)
            {
                return Ok("Record Deleted Successfully");
            }
            return Ok();
        }
        [HttpPut]
        [Route("update_stateData/{stateid}/{obj}")]
        public IHttpActionResult update(int stateid, State obj)
        {
            var dto = Ut_State.States.FirstOrDefault(n => n.Id == stateid);
            if (dto != null)
            {
                dto.Code = obj.Code;
                dto.State1 = obj.State1;
                dto.Country = obj.Country;
                Ut_State.SaveChanges();
            }
            return Ok("record updated successfully...");
        }
    }
}
