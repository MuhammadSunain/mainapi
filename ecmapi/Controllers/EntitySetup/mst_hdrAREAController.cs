using ecmapi.dto;
using ecmapi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ecmapi.Controllers.EntitySetup
{
    [RoutePrefix("api/v1/hdr_MST_area")]
    public class AreaController : BaseController<mst_hdrArea>
    {

        ecomSchoolEntities db = new ecomSchoolEntities();

        [HttpPost]
        [Route("Save/{area}")]
        public IHttpActionResult SaveHdrAREA(mst_hdrArea area)
        {
            try
            {
                Save(area);
            }
            catch(Exception)
            {
                throw;
            }
            return Ok(area);
        }
    }
}
