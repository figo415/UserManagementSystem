using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface ICellRepository:IRepositoryBase<Cell>,IRepositoryBase2<Cell,Guid>
    {
    }
}
