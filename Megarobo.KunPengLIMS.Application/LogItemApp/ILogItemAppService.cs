using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Application.LogItemApp.Dtos;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.LogItemApp
{
    public interface ILogItemAppService
    {
        Task<PagedList<LogItemDto>> GetLogItemsByPage(LogItemQueryParameters parameters);
    }
}
