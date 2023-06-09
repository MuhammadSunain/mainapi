﻿using ecmapi.dto;
using ecmapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ecmapi.Controllers.SM
{
    [RoutePrefix("api/v1/SmS_Religion")]
    public class ReligionController : BaseController<sms_Religion>
    {
        ecomSchoolEntities Religion = new ecomSchoolEntities();
        [HttpPost]
        [Route("Save/{sms_Religion}")]
        public IHttpActionResult Savesms_Religion(sms_Religion sms_Religion)
        {
            try
            {
                Save(sms_Religion);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(sms_Religion);
        }
        [HttpGet]
        [Route("SMS_Religion")]
        public IEnumerable<sms_Religion> SMS_Religion()
        {
            var obj = Religion.Set<sms_Religion>().ToList();
            return obj;
        }
        [HttpGet]
        [Route("getSMS_Religion_By_entityId/{entityid}")]
        public async Task<List<religion>> GetByEntityId(int entityid)
        {
            var query = (from hdr in Religion.sms_Religion
                         where
                         (entityid == hdr.entityid)
                         select new religion()
                         {
                             Id = hdr.Id,
                             Code = hdr.Code,
                             Religion = hdr.Religion,
                             Description = hdr.Description,
                         }).ToList();
            return query;
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var item = Delete<sms_Religion>(id);
            if (item != null)
            {
                return Ok("Record Deleted Successfully");
            }
            return Ok();
        }
        [HttpPut]
        [Route("update_ReligionData/{religionid}/{obj}")]
        public IHttpActionResult update(int religionid, sms_Religion obj)
        {
            var dto = Religion.sms_Religion.FirstOrDefault(n => n.Id == religionid);
            if (dto != null)
            {
                dto.Code = obj.Code;
                dto.Religion = obj.Religion;
                dto.Description = obj.Description;
                Religion.SaveChanges();
            }
            return Ok("record updated successfully...");
        }
    }
}
