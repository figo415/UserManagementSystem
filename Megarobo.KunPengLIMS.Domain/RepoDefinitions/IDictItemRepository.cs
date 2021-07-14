using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface IDictItemRepository:IRepositoryBase<DictItem>,IRepositoryBase2<DictItem,Guid>
    {
        System.Threading.Tasks.Task<PagedList<DictItem>> GetDictItemsByPage(DictItemQueryParameters parameters);

        System.Threading.Tasks.Task<IEnumerable<DictItem>> GetDictItemsByName(string dictItemName);
    }
}
