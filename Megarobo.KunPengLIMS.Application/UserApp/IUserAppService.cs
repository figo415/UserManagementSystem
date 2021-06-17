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
        User CheckUser(string userName, string password);

        List<UserDto> GetUserByDepartment(Guid departmentId, int startPage, int pageSize, out int rowCount);


        Task<UserDtoList> GetUsers(UserResourceParameter parameter);

        Task<UserDto> GetUser(Guid userId);

        Task<SkillDtoList> GetSkillsForUser(Guid userId);

        Task<UserDepartmentRoleDtoList> GetDepartmentRolesForUser(Guid userId);

        Task<bool> InsertUser(UserCreationDto dto);

        Task<bool> UpdateUser(Guid userId, UserUpdateDto dto);

        Task<bool> EnableUser(Guid userId, UserUpdateStatusDto dto);

        Task<bool> ResetPassword(Guid userId, UserUpdatePasswordDto dto);

        Task<bool> DeleteUsers(DeleteMultiDto dto);
    }
}
