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
    [RoutePrefix("api/v1/es_setup_academicRegister")]
    public class academicRegisterController : BaseController<academicRegister>
    {
        private readonly string _uploadPath = @"C:\Users\Zeeshan Hanif\source\repos\ecmapi\ecmapi\Images";
        ecomSchoolEntities academicregister = new ecomSchoolEntities();
        [HttpPost]
        [Route("Save/{acadRegister}")]
        public IHttpActionResult SaveacadRegister(academicRegister acadRegister)
        {
            try
            {
                Save(acadRegister);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(acadRegister);
        }

        [HttpGet]
        [Route("getAcademicregisterEntityWise/{id}")]
        public async Task<List<hdr_academicregister>> getAcademicregisterEntityWise(int id)
        {
            var query = (from hdr in academicregister.academicRegisters
                         where
                         (id == hdr.entityId)
                         select new hdr_academicregister()
                         {
                             Id = hdr.Id,
                             code = hdr.code,
                             academicregister = hdr.academicregister1,
                             description = hdr.description,
                             entityId = hdr.entityId
                         }).ToList();
            return query;
        }
        //[HttpPost]
        //[Route("save/{image}")]
        //public IHttpActionResult UploadFile([FromBody] IFormatProvider image)
        //{
        //    if(image == null)
        //    {
        //        return BadRequest("Invalid file");
        //    }
        //    var filename = Path.GetFileName(image.FileName);
        //    var filePath = Path.Combine(_uploadPath, filename);

        //    using (var stream = new FileStream(filePath, FileMode.Create))
        //    {
        //        image.CopyTo(stream);
        //    }
        //    return Ok();
        //}
    }
}
