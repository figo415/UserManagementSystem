using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface IMenuRepository:IRepositoryBase<Menu>,IRepositoryBase2<Menu,Guid>
    {
    }
}
