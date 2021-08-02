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
    public class SterilityDetectionAppService : ISterilityDetectionAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public SterilityDetectionAppService(IRepositoryWrapper wrapper, IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }

        public async Task<PagedList<SterilityDetectionDto>> GetSterilityDetectionsByPage(SterilityDetectionQueryParameters parameters)
        {
            var pagedSterilityDetections = await _repoWrapper.SterilityDetectionRepo.GetSterilityDetectionsByPage(parameters);
            var pagedDtos = _mapper.Map<List<SterilityDetectionDto>>(pagedSterilityDetections);
            return new PagedList<SterilityDetectionDto>(pagedDtos, pagedSterilityDetections.TotalCount, pagedSterilityDetections.PageNumber, pagedSterilityDetections.PageSize);
        }

        public async Task<bool> UpdateSterilityDetection(Guid sterilityDetectionId, SterilityDetectionUpdateDto dto)
        {
            var sterility = await _repoWrapper.SterilityDetectionRepo.GetByIdAsync(sterilityDetectionId);
            if (sterility == null)
            {
                throw new NotExistedException("SterilityDetection with Guid=" + sterilityDetectionId + " is not existed");
            }
            if (sterility.Status == DetectionStatusEnum.Finished)
            {
                throw new InvalidOperationException("Sterility detection is already finished");
            }
            _mapper.Map(dto, sterility, typeof(SterilityDetectionUpdateDto), typeof(SterilityDetection));
            sterility.Status = DetectionStatusEnum.Finished;
            sterility.LastModifiedAt = DateTime.Now;
            _repoWrapper.SterilityDetectionRepo.Update(sterility);
            var result = await _repoWrapper.SterilityDetectionRepo.SaveAsync();
            return result;
        }
    }
}

