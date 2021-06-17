using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface IRoleRepository:IRepositoryBase<Role>,IRepositoryBase2<Role,Guid>
    {
    }
}
