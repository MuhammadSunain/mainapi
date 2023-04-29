using ecmapi.dto;
using ecmapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ecmapi.Controllers
{
    [RoutePrefix("api/v1/ut_client")]
    public class ut_clientsController : ApiController
    {
        ecomSchoolEntities clients = new ecomSchoolEntities();

        [HttpGet]
        [Route("getut_clients_by_Id/{clientid}")]
        public async Task<List<utClients>> GetByEntityId(int clientid)
        {
            var query = (from hdr in clients.ut_clients
                         where
                         (clientid == hdr.id)
                         select new utClients()
                         {
                             Id = hdr.id,
                             Code = hdr.Code,
                             client = hdr.client
                         }).ToList();
            return query;
        }
    }
}
