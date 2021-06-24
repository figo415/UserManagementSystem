using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface IMenuRepository:IRepositoryBase<Menu>,IRepositoryBase2<Menu,Guid>
    {
        System.Threading.Tasks.Task<PagedList<Menu>> GetMenusByPage(MenuQueryParameters parameters);

        System.Threading.Tasks.Task<IEnumerable<Menu>> GetMenus(MenuQueryParameters parameters);
    }
}
