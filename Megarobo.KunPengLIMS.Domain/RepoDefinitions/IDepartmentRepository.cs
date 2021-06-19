using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface IDepartmentRepository:IRepositoryBase<Department>,IRepositoryBase2<Department,Guid>
    {
        System.Threading.Tasks.Task<PagedList<Department>> GetDepartmentsByPage(DepartmentQueryParameters parameters);

        System.Threading.Tasks.Task<PagedList<User>> GetUsersByDepartment(Guid departmentId, PagedParameters parameters);
    }
}
