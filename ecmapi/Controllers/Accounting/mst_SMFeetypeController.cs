using ecmapi.dto;
using ecmapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ecmapi.Controllers.Accounting
{
    [RoutePrefix("api/v1/mst_SMFeetype")]
    public class mst_SMFeetypeController : BaseController<mst_SMFeetype>
    {
        ecomSchoolEntities db = new ecomSchoolEntities();

        [Route("Save/{obj}")]
        [HttpPost]
        public IHttpActionResult Savehdr_cademicYear(mst_SMFeetype obj)
        {
            try
            {
                Save(obj);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(obj);
        }
        [HttpGet]
        [Route("getmst_SMFeeTypeEntityWise/{entityId}")]
        public async Task<List<dtomst_SMFeetype>> GetEntityById(int entityId)
        {
            var query = (from hdr in db.mst_SMFeetype
                         where
                         (entityId == hdr.entityId)
                         select new dtomst_SMFeetype()
                         {
                             Id = hdr.Id,
                             code = hdr.code,
                             sharedwith = hdr.sharedwith,
                             feecat = hdr.feecat,
                             feebaseon = hdr.feebaseon,
                             feetype = hdr.feetype,
                             taxable = hdr.taxable,
                             status = hdr.status,
                             description = hdr.description,
                             entityId = hdr.entityId,
                         }).ToList();
            return query;
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var item = Delete<mst_SMFeetype>(id);
            if (item != null)
            {
                return Ok("Record Deleted Successfully");
            }
            return Ok();
        }
        [HttpPut]
        [Route("update_mst_SMFeetypeData/{feetypeid}/{obj}")]
        public IHttpActionResult update(int feetypeid, mst_SMFeetype obj)
        {
            var dto = db.mst_SMFeetype.FirstOrDefault(n => n.Id == feetypeid);
            if (dto != null)
            {
                dto.code = obj.code;
                dto.sharedwith = obj.sharedwith;
                dto.feecat = obj.feecat;
                dto.feebaseon = obj.feebaseon;
                dto.feetype = obj.feetype;
                dto.taxable = obj.taxable;
                dto.status = obj.status;
                dto.description = obj.description;
                db.SaveChanges();
            }
            return Ok("record updated successfully...");
        }
    }
}
