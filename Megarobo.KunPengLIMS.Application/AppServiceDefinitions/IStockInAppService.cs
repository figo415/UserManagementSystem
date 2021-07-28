using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface IStockInAppService
    {
        Task<PagedList<StockInDto>> GetStockInsByPage(StockInQueryParameters parameters);

        Task<bool> UpdateStockIn(Guid stockInId, StockInUpdateDto dto);
    }
}