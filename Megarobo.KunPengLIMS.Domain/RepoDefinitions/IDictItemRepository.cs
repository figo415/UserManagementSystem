using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface IDictItemRepository:IRepositoryBase<DictItem>,IRepositoryBase2<DictItem,Guid>
    {
    }
}
