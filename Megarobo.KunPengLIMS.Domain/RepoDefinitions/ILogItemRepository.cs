using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface ILogItemRepository:IRepositoryBase<LogItem>,IRepositoryBase2<LogItem,int>
    {
        System.Threading.Tasks.Task<PagedList<LogItem>> GetLogItemsByPage(LogItemQueryParameters parameters);

        bool Save();
    }
}
