using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface ISkillAppService
    {
        Task<PagedList<SkillDto>> GetSkillsByPage(SkillQueryParameters parameters);

        Task<IEnumerable<SkillDto>> GetSkillTree(SkillQueryParameters parameters);

        Task<bool> InsertSkill(SkillCreationDto dto);

        Task<bool> UpdateSkill(Guid skillId, SkillUpdateDto dto);

        Task<bool> DeleteSkills(DeleteMultiDto dto);
    }
}
