using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    public class SpeciesAppService:ISpeciesAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public SpeciesAppService(IRepositoryWrapper wrapper, IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }

        public async Task<PagedList<SpeciesDto>> GetSpeciesByPage(SpeciesQueryParameters parameters)
        {
            var pagedSpecies = await _repoWrapper.SpeciesRepo.GetSpeciesByPage(parameters);
            var pagedDtos = _mapper.Map<List<SpeciesDto>>(pagedSpecies);
            return new PagedList<SpeciesDto>(pagedDtos, pagedSpecies.TotalCount, pagedSpecies.CurrentPage, pagedSpecies.PageSize);
        }

        public async Task<bool> InsertSpecies(SpeciesCreationDto dto)
        {
            var existed = await _repoWrapper.SpeciesRepo.GetSpeciesByName(dto.ChineseName);
            if(existed.Any())
            {
                throw new AlreadyExistedException("Species with ChineseName=" + dto.ChineseName + " is already existed");
            }
            var species = _mapper.Map<Species>(dto);
            species.Id = Guid.NewGuid();
            species.CreatedAt = DateTime.Now;
            species.IsDeleted = false;
            _repoWrapper.SpeciesRepo.Create(species);
            var result = await _repoWrapper.SpeciesRepo.SaveAsync();
            return result;
        }

        public async Task<bool> UpdateSpecies(Guid speciesId, SpeciesUpdateDto dto)
        {
            var species = await _repoWrapper.SpeciesRepo.GetByIdAsync(speciesId);
            if (species == null)
            {
                throw new NotExistedException("Species with Guid=" + speciesId + " is not existed");
            }
            if(dto.ChineseName!=species.ChineseName)
            {
                var existed = await _repoWrapper.SpeciesRepo.GetSpeciesByName(dto.ChineseName);
                if (existed.Any())
                {
                    throw new AlreadyExistedException("Species with ChineseName=" + dto.ChineseName + " is already existed");
                }
            }
            _mapper.Map(dto, species, typeof(SpeciesUpdateDto), typeof(Species));
            species.LastModifiedAt = DateTime.Now;
            _repoWrapper.SpeciesRepo.Update(species);
            var result = await _repoWrapper.SpeciesRepo.SaveAsync();
            return result;
        }

        public async Task<bool> DeleteSpecies(DeleteMultiDto dto)
        {
            foreach (var speciesId in dto.Guids)
            {
                var species = await _repoWrapper.SpeciesRepo.GetByIdAsync(speciesId);
                if (species == null)
                {
                    continue;
                }
                species.IsDeleted = true;
                species.LastModifiedAt = DateTime.Now;
                _repoWrapper.SpeciesRepo.Update(species);
            }
            var result = await _repoWrapper.SpeciesRepo.SaveAsync();
            return result;
        }
    }
}
