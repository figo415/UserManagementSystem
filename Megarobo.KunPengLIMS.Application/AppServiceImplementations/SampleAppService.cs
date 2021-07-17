using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Megarobo.KunPengLIMS.Application.Exceptions;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Domain.ExternalDefinitions;
using Megarobo.KunPengLIMS.Domain.Externals;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public class SampleAppService:ISampleAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;
        private readonly ILocationService _locationService;

        public SampleAppService(IRepositoryWrapper wrapper, IMapper mapper, ILocationService locationService)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
            _locationService = locationService;
        }

        public async Task<PagedList<SampleDto>> GetSamplesByPage(SampleQueryParameters parameters)
        {
            var pagedSamples = await _repoWrapper.SampleRepo.GetSamplesByPage(parameters);
            var pagedDtos = _mapper.Map<List<SampleDto>>(pagedSamples);
            foreach(var dto in pagedDtos)
            {
                dto.SubType = "cell";
                var locationlist = await  _locationService.GetLocation(dto.Id);
                dto.Positions = _mapper.Map<List<LocationDto>>(locationlist);
            }
            return new PagedList<SampleDto>(pagedDtos, pagedSamples.TotalCount, pagedSamples.CurrentPage, pagedSamples.PageSize);
        }

        public async Task<SampleDto> GetSample(Guid sampleId)
        {
            //var sample = await _repoWrapper.SampleRepo.GetByIdAsync(sampleId);
            var sample = await _repoWrapper.SampleRepo.GetSampleWithCell(sampleId);
            var dto = _mapper.Map<SampleDto>(sample);
            var locationlist = await _locationService.GetLocation(dto.Id);
            dto.Positions = _mapper.Map<List<LocationDto>>(locationlist);
            return dto;
        }

        public async Task<bool> InsertSample(SampleCreationDto dto)
        {
            var existed = await _repoWrapper.SampleRepo.GetSampleByName(dto.Name);
            if(existed.Any())
            {
                throw new AlreadyExistedException("Sample with Name=" + dto.Name + " is already existed");
            }
            var sample = _mapper.Map<Sample>(dto);
            sample.Id = Guid.NewGuid();
            sample.CreatedAt = DateTime.Now;
            sample.IsDeleted = false;
            if(dto.Cells.Any())
            {
                sample.CellId = dto.Cells[0].Id;
            }
            _repoWrapper.SampleRepo.Create(sample);
            var result = await _repoWrapper.SampleRepo.SaveAsync();
            if (result)
            {
                result = await InsertSampleLocation(sample.Id, dto.Name, dto.Positions);
                if (!result)
                {
                    await DeleteSample(sample.Id);
                }
            }
            return result;
        }

        private async Task<bool> InsertSampleLocation(Guid sampleId, string name, List<LocationDto> positions)
        {
            var request = new LocationCreationRequest();
            request.id = sampleId;
            request.name = name;
            request.positions = _mapper.Map<List<Location>>(positions);
            var result = await _locationService.InsertLocation(request);
            return result;
        }

        public async Task<bool> UpdateSample(Guid sampleId, SampleUpdateDto dto)
{
            var sample = await _repoWrapper.SampleRepo.GetByIdAsync(sampleId);
            if (sample == null)
            {
                throw new NotExistedException("Sample with Guid=" + sampleId + " is not existed");
            }
            if(dto.Name!=sample.Name)
            {
                var existed = await _repoWrapper.SampleRepo.GetSampleByName(dto.Name);
                if (existed.Any())
                {
                    throw new AlreadyExistedException("Sample with Name=" + dto.Name + " is already existed");
                }
            }
            _mapper.Map(dto, sample, typeof(SampleUpdateDto), typeof(Sample));
            sample.LastModifiedAt = DateTime.Now;
            if (dto.Cells.Any())
            {
                sample.CellId = dto.Cells[0].Id;
            }
            _repoWrapper.SampleRepo.Update(sample);
            var result = await _repoWrapper.SampleRepo.SaveAsync();
            if (result)
            {
                result = await InsertSampleLocation(sample.Id, sample.Name, dto.Positions);
                if(!result)
                {

                }
            }
            return result;
        }

        public async Task<bool> DeleteSamples(DeleteMultiDto dto)
        {
            foreach (var sampleId in dto.Guids)
            {
                var sample = await _repoWrapper.SampleRepo.GetByIdAsync(sampleId);
                if (sample == null)
                {
                    continue;
                }
                sample.IsDeleted = true;
                sample.LastModifiedAt = DateTime.Now;
                _repoWrapper.SampleRepo.Update(sample);
                await _locationService.DeleteLocation(sample.Id);
            }
            var result = await _repoWrapper.SampleRepo.SaveAsync();
            return result;
        }

        private async Task<bool> DeleteSample(Guid sampleId)
        {
            var sample = await _repoWrapper.SampleRepo.GetByIdAsync(sampleId);
            if (sample == null)
            {
                return false;
            }
            _repoWrapper.SampleRepo.Delete(sample);
            var result = await _repoWrapper.SampleRepo.SaveAsync();
            return result;
        }
    }
}
