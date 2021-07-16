using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface IDictItemAppService
    {
        Task<PagedList<DictItemDto>> GetDictItemsByPage(DictItemQueryParameters parameters);

        Task<bool> InsertDictItem(DictItemCreationDto dto);

        Task<bool> UpdateDictItem(Guid dictItemId, DictItemUpdateDto dto);

        Task<bool> UpdateDictItemValues(Guid dictItemId, DictItemUpdateValueDto dto);

        Task<bool> DeleteDictItems(DeleteMultiDto dto);

        Task<List<string>> GetDictItemValues(string keyName);
    }
}
