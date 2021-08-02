using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    [Route("limsapi/files")]
    [Produces("application/json")]
    [Consumes("application/json", "multipart/form-data")]
    [ApiController]
    [AllowAnonymous]
    public class FileController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<StringApiResult>> UploadFile(IFormCollection collection, string id)
        {
            var files = Request.Form.Files;
            foreach(var file in files)
            {
                var stream = new MemoryStream();
                //file.OpenReadStream();
                file.CopyTo(stream);
                var content = stream.ToArray();
            }
            throw new NotImplementedException();
        }

        private async Task<Stream> GetAllQueryResult()
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.WriteLine("Brand,ModelNumber,Price");
            writer.WriteLine("BYD,e5,260K");
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        [HttpGet]
        [ProducesResponseType(typeof(FileResult),200)]
        public async Task<FileResult> DownloadFile()
        {
            var res = await GetAllQueryResult();
            var actionresult = new FileStreamResult(res, new Microsoft.Net.Http.Headers.MediaTypeHeaderValue("text/csv"));
            actionresult.FileDownloadName = "Carinfos.csv";
            //Response.ContentLength = res.Length;
            return actionresult;
        }

    }
}
