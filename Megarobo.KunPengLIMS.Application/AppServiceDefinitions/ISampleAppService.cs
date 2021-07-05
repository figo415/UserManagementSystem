using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface ISampleAppService
    {
        Task<PagedList<SampleDto>> GetSamplesByPage(SampleQueryParameters parameters);

        Task<bool> InsertSample(SampleCreationDto dto);

        Task<bool> UpdateSample(Guid sampleId, SampleUpdateDto dto);

        Task<bool> DeleteSamples(DeleteMultiDto dto);
    }
}
