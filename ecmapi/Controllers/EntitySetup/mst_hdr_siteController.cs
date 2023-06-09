﻿using ecmapi.dto;
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
    [RoutePrefix("api/v1/mst_hdr_site")]
    public class hdr_SiteController : BaseController<mst_hdr_site>
    {

        ecomSchoolEntities db = new ecomSchoolEntities();

        [HttpPost]
        [Route("Save/{obj}")]
        public IHttpActionResult SaveMst_HDR_site(mst_hdr_site obj)
        {
            try
            {
                Save(obj);
            }
            catch(Exception)
            {
                throw;
            }
            return Ok(obj);
        }
        [HttpGet]
        [Route("getMst_HDR_Sites_entityWise/{id}")]
        public async Task<List<mstHdrSite>> getMst_HDR_Sites_entityWise(int id)
        {
            var query = (from hdr in db.mst_hdr_site
                         where
                         (id == hdr.entityId)
                         select new mstHdrSite()
                         {
                             Id = hdr.Id,
                             code = hdr.code,
                             sitename = hdr.sitename,
                             sitetype = hdr.sitetype,
                             sitefor = hdr.sitefor,
                             region = hdr.region,
                             entityId = hdr.entityId
                         }).ToList();
            return query;
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IHttpActionResult delete(int id)
        {
            var item = Delete<mst_hdr_site>(id);
            if (item != null)
            {
                return Ok("Record Deleted Successfully");
            }
            return Ok();
        }

        [HttpPut]
        [Route("update_siteData/{siteid}/{obj}")]
        public IHttpActionResult update(int siteid, mst_hdr_site obj)
        {
            var dto = db.mst_hdr_site.FirstOrDefault(n => n.Id == siteid);
            if (dto != null)
            {
                dto.code = obj.code;
                dto.sitename = obj.sitename;
                dto.sitetype = obj.sitetype;
                dto.sitefor = obj.sitefor;
                dto.region = obj.region;
                db.SaveChanges();
            }
            return Ok("record updated successfully...");
        }

    }
}
