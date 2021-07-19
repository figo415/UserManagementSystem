using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public class TakeAppService : ITakeAppService
    {
        public Task<PagedList<TakeDto>> GetTakesByPage(TakeQueryParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertTake(TakeCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTake(Guid takeId, TakeUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTakes(DeleteMultiDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
