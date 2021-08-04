using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using Megarobo.KunPengLIMS.WebAPI.Models;
using Megarobo.KunPengLIMS.Application.Services;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    [Route("limsapi/files")]
    [Produces("application/json")]
    [Consumes("application/json", "multipart/form-data")]
    [ApiController]
    [AllowAnonymous]
    public class FileController : ControllerBase
    {
        private readonly IDocumentAppService _service;
        private readonly ILogger<FileController> _logger;

        public FileController(IDocumentAppService service, ILogger<FileController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("{docId}")]
        [ProducesResponseType(typeof(FileResult), 200)]
        public async Task<FileResult> DownloadFile(Guid docId)
        {
            var docDto = await _service.GetDocument(docId);
            var stream = new MemoryStream(docDto.Content);
            stream.Write(docDto.Content, 0, docDto.Content.Length);
            stream.Position = 0;
            var actionresult = new FileStreamResult(stream, new MediaTypeHeaderValue("application/octet-stream"));//application/pdf, image/jpeg, image/png
            //var res = await GetAllQueryResult();
            //var actionresult = new FileStreamResult(res, new MediaTypeHeaderValue("text/csv"));
            actionresult.FileDownloadName = docDto.FileName;
            //Response.ContentLength = res.Length;
            return actionresult;
        }

        [HttpPost]
        public async Task<ActionResult<StringApiResult>> UploadFile(IFormCollection collection)
        {
            var files = Request.Form.Files;
            if(files.Any())
            {
                var file = files[0];
                var stream = new MemoryStream();
                //file.OpenReadStream();
                file.CopyTo(stream);
                var content = stream.ToArray();
                var fileid = await _service.InsertDocument(file.FileName, content);
                if (fileid == null)
                {
                    return StringApiResult.Fail();
                }
                return StringApiResult.Succeed(fileid.Value.ToString());
            }
            return StringApiResult.Error("No files");
        }

        //private async Task<Stream> GetAllQueryResult()
        //{
        //    var stream = new MemoryStream();
        //    var writer = new StreamWriter(stream);
        //    writer.WriteLine("Brand,ModelNumber,Price");
        //    writer.WriteLine("BYD,e5,260K");
        //    writer.Flush();
        //    stream.Position = 0;
        //    return stream;
        //}
    }
}
