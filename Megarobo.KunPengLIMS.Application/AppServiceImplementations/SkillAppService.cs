using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Exceptions;

namespace Megarobo.KunPengLIMS.Application.Services
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
            var pagedDtos = _mapper.Map<List<SkillDto>>(pagedSkills);
            return new PagedList<SkillDto>(pagedDtos, pagedSkills.TotalCount, pagedSkills.CurrentPage, pagedSkills.PageSize);
        }

        public async Task<IEnumerable<SkillDto>> GetSkillTree(SkillQueryParameters parameters)
        {
            var skills = await _repoWrapper.SkillRepo.GetSkills(parameters);
            var skillDtos = _mapper.Map<IEnumerable<SkillDto>>(skills);
            var tree = GetTree(Guid.Empty, skillDtos);
            return tree;
        }

        private List<SkillDto> GetTree(Guid parentId, IEnumerable<SkillDto> dtos)
        {
            var tree = dtos.Where(s => s.ParentId == parentId).ToList();
            foreach (var item in tree)
            {
                item.Children = GetTree(item.Id, dtos);
            }
            return tree;
        }

        public async Task<bool> InsertSkill(SkillCreationDto dto)
        {
            var existed = await _repoWrapper.SkillRepo.GetSkillsByName(dto.SkillName);
            if (existed.Any())
            {
                throw new AlreadyExistedException("Skill with Name=" + dto.SkillName + " is already existed");
            }
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
                throw new NotExistedException("Skill with Guid=" + skillId + " is not existed");
            }
            _mapper.Map(dto, skill, typeof(SkillUpdateDto), typeof(Skill));
            skill.LastModifiedAt = DateTime.Now;
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
                skill.LastModifiedAt = DateTime.Now;
                _repoWrapper.SkillRepo.Update(skill);
            }
            var result = await _repoWrapper.SkillRepo.SaveAsync();
            return result;
        }
    }
}
