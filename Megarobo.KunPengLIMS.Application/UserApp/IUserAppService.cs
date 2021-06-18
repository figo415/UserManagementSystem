using Megarobo.KunPengLIMS.Application.UserApp.Dtos;
using Megarobo.KunPengLIMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.SkillApp.Dtos;

namespace Megarobo.KunPengLIMS.Application.UserApp
{
    public interface IUserAppService
    {

        List<UserDto> GetUserByDepartment(Guid departmentId, int startPage, int pageSize, out int rowCount);


        Task<IEnumerable<UserDto>> GetUsers(UserResourceParameter parameter);

        Task<UserDto> GetUser(Guid userId);

        Task<IEnumerable<SkillDto>> GetSkillsForUser(Guid userId);

        Task<IEnumerable<UserDepartmentRoleDto>> GetDepartmentRolesForUser(Guid userId);

        Task<bool> InsertUser(UserCreationDto dto);

        Task<bool> UpdateUser(Guid userId, UserUpdateDto dto);

        Task<bool> EnableUser(Guid userId, UserUpdateStatusDto dto);

        Task<bool> ResetPassword(Guid userId, UserUpdatePasswordDto dto);

        Task<bool> DeleteUsers(DeleteMultiDto dto);
    }
}
