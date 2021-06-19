using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;

namespace Megarobo.KunPengLIMS.Infrastructure.RepoImplementations
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly DbContext _dbContext;

        public RepositoryWrapper(LimsDbContext aasContext)
        {
            _dbContext = aasContext;
        }

        private readonly IUserRepository _userRepo;
        private readonly IUserSkillRepository _userSkillRepo;
        private readonly ISkillRepository _skillRepo;
        private readonly IRoleRepository _roleRepo;
        private readonly IMenuRepository _menuRepo;
        private readonly ILogItemRepository _logItemRepo;
        private readonly IDictItemRepository _dictItemRepo;
        private readonly IDepartmentRepository _departmentRepo;

        public IUserRepository UserRepo => _userRepo ?? new UserRepository(_dbContext);

        public IUserSkillRepository UserSkillRepo => _userSkillRepo ?? new UserSkillRepository(_dbContext);

        public ISkillRepository SkillRepo => _skillRepo ?? new SkillRepository(_dbContext);

        public IRoleRepository RoleRepo => _roleRepo ?? new RoleRepository(_dbContext);

        public IMenuRepository MenuRepo => _menuRepo ?? new MenuRepository(_dbContext);

        public ILogItemRepository LogItemRepo => _logItemRepo ?? new LogItemRepository(_dbContext);

        public IDictItemRepository DictItemRepo => _dictItemRepo ?? new DictItemRepository(_dbContext);

        public IDepartmentRepository DepartmentRepo => _departmentRepo ?? new DepartmentRepository(_dbContext);
    }
}
