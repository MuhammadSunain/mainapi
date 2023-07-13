using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ecmapi.dto;
using ecmapi.Models;

namespace ecmapi.Controllers.Accounting
{
    [RoutePrefix("api/v1/mstSM_MonthlyFee")]
    public class mstSM_MonthlyFeeController : BaseController<mstSM_MonthlyFee>
    {
        ecomSchoolEntities db = new ecomSchoolEntities();

        [Route("Save/{obj}")]
        [HttpPost]
        public IHttpActionResult SavemstSM_MonthlyFee(mstSM_MonthlyFee obj)
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

        [Route("SavemstSM_MonthlyFeeStudentDetail/{obj}")]
        [HttpPost]
        public IHttpActionResult SavemstSM_MonthlyFeeStudentDetail(mstSM_MonthlyFeeStudent_Detail obj)
        {
            try
            {
                db.mstSM_MonthlyFeeStudent_Detail.Add(obj);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(obj);
        }

        [HttpGet]
        [Route("GetmstSM_MonthlyFeeStudent_DetailEntityIDWise/{entityId}")]

        public async Task<List<mstSM_MonthlyFeeStudentDetail>> GetmstSM_MonthlyFeeStudent_DetailEntityIDWise(int entityId)
        {
            var query = (from hdr in db.mstSM_MonthlyFeeStudent_Detail
                         where
                         (entityId == hdr.entityId)
                         select new mstSM_MonthlyFeeStudentDetail()
                         {
                            Id = hdr.Id,
                            monthfeeid = hdr.monthfeeid,
                            stdid = hdr.stdid,
                            grno = hdr.grno,
                            stdname = hdr.stdname,
                            fathername = hdr.fathername,
                            course = hdr.course,
                            section = hdr.section,
                            monthlyfee = hdr.monthlyfee,
                            monthfee = db.mstSM_MonthlyFee.Where(a => a.Id == hdr.monthfeeid),
                            dis_amount = hdr.dis_amount,
                            entityId = hdr.entityId,
                            clientId = hdr.clientId
                         }).ToList();
            return query;
        }

        [HttpGet]
        [Route("GetmstSM_MonthlyFeeEntityIDWise/{entityId}")]

        public async Task<List<mstSM_MonthlyFees>> GetmstSM_MonthlyFeeEntityIDWise(int entityId)
        {
            var query = (from hdr in db.mstSM_MonthlyFee
                         where
                         (entityId == hdr.entityId)
                         select new mstSM_MonthlyFees()
                         {
                            Id = hdr.Id,
                            course = hdr.course,
                            section = hdr.section,
                            month = hdr.month,
                            studentfeedetail = db.mstSM_MonthlyFeeStudent_Detail.Where(a => a.monthfeeid == hdr.Id),
                            year = hdr.year,
                            duedate = hdr.duedate,
                            latefeeamount = hdr.latefeeamount,
                            entityId = hdr.entityId,
                            clientId = hdr.clientId
                         }).ToList();
            return query;
        }

    }
}
