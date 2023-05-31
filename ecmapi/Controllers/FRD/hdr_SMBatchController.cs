using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ecmapi.dto;
using ecmapi.Models;

namespace ecmapi.Controllers.FRD
{
    [RoutePrefix("api/v1/Addmission/hdr_SMBatch")]
    public class hdr_SMBatchController : BaseController<hdr_SMBatch>
    {
        ecomSchoolEntities db = new ecomSchoolEntities();

        [HttpPost]
        [Route("Save/{obj}")]
        public IHttpActionResult Savehdr_SMBatch(hdr_SMBatch obj)
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
        [Route("gethdr_SMBatch/{entityId}")]
        public async Task<List<hdr_sm_batch>> GetEntityById(int entityId)
        {
            var query = (from hdr in db.hdr_SMBatch
                         where
                         (entityId == hdr.entityId)
                         select new hdr_sm_batch()
                         {
                             Id = hdr.Id,
                             bookno = hdr.bookno,
                             bookdate = hdr.bookdate,
                             booktype = hdr.booktype,
                             boojname = hdr.boojname,
                             status = hdr.status,
                             academicyearid = hdr.academicyearid,
                             startdate = hdr.startdate,
                             enddate = hdr.enddate,
                             prefix = hdr.prefix,
                             counter = hdr.counter,
                             masklength = hdr.masklength,
                             totalseats = hdr.totalseats,
                             enrolled = hdr.enrolled,
                             available = hdr.available,
                         }).ToList();
            return query;
        }

        [HttpGet]
        [Route("gethdr_SMBatch_dateWise/{entityId}/{bookdate}/{status}/{startdate}")]
        public async Task<List<hdr_sm_batch>> gethdr_SMBatch_dateWise(int entityId, string bookdate, string status, string startdate)
        {
            var query = (from hdr in db.hdr_SMBatch
                         where
                         (entityId == hdr.entityId && bookdate == hdr.bookdate && status == hdr.status  && startdate == hdr.startdate)
                         select new hdr_sm_batch()
                         {
                             Id = hdr.Id,
                             bookno = hdr.bookno,
                             bookdate = hdr.bookdate,
                             booktype = hdr.booktype,
                             boojname = hdr.boojname,
                             status = hdr.status,
                             academicyearid = hdr.academicyearid,
                             startdate = hdr.startdate,
                             enddate = hdr.enddate,
                             prefix = hdr.prefix,
                             counter = hdr.counter,
                             masklength = hdr.masklength,
                             totalseats = hdr.totalseats,
                             enrolled = hdr.enrolled,
                             available = hdr.available,
                         }).ToList();
            return query;
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var item = Delete<hdr_SMBatch>(id);
            if (item != null)
            {
                return Ok("Record Deleted Successfully");
            }
            return Ok();
        }

        [HttpPut]
        [Route("update_hdr_SMBATCHData/{smBatchid}/{obj}")]
        public IHttpActionResult update(int smBatchid, hdr_SMBatch obj)
        {
            var dto = db.hdr_SMBatch.FirstOrDefault(n => n.Id == smBatchid);
            if (dto != null)
            {
                dto.bookno = obj.bookno;
                dto.bookdate = obj.bookdate;
                dto.booktype = obj.booktype;
                dto.boojname = obj.boojname;
                dto.status = obj.status;
                dto.academicyearid = obj.academicyearid;
                dto.startdate = obj.startdate;
                dto.enddate = obj.enddate;
                dto.prefix = obj.prefix;
                dto.counter = obj.counter;
                dto.masklength = obj.masklength;
                db.SaveChanges();
            }
            return Ok("record updated successfully...");
        }

    }
}
