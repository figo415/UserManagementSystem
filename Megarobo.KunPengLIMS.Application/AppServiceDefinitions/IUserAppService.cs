using Megarobo.KunPengLIMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface IUserAppService
    {
        Task<PagedList<UserDto>> GetUsersByPage(UserQueryParameters parameters);

        Task<UserDto> GetUser(Guid userId);

        Task<IEnumerable<SkillDto>> GetSkillsForUser(Guid userId);

        Task<IEnumerable<UserDepartmentRoleDto>> GetDepartmentRolesForUser(Guid userId);

        Task<UserWithRightsDto> GetUserByToken(string userName);

        Task<bool> InsertUser(UserCreationDto dto);

        Task<bool> UpdateUser(Guid userId, UserUpdateDto dto);

        Task<bool> EnableUser(Guid userId, UserUpdateStatusDto dto);

        Task<bool> ResetPassword(Guid userId, UserUpdatePasswordDto dto);

        Task<bool> DeleteUsers(DeleteMultiDto dto);
    }
}
