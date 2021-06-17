using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Infrastructure.Repositories
{
    public class MenuRepository : LimsRepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(LimsDbContext dbcontext) : base(dbcontext)
        {

        }
    }
}
