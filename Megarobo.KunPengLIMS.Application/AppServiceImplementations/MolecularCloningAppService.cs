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
    public class MolecularCloningAppService: IMolecularCloningAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public MolecularCloningAppService(IRepositoryWrapper wrapper, IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }

        public async Task<PagedList<MolecularCloningDto>> GetMolecularCloningsByPage(MolecularCloningQueryParameters parameters)
        {
            var pagedMolecularClonings = await _repoWrapper.MolecularCloningRepo.GetMolecularCloningsByPage(parameters);
            var pagedDtos = _mapper.Map<List<MolecularCloningDto>>(pagedMolecularClonings);
            return new PagedList<MolecularCloningDto>(pagedDtos, pagedMolecularClonings.TotalCount, pagedMolecularClonings.PageNumber, pagedMolecularClonings.PageSize);
        }

        public async Task<bool> UpdateMolecularCloning(Guid molecularCloningId, MolecularCloningUpdateDto dto)
        {
            var molecular = await _repoWrapper.MolecularCloningRepo.GetByIdAsync(molecularCloningId);
            if (molecular == null)
            {
                throw new NotExistedException("MolecularCloning with Guid=" + molecularCloningId + " is not existed");
            }
            _mapper.Map(dto, molecular, typeof(MolecularCloningUpdateDto), typeof(MolecularCloning));
            molecular.LastModifiedAt = DateTime.Now;
            _repoWrapper.MolecularCloningRepo.Update(molecular);
            var result = await _repoWrapper.MolecularCloningRepo.SaveAsync();
            return result;
        }
    }
}
