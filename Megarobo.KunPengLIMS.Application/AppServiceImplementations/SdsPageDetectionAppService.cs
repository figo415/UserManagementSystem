using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.Enums;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Application.Exceptions;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public class SdsPageDetectionAppService : ISdsPageDetectionAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public SdsPageDetectionAppService(IRepositoryWrapper wrapper, IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }

        public async Task<PagedList<SdsPageDetectionDto>> GetSdsPageDetectionsByPage(SdsPageDetectionQueryParameters parameters)
        {
            var pagedSdsPageDetections = await _repoWrapper.SdsPageDetectionRepo.GetSdsPageDetectionsByPage(parameters);
            var pagedDtos = _mapper.Map<List<SdsPageDetectionDto>>(pagedSdsPageDetections);
            return new PagedList<SdsPageDetectionDto>(pagedDtos, pagedSdsPageDetections.TotalCount, pagedSdsPageDetections.PageNumber, pagedSdsPageDetections.PageSize);
        }

        public async Task<bool> UpdateSdsPageDetection(Guid sdsPageDetectionId, SdsPageDetectionUpdateDto dto)
        {
            var sdspage = await _repoWrapper.SdsPageDetectionRepo.GetByIdAsync(sdsPageDetectionId);
            if (sdspage == null)
            {
                throw new NotExistedException("SdsPageDetection with Guid=" + sdsPageDetectionId + " is not existed");
            }
            if (sdspage.Status == DetectionStatusEnum.Finished)
            {
                throw new InvalidOperationException("SDS-PAGE detection is already finished");
            }
            _mapper.Map(dto, sdspage, typeof(SdsPageDetectionUpdateDto), typeof(SdsPageDetection));
            sdspage.Status = DetectionStatusEnum.Finished;
            sdspage.LastModifiedAt = DateTime.Now;
            _repoWrapper.SdsPageDetectionRepo.Update(sdspage);
            var result = await _repoWrapper.SdsPageDetectionRepo.SaveAsync();
            return result;
        }
    }
}

