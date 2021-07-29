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
    public class QpcrDetectionAppService : IQpcrDetectionAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public QpcrDetectionAppService(IRepositoryWrapper wrapper, IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }

        public async Task<PagedList<QpcrDetectionDto>> GetQpcrDetectionsByPage(QpcrDetectionQueryParameters parameters)
        {
            var pagedQpcrDetections = await _repoWrapper.QpcrDetectionRepo.GetQpcrDetectionsByPage(parameters);
            var pagedDtos = _mapper.Map<List<QpcrDetectionDto>>(pagedQpcrDetections);
            return new PagedList<QpcrDetectionDto>(pagedDtos, pagedQpcrDetections.TotalCount, pagedQpcrDetections.PageNumber, pagedQpcrDetections.PageSize);
        }

        public async Task<bool> UpdateQpcrDetection(Guid qpcrDetectionId, QpcrDetectionUpdateDto dto)
        {
            var qpcr = await _repoWrapper.QpcrDetectionRepo.GetByIdAsync(qpcrDetectionId);
            if (qpcr == null)
            {
                throw new NotExistedException("QpcrDetection with Guid=" + qpcrDetectionId + " is not existed");
            }
            _mapper.Map(dto, qpcr, typeof(QpcrDetectionUpdateDto), typeof(QpcrDetection));
            qpcr.Status = DetectionStatusEnum.Finished;
            qpcr.LastModifiedAt = DateTime.Now;
            _repoWrapper.QpcrDetectionRepo.Update(qpcr);
            var result = await _repoWrapper.QpcrDetectionRepo.SaveAsync();
            return result;
        }
    }
}

