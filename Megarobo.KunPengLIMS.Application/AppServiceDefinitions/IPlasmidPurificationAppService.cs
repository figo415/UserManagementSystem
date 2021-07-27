using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface IPlasmidPurificationAppService
    {
        Task<PagedList<PlasmidPurificationDto>> GetPlasmidPurificationsByPage(PlasmidPurificationQueryParameters parameters);

        Task<bool> UpdatePlasmidPurification(Guid plasmidPurificationId, PlasmidPurificationUpdateDto dto);
    }
}
