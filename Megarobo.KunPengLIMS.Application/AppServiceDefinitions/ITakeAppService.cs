using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface ITakeAppService
    {
        Task<PagedList<TakeDto>> GetTakesByPage(TakeQueryParameters parameters);

        Task<bool> InsertTake(TakeCreationDto dto);

        Task<bool> UpdateTake(Guid takeId, TakeUpdateDto dto);

        Task<bool> DeleteTakes(DeleteMultiDto dto);
    }
}
