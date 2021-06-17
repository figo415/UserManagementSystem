using Megarobo.KunPengLIMS.Application.UserApp.Dtos;
using Megarobo.KunPengLIMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Application.UserApp
{
    public interface IUserAppService
    {
        List<UserDto> GetAllUsers();

        Task<UserDto> GetUser(Guid userId);

        User CheckUser(string userName, string password);

        List<UserDto> GetUserByDepartment(Guid departmentId, int startPage, int pageSize, out int rowCount);

        UserDto InsertOrUpdate(UserDto dto);

        /// <summary>
        /// 根据Id集合批量删除
        /// </summary>
        /// <param name="ids">Id集合</param>
        void DeleteBatch(List<Guid> ids);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">Id</param>
        void Delete(Guid id);

        //UserDto Get(Guid id);

        Task<bool> InsertUser(UserCreationDto dto);
    }
}
