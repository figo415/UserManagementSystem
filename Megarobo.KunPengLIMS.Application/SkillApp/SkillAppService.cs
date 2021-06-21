using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Application.SkillApp.Dtos;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Application.SkillApp
{
    public class SkillAppService:ISkillAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public SkillAppService(IRepositoryWrapper wrapper, IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }

        public async Task<PagedList<SkillDto>> GetSkillsByPage(SkillQueryParameters parameters)
        {
            var pagedSkills = await _repoWrapper.SkillRepo.GetSkillsByPage(parameters);
            var pagedDtos = _mapper.Map<IEnumerable<SkillDto>>(pagedSkills);
            return new PagedList<SkillDto>(pagedDtos.ToList(), pagedSkills.TotalCount, pagedSkills.CurrentPage, pagedSkills.PageSize);
        }

        public async Task<bool> InsertSkill(SkillCreationDto dto)
        {
            var skill = _mapper.Map<Skill>(dto);
            skill.Id = Guid.NewGuid();
            skill.CreatedAt = DateTime.Now;
            skill.IsDeleted = false;
            _repoWrapper.SkillRepo.Create(skill);
            var result = await _repoWrapper.SkillRepo.SaveAsync();
            return result;
        }

        public async Task<bool> UpdateSkill(Guid skillId, SkillUpdateDto dto)
        {
            var skill = await _repoWrapper.SkillRepo.GetByIdAsync(skillId);
            if (skill == null)
            {
                return false;
            }
            _mapper.Map(dto, skill, typeof(SkillUpdateDto), typeof(Skill));
            _repoWrapper.SkillRepo.Update(skill);
            var result = await _repoWrapper.SkillRepo.SaveAsync();
            return result;
        }

        public async Task<bool> DeleteSkills(DeleteMultiDto dto)
        {
            foreach (var skillId in dto.Guids)
            {
                var skill = await _repoWrapper.SkillRepo.GetByIdAsync(skillId);
                if (skill == null)
                {
                    continue;
                }
                skill.IsDeleted = true;
                _repoWrapper.SkillRepo.Update(skill);
            }
            var result = await _repoWrapper.SkillRepo.SaveAsync();
            return result;
        }
    }
}
