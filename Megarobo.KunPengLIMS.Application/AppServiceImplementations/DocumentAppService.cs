using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public class DocumentAppService:IDocumentAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public DocumentAppService(IRepositoryWrapper wrapper, IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }

        public async Task<DocumentDto> GetDocument(Guid docId)
        {
            var doc = await _repoWrapper.DocumentRepo.GetByIdAsync(docId);
            var dto = _mapper.Map<DocumentDto>(doc);
            return dto;
        }

        public async Task<Guid?> InsertDocument(string filename, byte[] content)
        {
            var doc = new Document();
            doc.Id = Guid.NewGuid();
            doc.FileName = filename;
            doc.CreatedAt = DateTime.Now;
            doc.Content = content;
            _repoWrapper.DocumentRepo.Create(doc);
            var result = await _repoWrapper.DocumentRepo.SaveAsync();
            if(result)
            {
                return doc.Id;
            }
            return null;
        }
    }
}
