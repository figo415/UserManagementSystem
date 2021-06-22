using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface IRepositoryWrapper
    {
        IUserRepository UserRepo { get; }

        IUserSkillRepository UserSkillRepo { get; }

        IUserDepartmentRoleRepository UserDepartmentRoleRepo { get; }

        ISkillRepository SkillRepo { get; }

        IRoleRepository RoleRepo { get; }

        IMenuRepository MenuRepo { get; }

        ILogItemRepository LogItemRepo { get; }

        IDictItemRepository DictItemRepo { get; }

        IDepartmentRepository DepartmentRepo { get; }
    }
}
