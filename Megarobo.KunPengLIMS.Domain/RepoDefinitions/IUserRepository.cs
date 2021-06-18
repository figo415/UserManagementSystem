using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface IUserRepository:IRepositoryBase<User>,IRepositoryBase2<User,Guid>
    {
        System.Threading.Tasks.Task<User> GetUserWithSkill(Guid userId);

        System.Threading.Tasks.Task<User> GetUserWithDepartmentRole(Guid userId);
    }
}
