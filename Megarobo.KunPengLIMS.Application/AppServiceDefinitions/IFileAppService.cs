using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface IFileAppService
    {
        Task<byte[]> GetFile(string filename);

        Task<DocumentDto> InsertFile(string filename, Stream content);
    }
}
