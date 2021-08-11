using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface IPlasmidPurificationRepository: IRepositoryBase<PlasmidPurification>, IRepositoryBase2<PlasmidPurification, Guid>
    {
        System.Threading.Tasks.Task<PagedList<PlasmidPurification>> GetPlasmidPurificationsByPage(PlasmidPurificationQueryParameters parameters);

        System.Threading.Tasks.Task<PlasmidPurification> GetPlasmidPurificationByOrder(Guid orderId);
    }
}
