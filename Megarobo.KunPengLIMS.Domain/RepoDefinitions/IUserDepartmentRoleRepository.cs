using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface IUserDepartmentRoleRepository:IRepositoryBase<UserDepartmentRole>
    {
        System.Threading.Tasks.Task<IEnumerable<UserDepartmentRole>> GetUserDepartmentRolesByUser(Guid userId);
    }
}
