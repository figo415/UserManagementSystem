using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface IQpcrDetectionAppService
    {
        Task<PagedList<QpcrDetectionDto>> GetQpcrDetectionsByPage(QpcrDetectionQueryParameters parameters);

        Task<bool> UpdateQpcrDetection(Guid qpcrDetectionId, QpcrDetectionUpdateDto dto);
    }
}