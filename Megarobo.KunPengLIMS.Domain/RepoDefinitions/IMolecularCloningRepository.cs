using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface IMolecularCloningRepository: IRepositoryBase<MolecularCloning>, IRepositoryBase2<MolecularCloning, Guid>
    {
        System.Threading.Tasks.Task<PagedList<MolecularCloning>> GetMolecularCloningsByPage(MolecularCloningQueryParameters parameters);
    }
}
