using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface IReagentAppService
    {
        Task<PagedList<ReagentDto>> GetReagents(ReagentQueryParameters parameters);
    }
}
