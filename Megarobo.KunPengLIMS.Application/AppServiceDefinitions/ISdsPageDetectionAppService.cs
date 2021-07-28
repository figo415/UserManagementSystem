using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface ISdsPageDetectionAppService
    {
        Task<PagedList<SdsPageDetectionDto>> GetSdsPageDetectionsByPage(SdsPageDetectionQueryParameters parameters);

        Task<bool> UpdateSdsPageDetection(Guid sdsPageDetectionId, SdsPageDetectionUpdateDto dto);
    }
}