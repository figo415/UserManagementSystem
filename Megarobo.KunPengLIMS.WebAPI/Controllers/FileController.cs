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
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    [Route("limsapi/files")]
    [Produces("application/json")]
    [Consumes("application/json", "multipart/form-data")]
    [ApiController]
    [AllowAnonymous]
    public class FileController : ControllerBase
    {
        private readonly IFileAppService _fileService;
        private readonly ILogger<FileController> _logger;

        public FileController(IFileAppService fileService, ILogger<FileController> logger)
        {
            _fileService = fileService;
            _logger = logger;
        }

        [HttpGet("{filename}")]
        [ProducesResponseType(typeof(FileResult), 200)]
        public async Task<FileResult> DownloadFile(string filename)
        {
            var content = await _fileService.GetFile(filename);
            if(content.Length>0)
            {
                var stream = new MemoryStream(content);
                stream.Write(content, 0, content.Length);
                stream.Position = 0;
                var actionresult = new FileStreamResult(stream, new MediaTypeHeaderValue("application/octet-stream"));//application/pdf, image/jpeg, image/png
                //actionresult.FileDownloadName = filename;
                //Response.ContentLength = res.Length;
                return actionresult;
            };
            return new FileContentResult(System.Text.Encoding.ASCII.GetBytes("Not Found"), new MediaTypeHeaderValue("text/plain"));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResult<DocumentDto>>> UploadFile(IFormCollection collection)
        {
            var files = Request.Form.Files;
            if(files.Any())
            {
                var file = files[0];
                var stream = new MemoryStream();
                file.CopyTo(stream);
                var dto = await _fileService.InsertFile(file.FileName, stream);
                if (string.IsNullOrEmpty(dto.ExceptionMessage))
                {
                    return ApiResult<DocumentDto>.HasSingleData(dto);
                }
                return new ActionResult<ApiResult<DocumentDto>>(new ApiResult<DocumentDto>() { Code = 2, Message = dto.ExceptionMessage, RowCount = 0 });
            }
            return new ActionResult<ApiResult<DocumentDto>>(new ApiResult<DocumentDto>() { Code = 1, Message = "No files", RowCount = 0 });
        }
    }
}
