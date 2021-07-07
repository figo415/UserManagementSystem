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
    public class SampleAppService:ISampleAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public SampleAppService(IRepositoryWrapper wrapper, IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }

        public async Task<PagedList<SampleDto>> GetSamplesByPage(SampleQueryParameters parameters)
        {
            var pagedSamples = await _repoWrapper.SampleRepo.GetSamplesByPage(parameters);
            var pagedDtos = _mapper.Map<List<SampleDto>>(pagedSamples);
            return new PagedList<SampleDto>(pagedDtos, pagedSamples.TotalCount, pagedSamples.CurrentPage, pagedSamples.PageSize);
        }

        public async Task<SampleDto> GetSample(Guid sampleId)
        {
            var sample = await _repoWrapper.SampleRepo.GetByIdAsync(sampleId);
            var dto = _mapper.Map<SampleDto>(sample);
            return dto;
        }

        public async Task<bool> InsertSample(SampleCreationDto dto)
        {
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
            return result;
        }

        public async Task<bool> UpdateSample(Guid sampleId, SampleUpdateDto dto)
{
            var sample = await _repoWrapper.SampleRepo.GetByIdAsync(sampleId);
            if (sample == null)
            {
                throw new NotExistedException("Sample with Guid=" + sampleId + " is not existed");
            }
            _mapper.Map(dto, sample, typeof(SampleUpdateDto), typeof(Sample));
            sample.LastModifiedAt = DateTime.Now;
            if (dto.Cells.Any())
            {
                sample.CellId = dto.Cells[0].Id;
            }
            _repoWrapper.SampleRepo.Update(sample);
            var result = await _repoWrapper.SampleRepo.SaveAsync();
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
            }
            var result = await _repoWrapper.SampleRepo.SaveAsync();
            return result;
        }
    }
}
