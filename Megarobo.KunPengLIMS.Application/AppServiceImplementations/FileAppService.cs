using Megarobo.KunPengLIMS.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.ExternalDefinitions;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public class FileAppService : IFileAppService
    {
        private readonly IAwss3Service _awss3;
        private readonly IMapper _mapper;

        public FileAppService(IAwss3Service awss3, IMapper mapper)
        {
            _awss3 = awss3;
            _mapper = mapper;
        }

        public async Task<byte[]> GetFile(string filename)
        {
            var content = await _awss3.S3Download(filename);
            return content;
        }

        public async Task<DocumentDto> InsertFile(string filename, Stream content)
        {
            var obj = await _awss3.S3Upload(filename, content);
            var dto = _mapper.Map<DocumentDto>(obj);
            return dto;
        }
    }
}
