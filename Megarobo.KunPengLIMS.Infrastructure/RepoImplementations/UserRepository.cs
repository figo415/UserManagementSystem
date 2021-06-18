using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;

namespace Megarobo.KunPengLIMS.Infrastructure.RepoImplementations
{
    public class UserRepository:RepositoryBase<User,Guid>,IUserRepository
    {
        public UserRepository(DbContext dbContext):base(dbContext)
        {

        }

        public System.Threading.Tasks.Task<User> GetUserWithSkill(Guid userId)
        {
            return System.Threading.Tasks.Task.FromResult(DbContext.Set<User>().Include(u => u.Skills).ThenInclude(us => us.Skill).Where(u => u.Id == userId).SingleOrDefault());
        }

        public System.Threading.Tasks.Task<User> GetUserWithDepartmentRole(Guid userId)
        {
            return System.Threading.Tasks.Task.FromResult(GetUserWithDepartmentRoleInternal(userId));
        }

        private User GetUserWithDepartmentRoleInternal(Guid userId)
        {
            var user = DbContext.Set<User>().Include(u => u.DepartmentRoles).ThenInclude(udr => udr.Department).SingleOrDefault();
            foreach(var dr in user.DepartmentRoles)
            {
                dr.Role = DbContext.Set<Role>().SingleOrDefault(s => s.Id == dr.RoleID);
            }
            return user;
        }
    }
}
