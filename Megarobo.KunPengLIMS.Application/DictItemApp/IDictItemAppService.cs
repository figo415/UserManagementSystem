using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Application.DictItemApp.Dtos;

namespace Megarobo.KunPengLIMS.Application.DictItemApp
{
    public interface IDictItemAppService
    {
        Task<PagedList<DictItemDto>> GetDictItemsByPage(DictItemQueryParameters parameters);

        Task<bool> InsertDictItem(DictItemCreationDto dto);

        Task<bool> UpdateDictItem(Guid dictItemId, DictItemUpdateDto dto);

        Task<bool> DeleteDictItems(DeleteMultiDto dto);
    }
}
