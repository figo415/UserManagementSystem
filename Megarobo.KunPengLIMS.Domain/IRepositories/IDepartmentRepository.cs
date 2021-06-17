using Megarobo.KunPengLIMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Domain.IRepositories
{
    public interface IDepartmentRepository : IRepository<Department, Guid>
    {
    }
}
