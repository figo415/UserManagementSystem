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
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Application.Exceptions;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public class PlasmidPurificationAppService: IPlasmidPurificationAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public PlasmidPurificationAppService(IRepositoryWrapper wrapper, IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }

        public async Task<PagedList<PlasmidPurificationDto>> GetPlasmidPurificationsByPage(PlasmidPurificationQueryParameters parameters)
        {
            var pagedPlasmidPurifications = await _repoWrapper.PlasmidPurificationRepo.GetPlasmidPurificationsByPage(parameters);
            var pagedDtos = _mapper.Map<List<PlasmidPurificationDto>>(pagedPlasmidPurifications);
            return new PagedList<PlasmidPurificationDto>(pagedDtos, pagedPlasmidPurifications.TotalCount, pagedPlasmidPurifications.PageNumber, pagedPlasmidPurifications.PageSize);
        }

        public async Task<bool> UpdatePlasmidPurification(Guid plasmidPurificationId, PlasmidPurificationUpdateDto dto)
        {
            var plasmid = await _repoWrapper.PlasmidPurificationRepo.GetByIdAsync(plasmidPurificationId);
            if (plasmid == null)
            {
                throw new NotExistedException("PlasmidPurification with Guid=" + plasmidPurificationId + " is not existed");
            }
            _mapper.Map(dto, plasmid, typeof(PlasmidPurificationUpdateDto), typeof(PlasmidPurification));
            plasmid.LastModifiedAt = DateTime.Now;
            _repoWrapper.PlasmidPurificationRepo.Update(plasmid);
            var result = await _repoWrapper.PlasmidPurificationRepo.SaveAsync();
            return result;
        }
    }
}
