using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface ISampleRepository:IRepositoryBase<Sample>,IRepositoryBase2<Sample,Guid>
    {
        System.Threading.Tasks.Task<PagedList<Sample>> GetSamplesByPage(SampleQueryParameters parameters);

        System.Threading.Tasks.Task<Sample> GetSampleWithCell(Guid sampleId);
    }
}
