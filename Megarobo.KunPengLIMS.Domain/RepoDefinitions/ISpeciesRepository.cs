using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface ISpeciesRepository:IRepositoryBase<Species>,IRepositoryBase2<Species,Guid>
    {
        System.Threading.Tasks.Task<PagedList<Species>> GetSpeciesByPage(SpeciesQueryParameters parameters);

        System.Threading.Tasks.Task<IEnumerable<Species>> GetSpeciesByName(string chineseName);
    }
}
