using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface ICellRepository:IRepositoryBase<Cell>,IRepositoryBase2<Cell,Guid>
    {
        System.Threading.Tasks.Task<PagedList<Cell>> GetCellsByPage(CellQueryParameters parameters);
    }
}
